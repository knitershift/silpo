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

namespace Shop
{
    public partial class SignIn : Form
    {
        SilpoDBEntities db;
        public SignIn()
        {
            InitializeComponent();
            comboBox_role.SelectedIndex = 0;
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
        private void button_signIn_Click(object sender, EventArgs e)
        {
            db = new SilpoDBEntities();


            using (new CursorEx())
            {
                try
                {
                    var role = db.Users.Where(x => x.Login == textBox_login.Text).Where(y => y.Password == textBox_password.Text).Select(r => r.Role).First();
                    //MessageBox.Show(role);
                    if (role == "admin" && comboBox_role.Text == "адмін")
                    {
                        AdminPanel adm = new AdminPanel(textBox_login.Text);
                        SignIn sn = new SignIn();
                        this.Hide();
                        Thread.Sleep(1000);
                        adm.ShowDialog();
                    }

                    else if (role == "seller" && comboBox_role.Text == "касир")
                    {
                        Cashbox cashbox = new Cashbox(textBox_login.Text);
                        this.Hide();
                        cashbox.ShowDialog();
                    }
                    else
                    {
                        MessageBox.Show("В доступі відмовлено");
                    }

                }
                catch (Exception ex)
                {
                    MessageBox.Show("такого користувача немає,можете реєструватися");
                    //MessageBox.Show(ex.Message);

                }
            }

        }
        
        private void textBox_login_TextChanged(object sender, EventArgs e)
        {
            if (textBox_login.Text.Length > 2 && textBox_password.Text.Length > 2 && comboBox_role.SelectedIndex >= 0)
                button_signIn.Enabled = true;
            else
                button_signIn.Enabled = false;

        }

        private void button_registration_Click(object sender, EventArgs e)
        {
            db = new SilpoDBEntities();
          
            try
            {
                int logins = db.Users.Where(log => log.Login == textBox_login.Text).Count(); // вибірка логіна із введеного
              
                 //MessageBox.Show(logins.Login.ToString());
                if (logins>0)
                {
                    MessageBox.Show("Ви зареестровані");

                }
                else if(logins==0)
                {
                    
                    Registration reg = new Registration(textBox_login.Text, textBox_password.Text);
                    reg.ShowDialog();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                
            }
        }
    }
}
