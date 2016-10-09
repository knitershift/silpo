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
        SilpoDBEntities2 db;
        
        ListViewItem listItem = new ListViewItem();
        public ProductForm(SilpoDBEntities2 db1)
        {
            InitializeComponent();
            db = db1;
            listItem = new ListViewItem();
            


        }

        public void FillDB() {


            using(new CursorEx()){
            foreach (var i in db.Product)
            {

                listItem = listView_product.Items.Add(i.ID_prod.ToString());
                listItem.SubItems.Add(i.Name);
                listItem.SubItems.Add(i.Expiry_time.ToString());
                listItem.SubItems.Add(db.Category.Where(x => x.ID_category == i.ID_category).First().Name);
                listItem.SubItems.Add(db.Producer.Where(x => x.ID_producer == i.ID_producer).First().Name);
                Thread.Sleep(100);
               
            }
            }
        }


        private void but_add_Click(object sender, EventArgs e)
        {

            NewProduct newProduct = new NewProduct();
            newProduct.ShowDialog();
            listView_product.Items.Clear();
            FillDB();


        }

        private void but_delete_Click(object sender, EventArgs e)
        {

            foreach (ListViewItem itm in listView_product.SelectedItems)
            {
            
                if (itm.Selected)
                {
                    int id = Int32.Parse(itm.Text);
                    db.Product.Remove(db.Product.Where(a => a.ID_prod == id).First());
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


        }

        private void textBox_search_TextChanged(object sender, EventArgs e)
        {
          using (new CursorEx())
           {

            listView_product.Items.Clear(); 

           List<Product> pr = db.Product.Where(a => a.Name.StartsWith(textBox_search.Text)).ToList();


           
               foreach (var p in pr)
               {
                   listItem = listView_product.Items.Add(p.ID_prod.ToString());
                   listItem.SubItems.Add(p.Name);
                   listItem.SubItems.Add(p.Expiry_time.ToString());
                   listItem.SubItems.Add(db.Category.Where(x => x.ID_category == p.ID_category).First().Name);
                   listItem.SubItems.Add(db.Producer.Where(x => x.ID_producer == p.ID_producer).First().Name);

               }

           }

        }

        private void ProductForm_Load(object sender, EventArgs e)
        {

            FillDB();

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
