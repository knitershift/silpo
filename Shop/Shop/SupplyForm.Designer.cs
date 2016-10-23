namespace Shop
{
    partial class SupplyForm
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
            this.but_add = new System.Windows.Forms.Button();
            this.listView_supply = new System.Windows.Forms.ListView();
            this.col_id = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.col_product = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.col_price = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.col_markup = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.col_amount = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.col_made = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.col_supply = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.textBox_search = new System.Windows.Forms.TextBox();
            this.combo_month = new System.Windows.Forms.ComboBox();
            this.but_Search = new System.Windows.Forms.Button();
            this.button_all = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // but_add
            // 
            this.but_add.BackColor = System.Drawing.Color.Cornsilk;
            this.but_add.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.but_add.ForeColor = System.Drawing.Color.DarkGreen;
            this.but_add.Location = new System.Drawing.Point(650, 75);
            this.but_add.Name = "but_add";
            this.but_add.Size = new System.Drawing.Size(94, 57);
            this.but_add.TabIndex = 4;
            this.but_add.Text = "Додати";
            this.but_add.UseVisualStyleBackColor = false;
            this.but_add.Click += new System.EventHandler(this.but_add_Click);
            // 
            // listView_supply
            // 
            this.listView_supply.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.listView_supply.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.col_id,
            this.col_product,
            this.col_price,
            this.col_markup,
            this.col_amount,
            this.col_made,
            this.col_supply});
            this.listView_supply.FullRowSelect = true;
            this.listView_supply.Location = new System.Drawing.Point(9, 75);
            this.listView_supply.Name = "listView_supply";
            this.listView_supply.Size = new System.Drawing.Size(635, 610);
            this.listView_supply.TabIndex = 3;
            this.listView_supply.UseCompatibleStateImageBehavior = false;
            this.listView_supply.View = System.Windows.Forms.View.Details;
            this.listView_supply.Click += new System.EventHandler(this.listView_supply_Click);
            // 
            // col_id
            // 
            this.col_id.Text = "id";
            this.col_id.Width = 35;
            // 
            // col_product
            // 
            this.col_product.Text = "Product";
            this.col_product.Width = 122;
            // 
            // col_price
            // 
            this.col_price.Text = "Price";
            // 
            // col_markup
            // 
            this.col_markup.Text = "MarkUp";
            // 
            // col_amount
            // 
            this.col_amount.Text = "Amount";
            // 
            // col_made
            // 
            this.col_made.Text = "Made";
            this.col_made.Width = 131;
            // 
            // col_supply
            // 
            this.col_supply.Text = "Suppy";
            this.col_supply.Width = 147;
            // 
            // textBox_search
            // 
            this.textBox_search.Location = new System.Drawing.Point(296, 35);
            this.textBox_search.Name = "textBox_search";
            this.textBox_search.Size = new System.Drawing.Size(184, 20);
            this.textBox_search.TabIndex = 6;
            // 
            // combo_month
            // 
            this.combo_month.FormattingEnabled = true;
            this.combo_month.Items.AddRange(new object[] {
            "01",
            "02",
            "03",
            "04",
            "05",
            "06",
            "07",
            "08",
            "09",
            "10",
            "11",
            "12"});
            this.combo_month.Location = new System.Drawing.Point(169, 32);
            this.combo_month.Name = "combo_month";
            this.combo_month.Size = new System.Drawing.Size(121, 21);
            this.combo_month.TabIndex = 7;
            // 
            // but_Search
            // 
            this.but_Search.Location = new System.Drawing.Point(486, 35);
            this.but_Search.Name = "but_Search";
            this.but_Search.Size = new System.Drawing.Size(94, 23);
            this.but_Search.TabIndex = 8;
            this.but_Search.Text = "Пошук";
            this.but_Search.UseVisualStyleBackColor = true;
            this.but_Search.Click += new System.EventHandler(this.but_Search_Click);
            // 
            // button_all
            // 
            this.button_all.ForeColor = System.Drawing.SystemColors.ControlText;
            this.button_all.Location = new System.Drawing.Point(586, 32);
            this.button_all.Name = "button_all";
            this.button_all.Size = new System.Drawing.Size(141, 31);
            this.button_all.TabIndex = 10;
            this.button_all.Text = "Показати всі товари";
            this.button_all.UseVisualStyleBackColor = true;
            this.button_all.Click += new System.EventHandler(this.button_all_Click_1);
            // 
            // SupplyForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkCyan;
            this.ClientSize = new System.Drawing.Size(756, 697);
            this.Controls.Add(this.button_all);
            this.Controls.Add(this.but_Search);
            this.Controls.Add(this.combo_month);
            this.Controls.Add(this.textBox_search);
            this.Controls.Add(this.but_add);
            this.Controls.Add(this.listView_supply);
            this.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.Name = "SupplyForm";
            this.Text = "SupplyForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button but_add;
        private System.Windows.Forms.ListView listView_supply;
        private System.Windows.Forms.ColumnHeader col_id;
        private System.Windows.Forms.ColumnHeader col_product;
        private System.Windows.Forms.ColumnHeader col_price;
        private System.Windows.Forms.ColumnHeader col_markup;
        private System.Windows.Forms.ColumnHeader col_amount;
        private System.Windows.Forms.ColumnHeader col_made;
        private System.Windows.Forms.ColumnHeader col_supply;
        private System.Windows.Forms.TextBox textBox_search;
        private System.Windows.Forms.ComboBox combo_month;
        private System.Windows.Forms.Button but_Search;
        private System.Windows.Forms.Button button_all;
    }
}