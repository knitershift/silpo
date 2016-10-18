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

namespace Shop
{
    public partial class ProductForm : Form
    {        
        string str = null;     
        SilpoDBEntities db;
        bool a = false;
      
        public ProductForm(SilpoDBEntities db1)
        {
            InitializeComponent();
            this.db = db1;
           

            but_delete.Enabled = false;
          

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
        public void FillDB() {

            InvokeOnFormThread(() =>
            {
                using (new CursorEx())
                {
                    foreach (var i in db.Product)
                    {
                        ListViewItem listItem = new ListViewItem();
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
            //SilpoDBEntities db = new SilpoDBEntities();
            str = listView_product.SelectedItems[0].Text;
            //selected_index = listView_product.SelectedIndices[0];
            //int to_delete = Int32.Parse(str);
            //deleted = db.Product.Where(x => x.ID_prod == to_delete).First().Name;
            if (str != null)
            {
                but_delete.Enabled = true;

            }
            else {
                but_delete.Enabled = false;
            }

        }

       
        private void textBox_search_TextChanged(object sender, EventArgs e)
        {

           

                using (new CursorEx())
                {

                    listView_product.Items.Clear();

                    List<Product> pr = db.Product.Where(a => a.Name.StartsWith(textBox_search.Text)).ToList();



                    foreach (var p in pr)
                    {
                        ListViewItem listItem = new ListViewItem();
                        listItem = listView_product.Items.Add(p.ID_product.ToString());
                        listItem.SubItems.Add(p.Name);
                        listItem.SubItems.Add(p.Expiry_time.ToString());
                        listItem.SubItems.Add(db.Category.Where(x => x.ID_category == p.ID_category).First().Name);
                        listItem.SubItems.Add(db.Producer.Where(x => x.ID_producer == p.ID_producer).First().Name);



                    }

                }

            }


       
        private void ProductForm_Load(object sender, EventArgs e)
        {


            //FillDB();
            Thread th = new Thread(new ThreadStart(FillDB));
            th.Start();
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
    }
}
