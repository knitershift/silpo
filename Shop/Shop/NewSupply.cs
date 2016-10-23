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
        bool pr = false;
        SilpoDBEntities db = new SilpoDBEntities();
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
            SilpoDBEntities db = new SilpoDBEntities();
            int id = db.Product.Where(x => x.Name == combo_prod.Text).First().ID_product;


            Supply supply = new Supply()
            {
                Id_product = id,
                Price = numeric_price.Value,
                MarkUp = (int)numeric_markup.Value,
                Amount = (int)numeric_amount.Value,
                Date_made = dateTime_made.Value,
                Date_supply = dateTime_supply.Value

            };
            db.Supply.Add(supply);
            db.SaveChanges();
            DateTime dt = dateTime_made.Value;
            double days = (double)db.Product.Where(x => x.ID_product == id).First().Expiry_time;

            Storage storage = new Storage()
            {
                Id_product = id,
                id_supply = db.Supply.ToList().Last().ID_supply,
                Available_items = (int)numeric_amount.Value,
                FinalDate = dt.AddDays(days)
            };
            if (numeric_price.Value > 0)
            {
                db.Storage.Add(storage);
                db.SaveChanges();



                double price_product = (double)(numeric_price.Value + ((numeric_price.Value * numeric_markup.Value) / 100));

                foreach (var i in db.Prices)
                {
                    if (id == i.idProduct)
                    {
                        pr = true;
                    }
                }

                if (pr == false)
                {
                    Prices price = new Prices()
                    {

                        idProduct = id,
                        Price = (decimal)price_product,
                        Date = DateTime.Now,

                    };

                    db.Prices.Add(price);
                    db.SaveChanges();
                }
                else
                {
                    //  var prs = db.Prices.Where(x => x.idProduct == id).ToArray().Last();
                    Prices last_prc = db.Prices.Where(x => x.idProduct == id).ToArray().Last();
                    if (price_product != (double)last_prc.Price)
                    {

                        Prices price = new Prices()
                        {

                            idProduct = id,
                            Price = (decimal)price_product,
                            Date = DateTime.Now,

                        };

                        db.Prices.Add(price);
                        db.SaveChanges();
                    }
                    else
                    {
                        MessageBox.Show("Ціна не змінилась");

                    }
                }
                this.Hide();
            }
            else
            {

                MessageBox.Show("Ціна мусить бути > 0");
            }
           

        }
    }
}
