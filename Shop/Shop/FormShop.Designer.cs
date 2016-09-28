namespace Shop
{
    partial class FormShop
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.listView_Product = new System.Windows.Forms.ListView();
            this.columnHeader_N = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader_name = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader_country = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader_produser = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader_price = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader_amount = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader_suma = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader_toBy = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.button1_toBuy = new System.Windows.Forms.Button();
            this.button_clean = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.Column_N = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column_name = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column_country = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column_producer = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column_price = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column_amount = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column_suma = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column_toBuy = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // listView_Product
            // 
            this.listView_Product.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader_N,
            this.columnHeader_name,
            this.columnHeader_country,
            this.columnHeader_produser,
            this.columnHeader_price,
            this.columnHeader_amount,
            this.columnHeader_suma,
            this.columnHeader_toBy});
            this.listView_Product.Cursor = System.Windows.Forms.Cursors.Default;
            this.listView_Product.Location = new System.Drawing.Point(2, 2);
            this.listView_Product.Name = "listView_Product";
            this.listView_Product.Size = new System.Drawing.Size(669, 237);
            this.listView_Product.TabIndex = 0;
            this.listView_Product.UseCompatibleStateImageBehavior = false;
            this.listView_Product.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader_N
            // 
            this.columnHeader_N.Text = "№";
            this.columnHeader_N.Width = 25;
            // 
            // columnHeader_name
            // 
            this.columnHeader_name.Text = "Назва";
            this.columnHeader_name.Width = 120;
            // 
            // columnHeader_country
            // 
            this.columnHeader_country.Text = "Країна";
            this.columnHeader_country.Width = 120;
            // 
            // columnHeader_produser
            // 
            this.columnHeader_produser.Text = "Виробник";
            this.columnHeader_produser.Width = 120;
            // 
            // columnHeader_price
            // 
            this.columnHeader_price.Text = "Ціна";
            this.columnHeader_price.Width = 80;
            // 
            // columnHeader_amount
            // 
            this.columnHeader_amount.Text = "Кількість";
            this.columnHeader_amount.Width = 70;
            // 
            // columnHeader_suma
            // 
            this.columnHeader_suma.Text = "Сума";
            this.columnHeader_suma.Width = 80;
            // 
            // columnHeader_toBy
            // 
            this.columnHeader_toBy.Text = "Купити";
            this.columnHeader_toBy.Width = 50;
            // 
            // button1_toBuy
            // 
            this.button1_toBuy.BackColor = System.Drawing.Color.Honeydew;
            this.button1_toBuy.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1_toBuy.Location = new System.Drawing.Point(365, 498);
            this.button1_toBuy.Name = "button1_toBuy";
            this.button1_toBuy.Size = new System.Drawing.Size(150, 44);
            this.button1_toBuy.TabIndex = 1;
            this.button1_toBuy.Text = "To buy";
            this.button1_toBuy.UseVisualStyleBackColor = false;
            // 
            // button_clean
            // 
            this.button_clean.BackColor = System.Drawing.Color.LemonChiffon;
            this.button_clean.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_clean.Location = new System.Drawing.Point(156, 499);
            this.button_clean.Name = "button_clean";
            this.button_clean.Size = new System.Drawing.Size(151, 44);
            this.button_clean.TabIndex = 2;
            this.button_clean.Text = "Clean";
            this.button_clean.UseVisualStyleBackColor = false;
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column_N,
            this.Column_name,
            this.Column_country,
            this.Column_producer,
            this.Column_price,
            this.Column_amount,
            this.Column_suma,
            this.Column_toBuy});
            this.dataGridView1.Location = new System.Drawing.Point(2, 245);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(669, 247);
            this.dataGridView1.TabIndex = 3;
            // 
            // Column_N
            // 
            this.Column_N.Frozen = true;
            this.Column_N.HeaderText = "№";
            this.Column_N.Name = "Column_N";
            this.Column_N.ReadOnly = true;
            this.Column_N.Width = 25;
            // 
            // Column_name
            // 
            this.Column_name.Frozen = true;
            this.Column_name.HeaderText = "Назва";
            this.Column_name.Name = "Column_name";
            this.Column_name.ReadOnly = true;
            this.Column_name.Width = 125;
            // 
            // Column_country
            // 
            this.Column_country.Frozen = true;
            this.Column_country.HeaderText = "Країна";
            this.Column_country.Name = "Column_country";
            this.Column_country.ReadOnly = true;
            this.Column_country.Width = 125;
            // 
            // Column_producer
            // 
            this.Column_producer.Frozen = true;
            this.Column_producer.HeaderText = "Виробник";
            this.Column_producer.Name = "Column_producer";
            this.Column_producer.ReadOnly = true;
            this.Column_producer.Width = 125;
            // 
            // Column_price
            // 
            this.Column_price.Frozen = true;
            this.Column_price.HeaderText = "Ціна";
            this.Column_price.Name = "Column_price";
            this.Column_price.ReadOnly = true;
            this.Column_price.Width = 60;
            // 
            // Column_amount
            // 
            this.Column_amount.Frozen = true;
            this.Column_amount.HeaderText = "Кількість";
            this.Column_amount.Name = "Column_amount";
            this.Column_amount.Width = 60;
            // 
            // Column_suma
            // 
            this.Column_suma.Frozen = true;
            this.Column_suma.HeaderText = "Сума";
            this.Column_suma.Name = "Column_suma";
            this.Column_suma.ReadOnly = true;
            this.Column_suma.Width = 60;
            // 
            // Column_toBuy
            // 
            this.Column_toBuy.Frozen = true;
            this.Column_toBuy.HeaderText = "Купити";
            this.Column_toBuy.Name = "Column_toBuy";
            this.Column_toBuy.ReadOnly = true;
            this.Column_toBuy.Width = 50;
            // 
            // FormShop
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(673, 545);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.button_clean);
            this.Controls.Add(this.button1_toBuy);
            this.Controls.Add(this.listView_Product);
            this.Name = "FormShop";
            this.Text = "FormShop";
            this.Load += new System.EventHandler(this.FormShop_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListView listView_Product;
        private System.Windows.Forms.ColumnHeader columnHeader_N;
        private System.Windows.Forms.ColumnHeader columnHeader_name;
        private System.Windows.Forms.ColumnHeader columnHeader_country;
        private System.Windows.Forms.ColumnHeader columnHeader_produser;
        private System.Windows.Forms.ColumnHeader columnHeader_amount;
        private System.Windows.Forms.ColumnHeader columnHeader_suma;
        private System.Windows.Forms.ColumnHeader columnHeader_toBy;
        private System.Windows.Forms.ColumnHeader columnHeader_price;
        private System.Windows.Forms.Button button1_toBuy;
        private System.Windows.Forms.Button button_clean;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column_N;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column_name;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column_country;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column_producer;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column_price;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column_amount;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column_suma;
        private System.Windows.Forms.DataGridViewCheckBoxColumn Column_toBuy;
    }
}