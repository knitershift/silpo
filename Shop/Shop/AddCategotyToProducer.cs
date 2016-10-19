using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MaterialSkin.Controls;
using MaterialSkin;

namespace Shop
{
    public partial class AddCategoryToProducer : MaterialForm
    {
        SilpoDBEntities db;
        ListViewItem listitem;
        public AddCategoryToProducer()
        {

            InitializeComponent();

            listitem = new ListViewItem();
            db = new SilpoDBEntities();
            FillListView();
            FillCheckBox();
            var skinmanager = MaterialSkinManager.Instance;
            skinmanager.AddFormToManage(this);
            skinmanager.Theme = MaterialSkinManager.Themes.DARK;
            skinmanager.ColorScheme = new ColorScheme(Primary.BlueGrey800, Primary.BlueGrey900, Primary.BlueGrey500, Accent.LightBlue200, TextShade.WHITE);
        }

        void FillListView()
        {
            listViewProdCat.Items.Clear();
            var nuber2 = db.ProducerCats.Select(n => n.ID_producer_cats);
            try
            {
                foreach (var item in nuber2)
                {
                    var pr = db.ProducerCats.Where(id => id.ID_producer_cats == item).Select(p => p.Id_producer).First();
                    var cats = db.ProducerCats.Where(id => id.ID_producer_cats == item).Select(p => p.Id_category).First();

                    var prod = db.ProducerCats.Where(p => p.Id_producer == pr).Select(p => p.Producer.Name).First();
                    var cat = db.ProducerCats.Where(p => p.Id_category == cats).Select(p => p.Category.Name).First();

                    listitem = listViewProdCat.Items.Add(item.ToString());
                    listitem.SubItems.Add(prod);
                    listitem.SubItems.Add(cat);


                }
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }

        }

        void FillCheckBox()
        {
            var producer = (from tmp in db.Producer
                            select tmp.Name).Distinct();
            comboBoxProducer.Items.AddRange(producer.ToArray());

            var category = (from tmp in db.Category
                            select tmp.Name).Distinct();
            comboBoxCategory.Items.AddRange(category.ToArray());
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void materialFlatButtonAdd_Click(object sender, EventArgs e)
        {

            try
            {
                var selectItemProducer = comboBoxProducer.SelectedItem.ToString();
                var selectItemCategory = comboBoxCategory.SelectedItem.ToString();

                Producer idProducer = db.Producer.Where(x => x.Name == selectItemProducer).SingleOrDefault<Producer>();

                Category idCategory = db.Category.Where(x => x.Name == selectItemCategory).SingleOrDefault<Category>();

                MessageBox.Show(idProducer.ID_producer.ToString() + "  " + idCategory.ID_category.ToString());

                ProducerCats validate = db.ProducerCats.Where(x => x.Id_producer == idProducer.ID_producer).Where(x => x.Id_category == idCategory.ID_category).SingleOrDefault<ProducerCats>();
                if (validate != null)
                {
                    MessageBox.Show("Уже існує");
                    return;
                }


                db.ProducerCats.Add(new ProducerCats { Id_producer = idProducer.ID_producer, Id_category = idCategory.ID_category });

                db.SaveChanges();

                MessageBox.Show("Додано");
                FillListView();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);

            }
        }

        private void exitMenu_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
