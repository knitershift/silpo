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

namespace ShowCase
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        SilpoDBEntities5 dbSilpo;
        List<int> listIdProduct;

        public MainWindow()
        {
            InitializeComponent();
            dbSilpo = new SilpoDBEntities5();
            listIdProduct = new List<int>();
            fillData();
            addButtonToGrid();

        }

        private void fillData()
        {
            // add categories
            foreach (var u in dbSilpo.Category)
            {
                ListViewItem itm = new ListViewItem();
                itm.Content = u.Name;
                itm.Tag = u.ID_category;
                listViewCategory.Items.Add(itm);
            }

            Row row;
            int i = 0;
            int countProduct = dbSilpo.Product.Count();
            labelCountProduct.Content = countProduct.ToString();
            labelNameCategory.Content = "All category";
            foreach (var p in dbSilpo.Product)
            {
                //if (DateTime.Now > p.Expiry_time) // перевірка терміну придатності
                //    return;

                // get name and country producer
                Producer producer = (from tmp in dbSilpo.Producer
                                     where tmp.ID_producer == p.ID_producer
                                     select tmp).SingleOrDefault<Producer>();
                // ---------

                // get current Price
                Prices price = (from s in dbSilpo.Prices  // не заповнено ще
                                where s.idProduct == p.ID_product
                                select s).SingleOrDefault<Prices>();
                // ---------
                double pr;
                if (price == null)
                    pr = p.ID_product;
                else
                    pr = (double)price.Price;

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
            Basket bs = new Basket(listIdProduct);
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

            Row row;
            int i = 0;
            foreach (var p in dbSilpo.Product)
            {
                if (p.ID_category == idCat)
                {
                    Producer producer = (from tmp in dbSilpo.Producer
                                         where tmp.ID_producer == p.ID_producer
                                         select tmp).SingleOrDefault<Producer>();

                    row = new Row()
                    {
                        Tag = p.ID_product,
                        number = 1 + i++,
                        name = p.Name,
                        producer = producer.Name,
                        country = producer.Country,
                        price = 404,
                        b = new FrameworkElementFactory(typeof(Button))
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
            // add extention method
            Row row;
            bool c = true;
            for (int i = 0; i < dataGrid_case.Items.Count; i++)
            {
                c = true;
                row = dataGrid_case.Items[i] as Row;
                foreach (int u in listIdProduct)
                {
                    if (row.Tag == u)
                    {
                        buttonTemplate.SetValue(Button.ContentProperty, "Cancel");
                        c = false;
                        break;
                    }
                }

                if (c)
                    buttonTemplate.SetValue(Button.ContentProperty, "To buy");
            }




            buttonTemplate.AddHandler(
                Button.ClickEvent,
                new RoutedEventHandler((o, e) =>
                {
                    Row rowTmp = dataGrid_case.SelectedItem as Row;

                    if ((o as Button).Content.ToString() == "Cancel")
                    {
                        listIdProduct.Remove(rowTmp.Tag);
                        (o as Button).Content = "To buy";
                    }
                    else
                    {
                        (o as Button).Content = "Cancel";
                        listIdProduct.Add(rowTmp.Tag);
                    }
                })
            );
            dataGrid_case.Columns[5] = new DataGridTemplateColumn()
            {
                Header = "Купити",
                CellTemplate = new DataTemplate() { VisualTree = buttonTemplate }
            };

        }
    }
}
