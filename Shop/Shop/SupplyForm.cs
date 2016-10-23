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
using MaterialSkin;
using MaterialSkin.Controls;
namespace Shop
{
    public partial class SupplyForm : MaterialForm
    {
        SilpoDBEntities db;
        ListViewItem listItem;
        public SupplyForm()
        {
            InitializeComponent();

            var skinmanager = MaterialSkinManager.Instance;
            skinmanager.AddFormToManage(this);
            skinmanager.Theme = MaterialSkinManager.Themes.DARK;
            skinmanager.ColorScheme = new ColorScheme(Primary.BlueGrey800, Primary.BlueGrey900, Primary.BlueGrey500, Accent.LightBlue200, TextShade.WHITE);

            db = new SilpoDBEntities();
            // FillDB();

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
                    foreach (var j in db.Supply)
                    {

                        listItem = new ListViewItem();
                        listItem = listView_supply.Items.Add(j.ID_supply.ToString());
                        listItem.SubItems.Add(db.Product.Where(x => x.ID_product == j.Id_product).First().Name);
                        listItem.SubItems.Add(j.Price.ToString());
                        listItem.SubItems.Add(j.MarkUp.ToString());
                        listItem.SubItems.Add(j.Amount.ToString());
                        listItem.SubItems.Add(j.Date_made.ToString());
                        listItem.SubItems.Add(j.Date_supply.ToString());

                    }

                }
            });
        }
        private void but_add_Click(object sender, EventArgs e)
        {
            NewSupply ns = new NewSupply();
            ns.ShowDialog();
            listView_supply.Items.Clear();
            FillDB();
        }

        private void but_delete_Click(object sender, EventArgs e)
        {
            foreach (ListViewItem itm in listView_supply.SelectedItems)
            {

                if (itm.Selected)
                {
                    int id = Int32.Parse(itm.Text);
                    db.Supply.Remove(db.Supply.Where(a => a.ID_supply == id).First());
                }
            }
            db.SaveChanges();
            listView_supply.Items.Clear();
            FillDB();
        }



        private void listView_supply_Click(object sender, EventArgs e)
        {

            string str = listView_supply.SelectedItems[0].Text;

        }

       

        private void SupplyForm_Load(object sender, EventArgs e)
        {

            Thread th = new Thread(new ThreadStart(FillDB));
            th.Start();
        }

        private void but_Search_Click(object sender, EventArgs e)
        {
            List<Supply> pr = null;
            if (combo_month.Text != "" && textBox_search.Text == "")
            {

                using (new CursorEx())
                {
                    listView_supply.Items.Clear();
                    int month = Int32.Parse(combo_month.Text);
                    pr = db.Supply.Where(a => a.Date_supply.Month == month).ToList();

                    foreach (var j in pr)
                    {

                        listItem = new ListViewItem();
                        listItem = listView_supply.Items.Add(j.ID_supply.ToString());
                        listItem.SubItems.Add(db.Product.Where(x => x.ID_product == j.Id_product).First().Name);
                        listItem.SubItems.Add(j.Price.ToString());
                        listItem.SubItems.Add(j.MarkUp.ToString());
                        listItem.SubItems.Add(j.Amount.ToString());
                        listItem.SubItems.Add(j.Date_made.ToString());
                        listItem.SubItems.Add(j.Date_supply.ToString());

                    }
                } if (pr.Count() == 0)
                {

                    MessageBox.Show("Немає такого товару");
                }

            }

            if (combo_month.Text == "" && textBox_search.Text != "")
            {
                using (new CursorEx())
                {
                    listView_supply.Items.Clear();

                    pr = db.Supply.Where(a => a.Product.Name.StartsWith(textBox_search.Text)).ToList();

                    foreach (var p in pr)
                    {
                        listItem = listView_supply.Items.Add(p.ID_supply.ToString());
                        listItem.SubItems.Add(db.Product.Where(x => x.ID_product == p.Id_product).First().Name);
                        listItem.SubItems.Add(p.Price.ToString());
                        listItem.SubItems.Add(p.MarkUp.ToString());
                        listItem.SubItems.Add(p.Amount.ToString());
                        listItem.SubItems.Add(p.Date_made.ToString());
                        listItem.SubItems.Add(p.Date_supply.ToString());

                    }
                } if (pr.Count() == 0)
                {

                    MessageBox.Show("Немає такого товару");
                }
            }
            if (combo_month.Text != "" && textBox_search.Text != "")
            {
                using (new CursorEx())
                {
                    listView_supply.Items.Clear();
                    int month = Int32.Parse(combo_month.Text);

                    var similar = db.Product.Where(p => p.Name.StartsWith(textBox_search.Text));

                    foreach (var i in similar)
                    {


                        pr = db.Supply.Where(s => s.Date_supply.Month == month && s.Id_product == i.ID_product).ToList();
                        foreach (var supply in pr)
                        {
                            listItem = new ListViewItem();
                            listItem = listView_supply.Items.Add(supply.ID_supply.ToString());
                            listItem.SubItems.Add(db.Product.Where(x => x.ID_product == supply.Id_product).First().Name);
                            listItem.SubItems.Add(supply.Price.ToString());
                            listItem.SubItems.Add(supply.MarkUp.ToString());
                            listItem.SubItems.Add(supply.Amount.ToString());
                            listItem.SubItems.Add(supply.Date_made.ToString());
                            listItem.SubItems.Add(supply.Date_supply.ToString());
                        }
                    }

                }
                //if (pr.Count() == 0)
                //                  {

                //                      MessageBox.Show("Немає такого товару");
                //                  }
            }
        }

        private void button_all_Click_1(object sender, EventArgs e)
        {
            listView_supply.Items.Clear();
            textBox_search.Text = "";
            combo_month.Text = "";
            FillDB();
        }
    }
}
