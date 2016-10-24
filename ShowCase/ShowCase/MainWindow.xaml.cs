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
using System.Threading;

namespace ShowCase
{
    public partial class MainWindow
    {
        SilpoDBEntities dbSilpo;
        private Users user;

        List<int> idInBasket;
        List<int> idAvailableProducts;

        Dictionary<string, int> categoriesInfo; //name and id
        Dictionary<int, List<Row>> catRows;


        public MainWindow(SilpoDBEntities dbSilpo, Users user)
        {
            this.InitializeComponent();
            this.dbSilpo = dbSilpo;
            this.user = user;
            this.labelUserName.Content = user.Full_name + "!";

            idInBasket = new List<int>();
            initShop();
            
        }


        bool preloadData()
        {
            try { 
            getAllAvailableProducts();

            categoriesInfo = new Dictionary<string, int>();
            catRows = new Dictionary<int, List<Row>>();

            foreach (var c in dbSilpo.Category)
            {
                categoriesInfo.Add(c.Name, c.ID_category); // save Name and ID of category
                catRows.Add(c.ID_category, productsOfCategory(c.ID_category)); // preload rows for each category   
            }
                return true;
            }
            catch {
                return false;
            }
        }

        private Task<bool> preloadAsync()
        {
            return Task.Factory.StartNew(() => preloadData());
        }

        async void initShop()
        {
            labelNameCategory.Content = "Всі";

            imgLoading.Visibility = Visibility.Visible;
            imgLoading.Opacity = 1;
            TimeSpan fadeOutTime = new TimeSpan(0, 0, 0, 0, 300);
            var fadeAnimation = new System.Windows.Media.Animation.DoubleAnimation(0d, fadeOutTime);

            if (await preloadAsync()) // якщо все успішно загружено
            {
                labelCountProduct.Content = idAvailableProducts.Count.ToString();

                showAllCategories();
                showAllProducts();
                

                addButtonToGrid();

                imgLoading.BeginAnimation(Image.OpacityProperty, fadeAnimation);
                imgLoading.Visibility = Visibility.Hidden;
            }
            else
            {
                MessageBox.Show("Вибачаємось. Проблеми з інтернетом або з системою");
                this.Close();
            }
        }

        void showAllCategories()
        {
            foreach (var c in categoriesInfo)
            {
                var li = new ListViewItem();
                li.Content = c.Key;
                li.Tag = c.Value;
                listViewCategory.Items.Add(li);
            }
        }

        void showAllProducts()
        {
            foreach (var list in catRows.Values)
            {
                foreach(var r in list)
                    dataGrid_case.Items.Add(r);
            }
                
        }

        private void getAllAvailableProducts()
        {
            idAvailableProducts = new List<int>(); // id доступних товарів
            var storage = dbSilpo.Storage.Where(s => s.FinalDate < DateTime.Now && s.Available_items > 0);

            foreach (var s in storage)
            {
                int id = dbSilpo.Product.Where(p => p.ID_product == s.Id_product).First().ID_product;
                if (!idAvailableProducts.Contains(id))
                    idAvailableProducts.Add(id);
            }
        }

        private List<Row> productsOfCategory(int idCategory)
        {
            var list = new List<Row>();

            int i = 0;
            foreach (var p in dbSilpo.Product)
            {
                if (!idAvailableProducts.Contains(p.ID_product))
                    continue;

                if (p.ID_category == idCategory)
                {;
                    Producer producer = dbSilpo.Producer.ToList().Where(pro => pro.ID_producer == p.ID_producer).SingleOrDefault();
                    double pr;
                    try
                    {
                        Prices price = dbSilpo.Prices.ToList().Where(prc => prc.idProduct == p.ID_product).Last();
                        pr = (price == null) ? p.ID_product : (double)price.Price;
                    }
                    catch { pr = 0; };

                    var btn = new FrameworkElementFactory(typeof(Button));

                    btn.SetBinding(Button.ContentProperty, new Binding("btnText"));

                    Row row = new Row()
                    {
                        Tag = p.ID_product,
                        number = 1 + i++,
                        name = p.Name,
                        producer = producer.Name,
                        country = producer.Country,
                        price = pr,
                        b = btn,
                        btnText = idInBasket.Contains(p.ID_product) ? "Відм." : "Купити"
                    };

                    list.Add(row);
                }
            }
            return list;
        }


        private void listViewCategory_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {

            dataGrid_case.Items.Clear();

            ListViewItem itm = listViewCategory.SelectedItem as ListViewItem;

            int idCat = (int)itm.Tag;
            labelNameCategory.Content = itm.Content.ToString();
            labelCountProduct.Content = catRows[idCat].Count.ToString();

            foreach (var r in catRows[idCat])
                dataGrid_case.Items.Add(r);
        }

        private void addButtonToGrid()
        {
            FrameworkElementFactory buttonTemplate = new FrameworkElementFactory(typeof(Button));
            buttonTemplate.SetBinding(Button.ContentProperty, new Binding("btnText"));

            buttonTemplate.AddHandler(Button.ClickEvent,
                  new RoutedEventHandler((o, e) =>
                  {
                      Row selectedRow = dataGrid_case.SelectedItem as Row;
                      Button btn = o as Button;

                      if (btn.Content.ToString() == "Відм.")
                      {
                          selectedRow.btnText = "Купити";
                          btn.Content = "Купити";
                          idInBasket.Remove(selectedRow.Tag);
                      }
                      else
                      {
                          selectedRow.btnText = "Відм.";
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

        private void buttonToBasket_Click(object sender, RoutedEventArgs e)
        {
            Basket bs = new Basket(idInBasket, dbSilpo, user);
            bs.Show();
        }

        private void buttonExit_Click(object sender, RoutedEventArgs e)
        {
            new LogIn().Show();
            this.Close();
        }

        private void buttonDiscounts_Click(object sender, RoutedEventArgs e)
        {
            Discounts dis = new Discounts(dbSilpo);
            dis.ShowDialog();
        }
    }
}
