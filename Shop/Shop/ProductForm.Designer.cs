namespace Shop
{
    partial class ProductForm
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
            this.listView_product = new System.Windows.Forms.ListView();
            this.col_id = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.col_name = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.col_time = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.col_cat = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.col_produce = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.but_add = new System.Windows.Forms.Button();
            this.but_delete = new System.Windows.Forms.Button();
            this.textBox_search = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // listView_product
            // 
            this.listView_product.BackColor = System.Drawing.Color.CadetBlue;
            this.listView_product.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.col_id,
            this.col_name,
            this.col_time,
            this.col_cat,
            this.col_produce});
            this.listView_product.ForeColor = System.Drawing.SystemColors.WindowText;
            this.listView_product.FullRowSelect = true;
            this.listView_product.Location = new System.Drawing.Point(12, 46);
            this.listView_product.Name = "listView_product";
            this.listView_product.Size = new System.Drawing.Size(637, 568);
            this.listView_product.TabIndex = 0;
            this.listView_product.UseCompatibleStateImageBehavior = false;
            this.listView_product.View = System.Windows.Forms.View.Details;
            this.listView_product.Click += new System.EventHandler(this.listView_product_Click);
            // 
            // col_id
            // 
            this.col_id.Text = "id";
            this.col_id.Width = 42;
            // 
            // col_name
            // 
            this.col_name.Text = "Name";
            this.col_name.Width = 239;
            // 
            // col_time
            // 
            this.col_time.Text = "Expiry time";
            this.col_time.Width = 63;
            // 
            // col_cat
            // 
            this.col_cat.Text = "Category";
            this.col_cat.Width = 106;
            // 
            // col_produce
            // 
            this.col_produce.Text = "Producer";
            this.col_produce.Width = 160;
            // 
            // but_add
            // 
            this.but_add.BackColor = System.Drawing.Color.FloralWhite;
            this.but_add.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.but_add.ForeColor = System.Drawing.Color.ForestGreen;
            this.but_add.Location = new System.Drawing.Point(655, 12);
            this.but_add.Name = "but_add";
            this.but_add.Size = new System.Drawing.Size(92, 52);
            this.but_add.TabIndex = 1;
            this.but_add.Text = "Додати";
            this.but_add.UseVisualStyleBackColor = false;
            this.but_add.Click += new System.EventHandler(this.but_add_Click);
            // 
            // but_delete
            // 
            this.but_delete.BackColor = System.Drawing.SystemColors.ControlLight;
            this.but_delete.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.but_delete.ForeColor = System.Drawing.Color.Firebrick;
            this.but_delete.Location = new System.Drawing.Point(655, 70);
            this.but_delete.Name = "but_delete";
            this.but_delete.Size = new System.Drawing.Size(92, 57);
            this.but_delete.TabIndex = 2;
            this.but_delete.Text = "Видалити";
            this.but_delete.UseVisualStyleBackColor = false;
            this.but_delete.Click += new System.EventHandler(this.but_delete_Click);
            // 
            // textBox_search
            // 
            this.textBox_search.Location = new System.Drawing.Point(477, 12);
            this.textBox_search.Name = "textBox_search";
            this.textBox_search.Size = new System.Drawing.Size(172, 20);
            this.textBox_search.TabIndex = 3;
            this.textBox_search.TextChanged += new System.EventHandler(this.textBox_search_TextChanged);
            // 
            // ProductForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkCyan;
            this.ClientSize = new System.Drawing.Size(751, 626);
            this.Controls.Add(this.textBox_search);
            this.Controls.Add(this.but_delete);
            this.Controls.Add(this.but_add);
            this.Controls.Add(this.listView_product);
            this.ForeColor = System.Drawing.Color.DimGray;
            this.Name = "ProductForm";
            this.Text = "ProductForm";
            this.Load += new System.EventHandler(this.ProductForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListView listView_product;
        private System.Windows.Forms.Button but_add;
        private System.Windows.Forms.Button but_delete;
        private System.Windows.Forms.ColumnHeader col_id;
        private System.Windows.Forms.ColumnHeader col_name;
        private System.Windows.Forms.ColumnHeader col_time;
        private System.Windows.Forms.ColumnHeader col_cat;
        private System.Windows.Forms.ColumnHeader col_produce;
        private System.Windows.Forms.TextBox textBox_search;
    }
}