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
using System.Windows.Navigation;
using System.Windows.Shapes;
using System.Globalization;
using MahApps.Metro.Controls;

namespace ShowCase
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow
    {
        SilpoDBEntities dbSilpo;
        List<int> idInBasket;
        List<int> idAvailableProducts;
        private Users user;

        public MainWindow(SilpoDBEntities dbSilpo, Users user)
        {
            this.InitializeComponent();
                this.dbSilpo = dbSilpo;
                idInBasket = new List<int>();
                this.user = user;

            this.labelUserName.Content = user.Full_name + "!";
                fillData();
            addButtonToGrid();

        }

        private void fillData()
        {
            // Fill categories list
            foreach (var c in dbSilpo.Category)
            {
                ListViewItem itm = new ListViewItem();
                itm.Content = c.Name;
                itm.Tag = c.ID_category;
                this.listViewCategory.Items.Add(itm);
            }

            Row row;
            int i = 0;
            int countProduct = dbSilpo.Product.Count();

            labelCountProduct.Content = countProduct.ToString();
            labelNameCategory.Content = "Всі";

            //** добути товари які на складі **//

            idAvailableProducts = new List<int>(); // id доступних товарів

            var storage = dbSilpo.Storage.Where(s => s.FinalDate < DateTime.Now && s.Available_items > 0);

            foreach (var s in storage){
                int id = dbSilpo.Product.Where(p => p.ID_product == s.Id_product).First().ID_product;
                if(!idAvailableProducts.Contains(id))
                    idAvailableProducts.Add(id);
            }

            foreach (var p in dbSilpo.Product)
            {   
                if (!idAvailableProducts.Contains(p.ID_product))
                    continue;

                // get name and country producer
                Producer producer = (from tmp in dbSilpo.Producer
                                     where tmp.ID_producer == p.ID_producer
                                     select tmp).SingleOrDefault<Producer>();

                // get current Price
                double pr;
                try
                {
                    Prices price = (from s in dbSilpo.Prices.ToList()  // не заповнено ще
                                    where s.idProduct == p.ID_product
                                    select s).Last();

                    if (price == null)
                        pr = p.ID_product;
                    else
                        pr = (double)price.Price;
                }

                catch { pr = 0; };                          

                row = new Row()
                {
                    // в Tag записати Dictionary <int,int> - id, скільки є
                    Tag = p.ID_product,
                    number = 1 + i++,
                    name = p.Name,
                    producer = producer.Name,
                    country = producer.Country,
                    price = pr,
                    b = new FrameworkElementFactory(typeof(Button))
                };

                dataGrid_case.Items.Add(row);
            }

        }

        private void buttonToBasket_Click(object sender, RoutedEventArgs e)
        {
            //Відкрити корзину
            Basket bs = new Basket(idInBasket, dbSilpo);
            bs.ShowDialog();
        }

        private void listViewCategory_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            dataGrid_case.Items.Clear();

            ListViewItem itm = listViewCategory.SelectedItem as ListViewItem;

            int idCat = (int)itm.Tag;

            int countProduct = dbSilpo.Product.Where(x => x.ID_category == idCat).Count();
            labelCountProduct.Content = countProduct.ToString();
            labelNameCategory.Content = itm.Content.ToString();

            
            int i = 0;
            foreach (var p in dbSilpo.Product)
            {
                if (!idAvailableProducts.Contains(p.ID_product))
                    continue;

                    if (p.ID_category == idCat)
                {
                    Producer producer = (from tmp in dbSilpo.Producer
                                         where tmp.ID_producer == p.ID_producer
                                         select tmp).SingleOrDefault<Producer>();


                    double pr;
                    try
                    {
                        Prices price = (from s in dbSilpo.Prices.ToList()  // не заповнено ще
                                        where s.idProduct == p.ID_product
                                        select s).Last();

                        if (price == null)
                            pr = p.ID_product;
                        else
                            pr = (double)price.Price;
                    }

                    catch { pr = 0; };

                    var btn = new FrameworkElementFactory(typeof(Button));
                    // перевіряю чи є вже в корзині
                    if (idInBasket.Contains(p.ID_product))
                    {
                        MessageBox.Show("Something is!");
                    }

                    //(idInBasket.Contains(p.ID_product) ? "Відм." : "Купити")


                    btn.SetBinding(Button.IsEnabledProperty, new Binding("Status")
                    {
                        Converter = new StatusToEnabledConverter()
                    });

                    btn.SetValue(Button.ContentProperty, "Відм.");

                    Row row = new Row()
                    {
                        Tag = p.ID_product,
                        number = 1 + i++,
                        name = p.Name,
                        producer = producer.Name,
                        country = producer.Country,
                        price = pr, //ВКАЗАТИ ЦІНУ ТУТ
                        b = btn
                    };
                    dataGrid_case.Items.Add(row);
                }
            }

        }

        private void addButtonToGrid()
        {
            FrameworkElementFactory buttonTemplate = new FrameworkElementFactory(typeof(Button));
            buttonTemplate.SetBinding(Button.IsEnabledProperty, new Binding("Status")
            {
                Converter = new StatusToEnabledConverter()
            });

            //Якщо товар вже є у корзині напис буде "забрати", а ні то - "купити"
            for (int i = 0; i < dataGrid_case.Items.Count; i++)
            {
                Row currRow = dataGrid_case.Items[i] as Row;

                buttonTemplate.SetValue(Button.ContentProperty, 
                    (idInBasket.Contains(currRow.Tag) ? "Відм." : "Купити"));
            }

            buttonTemplate.AddHandler(Button.ClickEvent,
                new RoutedEventHandler((o, e) =>
                {
                    Row selectedRow = dataGrid_case.SelectedItem as Row;
                    Button btn = o as Button;

                    if (btn.Content.ToString() == "Відм.")
                    {
                        btn.Content = "Купити";
                        idInBasket.Remove(selectedRow.Tag);
                    }
                    else
                    {
                        btn.Content = "Відм.";
                        idInBasket.Add(selectedRow.Tag);
                    }
                }));

            //заголовок колонки "купити"
            dataGrid_case.Columns[5] = new DataGridTemplateColumn()
            {
                Header = "Купити",
                CellTemplate = new DataTemplate() { VisualTree = buttonTemplate }
            };

        }

        private void buttonAccount_Click(object sender, RoutedEventArgs e)
        {
            Account ac = new Account(user, dbSilpo);
            ac.ShowDialog();
        }
    }
}
