using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;

namespace ShowCase
{

    public partial class Basket
    {
        private SilpoDBEntities dbSilpo;

        private List<int> listIdProduct;
        private Users user;
        private double suma;

        public Basket(List<int> listIdProduct, SilpoDBEntities dbSilpo, Users user)
        {
            InitializeComponent();
            this.dbSilpo = dbSilpo;
            this.user = user;
            this.listIdProduct = listIdProduct;
            addButtonToGrid();
            fillData();
        }


        private void fillData()
        {
            RowBasket row;
            int i = 0;
            int countProduct = dbSilpo.Product.Count();
            foreach (var p in listIdProduct)
            {
                Product product = dbSilpo.Product.Where(x => x.ID_product == p).First();

                // get name and country producer
                Producer producer = (from tmp in dbSilpo.Producer
                                     where tmp.ID_producer == product.ID_producer
                                     select tmp).SingleOrDefault<Producer>();
                // ---------

                // get current Price
                Prices price = null;

                try
                {
                    price = (from s in dbSilpo.Prices  // не заповнено ще
                             where s.idProduct == p
                             select s).SingleOrDefault<Prices>();
                }
                catch (Exception ex)
                {

                }
                // ---------
                int coutnProduct = 0;
                try
                {
                    // get current Supply
                    Supply supply = (from s in dbSilpo.Supply
                                     where s.Id_product == p
                                     select s).SingleOrDefault<Supply>();
                    coutnProduct = supply.Amount;
                    // ---------
                }
                catch (Exception ex)
                {
                    coutnProduct = 7;
                }
                double sum;
                double pr;
                if (price == null)
                {
                    sum = 0;
                    pr = 0;
                }
                else
                {
                    sum = (double)price.Price * 1;
                    pr = (double)price.Price;
                }
                suma += pr;
                row = new RowBasket()
                {
                    number = 1 + i++,
                    name = product.Name.ToString(),
                    price = pr,
                    producer = producer.Name,
                    country = producer.Country,
                    amount = 1,
                    suma = sum,
                    b = new FrameworkElementFactory(typeof(Button)),
                    Tag = p,
                    allAmount = coutnProduct
                };


                dataGrid_basket.Items.Add(row);
            }
            labelAmount.Content = dataGrid_basket.Items.Count.ToString();
        }

        private void addButtonToGrid()
        {
            FrameworkElementFactory buttonTemplate = new FrameworkElementFactory(typeof(Button));
            buttonTemplate.SetBinding(Button.IsEnabledProperty, new Binding("Status")
            {
                Converter = new StatusToEnabledConverter()
            });

            buttonTemplate.SetValue(Button.ContentProperty, "Видалити");

            buttonTemplate.AddHandler(
                Button.ClickEvent,
                new RoutedEventHandler((o, e) =>
                {
                    RowBasket rowTmp = dataGrid_basket.SelectedItem as RowBasket;

                    if ((o as Button).Content.ToString() == "Повернути")
                    {
                        listIdProduct.Add(rowTmp.Tag);
                        (o as Button).Content = "Видалити";
                    }
                    else
                    {
                        listIdProduct.Remove(rowTmp.Tag);
                        (o as Button).Content = "Повернути";
                    }
                })
            );
            dataGrid_basket.Columns[7] = new DataGridTemplateColumn()
            {
                Header = "Видалити",
                CellTemplate = new DataTemplate() { VisualTree = buttonTemplate }
            };

        }

        private void buttonClear_Click(object sender, RoutedEventArgs e)
        {
            listIdProduct.Clear();
            dataGrid_basket.Items.Clear();
        }

        private void buttonToBuy_Click(object sender, RoutedEventArgs e)
        {
            if (dataGrid_basket.Items.Count == 0)
            {
                MessageBox.Show("Немає товарів для покупки");
                return;
            }

            foreach (var u in listIdProduct)
            {
                Product prod = dbSilpo.Product.Where(x => x.ID_product == u).SingleOrDefault<Product>();

                Orders order = new Orders()
                {
                    Complited = "false",
                    Count = listIdProduct.Count,
                    Date_of_order = DateTime.Now,
                    FullPrice = (int)suma,
                    ID_user = user.ID_User,
                    ID_product = prod.ID_product
                };
                dbSilpo.Orders.Add(order);
                try
                {
                    int amountToBuy = 0;
                    foreach (var row in dataGrid_basket.Items)
                    {
                        var r = row as RowBasket;
                        if (u == r.Tag)
                        {
                            amountToBuy += r.amount;
                        }
                    }

                    int currentCountProduct = amountToBuy;//  кількість заказаного товару (ще не доступно)
                    Supply sup = dbSilpo.Supply.ToList().Where(x => x.Id_product == u).Last();

                    if (sup.Amount < currentCountProduct)
                    {
                        // знайти поставку в якій є потрібна кількість і відмінусувати її
                        foreach (Supply tmp in dbSilpo.Supply)
                        {
                            if (tmp.Id_product == u && tmp.Amount >= currentCountProduct)
                                tmp.Amount -= currentCountProduct;
                        }
                    }
                    else
                    {
                        sup.Amount -= currentCountProduct;
                    }
                }
                catch 
                {
                    MessageBox.Show("Error");
                }
                Bill bill = dbSilpo.Bill.Where(x => x.ID_User == user.ID_User).First();
                if (bill.Balance < suma)
                    MessageBox.Show("Мало коштів на рахунку!!");

                bill.Balance = (int)((int)bill.Balance - (double)suma);
                dbSilpo.SaveChanges();

                MessageBox.Show("Дякуємо за покупку!");
                dataGrid_basket.Items.Clear();
            }

        }

        private void dataGrid_basket_AutoGeneratingColumn(object sender, DataGridAutoGeneratingColumnEventArgs e)
        {
            if (e.Column.Header.ToString() == "Кількість")
            {
                e.Column.IsReadOnly = false;
            }
        }
        }
    }

