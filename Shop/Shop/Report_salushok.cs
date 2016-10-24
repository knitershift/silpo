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
    public partial class Report_salushok : MaterialForm
    {
        SilpoDBEntities db;
        ListViewItem lv;
        public Report_salushok()
        {
            InitializeComponent();
            listView1.GridLines = true;
        }

        private void Report_salushok_Load(object sender, EventArgs e)
        {
            db = new SilpoDBEntities();
            DateTime date =  DateTime.Now;
           
            try
            {
                var zalish = db.Storage.Where(d=>d.FinalDate>=date).Where(c=>c.Available_items>0).OrderBy(x=>x.Id_product);// колекцыя полів вибраних по даті
               // MessageBox.Show(zalish.ToString());
                foreach (var user in zalish)
                {
                    lv = new ListViewItem(user.ID_storage.ToString());
                    string prName = db.Product.Where(pr => pr.ID_product == user.Id_product).First().Name;

                    lv.SubItems.Add(prName.ToString());
                    lv.SubItems.Add(user.Available_items.ToString());
                    lv.SubItems.Add(user.FinalDate.ToShortDateString());

                    listView1.Items.Add(lv);
                }
            }

            catch (Exception ex)
            {
                MessageBox.Show(ex.Message); 
            }
            listView1.AutoResizeColumns(ColumnHeaderAutoResizeStyle.HeaderSize);
            MessageBox.Show("ви зайшли в таблицю Залишки");
        }


    }
}
