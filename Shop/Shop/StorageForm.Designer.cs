namespace Shop
{
    partial class StorageForm
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
            this.listView_Storage = new System.Windows.Forms.ListView();
            this.id = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Product = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.idSupply = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Items = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Final = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.SuspendLayout();
            // 
            // listView_Storage
            // 
            this.listView_Storage.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.listView_Storage.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.id,
            this.Product,
            this.idSupply,
            this.Items,
            this.Final});
            this.listView_Storage.Location = new System.Drawing.Point(12, 12);
            this.listView_Storage.Name = "listView_Storage";
            this.listView_Storage.Size = new System.Drawing.Size(447, 509);
            this.listView_Storage.TabIndex = 0;
            this.listView_Storage.UseCompatibleStateImageBehavior = false;
            this.listView_Storage.View = System.Windows.Forms.View.Details;
            this.listView_Storage.SelectedIndexChanged += new System.EventHandler(this.listView_Storage_SelectedIndexChanged);
            // 
            // id
            // 
            this.id.Text = "id";
            this.id.Width = 32;
            // 
            // Product
            // 
            this.Product.Text = "Продукт";
            this.Product.Width = 141;
            // 
            // idSupply
            // 
            this.idSupply.Text = "idSupply";
            // 
            // Items
            // 
            this.Items.Text = "штук";
            // 
            // Final
            // 
            this.Final.Text = "Залишок на дату";
            this.Final.Width = 150;
            // 
            // StorageForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(540, 533);
            this.Controls.Add(this.listView_Storage);
            this.Name = "StorageForm";
            this.Text = "StorageForm";
            this.Load += new System.EventHandler(this.StorageForm_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListView listView_Storage;
        private System.Windows.Forms.ColumnHeader id;
        private System.Windows.Forms.ColumnHeader Product;
        private System.Windows.Forms.ColumnHeader idSupply;
        private System.Windows.Forms.ColumnHeader Items;
        private System.Windows.Forms.ColumnHeader Final;
    }
}