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
    public partial class LogIn
    {
        private DataTable users = null;
        private SilpoDBEntities dbSilpo = null;
        bool initIsOk = false;

        public LogIn()
        {
            InitializeComponent();
            connect();
            InputsState(false);
        }

        void InputsState(bool isEnabled)
        {
            button_LogIn.IsEnabled = isEnabled;
            button_Registration.IsEnabled = isEnabled;
            textBox_Login.IsEnabled = isEnabled;
            textBox_Password.IsEnabled = isEnabled;
        }

        private async void connect()
        {
            imgLoading.Visibility = Visibility.Visible;
            initIsOk = await connectAsync();

            if (initIsOk)
            {
                TimeSpan fadeOutTime = new TimeSpan(0, 0, 0, 0, 300);
                var fadeAnimation = new System.Windows.Media.Animation.DoubleAnimation(0d, fadeOutTime);
                imgLoading.BeginAnimation(Image.OpacityProperty, fadeAnimation);
                imgLoading.Visibility = Visibility.Hidden;
                InputsState(true);
            }
            else
            {
                if (MessageBoxResult.OK == MessageBox.Show("Перевірте з'єднання з інтернетом і продовжіть", "Увага", MessageBoxButton.OKCancel))
                    connect();
                else
                    this.Close();
            }
        }

        private Task<bool> connectAsync()
        {
            return Task.Factory.StartNew(() => initData());
        }

        private bool initData()
        {
            try
            {
                dbSilpo = new SilpoDBEntities();
                users = new DataTable("Users");
                users.Columns.Add("Login", typeof(string));
                users.Columns.Add("Password", typeof(string));
                fillDataTable_Users();

                return true;
            }
            catch (Exception ex)
            {
                return false;
            }

        }
        private void button_LogIn_Click(object sender, RoutedEventArgs e)
        {
            if (!initIsOk)
            {
                MessageBox.Show("Пробдлеми зі з'єднанням");
                connect();
                return;
            }

            bool enter = false;
            Users us = null;
            foreach (DataRow u in users.Rows)
            {
                string login = u["Login"].ToString();
                string pass = u["Password"].ToString();
                if (login == textBox_Login.Text.ToString() && pass == textBox_Password.Password.ToString())
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
                main.Show();
                this.Close();
            }
        }

        private void fillDataTable_Users()
        {
            try
            {
                foreach (var u in dbSilpo.Users)
                    if (u.Role == "user")
                        users.Rows.Add(u.Login, u.Password);
            }
            catch
            {
                throw new Exception();
            }
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
