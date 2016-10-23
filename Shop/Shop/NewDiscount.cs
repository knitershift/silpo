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
using MaterialSkin;

namespace Shop
{
    public partial class NewDiscount : MaterialForm
    {
      SilpoDBEntities db;
        ListViewItem lv;

        public NewDiscount()
        {
            InitializeComponent();
            listView1.GridLines = true;
            //var skinmanager = MaterialSkinManager.Instance;
            //skinmanager.AddFormToManage(this);
            //skinmanager.Theme = MaterialSkinManager.Themes.DARK;
            //skinmanager.ColorScheme = new ColorScheme(Primary.BlueGrey800, Primary.BlueGrey900, Primary.BlueGrey500, Accent.LightBlue200, TextShade.WHITE);

        }

        private void Discount_Load(object sender, EventArgs e)
        {   



            checkBox_true.Visible = false;

            db = new SilpoDBEntities();
            try
            {
                // вивід
                var category = db.Category.Select(n => n.Name);
                foreach (var n in category)
                {
                    comboBox_category.Items.Add(n);

                }
                // comboBox_category.SelectedIndex = 0;// фокусування
                var nuber = db.Discount.Select(n => n.Id_discount); // вибираемо всы ад дискаунту


                foreach (var item in nuber)  //item- id discount
                {
                    lv = new ListViewItem(item.ToString());
                    var idd = db.Discount.Where(id => id.Id_discount == item).Select(p => p.Id_product).First();
                    var pr = db.Discount.Where(p => p.Id_product == idd).Select(p => p.Product.Name).First();

                    var qury = db.Discount.Where(u => u.Id_discount == item); // колекція  полів
                    foreach (var user in qury) // і в кожному полі,,,
                    {
                        lv.SubItems.Add(pr.ToString());
                        lv.SubItems.Add(user.Percent.ToString());
                        lv.SubItems.Add(user.Start.ToString());
                        lv.SubItems.Add(user.End.ToString());

                    }

                    listView1.Items.Add(lv);
                }

             

            }

            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            listView1.AutoResizeColumns(ColumnHeaderAutoResizeStyle.HeaderSize);
            MessageBox.Show("ви зайшли в таблицю Знижки");
        }
       
        public void Prods_load()
        {
            listView1.Items.Clear();
            checkBox_true.Visible = true;

            var comboselected = comboBox_category.SelectedItem.ToString();
            var id_cat = db.Category.Where(id => id.Name == comboselected).Select(id => id.ID_category).First(); // id category
            var prods = db.Product.Where(cat => cat.ID_category == id_cat); //колекція продуктів выбранх по определенной категории

            var nuber = db.Discount.Join(prods, p => p.Id_product, c => c.ID_product, // спільна таблиця ыз спільних ключем= id_prod
                (p, c) => new
                {
                    id = p.Id_discount,
                    name = c.Name,
                    proc = p.Percent,
                    start = p.Start,
                    end = p.End
                });
            foreach (var num in nuber)
            {
                lv = new ListViewItem(num.id.ToString());
                lv.SubItems.Add(num.name.ToString());
                lv.SubItems.Add(num.proc.ToString());
                lv.SubItems.Add(num.start.ToString());
                lv.SubItems.Add(num.end.ToString());

                listView1.Items.Add(lv);

            }
        }

        private void comboBox_category_SelectedIndexChanged(object sender, EventArgs e)
        {
            Prods_load();
        }


        private void checkBox_true_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox_true.Checked)
            {
                listView1.Items.Clear();
                DateTime dt = DateTime.Now;


                try
                {
                    var comboselected = comboBox_category.SelectedItem.ToString();
                    var id_cat = db.Category.Where(id => id.Name == comboselected).Select(id => id.ID_category).First(); // id category
                    var prods = db.Product.Where(cat => cat.ID_category == id_cat); //колекція продуктів выбранх по определенной категории
                    var nuber = db.Discount.Where(st => st.Start >= dt);// колекция id discount  выбранная по дате
                    var nuber2 = nuber.Join(prods, p => p.Id_product, c => c.ID_product, // спыльна ьаблиця ыз спыльних ключем= id_prod
                   (p, c) => new
                   {
                       id = p.Id_discount,
                       name = c.Name,
                       proc = p.Percent,
                       start = p.Start,
                       end = p.End
                   });
                    foreach (var num in nuber2)
                    {
                        lv = new ListViewItem(num.id.ToString());
                        lv.SubItems.Add(num.name.ToString());
                        lv.SubItems.Add(num.proc.ToString());
                        lv.SubItems.Add(num.start.ToString());
                        lv.SubItems.Add(num.end.ToString());

                        listView1.Items.Add(lv);

                    }

                    listView1.AutoResizeColumns(ColumnHeaderAutoResizeStyle.HeaderSize);

                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
                MessageBox.Show("діючі");
            }
            else
            {
                Prods_load();
            }

        }


        private void button_add_Click(object sender, EventArgs e)
        {
          
            Add_disc form = new Add_disc();
            form.Show();

        }

        private void button_del_Click(object sender, ListViewItemSelectionChangedEventArgs e)
        {

            int i = Convert.ToInt32(listView1.FocusedItem.Index); //видаленя з ліста
            int id = Convert.ToInt32(listView1.FocusedItem.Text); //видалення з бд
            var del = db.Discount.Where(d => d.Id_discount == id).FirstOrDefault();

            if (e.IsSelected)
            {
                string message = "Видалити?";
                string caption = "Видалення";
                MessageBoxButtons buttons = MessageBoxButtons.YesNo;
                DialogResult result;

                result = MessageBox.Show(message, caption, buttons);

                if (result == System.Windows.Forms.DialogResult.Yes)
                {
                    listView1.Items.RemoveAt(i);
                    db.Discount.Remove(del);
                    db.SaveChanges();
                }

            }

        }

        private void Form1_Closing(object sender, System.ComponentModel.CancelEventArgs e)
        {
            //MessageBox.Show("закрито");
        }

    }
}
