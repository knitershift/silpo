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
    public partial class SignIn : Form
    {
        public SignIn()
        {
            InitializeComponent();
            comboBox_role.SelectedIndex = 0;
        }

        private void button_signIn_Click(object sender, EventArgs e)
        {

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
