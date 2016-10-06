namespace Shop
{
    partial class NewProduct
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
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.text_name = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.combo_category = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.but_confirm = new System.Windows.Forms.Button();
            this.text_amount = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.combo_producer = new System.Windows.Forms.ComboBox();
            this.label9 = new System.Windows.Forms.Label();
            this.numeric_datedie = new System.Windows.Forms.NumericUpDown();
            ((System.ComponentModel.ISupportInitialize)(this.numeric_datedie)).BeginInit();
            this.SuspendLayout();
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Comic Sans MS", 11.25F, System.Drawing.FontStyle.Bold);
            this.label3.ForeColor = System.Drawing.Color.Azure;
            this.label3.Location = new System.Drawing.Point(76, 213);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(83, 21);
            this.label3.TabIndex = 12;
            this.label3.Text = "Термін дії";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Comic Sans MS", 11.25F, System.Drawing.FontStyle.Bold);
            this.label2.ForeColor = System.Drawing.Color.Azure;
            this.label2.Location = new System.Drawing.Point(80, 146);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(53, 21);
            this.label2.TabIndex = 11;
            this.label2.Text = "Назва";
            // 
            // text_name
            // 
            this.text_name.Location = new System.Drawing.Point(182, 143);
            this.text_name.Name = "text_name";
            this.text_name.Size = new System.Drawing.Size(189, 20);
            this.text_name.TabIndex = 9;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Comic Sans MS", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.ForeColor = System.Drawing.Color.Azure;
            this.label1.Location = new System.Drawing.Point(80, 88);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(79, 21);
            this.label1.TabIndex = 9;
            this.label1.Text = "Категорія";
            // 
            // combo_category
            // 
            this.combo_category.FormattingEnabled = true;
            this.combo_category.Location = new System.Drawing.Point(182, 85);
            this.combo_category.Name = "combo_category";
            this.combo_category.Size = new System.Drawing.Size(189, 21);
            this.combo_category.TabIndex = 8;
            this.combo_category.SelectedIndexChanged += new System.EventHandler(this.combo_category_SelectedIndexChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Comic Sans MS", 11.25F, System.Drawing.FontStyle.Bold);
            this.label5.ForeColor = System.Drawing.Color.Azure;
            this.label5.Location = new System.Drawing.Point(80, 279);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(79, 21);
            this.label5.TabIndex = 16;
            this.label5.Text = "Виробник";
            // 
            // but_confirm
            // 
            this.but_confirm.BackColor = System.Drawing.Color.DarkCyan;
            this.but_confirm.Font = new System.Drawing.Font("Microsoft YaHei UI", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.but_confirm.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.but_confirm.Location = new System.Drawing.Point(183, 336);
            this.but_confirm.Name = "but_confirm";
            this.but_confirm.Size = new System.Drawing.Size(189, 51);
            this.but_confirm.TabIndex = 18;
            this.but_confirm.Text = "Підтвердити";
            this.but_confirm.UseVisualStyleBackColor = false;
            this.but_confirm.Click += new System.EventHandler(this.but_confirm_Click);
            // 
            // text_amount
            // 
            this.text_amount.Location = new System.Drawing.Point(182, 175);
            this.text_amount.Name = "text_amount";
            this.text_amount.Size = new System.Drawing.Size(189, 20);
            this.text_amount.TabIndex = 10;
            this.text_amount.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.text_amount_KeyPress);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Comic Sans MS", 11.25F, System.Drawing.FontStyle.Bold);
            this.label6.ForeColor = System.Drawing.Color.Azure;
            this.label6.Location = new System.Drawing.Point(80, 178);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(74, 21);
            this.label6.TabIndex = 20;
            this.label6.Text = "Кількість";
            // 
            // combo_producer
            // 
            this.combo_producer.FormattingEnabled = true;
            this.combo_producer.Location = new System.Drawing.Point(182, 282);
            this.combo_producer.Name = "combo_producer";
            this.combo_producer.Size = new System.Drawing.Size(189, 21);
            this.combo_producer.TabIndex = 14;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Constantia", 21.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.Color.Azure;
            this.label9.Location = new System.Drawing.Point(177, 21);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(194, 36);
            this.label9.TabIndex = 25;
            this.label9.Text = "Новий Товар";
            this.label9.Click += new System.EventHandler(this.label9_Click);
            // 
            // numeric_datedie
            // 
            this.numeric_datedie.Location = new System.Drawing.Point(183, 213);
            this.numeric_datedie.Name = "numeric_datedie";
            this.numeric_datedie.Size = new System.Drawing.Size(188, 20);
            this.numeric_datedie.TabIndex = 27;
            // 
            // NewProduct
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.ClientSize = new System.Drawing.Size(538, 445);
            this.Controls.Add(this.numeric_datedie);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.combo_producer);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.text_amount);
            this.Controls.Add(this.but_confirm);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.text_name);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.combo_category);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "NewProduct";
            this.Text = "Новий Продукт";
            this.Load += new System.EventHandler(this.Admin_Load);
            ((System.ComponentModel.ISupportInitialize)(this.numeric_datedie)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox text_name;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox combo_category;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button but_confirm;
        private System.Windows.Forms.TextBox text_amount;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox combo_producer;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.NumericUpDown numeric_datedie;
    }
}