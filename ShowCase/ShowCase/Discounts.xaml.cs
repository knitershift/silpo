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
    /// Interaction logic for Discounts.xaml
    /// </summary>
    public partial class Discounts
    {
        SilpoDBEntities db;
        List<RowDiscounts> discountsList;

        public Discounts(SilpoDBEntities db)
        {
            InitializeComponent();
            this.db = db;
            fillData();
        }

        async void fillData()
        {
            imgLoading.Visibility = Visibility.Visible;
            imgLoading.Opacity = 1;
            TimeSpan fadeOutTime = new TimeSpan(0, 0, 0, 0, 300);
            var fadeAnimation = new System.Windows.Media.Animation.DoubleAnimation(0d, fadeOutTime);

            if (await preloadAsync()) // якщо все успішно загружено
            {
                foreach (var d in discountsList)
                    dataGridDiscounts.Items.Add(d);

                imgLoading.BeginAnimation(Image.OpacityProperty, fadeAnimation);
                imgLoading.Visibility = Visibility.Hidden;
            }
            else
            {
                MessageBox.Show("Вибачаємось. Проблеми з інтернетом або з системою");
                this.Close();
            }

        }

        Task<bool> preloadAsync()
        {
            return Task.Factory.StartNew(() => preloadData());
        }

        bool preloadData()
        {
            try
            {
                discountsList = new List<RowDiscounts>();

                //simplifyIT

                List<int> idAvailableProducts = new List<int>(); // id доступних товарів
                var storage = db.Storage.Where(s => s.FinalDate < DateTime.Now && s.Available_items > 0);
                foreach (var s in storage)
                {
                    int id = db.Product.Where(p => p.ID_product == s.Id_product).First().ID_product;
                    if (!idAvailableProducts.Contains(id))
                        idAvailableProducts.Add(id);
                }

                foreach (Discount u in db.Discount)
                {

                    if (!idAvailableProducts.Contains(u.Id_product))
                        continue;

                    Product product = db.Product.Where(x => x.ID_product == u.Id_product).SingleOrDefault<Product>();
                    Prices priceProduct = db.Prices.Where(x => x.idProduct == u.Id_product).ToList().Last();

                    double price = 0;
                    try
                    {
                        price = (double)priceProduct.Price;
                    }
                    catch
                    {
                        price = 100;
                    }

                    double a = (double)price / 100;
                    double b = a * u.Percent;
                    price = (double)price - b;


                    RowDiscounts rowDiscount;
                    rowDiscount = new RowDiscounts()
                    {
                        name = product.Name,
                        percent = u.Percent,
                        oldPrice = string.Format("{0:#,###0.00}", (double)priceProduct.Price),   
                        newPrice = string.Format("{0:#,###0.00}",(double)price),
                        startDate = u.Start.ToShortDateString(),
                        endDate = u.End.ToShortDateString()
                    };

                    discountsList.Add(rowDiscount);
                    //dataGridDiscounts.Items.Add(rowDis);
                }
                return true;
            }
            catch
            {

                return false;
            }
        }
        

 

    }
}
