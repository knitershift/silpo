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
            SilpoDBEntities2 db = new SilpoDBEntities2();


            using (new CursorEx())
            {
                foreach (var i in db.Users)
                {
                    if (textBox_login.Text == i.Login && textBox_password.Text == i.Password && comboBox_role.Text == "адмін")
                    {

                        AdminPanel adm = new AdminPanel(textBox_login.Text);
                        SignIn sn = new SignIn();
                        this.Hide();
                        Thread.Sleep(1000);
                        adm.ShowDialog();

                        break;

                    }
                }

            }

        }

        private void textBox_login_TextChanged(object sender, EventArgs e)
        {
            if (textBox_login.Text.Length > 2 && textBox_password.Text.Length > 2&&comboBox_role.SelectedIndex>=0)
                button_signIn.Enabled = true;
            else
                button_signIn.Enabled = false;

        }

        private void button_registration_Click(object sender, EventArgs e)
        {
            Registration reg = new Registration();
            reg.ShowDialog();
        }
    }
}
