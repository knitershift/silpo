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
    public partial class SupplyForm : Form
    {
        SilpoDBEntities1 db;
        public SupplyForm()
        {
            InitializeComponent();
           

             db = new SilpoDBEntities1();
             FillDB();
         
        }

        private void listView_supply_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
        private void FillDB() {
            foreach (var j in db.Supply)
            {

                ListViewItem listItem = new ListViewItem();
                listItem = listView_supply.Items.Add(j.ID_supply.ToString());
                listItem.SubItems.Add(db.Product.Where(x => x.ID_prod == j.Id_product).First().Name);
                listItem.SubItems.Add(j.Price.ToString());
                listItem.SubItems.Add(j.MarkUp.ToString());
                listItem.SubItems.Add(j.Amount.ToString());
                listItem.SubItems.Add(j.Date_made.ToString());
                listItem.SubItems.Add(j.Date_supply.ToString());

            }
        
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
            MessageBox.Show(" Видалено");
            MessageBox.Show("Зачекайте!");
            db.SaveChanges();
            listView_supply.Items.Clear();
            FillDB();
        }
    }
}
