using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;

namespace ShowCase
{
    /// <summary>
    /// Interaction logic for Account.xaml
    /// </summary>
    public partial class Account : Window
    {
        private SilpoDBEntities db;
        private Users user;
        private Bill bill;
        public Account(Users user,SilpoDBEntities db)
        {
            InitializeComponent();
            this.db = db;
            this.user = user;

            bill = db.Bill.Where(x => x.ID_User == user.ID_User).First();
            // білів мало є
            textBoxPIB.Text = user.Full_name;
            textBoxPassword.Text = user.Password;
            textBoxLogin.Text = user.Login;
            textBoxCity.Text = user.City;
            label_Balance.Content = bill.Balance.ToString();
            labelBonus.Content = bill.Bonus.ToString();
        }

        private void buttonAddBalance_Click(object sender, RoutedEventArgs e)
        {
            bill.Balance += Convert.ToInt32(textBoxAddBalance.Text);
            db.SaveChanges();
            label_Balance.Content = bill.Balance.ToString();
            MessageBox.Show("Зміна збережена :)");
        }

        private void buttonCity_Click(object sender, RoutedEventArgs e)
        {

            user.City = textBoxCity.Text.ToString();
            db.SaveChanges();
            MessageBox.Show("Зміна збережена :)");
        }

        private void buttonPassword_Click(object sender, RoutedEventArgs e)
        {
            user.Password = textBoxPassword.Text.ToString();
            db.SaveChanges();
            MessageBox.Show("Зміна збережена :)");
        }

        private void buttonLogin_Click(object sender, RoutedEventArgs e)
        {
            foreach (var u in db.Users)
                if (u.Login == textBoxLogin.Text.ToString())
                {
                    MessageBox.Show("Такий логін вже існує !!");
                    return;
                }
            user.Login = textBoxLogin.Text.ToString();
            db.SaveChanges();
            MessageBox.Show("Зміна збережена :)");
        }

        private void buttonPIB_Click(object sender, RoutedEventArgs e)
        {
            user.Full_name = textBoxPIB.Text.ToString();
            db.SaveChanges();
            MessageBox.Show("Зміна збережена :)");
        }
    }
}
