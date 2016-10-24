using MaterialSkin.Controls;
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
    public partial class Cashbox : MaterialForm
    {  
        SilpoDBEntities db ;
        public Cashbox(string login)
        {
            InitializeComponent();
            db = new SilpoDBEntities();
            label_name.Text = db.Users.Where(x => x.Login == login).First().Full_name;
            label_userid.Text = db.Users.Where(x => x.Login == login).First().ID_User.ToString(); //це сховано
           
        }
      
    
        bool empty = false;
        static  double mylt = 0;  // сума яка додається до балансу компанїї при підтвердженні замовлення

        private void Cashbox_Load(object sender, EventArgs e)
        {
            var or = db.Orders.Select(x => x.ID_product);
            var users = db.Orders.Where(id => id.Complited == "no").Select(x => x.Users).Distinct();  // створили колекцію імен 
            foreach (var items in users)
            {
                listBox_queue.Items.Add(items.Full_name); // присвоїли кожному item- імя з колекціі імен

            }
            if (listBox_queue.Items.Count > 0)
            {
                empty = true;
            }
            else
            {
                MessageBox.Show("замовлень немає");
                this.Close();
            }

        }
        private void Select(object sender, System.EventArgs e)
        {
            if (empty == true)
            {
                listView_queue.Items.Clear();
                try
                {
                    if (listBox_queue.SelectedIndex > -1)
                    {
                        var s = listBox_queue.SelectedItem.ToString();
                        //MessageBox.Show(s);                  

                        var orders = db.Orders.Where(x => x.Users.Full_name == s).Where(id => id.Complited == "no");

                        foreach (var item in orders)
                        {
                            ListViewItem lv = new ListViewItem(item.ID_order.ToString());

                            string prName = db.Product.Where(p => p.ID_product == item.ID_product).First().Name;
                            lv.SubItems.Add(prName);
                            lv.SubItems.Add(item.Count.ToString());
                            lv.SubItems.Add(item.FullPrice.ToString());
                            listView_queue.Items.Add(lv);
                        }


                        var count_listview = listView_queue.Items.Count;
                        //MessageBox.Show(count_listview.ToString());

                       // double mylt = 0;
                        for (int i = 0; i < count_listview; i++)
                        {
                            var first = Convert.ToDouble(listView_queue.Items[i].SubItems[2].Text);
                            double sec = Convert.ToDouble(listView_queue.Items[i].SubItems[3].Text);
                            mylt +=(sec * first);

                        }
                        materialSingleLineTextField_sum.Text = Convert.ToString(mylt);  // поле "до сплати"
                       
                        listView_queue.AutoResizeColumns(ColumnHeaderAutoResizeStyle.HeaderSize);

                    }

                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }

            }
           // MessageBox.Show("зміни внесено");
        }

        private void materialFlatButton_ok_Click(object sender, EventArgs e)  // ПіДТВЕРДЖЕНННЯ кнопка
        {
            var itemss = listView_queue.Items;    // колекція IdOrder
            foreach (var it in itemss)  // заповнення поля "complited"
            {
                var li = (ListViewItem)it;
                int idorder = Convert.ToInt32(li.Text);

                var orderOrder = db.Orders.Where(x => x.ID_order == idorder).First();
                orderOrder.Complited = "yes";

                var sell = new Sell();
                sell.idSeller = Convert.ToInt32( label_userid.Text);                    
                sell.idOrder = idorder;
                //MessageBox.Show(sell.idSeller.ToString());
                //MessageBox.Show(sell.idOrder.ToString());
                db.Sell.Add(sell);


            }
            var balance = db.ShopBank.Where(name => name.AccountName == "Silpo").First(); // заповнення таблиці Shopbank
            decimal sum = Convert.ToDecimal( mylt);
            //MessageBox.Show(balance.ToString());
            //MessageBox.Show(sum.ToString());
            balance.Balance += sum;
            //MessageBox.Show(balance.ToString());
            
            db.SaveChanges();
            listBox_queue.Items.Remove(listBox_queue.SelectedItem);
        }

        private void materialFlatButton_away_Click(object sender, EventArgs e) //кнопка вийти
        {
            this.Close();
        }
    }
}
