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
    /// Логика взаимодействия для Registration.xaml
    /// </summary>
    public partial class Registration
    {
        DataTable users;
        SilpoDBEntities db;

        public Registration(DataTable users, SilpoDBEntities db)
        {
            InitializeComponent();
            this.users = users;
            this.db = db;
        }

        private void button_OK_Click(object sender, RoutedEventArgs e)
        {
            if (textBox_City.Text.Length <= 4 && textBox_FullName.Text.Length <= 4 && textBox_Login.Text.Length <= 4 && textBox_Password.Text.Length <= 4)
            {
                MessageBox.Show("Дані не заповнені!");
                return;
            }
            bool enter = false;
            foreach (DataRow u in users.Rows)
            {
                string login = u["Login"].ToString();
                if (login == textBox_Login.Text.ToString())
                {
                    enter = true;
                    break;
                }
            }

            using (var trans = db.Database.BeginTransaction())
            {
                try
                {
                    if (enter)
                        MessageBox.Show("Невірний логін!");
                    else
                    {

                        Users usTmp = new Users()
                        {
                            City = textBox_City.Text.ToString(),
                            Full_name = textBox_FullName.Text.ToString(),
                            Login = textBox_Login.Text.ToString(),
                            Password = textBox_Password.Text.ToString(),
                            Role = "user",
                        };
                        db.Users.Add(usTmp);
                        db.SaveChanges();

                        Bill bil = new Bill()
                        {
                            ID_User = db.Users.ToList().Last().ID_User,
                            Balance = 1,
                            Bonus = 0,

                        };
                        db.Bill.Add(bil);
                        db.SaveChanges();
                        trans.Commit();
                        MessageBox.Show("Зареєстровано :)");
                        this.Close();
                    }
                }
                catch (Exception ex)
                {
                    trans.Rollback();
                }
            }
        }
    }
}
