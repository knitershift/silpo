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
    public partial class NewUsers : MaterialForm
    {
        SilpoDBEntities db;
        ListViewItem lv;
        public NewUsers()
        {
            InitializeComponent();
            listView_users.GridLines = true;
        }

        private void NewUsers_Load(object sender, EventArgs e)
        {
            try
            {
                db = new SilpoDBEntities();
                var users = db.Users.Select(u => u.ID_User); // колекцыя ад юзерыв
                foreach (var item in users)  //item- id user
                {
                    lv = new ListViewItem(item.ToString());
                    //var idd = db.Discount.Where(id => id.Id_discount == item).Select(p => p.Id_product).First();
                    //var pr = db.Discount.Where(p => p.Id_product == idd).Select(p => p.Product.Name).First();

                    var qury = db.Users.Where(u => u.ID_User == item); // колекція  полів
                    foreach (var user in qury) // і в кожному полі,,,
                    {
                        lv.SubItems.Add(user.Full_name);
                        lv.SubItems.Add(user.City);
                        lv.SubItems.Add(user.Role);
                        lv.SubItems.Add(user.Login);
                        lv.SubItems.Add(user.Password);

                    }
                    listView_users.Items.Add(lv);
                    // .Items.Add(lv);
                }
            }
            catch (Exception ex)

            { MessageBox.Show(ex.Message); }
   
            listView_users.AutoResizeColumns(ColumnHeaderAutoResizeStyle.HeaderSize);
            MessageBox.Show("ви зайшли в таблицю Користувачі");
        }

        private void button_add_Click(object sender, EventArgs e)
        {
            MessageBox.Show("тут мають додаватися користувач :)");
        }
    }
}
