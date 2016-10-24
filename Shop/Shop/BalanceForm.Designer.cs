namespace Shop
{
    partial class BalanceForm
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
            this.listView_Balance = new System.Windows.Forms.ListView();
            this.button_add = new System.Windows.Forms.Button();
            this.button_del = new System.Windows.Forms.Button();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.textBox_add = new System.Windows.Forms.TextBox();
            this.textBox_del = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // listView_Balance
            // 
            this.listView_Balance.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3});
            this.listView_Balance.Location = new System.Drawing.Point(12, 12);
            this.listView_Balance.Name = "listView_Balance";
            this.listView_Balance.Size = new System.Drawing.Size(374, 176);
            this.listView_Balance.TabIndex = 0;
            this.listView_Balance.UseCompatibleStateImageBehavior = false;
            this.listView_Balance.View = System.Windows.Forms.View.Details;
            // 
            // button_add
            // 
            this.button_add.Location = new System.Drawing.Point(405, 38);
            this.button_add.Name = "button_add";
            this.button_add.Size = new System.Drawing.Size(94, 45);
            this.button_add.TabIndex = 1;
            this.button_add.Text = "Додати";
            this.button_add.UseVisualStyleBackColor = true;
            this.button_add.Click += new System.EventHandler(this.button_add_Click);
            // 
            // button_del
            // 
            this.button_del.Location = new System.Drawing.Point(405, 144);
            this.button_del.Name = "button_del";
            this.button_del.Size = new System.Drawing.Size(94, 44);
            this.button_del.TabIndex = 2;
            this.button_del.Text = "Зняти";
            this.button_del.UseVisualStyleBackColor = true;
            this.button_del.Click += new System.EventHandler(this.button_del_Click);
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "id";
            this.columnHeader1.Width = 25;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Name";
            this.columnHeader2.Width = 176;
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "Balance";
            this.columnHeader3.Width = 162;
            // 
            // textBox_add
            // 
            this.textBox_add.Location = new System.Drawing.Point(405, 12);
            this.textBox_add.Name = "textBox_add";
            this.textBox_add.Size = new System.Drawing.Size(94, 20);
            this.textBox_add.TabIndex = 3;
            // 
            // textBox_del
            // 
            this.textBox_del.Location = new System.Drawing.Point(405, 118);
            this.textBox_del.Name = "textBox_del";
            this.textBox_del.Size = new System.Drawing.Size(94, 20);
            this.textBox_del.TabIndex = 4;
            // 
            // BalanceForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(511, 200);
            this.Controls.Add(this.textBox_del);
            this.Controls.Add(this.textBox_add);
            this.Controls.Add(this.button_del);
            this.Controls.Add(this.button_add);
            this.Controls.Add(this.listView_Balance);
            this.Name = "BalanceForm";
            this.Text = "BalanceForm";
            this.Load += new System.EventHandler(this.BalanceForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListView listView_Balance;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.Button button_add;
        private System.Windows.Forms.Button button_del;
        private System.Windows.Forms.TextBox textBox_add;
        private System.Windows.Forms.TextBox textBox_del;
    }
}