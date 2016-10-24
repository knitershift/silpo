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
    public partial class BalanceForm : Form
    {
        string balace = null;
        SilpoDBEntities db;
        public BalanceForm()
        {
            InitializeComponent();
            db = new SilpoDBEntities();


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
                    foreach (var i in db.ShopBank)
                    {
                        ListViewItem listItem = new ListViewItem();
                        listItem = listView_Balance.Items.Add(i.idBank.ToString());
                        listItem.SubItems.Add(i.AccountName);
                        listItem.SubItems.Add(i.Balance.ToString());
                      
                    }
                 
                }
            });
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

        private void BalanceForm_Load(object sender, EventArgs e)
        {
            Thread th = new Thread(new ThreadStart(FillDB));
            th.Start();
        }

        private void button_add_Click(object sender, EventArgs e)
        {

            foreach (var i in db.ShopBank)
            {

                balace = i.Balance.ToString();

            }
               balace = (Double.Parse(balace) + Double.Parse(textBox_add.Text)).ToString();


            foreach (var i in db.ShopBank)
            {
                i.Balance =Int32.Parse(balace);

            }
            db.SaveChanges();
            listView_Balance.Items.Clear();
            Thread th = new Thread(new ThreadStart(FillDB));
            th.Start();
        }

        private void button_del_Click(object sender, EventArgs e)
        {

            foreach (var i in db.ShopBank)
            {

                balace = i.Balance.ToString();

            }
            balace = (Double.Parse(balace) +- Double.Parse(textBox_del.Text)).ToString();


            foreach (var i in db.ShopBank)
            {
                i.Balance = Int32.Parse(balace);

            }
            db.SaveChanges();
            listView_Balance.Items.Clear();
            Thread th = new Thread(new ThreadStart(FillDB));
            th.Start();
        }
    }
    }

