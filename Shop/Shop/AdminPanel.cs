using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Globalization;
namespace Shop
{
    public partial class AdminPanel : Form
    {
        SilpoDBEntities1 db;

        public AdminPanel()
        {
            InitializeComponent();
            DateTime localDate = DateTime.Now;
            String[] cultureNames = { "ru-RU" };

            foreach (var cultureName in cultureNames)
            {
                var culture = new CultureInfo(cultureName);
                label_data.Text = localDate.ToString(culture);
            }


             db= new SilpoDBEntities1();
            ProductForm pf = new ProductForm(db);
            
          

        
    }


        public AdminPanel(string a)
        {
            InitializeComponent();
          db = new SilpoDBEntities1();


           label_name.Text = db.Users.Where(x => x.Login == a).First().Full_name;
           label_who.Text = db.Users.Where(x => x.Login == a).First().Role; 
            DateTime localDate = DateTime.Now;
            String[] cultureNames = { "ru-RU" };

            foreach (var cultureName in cultureNames)
            {
                var culture = new CultureInfo(cultureName);
              label_data.Text = localDate.ToString(culture);
            }

        }

        private void but_product_Click(object sender, EventArgs e)
        {

            ProductForm product = new ProductForm(db);
            product.ShowDialog();
        }

        private void but_supply_Click(object sender, EventArgs e)
        {
            SupplyForm supply = new SupplyForm();
            supply.ShowDialog();   
        }

        private void but_Exit_Click(object sender, EventArgs e)
        {
            this.Hide();
            SignIn sn = new SignIn();
            sn.ShowDialog();
        }

        private void but_producer_Click(object sender, EventArgs e)
        {

        }
    }
}
