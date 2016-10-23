using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading;
using System.Timers;
using MaterialSkin;
using MaterialSkin.Controls;
namespace Shop
{
    public partial class ProductForm : MaterialForm
    {
        string str = null;
        SilpoDBEntities db;
        bool a = false;
        ListViewItem listItem;
        public ProductForm(SilpoDBEntities db1)
        {
            InitializeComponent();
            this.db = db1;


            but_delete.Enabled = false;
            var skinmanager = MaterialSkinManager.Instance;
            skinmanager.AddFormToManage(this);
            skinmanager.Theme = MaterialSkinManager.Themes.DARK;
            skinmanager.ColorScheme = new ColorScheme(Primary.BlueGrey800, Primary.BlueGrey900, Primary.BlueGrey500, Accent.LightBlue200, TextShade.WHITE);

        }
        private void InvokeOnFormThread(Action behavior)
        {
            if (IsHandleCreated && InvokeRequired)
            {
                Invoke(behavior);
            }
            else
            {
                behavior();
            }
        }
        public void FillDB()
        {

            InvokeOnFormThread(() =>
            {


                using (new CursorEx())
                {

                    foreach (var i in db.Product)
                    {
                        listItem = new ListViewItem();
                        listItem = listView_product.Items.Add(i.ID_product.ToString());
                        listItem.SubItems.Add(i.Name);
                        listItem.SubItems.Add(i.Expiry_time.ToString());
                        listItem.SubItems.Add(db.Category.Where(x => x.ID_category == i.ID_category).First().Name);
                        listItem.SubItems.Add(db.Producer.Where(x => x.ID_producer == i.ID_producer).First().Name);


                    }
                    but_delete.Enabled = false;

                }

            });
        }


        private void but_add_Click(object sender, EventArgs e)
        {

            NewProduct newProduct = new NewProduct(ref a);
            if (DialogResult.OK == newProduct.ShowDialog())
            {
                listView_product.Items.Clear();
                FillDB();
            }


        }

        private void but_delete_Click(object sender, EventArgs e)
        {

            foreach (ListViewItem itm in listView_product.SelectedItems)
            {

                if (itm.Selected)
                {
                    int id = Int32.Parse(itm.Text);
                    db.Product.Remove(db.Product.Where(a => a.ID_product == id).First());
                }
            }
            db.SaveChanges();
            listView_product.Items.Clear();
            FillDB();








        }

        private void listView_product_Click(object sender, EventArgs e)
        {

            str = listView_product.SelectedItems[0].Text;

            if (str != null)
            {
                but_delete.Enabled = true;
                str = null;
            }
            else
            {
                but_delete.Enabled = false;
            }

        }


        private void ProductForm_Load(object sender, EventArgs e)
        {


            //FillDB();
            System.Windows.Forms.Timer Clock = new System.Windows.Forms.Timer();
            Clock.Interval = 100; // not sure if this length of time will work 
            Clock.Start();
            //Thread th = new Thread(new ThreadStart(FillDB));
            //th.Start();

            Clock.Tick += new EventHandler(Timer_Tick);

        }

        public void Timer_Tick(object sender, EventArgs eArgs)
        {

            FillDB();
            (sender as System.Windows.Forms.Timer).Stop();


        }
        class CursorEx : IDisposable
        {

            public CursorEx()
            {

                Cursor.Current = Cursors.WaitCursor;
            }
            public void Dispose()
            {
                Cursor.Current = Cursors.Default;

            }
        }

      

        private void textBox_search_MouseClick(object sender, MouseEventArgs e)
        {
            str = null;
            but_delete.Enabled = false;
        }

        private void textBox_search_TextChanged(object sender, EventArgs e)
        {

            if (textBox_search.Text == "")
            {

                FillDB();

            }

        }

        private void listView_product_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void Search_Click(object sender, EventArgs e)
        {
            List<Product> pr = null;

            if (textBox_search.Text != "")
            {
                using (new CursorEx())
                {

                    listView_product.Items.Clear();

                    pr = db.Product.Where(a => a.Name.StartsWith(textBox_search.Text)).ToList();



                    foreach (var p in pr)
                    {
                        listItem = new ListViewItem();
                        listItem = listView_product.Items.Add(p.ID_product.ToString());
                        listItem.SubItems.Add(p.Name);
                        listItem.SubItems.Add(p.Expiry_time.ToString());
                        listItem.SubItems.Add(db.Category.Where(x => x.ID_category == p.ID_category).First().Name);
                        listItem.SubItems.Add(db.Producer.Where(x => x.ID_producer == p.ID_producer).First().Name);



                    }


                } if (pr.Count() == 0)
                {

                    MessageBox.Show("Немає такого товару");
                }
            }
        }
    }
}
