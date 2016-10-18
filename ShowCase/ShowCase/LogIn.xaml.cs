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
using System.Data;
namespace ShowCase
{
    /// <summary>
    /// Логика взаимодействия для LogIn.xaml
    /// </summary>
    public partial class LogIn : Window
    {
        private DataTable users;
        private SilpoDBEntities dbSilpo;
        public LogIn()
        {
            InitializeComponent();
            dbSilpo = new SilpoDBEntities();
            users = new DataTable("Users");
            users.Columns.Add("Login", typeof(string));
            users.Columns.Add("Password", typeof(string));
            fillDataTable_Users();
        }

        private void button_LogIn_Click(object sender, RoutedEventArgs e)
        {
            bool enter = false;
            Users us=null;
            foreach (DataRow u in users.Rows)
            {
                string login = u["Login"].ToString();
                string pass = u["Password"].ToString();
                if (login == textBox_Login.Text.ToString() && pass == textBox_Password.Text.ToString())
                {
                      us = dbSilpo.Users.Where(x => x.Login == login).Single<Users>();
                    enter = true;

                    break;
                }
            }

            if (!enter)
                MessageBox.Show("Incorrect data !!");
            else
            {
                MainWindow main = new MainWindow(dbSilpo, us);
                main.ShowDialog();
            }
        }

        private void fillDataTable_Users()
        {
            foreach (var u in dbSilpo.Users)
                if (u.Role == "user")
                    users.Rows.Add(u.Login, u.Password);
        }

        private void button_Registration_Click(object sender, RoutedEventArgs e)
        {
            Registration reg = new Registration(users, dbSilpo);
            reg.ShowDialog();
            users.Clear();
            fillDataTable_Users();
        }
    }
}
