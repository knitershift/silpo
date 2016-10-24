namespace Shop
{
    partial class AddCategoryToProducer
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
            this.components = new System.ComponentModel.Container();
            this.listViewProdCat = new System.Windows.Forms.ListView();
            this.ID = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Producer = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Category = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.materialLabelProducer = new MaterialSkin.Controls.MaterialLabel();
            this.materialLabelCategory = new MaterialSkin.Controls.MaterialLabel();
            this.comboBoxProducer = new System.Windows.Forms.ComboBox();
            this.comboBoxCategory = new System.Windows.Forms.ComboBox();
            this.materialFlatButtonAdd = new MaterialSkin.Controls.MaterialFlatButton();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.addMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.exitMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.contextMenuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // listViewProdCat
            // 
            this.listViewProdCat.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
            | System.Windows.Forms.AnchorStyles.Left)
            | System.Windows.Forms.AnchorStyles.Right)));
            this.listViewProdCat.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.ID,
            this.Producer,
            this.Category});
            this.listViewProdCat.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.listViewProdCat.FullRowSelect = true;
            this.listViewProdCat.GridLines = true;
            this.listViewProdCat.Location = new System.Drawing.Point(22, 133);
            this.listViewProdCat.MinimumSize = new System.Drawing.Size(479, 301);
            this.listViewProdCat.Name = "listViewProdCat";
            this.listViewProdCat.Size = new System.Drawing.Size(529, 369);
            this.listViewProdCat.TabIndex = 0;
            this.listViewProdCat.UseCompatibleStateImageBehavior = false;
            this.listViewProdCat.View = System.Windows.Forms.View.Details;
            // 
            // ID
            // 
            this.ID.Text = "Номер";
            this.ID.Width = 141;
            // 
            // Producer
            // 
            this.Producer.Text = "Виробники";
            this.Producer.Width = 147;
            // 
            // Category
            // 
            this.Category.Text = "Категорії";
            this.Category.Width = 236;
            // 
            // materialLabelProducer
            // 
            this.materialLabelProducer.AutoSize = true;
            this.materialLabelProducer.Depth = 0;
            this.materialLabelProducer.Font = new System.Drawing.Font("Roboto", 11F);
            this.materialLabelProducer.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabelProducer.Location = new System.Drawing.Point(18, 68);
            this.materialLabelProducer.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabelProducer.Name = "materialLabelProducer";
            this.materialLabelProducer.Size = new System.Drawing.Size(78, 19);
            this.materialLabelProducer.TabIndex = 1;
            this.materialLabelProducer.Text = "Виробник";
            // 
            // materialLabelCategory
            // 
            this.materialLabelCategory.AutoSize = true;
            this.materialLabelCategory.Depth = 0;
            this.materialLabelCategory.Font = new System.Drawing.Font("Roboto", 11F);
            this.materialLabelCategory.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabelCategory.Location = new System.Drawing.Point(196, 70);
            this.materialLabelCategory.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabelCategory.Name = "materialLabelCategory";
            this.materialLabelCategory.Size = new System.Drawing.Size(77, 19);
            this.materialLabelCategory.TabIndex = 2;
            this.materialLabelCategory.Text = "Категорія";
            // 
            // comboBoxProducer
            // 
            this.comboBoxProducer.FormattingEnabled = true;
            this.comboBoxProducer.Location = new System.Drawing.Point(22, 93);
            this.comboBoxProducer.Name = "comboBoxProducer";
            this.comboBoxProducer.Size = new System.Drawing.Size(163, 21);
            this.comboBoxProducer.TabIndex = 3;
            // 
            // comboBoxCategory
            // 
            this.comboBoxCategory.FormattingEnabled = true;
            this.comboBoxCategory.Location = new System.Drawing.Point(200, 94);
            this.comboBoxCategory.Name = "comboBoxCategory";
            this.comboBoxCategory.Size = new System.Drawing.Size(163, 21);
            this.comboBoxCategory.TabIndex = 4;
            this.comboBoxCategory.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // materialFlatButtonAdd
            // 
            this.materialFlatButtonAdd.AutoSize = true;
            this.materialFlatButtonAdd.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.materialFlatButtonAdd.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.materialFlatButtonAdd.Depth = 0;
            this.materialFlatButtonAdd.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.materialFlatButtonAdd.FlatAppearance.BorderSize = 3;
            this.materialFlatButtonAdd.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.materialFlatButtonAdd.Location = new System.Drawing.Point(375, 88);
            this.materialFlatButtonAdd.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.materialFlatButtonAdd.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialFlatButtonAdd.Name = "materialFlatButtonAdd";
            this.materialFlatButtonAdd.Primary = false;
            this.materialFlatButtonAdd.Size = new System.Drawing.Size(69, 36);
            this.materialFlatButtonAdd.TabIndex = 5;
            this.materialFlatButtonAdd.Text = "Додати";
            this.materialFlatButtonAdd.UseVisualStyleBackColor = false;
            this.materialFlatButtonAdd.Click += new System.EventHandler(this.materialFlatButtonAdd_Click);
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.addMenu,
            this.exitMenu});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(153, 70);
            // 
            // addMenu
            // 
            this.addMenu.Name = "addMenu";
            this.addMenu.Size = new System.Drawing.Size(152, 22);
            this.addMenu.Text = "Додати";
            // 
            // exitMenu
            // 
            this.exitMenu.Name = "exitMenu";
            this.exitMenu.Size = new System.Drawing.Size(152, 22);
            this.exitMenu.Text = "Вийти";
            this.exitMenu.Click += new System.EventHandler(this.exitMenu_Click);
            // 
            // AddCategoryToProducer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(563, 514);
            this.Controls.Add(this.materialFlatButtonAdd);
            this.Controls.Add(this.comboBoxCategory);
            this.Controls.Add(this.comboBoxProducer);
            this.Controls.Add(this.materialLabelCategory);
            this.Controls.Add(this.materialLabelProducer);
            this.Controls.Add(this.listViewProdCat);
            this.MinimumSize = new System.Drawing.Size(563, 514);
            this.Name = "AddCategoryToProducer";
            this.Text = "Додавання категорії продюсеру";
            this.contextMenuStrip1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListView listViewProdCat;
        private MaterialSkin.Controls.MaterialLabel materialLabelProducer;
        private MaterialSkin.Controls.MaterialLabel materialLabelCategory;
        private System.Windows.Forms.ComboBox comboBoxProducer;
        private System.Windows.Forms.ComboBox comboBoxCategory;
        private MaterialSkin.Controls.MaterialFlatButton materialFlatButtonAdd;
        private System.Windows.Forms.ColumnHeader ID;
        private System.Windows.Forms.ColumnHeader Producer;
        private System.Windows.Forms.ColumnHeader Category;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem addMenu;
        private System.Windows.Forms.ToolStripMenuItem exitMenu;
    }
}