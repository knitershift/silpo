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
            this.but_delete = new System.Windows.Forms.Button();
            this.but_add = new System.Windows.Forms.Button();
            this.listView_supply = new System.Windows.Forms.ListView();
            this.col_id = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.col_product = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.col_price = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.col_markup = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.col_amount = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.col_made = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.col_supply = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.SuspendLayout();
            // 
            // but_delete
            // 
            this.but_delete.BackColor = System.Drawing.Color.Firebrick;
            this.but_delete.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.but_delete.ForeColor = System.Drawing.Color.DarkGray;
            this.but_delete.Location = new System.Drawing.Point(653, 75);
            this.but_delete.Name = "but_delete";
            this.but_delete.Size = new System.Drawing.Size(91, 54);
            this.but_delete.TabIndex = 5;
            this.but_delete.Text = "Видалити";
            this.but_delete.UseVisualStyleBackColor = false;
            this.but_delete.Click += new System.EventHandler(this.but_delete_Click);
            // 
            // but_add
            // 
            this.but_add.BackColor = System.Drawing.SystemColors.Desktop;
            this.but_add.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.but_add.ForeColor = System.Drawing.Color.DarkGreen;
            this.but_add.Location = new System.Drawing.Point(650, 12);
            this.but_add.Name = "but_add";
            this.but_add.Size = new System.Drawing.Size(94, 57);
            this.but_add.TabIndex = 4;
            this.but_add.Text = "Додати";
            this.but_add.UseVisualStyleBackColor = false;
            this.but_add.Click += new System.EventHandler(this.but_add_Click);
            // 
            // listView_supply
            // 
            this.listView_supply.BackColor = System.Drawing.Color.CadetBlue;
            this.listView_supply.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.col_id,
            this.col_product,
            this.col_price,
            this.col_markup,
            this.col_amount,
            this.col_made,
            this.col_supply});
            this.listView_supply.FullRowSelect = true;
            this.listView_supply.Location = new System.Drawing.Point(12, 12);
            this.listView_supply.Name = "listView_supply";
            this.listView_supply.Size = new System.Drawing.Size(632, 647);
            this.listView_supply.TabIndex = 3;
            this.listView_supply.UseCompatibleStateImageBehavior = false;
            this.listView_supply.View = System.Windows.Forms.View.Details;
            this.listView_supply.SelectedIndexChanged += new System.EventHandler(this.listView_supply_SelectedIndexChanged);
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
            // SupplyForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkCyan;
            this.ClientSize = new System.Drawing.Size(756, 671);
            this.Controls.Add(this.but_delete);
            this.Controls.Add(this.but_add);
            this.Controls.Add(this.listView_supply);
            this.Name = "SupplyForm";
            this.Text = "SupplyForm";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button but_delete;
        private System.Windows.Forms.Button but_add;
        private System.Windows.Forms.ListView listView_supply;
        private System.Windows.Forms.ColumnHeader col_id;
        private System.Windows.Forms.ColumnHeader col_product;
        private System.Windows.Forms.ColumnHeader col_price;
        private System.Windows.Forms.ColumnHeader col_markup;
        private System.Windows.Forms.ColumnHeader col_amount;
        private System.Windows.Forms.ColumnHeader col_made;
        private System.Windows.Forms.ColumnHeader col_supply;
    }
}