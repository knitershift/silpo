using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Shop
{
    public partial class NewSupply : Form
    {

        SilpoDBEntities1 db = new SilpoDBEntities1();
        public NewSupply()
        {
            InitializeComponent();

            foreach (var i in db.Product)
            {
                combo_prod.Items.Add(i.Name);
            }






        }

        private void but_ok_Click(object sender, EventArgs e)
        {
            SilpoDBEntities1 db = new SilpoDBEntities1();
            int id = db.Product.Where(x => x.Name == combo_prod.Text).First().ID_prod;

            
            Supply supply = new Supply()
            {
            Id_product = id,
            Price = numeric_price.Value,
            MarkUp = (int)numeric_markup.Value,
            Amount = (int)numeric_amount.Value,
            Date_made =  dateTime_made.Value,
            Date_supply = dateTime_supply.Value
            

            };
            db.Supply.Add(supply);
            db.SaveChanges();       
            this.Hide();
           

        }
    }
}
