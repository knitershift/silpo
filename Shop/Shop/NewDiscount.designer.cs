namespace Shop
{
    partial class NewDiscount
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
            this.label1 = new System.Windows.Forms.Label();
            this.checkBox_true = new System.Windows.Forms.CheckBox();
            this.button_add = new System.Windows.Forms.Button();
            this.comboBox_category = new System.Windows.Forms.ComboBox();
            this.listView1 = new System.Windows.Forms.ListView();
            this.Number = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Product = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.percent = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.DateStart = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.DateEnd = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.label_cat = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AllowDrop = true;
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(409, 82);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(46, 19);
            this.label1.TabIndex = 1;
            this.label1.Text = "Діючі";
            // 
            // checkBox_true
            // 
            this.checkBox_true.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.checkBox_true.AutoSize = true;
            this.checkBox_true.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.checkBox_true.Location = new System.Drawing.Point(471, 87);
            this.checkBox_true.Name = "checkBox_true";
            this.checkBox_true.Size = new System.Drawing.Size(15, 14);
            this.checkBox_true.TabIndex = 2;
            this.checkBox_true.UseVisualStyleBackColor = true;
            this.checkBox_true.CheckedChanged += new System.EventHandler(this.checkBox_true_CheckedChanged);
            // 
            // button_add
            // 
            this.button_add.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.button_add.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.button_add.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button_add.ForeColor = System.Drawing.Color.DarkGreen;
            this.button_add.Location = new System.Drawing.Point(609, 80);
            this.button_add.Name = "button_add";
            this.button_add.Size = new System.Drawing.Size(140, 27);
            this.button_add.TabIndex = 3;
            this.button_add.Text = "Додати знижку";
            this.button_add.UseVisualStyleBackColor = true;
            this.button_add.Click += new System.EventHandler(this.button_add_Click);
            // 
            // comboBox_category
            // 
            this.comboBox_category.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.comboBox_category.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.comboBox_category.FormattingEnabled = true;
            this.comboBox_category.Location = new System.Drawing.Point(178, 79);
            this.comboBox_category.Name = "comboBox_category";
            this.comboBox_category.Size = new System.Drawing.Size(201, 24);
            this.comboBox_category.TabIndex = 5;
            this.comboBox_category.Text = "+";
            this.comboBox_category.SelectedIndexChanged += new System.EventHandler(this.comboBox_category_SelectedIndexChanged);
            // 
            // listView1
            // 
            this.listView1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.listView1.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.Number,
            this.Product,
            this.percent,
            this.DateStart,
            this.DateEnd});
            this.listView1.Location = new System.Drawing.Point(100, 144);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(649, 326);
            this.listView1.TabIndex = 6;
            this.listView1.UseCompatibleStateImageBehavior = false;
            this.listView1.View = System.Windows.Forms.View.Details;
            this.listView1.ItemSelectionChanged += new System.Windows.Forms.ListViewItemSelectionChangedEventHandler(this.button_del_Click);
            // 
            // Number
            // 
            this.Number.Text = "N";
            this.Number.Width = 51;
            // 
            // Product
            // 
            this.Product.Text = "Product";
            this.Product.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.Product.Width = 62;
            // 
            // percent
            // 
            this.percent.Text = "%";
            this.percent.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.percent.Width = 44;
            // 
            // DateStart
            // 
            this.DateStart.Text = "Дата початку";
            this.DateStart.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.DateStart.Width = 175;
            // 
            // DateEnd
            // 
            this.DateEnd.Text = "Дата кінця";
            this.DateEnd.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.DateEnd.Width = 221;
            // 
            // label_cat
            // 
            this.label_cat.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label_cat.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label_cat.Location = new System.Drawing.Point(97, 82);
            this.label_cat.Name = "label_cat";
            this.label_cat.Size = new System.Drawing.Size(75, 21);
            this.label_cat.TabIndex = 7;
            this.label_cat.Text = "Категорїї";
            // 
            // NewDiscount
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(821, 562);
            this.Controls.Add(this.label_cat);
            this.Controls.Add(this.listView1);
            this.Controls.Add(this.comboBox_category);
            this.Controls.Add(this.button_add);
            this.Controls.Add(this.checkBox_true);
            this.Controls.Add(this.label1);
            this.ForeColor = System.Drawing.Color.Maroon;
            this.Name = "NewDiscount";
            this.Text = "Discount";
            this.Load += new System.EventHandler(this.Discount_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.CheckBox checkBox_true;
        private System.Windows.Forms.Button button_add;
        private System.Windows.Forms.ComboBox comboBox_category;
        private System.Windows.Forms.ListView listView1;
        private System.Windows.Forms.ColumnHeader Number;
        private System.Windows.Forms.ColumnHeader Product;
        private System.Windows.Forms.ColumnHeader percent;
        private System.Windows.Forms.ColumnHeader DateStart;
        private System.Windows.Forms.ColumnHeader DateEnd;
        private System.Windows.Forms.Label label_cat;
    }
}

