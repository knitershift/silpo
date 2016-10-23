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
using MaterialSkin.Controls;
using MaterialSkin;
using Shop.Properties;
namespace Shop
{
    public partial class ProducerPanel : MaterialForm
    {
        //  Thread myThread;
        SilpoDBEntities db;
        ListViewItem listitem;
        Image SearchImage = Resources.searchBitmap;
        Image PlusImage = Resources.plus;
        public ProducerPanel()
        {
            InitializeComponent();
            db = new SilpoDBEntities();
            listitem = new ListViewItem();
            //myThread = new Thread(FillDb);
            // myThread.Start();
            pictureBox1.Image = SearchImage;
            pictureBox2.Image = PlusImage;

            var skinmanager = MaterialSkinManager.Instance;
            skinmanager.AddFormToManage(this);
            skinmanager.Theme = MaterialSkinManager.Themes.DARK;
            skinmanager.ColorScheme = new ColorScheme(Primary.BlueGrey800, Primary.BlueGrey900, Primary.BlueGrey500, Accent.LightBlue200, TextShade.WHITE);
            comboBox1.SelectedIndex = 0;
            FillCombobox();
            FillDb();
        }
        /// <summary>
        /// Add new producer
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void button1Add_Click(object sender, EventArgs e)
        {
            try
            {
                if (textBox1Name.Text == "" || textBox1Country.Text == "")
                {
                    MessageBox.Show("Поля не заповненні");
                    return;
                }
                else
                {
                    db.Producer.Add(new Producer { Name = "\"" + textBox1Name.Text + "\"", Country = textBox1Country.Text });
                    db.SaveChanges();
                    listView1.Items.Clear();
                    comboBox1.Items.Clear();
                    FillDb();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            textBox1Name.Text = null;
            textBox1Country.Text = null;
        }
        /// <summary>
        /// Function fiil listview
        /// </summary>
        void FillDb()
        {
            listView1.Items.Clear();
            foreach (var i in db.Producer)
            {
                listitem = listView1.Items.Add(i.ID_producer.ToString());
                listitem.SubItems.Add(i.Name);
                listitem.SubItems.Add(i.Country);
            }
        }

        void FillCombobox()
        {
            var producer = (from tmp in db.Producer
                            select tmp.Country).Distinct();
            comboBox1.Items.AddRange(producer.ToArray());


        }


        private void button1Del_Click(object sender, EventArgs e)
        {

            if (listitem.Selected == false)
            {
                MessageBox.Show("Нічого не виділено");
                return;
            }
            else
            {
                DialogResult dialogResult = MessageBox.Show("Ви впевнені?", "Підтвердження дії", MessageBoxButtons.YesNo);
                if (dialogResult == DialogResult.Yes)
                {
                    //do something                     
                    foreach (ListViewItem itm in listView1.SelectedItems)
                    {
                        if (itm.Selected)
                        {
                            int id = Int32.Parse(itm.Text);
                            db.Producer.Remove(db.Producer.Where(a => a.ID_producer == id).First());
                        }
                    }
                    MessageBox.Show("Done!");
                    db.SaveChanges();
                    listView1.Items.Clear();
                    FillDb();
                }
                else if (dialogResult == DialogResult.No)
                {
                    return;
                }
            }
        }

        private void закритиToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }



        private void видалитиToolStripMenuItem_Click(object sender, EventArgs e)
        {
            button1Del_Click(button1Del, null);
        }

        private void toolStripMenuItem1_Click(object sender, EventArgs e)
        {
            button1Add_Click(pictureBox2, null);
        }

        private void button1Search_Click(object sender, EventArgs e)
        {
            listView1.Items.Clear();

            List<Producer> pr = db.Producer.Where(a => a.Name.StartsWith("\"" + textBox1Search.Text)).ToList();

            foreach (var p in pr)
            {
                listitem = listView1.Items.Add(p.ID_producer.ToString());
                listitem.SubItems.Add(p.Name);
                listitem.SubItems.Add(p.Country);
            }

        }

        private void заповнитиToolStripMenuItem_Click(object sender, EventArgs e)
        {
            listView1.Items.Clear();
            comboBox1.Items.Clear();
            FillDb();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            listView1.Items.Clear();
            if (comboBox1.SelectedIndex == 0)
            {
                FillDb();
            }
            else
                foreach (var i in db.Producer)
                {
                    if (i.Country == this.comboBox1.GetItemText(this.comboBox1.SelectedItem))
                    {
                        listitem = listView1.Items.Add(i.ID_producer.ToString());
                        listitem.SubItems.Add(i.Name);
                        listitem.SubItems.Add(i.Country);
                    }
                }
        }

        private void textBox1Name_KeyPress(object sender, KeyPressEventArgs e)
        {

            if (!Char.IsDigit(e.KeyChar)) return;
            else
                e.Handled = true;
        }

        private void textBox1Search_KeyDown(object sender, KeyEventArgs e)
        {

            if (e.KeyCode == Keys.Enter)
            {
                pictureBox1_Click(pictureBox1, null);
            }
        }

        private void textBox1Search_TextChanged(object sender, EventArgs e)
        {
            if (textBox1Search.Text == "")
            {
                FillDb();
            }
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            listView1.Items.Clear();

            List<Producer> pr = db.Producer.Where(a => a.Name.StartsWith("\"" + textBox1Search.Text)).ToList();

            foreach (var p in pr)
            {
                listitem = listView1.Items.Add(p.ID_producer.ToString());
                listitem.SubItems.Add(p.Name);
                listitem.SubItems.Add(p.Country);
            }

        }

        private void pictureBox1_MouseHover(object sender, EventArgs e)
        {
            int SearchWidth = SearchImage.Width + ((SearchImage.Width * 10) / 100);
            int SearchHeight = SearchImage.Height + ((SearchImage.Height * 10) / 100);

            Bitmap Search1 = new Bitmap(SearchWidth, SearchHeight);
            Graphics g = Graphics.FromImage(Search1);
            g.DrawImage(SearchImage, new Rectangle(Point.Empty, Search1.Size));
            pictureBox1.Image = Search1;
        }

        private void pictureBox1_MouseLeave(object sender, EventArgs e)
        {
            pictureBox1.Image = SearchImage;
        }

        private void pictureBox2_MouseHover(object sender, EventArgs e)
        {
            int SearchWidth = PlusImage.Width + ((PlusImage.Width * 10) / 100);
            int SearchHeight = PlusImage.Height + ((PlusImage.Height * 10) / 100);

            Bitmap Plus1 = new Bitmap(SearchWidth, SearchHeight);
            Graphics g = Graphics.FromImage(Plus1);
            g.DrawImage(PlusImage, new Rectangle(Point.Empty, Plus1.Size));
            pictureBox2.Image = Plus1;
        }

        private void pictureBox2_MouseLeave(object sender, EventArgs e)
        {
            pictureBox2.Image = PlusImage;
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            try
            {
                if (textBox1Name.Text == "" || textBox1Country.Text == "")
                {
                    MessageBox.Show("Поля не заповненні");
                    return;
                }
                else
                {
                    db.Producer.Add(new Producer { Name = "\"" + textBox1Name.Text + "\"", Country = textBox1Country.Text });
                    db.SaveChanges();
                    listView1.Items.Clear();
                    comboBox1.Items.Clear();
                    FillDb();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            textBox1Name.Text = null;
            textBox1Country.Text = null;
        }
    }
}
