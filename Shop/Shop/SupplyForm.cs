﻿using System;
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
    public partial class SupplyForm : Form
    {
        SilpoDBEntities db;
        ListViewItem listItem;
        public SupplyForm()
        {
            InitializeComponent();
            but_delete.Enabled = false;

            db = new SilpoDBEntities();
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

       
        private void FillDB() {
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
                but_delete.Enabled = false;
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
            db.SaveChanges();
            listView_supply.Items.Clear();
            FillDB();
        }

        private void textBox_search_TextChanged(object sender, EventArgs e)
        {
            listView_supply.Items.Clear();

            List<Supply> pr = db.Supply.Where(a => a.Product.Name.StartsWith(textBox_search.Text)).ToList();

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
        }

        private void listView_supply_Click(object sender, EventArgs e)
        {

            string str = listView_supply.SelectedItems[0].Text;
            if (str != null)
            {
                but_delete.Enabled = true;

            }
            else
            {
                but_delete.Enabled = false;
            }
        }

        private void combo_month_SelectedIndexChanged(object sender, EventArgs e)
        {


            listView_supply.Items.Clear();
            int month = Int32.Parse(combo_month.Text);
            List<Supply> pr = db.Supply.Where(a => a.Date_supply.Month==month).ToList();

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



        }
    }
}
