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
    public partial class Registration : Form
    {
        SilpoDBEntities db;
        public Registration()
        {
            InitializeComponent();

        }
        public Registration(string login, string parol)
        {
            InitializeComponent();
            textBox_login.Text = login;
            textBox_pass.Text = parol;
        }

        private void Registration_Load(object sender, EventArgs e)
        {
            // нічого не треба

        }

        private void button_ok_Click(object sender, EventArgs e)
        {
            try
            {
                db = new SilpoDBEntities();
                string role = comboBox_role.SelectedItem.ToString();
                string city = textBox_city.Text;
                string name = textBox_name.Text;
                string login = textBox_login.Text;
                string pass = textBox_pass.Text;

                Users newUser = new Users();
                newUser.Role = role;
                newUser.City = city;
                newUser.Full_name = textBox_name.Text;
                newUser.Login = login;
                newUser.Password = pass;
                db.Users.Add(newUser);
                db.SaveChanges();
                MessageBox.Show("зареестровані");
                this.Close();
            }
            catch(Exception ex)
            { 
                MessageBox.Show(ex.Message); 
            }
           
        }

    }
}
