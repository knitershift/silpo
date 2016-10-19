namespace Shop
{
    partial class ProducerPanel
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
            this.listView1 = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.textBox1Name = new System.Windows.Forms.TextBox();
            this.textBox1Country = new System.Windows.Forms.TextBox();
            this.button1Del = new System.Windows.Forms.Button();
            this.NameLabel = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.textBox1Search = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.FillMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.AddMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.DelMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.CloseMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.contextMenuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // listView1
            // 
            this.listView1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.listView1.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3});
            this.listView1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.listView1.FullRowSelect = true;
            this.listView1.GridLines = true;
            this.listView1.Location = new System.Drawing.Point(12, 72);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(619, 389);
            this.listView1.TabIndex = 0;
            this.listView1.UseCompatibleStateImageBehavior = false;
            this.listView1.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "ID";
            this.columnHeader1.Width = 49;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Виробник";
            this.columnHeader2.Width = 201;
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "Країна";
            this.columnHeader3.Width = 264;
            // 
            // textBox1Name
            // 
            this.textBox1Name.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.textBox1Name.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBox1Name.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBox1Name.Location = new System.Drawing.Point(12, 480);
            this.textBox1Name.Name = "textBox1Name";
            this.textBox1Name.Size = new System.Drawing.Size(206, 23);
            this.textBox1Name.TabIndex = 3;
            // 
            // textBox1Country
            // 
            this.textBox1Country.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.textBox1Country.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBox1Country.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBox1Country.Location = new System.Drawing.Point(12, 522);
            this.textBox1Country.Name = "textBox1Country";
            this.textBox1Country.Size = new System.Drawing.Size(204, 23);
            this.textBox1Country.TabIndex = 4;
            // 
            // button1Del
            // 
            this.button1Del.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.button1Del.BackColor = System.Drawing.Color.LightCoral;
            this.button1Del.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1Del.Font = new System.Drawing.Font("Impact", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1Del.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.button1Del.Location = new System.Drawing.Point(470, 480);
            this.button1Del.Name = "button1Del";
            this.button1Del.Size = new System.Drawing.Size(161, 60);
            this.button1Del.TabIndex = 5;
            this.button1Del.Text = "Видалити";
            this.button1Del.UseVisualStyleBackColor = false;
            this.button1Del.Click += new System.EventHandler(this.button1Del_Click);
            // 
            // NameLabel
            // 
            this.NameLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.NameLabel.AutoSize = true;
            this.NameLabel.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.NameLabel.Location = new System.Drawing.Point(13, 464);
            this.NameLabel.Name = "NameLabel";
            this.NameLabel.Size = new System.Drawing.Size(39, 13);
            this.NameLabel.TabIndex = 6;
            this.NameLabel.Text = "Назва";
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label1.Location = new System.Drawing.Point(11, 506);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(41, 13);
            this.label1.TabIndex = 7;
            this.label1.Text = "Країна";
            // 
            // comboBox1
            // 
            this.comboBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "Всі"});
            this.comboBox1.Location = new System.Drawing.Point(210, 33);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(155, 24);
            this.comboBox1.TabIndex = 8;
            this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // textBox1Search
            // 
            this.textBox1Search.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.textBox1Search.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBox1Search.Font = new System.Drawing.Font("Segoe UI", 13.25F);
            this.textBox1Search.Location = new System.Drawing.Point(454, 29);
            this.textBox1Search.Name = "textBox1Search";
            this.textBox1Search.Size = new System.Drawing.Size(126, 31);
            this.textBox1Search.TabIndex = 9;
            this.textBox1Search.TextChanged += new System.EventHandler(this.textBox1Search_TextChanged);
            this.textBox1Search.KeyDown += new System.Windows.Forms.KeyEventHandler(this.textBox1Search_KeyDown);
            this.textBox1Search.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox1Name_KeyPress);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.label2.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label2.Location = new System.Drawing.Point(135, 32);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(73, 24);
            this.label2.TabIndex = 11;
            this.label2.Text = "Країна:";
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.FillMenu,
            this.AddMenu,
            this.DelMenu,
            this.CloseMenu});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(134, 92);
            // 
            // FillMenu
            // 
            this.FillMenu.ForeColor = System.Drawing.SystemColors.ScrollBar;
            this.FillMenu.Name = "FillMenu";
            this.FillMenu.Size = new System.Drawing.Size(133, 22);
            this.FillMenu.Text = "Заповнити";
            // 
            // AddMenu
            // 
            this.AddMenu.ForeColor = System.Drawing.SystemColors.ScrollBar;
            this.AddMenu.Name = "AddMenu";
            this.AddMenu.Size = new System.Drawing.Size(133, 22);
            this.AddMenu.Text = "Добавити";
            // 
            // DelMenu
            // 
            this.DelMenu.ForeColor = System.Drawing.SystemColors.ScrollBar;
            this.DelMenu.Name = "DelMenu";
            this.DelMenu.Size = new System.Drawing.Size(133, 22);
            this.DelMenu.Text = "Видалити";
            this.DelMenu.Click += new System.EventHandler(this.видалитиToolStripMenuItem_Click);
            // 
            // CloseMenu
            // 
            this.CloseMenu.ForeColor = System.Drawing.SystemColors.ScrollBar;
            this.CloseMenu.Name = "CloseMenu";
            this.CloseMenu.Size = new System.Drawing.Size(133, 22);
            this.CloseMenu.Text = "Закрити";
            this.CloseMenu.Click += new System.EventHandler(this.закритиToolStripMenuItem_Click);
            // 
            // pictureBox2
            // 
            this.pictureBox2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.pictureBox2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictureBox2.Location = new System.Drawing.Point(230, 481);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(80, 65);
            this.pictureBox2.TabIndex = 14;
            this.pictureBox2.TabStop = false;
            this.pictureBox2.Click += new System.EventHandler(this.pictureBox2_Click);
            this.pictureBox2.MouseLeave += new System.EventHandler(this.pictureBox2_MouseLeave);
            this.pictureBox2.MouseHover += new System.EventHandler(this.pictureBox2_MouseHover);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictureBox1.Location = new System.Drawing.Point(588, 25);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(40, 40);
            this.pictureBox1.TabIndex = 13;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            this.pictureBox1.MouseLeave += new System.EventHandler(this.pictureBox1_MouseLeave);
            this.pictureBox1.MouseHover += new System.EventHandler(this.pictureBox1_MouseHover);
            // 
            // ProducerPanel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(643, 552);
            this.ContextMenuStrip = this.contextMenuStrip1;
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.textBox1Search);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.NameLabel);
            this.Controls.Add(this.button1Del);
            this.Controls.Add(this.textBox1Country);
            this.Controls.Add(this.textBox1Name);
            this.Controls.Add(this.listView1);
            this.MinimumSize = new System.Drawing.Size(564, 552);
            this.Name = "ProducerPanel";
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Виробники";
            this.contextMenuStrip1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListView listView1;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.TextBox textBox1Name;
        private System.Windows.Forms.TextBox textBox1Country;
        private System.Windows.Forms.Button button1Del;
        private System.Windows.Forms.Label NameLabel;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.TextBox textBox1Search;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem AddMenu;
        private System.Windows.Forms.ToolStripMenuItem DelMenu;
        private System.Windows.Forms.ToolStripMenuItem CloseMenu;
        private System.Windows.Forms.ToolStripMenuItem FillMenu;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
    }
}

