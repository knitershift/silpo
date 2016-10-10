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
    /// <summary>
    /// Логика взаимодействия для Basket.xaml
    /// </summary>
    public partial class Basket : Window
    {
        private SilpoDBEntities5 dbSilpo;

        List<int> listIdProduct;

        public Basket(List<int> listIdProduct)
        {
            InitializeComponent();
            dbSilpo = new SilpoDBEntities5();
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
               Product product= dbSilpo.Product.Where(x => x.ID_product == p).First();
               
                // get name and country producer
                Producer producer = (from tmp in dbSilpo.Producer
                                     where tmp.ID_producer == product.ID_producer
                                     select tmp).SingleOrDefault<Producer>();
                // ---------

                // get current Price
                Prices price = (from s in dbSilpo.Prices  // не заповнено ще
                                 where s.idProduct == p
                                 select s).SingleOrDefault<Prices>();
                // ---------

                // get current Supply
                Supply supply = (from s in dbSilpo.Supply
                                 where s.Id_product == p
                                 select s).SingleOrDefault<Supply>();
                // ---------

                double sum;
                double pr;
                if (price == null) {
                    sum = 0;
                    pr = 0;
                }
                else {
                    sum = (double)price.Price * 1;
                    pr = (double)price.Price;
                }
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
                    allAmount= supply.Amount
                };
                dataGrid_basket.Items.Add(row);
            }

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
                    Row rowTmp = dataGrid_basket.SelectedItem as Row;

                    if ((o as Button).Content.ToString() == "Повернути")
                    {
                        (o as Button).Content = "Видалити";
                    }
                    else
                    {
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


    }
}
