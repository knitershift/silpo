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
    public partial class NewProduct : Form
    {
        public NewProduct()
        {
            InitializeComponent();
        }
        public String[] categ = null;
        public String[] producer = null;
        public String[] country = null;
        private void Admin_Load(object sender, EventArgs e)
        {
            SilpoDBEntities1 db = new SilpoDBEntities1();
            foreach (var i in db.Category) {
                combo_category.Items.Add(i.Name);         
            }
            foreach (var i in db.Producer)
            {
                combo_producer.Items.Add(i.Name);
                
            }
        }

        private void combo_category_SelectedIndexChanged(object sender, EventArgs e)
        {
         
        }

        private void but_confirm_Click(object sender, EventArgs e)
        {

            if (text_amount.Text == "" || text_name.Text == "") {
                MessageBox.Show("Заповніть всі поля!!!");
            }
            else { 
           // MessageBox.Show(combo_category.Text + "  " + combo_producer.Text + "  " + text_name.Text + " " + text_amount.Text + " " + numeric_datedie.Value);
            SilpoDBEntities1 db = new SilpoDBEntities1();

               
                Product product = new Product()
                {
                    Name = text_name.Text,
                    Expiry_time = (int)numeric_datedie.Value,
                    ID_category = db.Category.Where(x => x.Name == combo_category.Text).First().ID_category,
                    ID_producer = db.Producer.Where(x=>x.Name ==combo_producer.Text).First().ID_producer

                     };
            db.Product.Add(product);
            db.SaveChanges();
            MessageBox.Show(text_name.Text + "  Додано");
            this.Hide();

        }
        }

        private void text_amount_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!System.Text.RegularExpressions.Regex.IsMatch(e.KeyChar.ToString(), "\\d+")) {
                if (e.KeyChar == (char)8)
                {

                }
                else { 
                e.Handled = true;
                }
            }
               
        }

        private void text_price_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!System.Text.RegularExpressions.Regex.IsMatch(e.KeyChar.ToString(), "\\d+"))
            {
                if (e.KeyChar == (char)8)
                {

                }
                else
                {
                    e.Handled = true;
                }
            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
    if (!System.Text.RegularExpressions.Regex.IsMatch(e.KeyChar.ToString(), "\\d+"))
            {
                if (e.KeyChar == (char)8)
                {

                }
                else
                {
                    e.Handled = true;
                }
            }
        }

        private void label9_Click(object sender, EventArgs e)
        {

        }
        
    }
}
