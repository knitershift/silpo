using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MaterialSkin.Controls;
using MaterialSkin;

namespace Shop
{
    public partial class CategoryPanel : MaterialForm
    {
        AddCategoryToProducer FormAddCategory;
        SilpoDBEntities db;
        ListViewItem listitem;
        public CategoryPanel()
        {
            InitializeComponent();
            db = new SilpoDBEntities();
            listitem = new ListViewItem();
            FillDb();
            var skinmanager = MaterialSkinManager.Instance;
            skinmanager.AddFormToManage(this);
            skinmanager.Theme = MaterialSkinManager.Themes.DARK;
            skinmanager.ColorScheme = new ColorScheme(Primary.BlueGrey800, Primary.BlueGrey900, Primary.BlueGrey500, Accent.LightBlue200, TextShade.WHITE);
        }
        public void FillDb()
        {
            listView2.Items.Clear();

            foreach (var i in db.Category)
            {
                listitem = listView2.Items.Add(i.ID_category.ToString());
                listitem.SubItems.Add(i.Name);


            }
        }

        private void button1Search_Click(object sender, EventArgs e)
        {
            listView2.Items.Clear();

            List<Category> pr = db.Category.Where(a => a.Name.StartsWith(textBox1Search.Text)).ToList();

            foreach (var p in pr)
            {
                listitem = listView2.Items.Add(p.ID_category.ToString());
                listitem.SubItems.Add(p.Name);

            }
        }

        private void button1Add_Click(object sender, EventArgs e)
        {
            try
            {
                if (textBox1Add.Text == "")
                {
                    MessageBox.Show("Полe не заповненнe");
                    return;
                }
                else
                {
                    db.Category.Add(new Category { Name = textBox1Add.Text });
                    db.SaveChanges();
                    listView2.Items.Clear();
                    FillDb();
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            textBox1Add.Text = null;
        }

        private void button2del_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("Ви впевнені?", "Підтвердження дії", MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.Yes)
            {
                foreach (ListViewItem itm in listView2.SelectedItems)
                {
                    if (itm.Selected)
                    {
                        int id = Int32.Parse(itm.Text);
                        db.Category.Remove(db.Category.Where(a => a.ID_category == id).First());
                    }
                }
                MessageBox.Show("Done!");
                db.SaveChanges();
                listView2.Items.Clear();
                FillDb();
            }
            else if (dialogResult == DialogResult.No)
            {
                return;
            }
        }

        private void toolStripMenuItem1_Click(object sender, EventArgs e)
        {
            listView2.Items.Clear();
            FillDb();
        }

        private void добавитиToolStripMenuItem_Click(object sender, EventArgs e)
        {
            button1Add_Click(button1Add, null);
        }

        private void видалитиToolStripMenuItem_Click(object sender, EventArgs e)
        {
            button2del_Click(button2del, null);
        }

        private void вийтиToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void textBox1Search_TextChanged(object sender, EventArgs e)
        {
            if (textBox1Search.Text == "")
            {
                FillDb();
            }

        }

        private void textBox1Search_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                button1Search_Click(button1Search, null);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            FormAddCategory = new AddCategoryToProducer();
            FormAddCategory.ShowDialog();

        }
    }
}






