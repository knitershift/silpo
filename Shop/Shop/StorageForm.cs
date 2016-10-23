using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Shop
{
    public partial class StorageForm : Form
    {

        //string str = null;
        SilpoDBEntities db;
       
        
        public StorageForm(SilpoDBEntities db)
        {
            InitializeComponent();
            this.db = db;
           
           
        
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
        private void FillDB()
        {
            InvokeOnFormThread(() =>
            {
                using (new CursorEx())
                {
                    foreach (var j in db.Storage)
                    {

                        ListViewItem listItem = new ListViewItem();

                        listItem = listView_Storage.Items.Add(j.ID_storage.ToString());
                        listItem.SubItems.Add(db.Product.Where(x => x.ID_product == j.Id_product).First().Name);
                        listItem.SubItems.Add(j.id_supply.ToString());
                        listItem.SubItems.Add(j.Available_items.ToString());
                        listItem.SubItems.Add(j.FinalDate.ToString());


                    }
                }
            });
        }

        private void listView_Storage_SelectedIndexChanged(object sender, EventArgs e)
        {




        }

        private void StorageForm_Load(object sender, EventArgs e)
        {

            Thread th = new Thread(new ThreadStart(FillDB));
            th.Start();
        }
    }
}
