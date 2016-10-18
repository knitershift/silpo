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
using MaterialSkin;
using MaterialSkin.Controls;
namespace Shop
{
    public partial class AdminPanel : MaterialForm
    {
        SilpoDBEntities db;

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


             db= new SilpoDBEntities();
            ProductForm pf = new ProductForm(db);

            var skinmanager = MaterialSkinManager.Instance;
            skinmanager.AddFormToManage(this);
            skinmanager.Theme = MaterialSkinManager.Themes.DARK;
            skinmanager.ColorScheme = new ColorScheme(Primary.BlueGrey800, Primary.BlueGrey900, Primary.BlueGrey500, Accent.LightBlue200, TextShade.WHITE);
        }


        public AdminPanel(string a)
        {
            InitializeComponent();
          db = new SilpoDBEntities();


           label_name.Text = db.Users.Where(x => x.Login == a).First().Full_name;
           label_who.Text = db.Users.Where(x => x.Login == a).First().Role; 
            DateTime localDate = DateTime.Now;
            String[] cultureNames = { "ru-RU" };

            foreach (var cultureName in cultureNames)
            {
                var culture = new CultureInfo(cultureName);
              label_data.Text = localDate.ToString(culture);
            }

            var skinmanager = MaterialSkinManager.Instance;
            skinmanager.AddFormToManage(this);
            skinmanager.Theme = MaterialSkinManager.Themes.DARK;
            skinmanager.ColorScheme = new ColorScheme(Primary.BlueGrey800, Primary.BlueGrey900, Primary.BlueGrey500, Accent.LightBlue200, TextShade.WHITE);

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
        private void but_storage_Click(object sender, EventArgs e)
        {
            StorageForm storage = new StorageForm(db);
            storage.ShowDialog();

        }

        private void but_balance_Click(object sender, EventArgs e)
        {
            BalanceForm bl = new BalanceForm();
            bl.ShowDialog();

        }

        private void but_Exit_MouseHover(object sender, EventArgs e)
        {

            but_Exit.BackColor = Color.Red;    
        }

        private void but_Exit_MouseLeave(object sender, EventArgs e)
        {
            but_Exit.BackColor = Color.WhiteSmoke; 
        }
    }
}
