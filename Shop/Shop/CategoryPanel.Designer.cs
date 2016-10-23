namespace Shop
{
    partial class CategoryPanel
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
            this.listView2 = new System.Windows.Forms.ListView();
            this.nameID = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.NameName = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.button1Add = new System.Windows.Forms.Button();
            this.button2del = new System.Windows.Forms.Button();
            this.textBox1Add = new System.Windows.Forms.TextBox();
            this.button1Search = new System.Windows.Forms.Button();
            this.textBox1Search = new System.Windows.Forms.TextBox();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.добавитиToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.видалитиToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.вийтиToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.button1 = new System.Windows.Forms.Button();
            this.contextMenuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // listView2
            // 
            this.listView2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
            | System.Windows.Forms.AnchorStyles.Left)
            | System.Windows.Forms.AnchorStyles.Right)));
            this.listView2.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.nameID,
            this.NameName});
            this.listView2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.listView2.FullRowSelect = true;
            this.listView2.GridLines = true;
            this.listView2.Location = new System.Drawing.Point(16, 120);
            this.listView2.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.listView2.MinimumSize = new System.Drawing.Size(577, 354);
            this.listView2.Name = "listView2";
            this.listView2.Size = new System.Drawing.Size(577, 354);
            this.listView2.TabIndex = 0;
            this.listView2.UseCompatibleStateImageBehavior = false;
            this.listView2.View = System.Windows.Forms.View.Details;
            // 
            // nameID
            // 
            this.nameID.Text = "ID";
            this.nameID.Width = 117;
            // 
            // NameName
            // 
            this.NameName.Text = "Name";
            this.NameName.Width = 336;
            // 
            // button1Add
            // 
            this.button1Add.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.button1Add.BackColor = System.Drawing.SystemColors.InactiveCaptionText;
            this.button1Add.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1Add.Font = new System.Drawing.Font("Impact", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button1Add.ForeColor = System.Drawing.SystemColors.ScrollBar;
            this.button1Add.Location = new System.Drawing.Point(178, 497);
            this.button1Add.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.button1Add.Name = "button1Add";
            this.button1Add.Size = new System.Drawing.Size(87, 33);
            this.button1Add.TabIndex = 1;
            this.button1Add.Text = "Добавити";
            this.button1Add.UseVisualStyleBackColor = false;
            this.button1Add.Click += new System.EventHandler(this.button1Add_Click);
            // 
            // button2del
            // 
            this.button2del.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.button2del.BackColor = System.Drawing.SystemColors.InactiveCaptionText;
            this.button2del.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2del.Font = new System.Drawing.Font("Impact", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button2del.ForeColor = System.Drawing.SystemColors.ScrollBar;
            this.button2del.Location = new System.Drawing.Point(271, 498);
            this.button2del.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.button2del.Name = "button2del";
            this.button2del.Size = new System.Drawing.Size(89, 33);
            this.button2del.TabIndex = 2;
            this.button2del.Text = "Видалити";
            this.button2del.UseVisualStyleBackColor = false;
            this.button2del.Click += new System.EventHandler(this.button2del_Click);
            // 
            // textBox1Add
            // 
            this.textBox1Add.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.textBox1Add.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBox1Add.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBox1Add.Location = new System.Drawing.Point(16, 500);
            this.textBox1Add.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.textBox1Add.Name = "textBox1Add";
            this.textBox1Add.Size = new System.Drawing.Size(156, 26);
            this.textBox1Add.TabIndex = 3;
            // 
            // button1Search
            // 
            this.button1Search.BackColor = System.Drawing.SystemColors.InactiveCaptionText;
            this.button1Search.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1Search.Font = new System.Drawing.Font("Impact", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button1Search.ForeColor = System.Drawing.SystemColors.ScrollBar;
            this.button1Search.Location = new System.Drawing.Point(178, 80);
            this.button1Search.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.button1Search.Name = "button1Search";
            this.button1Search.Size = new System.Drawing.Size(87, 30);
            this.button1Search.TabIndex = 13;
            this.button1Search.Text = "Пошук";
            this.button1Search.UseVisualStyleBackColor = false;
            this.button1Search.Click += new System.EventHandler(this.button1Search_Click);
            // 
            // textBox1Search
            // 
            this.textBox1Search.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBox1Search.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBox1Search.Location = new System.Drawing.Point(14, 83);
            this.textBox1Search.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.textBox1Search.Name = "textBox1Search";
            this.textBox1Search.Size = new System.Drawing.Size(158, 26);
            this.textBox1Search.TabIndex = 14;
            this.textBox1Search.TextChanged += new System.EventHandler(this.textBox1Search_TextChanged);
            this.textBox1Search.KeyDown += new System.Windows.Forms.KeyEventHandler(this.textBox1Search_KeyDown);
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItem1,
            this.добавитиToolStripMenuItem,
            this.видалитиToolStripMenuItem,
            this.вийтиToolStripMenuItem});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(134, 92);
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.ForeColor = System.Drawing.SystemColors.ScrollBar;
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(133, 22);
            this.toolStripMenuItem1.Text = "Заповнити";
            this.toolStripMenuItem1.Click += new System.EventHandler(this.toolStripMenuItem1_Click);
            // 
            // добавитиToolStripMenuItem
            // 
            this.добавитиToolStripMenuItem.ForeColor = System.Drawing.SystemColors.ScrollBar;
            this.добавитиToolStripMenuItem.Name = "добавитиToolStripMenuItem";
            this.добавитиToolStripMenuItem.Size = new System.Drawing.Size(133, 22);
            this.добавитиToolStripMenuItem.Text = "Добавити";
            this.добавитиToolStripMenuItem.Click += new System.EventHandler(this.добавитиToolStripMenuItem_Click);
            // 
            // видалитиToolStripMenuItem
            // 
            this.видалитиToolStripMenuItem.ForeColor = System.Drawing.SystemColors.ScrollBar;
            this.видалитиToolStripMenuItem.Name = "видалитиToolStripMenuItem";
            this.видалитиToolStripMenuItem.Size = new System.Drawing.Size(133, 22);
            this.видалитиToolStripMenuItem.Text = "Видалити";
            this.видалитиToolStripMenuItem.Click += new System.EventHandler(this.видалитиToolStripMenuItem_Click);
            // 
            // вийтиToolStripMenuItem
            // 
            this.вийтиToolStripMenuItem.ForeColor = System.Drawing.SystemColors.ScrollBar;
            this.вийтиToolStripMenuItem.Name = "вийтиToolStripMenuItem";
            this.вийтиToolStripMenuItem.Size = new System.Drawing.Size(133, 22);
            this.вийтиToolStripMenuItem.Text = "Вийти";
            this.вийтиToolStripMenuItem.Click += new System.EventHandler(this.вийтиToolStripMenuItem_Click);
            // 
            // button1
            // 
            this.button1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.button1.BackColor = System.Drawing.SystemColors.InactiveCaptionText;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Impact", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button1.ForeColor = System.Drawing.SystemColors.ScrollBar;
            this.button1.Location = new System.Drawing.Point(446, 79);
            this.button1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.button1.Name = "button1";
            this.button1.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.button1.Size = new System.Drawing.Size(145, 33);
            this.button1.TabIndex = 15;
            this.button1.Text = "Виробники";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // CategoryPanel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(623, 556);
            this.ContextMenuStrip = this.contextMenuStrip1;
            this.Controls.Add(this.button1);
            this.Controls.Add(this.textBox1Search);
            this.Controls.Add(this.button1Search);
            this.Controls.Add(this.textBox1Add);
            this.Controls.Add(this.button2del);
            this.Controls.Add(this.button1Add);
            this.Controls.Add(this.listView2);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "CategoryPanel";
            this.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.Text = "Категорія";
            this.contextMenuStrip1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListView listView2;
        private System.Windows.Forms.ColumnHeader nameID;
        private System.Windows.Forms.ColumnHeader NameName;
        private System.Windows.Forms.Button button1Add;
        private System.Windows.Forms.Button button2del;
        private System.Windows.Forms.TextBox textBox1Add;
        private System.Windows.Forms.Button button1Search;
        private System.Windows.Forms.TextBox textBox1Search;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem добавитиToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem видалитиToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem вийтиToolStripMenuItem;
        private System.Windows.Forms.Button button1;
    }
}