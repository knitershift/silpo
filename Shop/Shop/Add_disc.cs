using MaterialSkin.Controls;
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
    public partial class Add_disc : MaterialForm
    {
        SilpoDBEntities db; 
        public Add_disc()
        {
            InitializeComponent();

            db = new SilpoDBEntities();         

            var nuber = db.Product.Select(n => n.Name);
            foreach (var n in nuber)
            {
                comboBox1.Items.Add(n);
               
            }
     }

        private void button1_Click(object sender, EventArgs e)
        {
            //add
            try
            {
                var com = comboBox1.SelectedItem.ToString(); // назвы продуктів із комбобокса

                var nuber = db.Product.Where(x => x.Name == com).Select(n => n.ID_product).First();
                //  MessageBox.Show(nuber.ToString());

                textBox_id_prod.Text = nuber.ToString();

                var sd = new Discount();
                sd.Id_product = Int32.Parse(textBox_id_prod.Text);
                sd.Percent = Convert.ToInt32(numericUpDown1.Value);  // відсоток
                //DateTime date = new DateTime(2016, 11, 01);
                //DateTime date2 = new DateTime(2016, 11, 07);
                var date = Convert.ToDateTime(textBox_start.Text);
                var date2 = Convert.ToDateTime(textBox_end.Text);
                sd.Start = date;                                      // дата початку знижки
                sd.End = date2;                                       // дата закінчення знижки
                db.Discount.Add(sd);
                db.SaveChanges();
                MessageBox.Show("Додано");
                textBox_id_prod.Clear();
                textBox_start.Clear();
                textBox_end.Clear();
            }
            catch(Exception ex)
            { MessageBox.Show(ex.Message); 
            
            }
        }
            
        
    }
}
