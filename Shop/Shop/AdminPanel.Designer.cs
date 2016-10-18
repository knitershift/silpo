namespace Shop
{
    partial class AdminPanel
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.менюToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.логінToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.поставкиToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.товариToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.виробникиToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.категоріїToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.знижкиToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.користувачіToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.звітиToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.балансToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.вихідToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.інфоToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.label_name = new System.Windows.Forms.Label();
            this.but_Exit = new System.Windows.Forms.Button();
            this.label_who = new System.Windows.Forms.Label();
            this.label_data = new System.Windows.Forms.Label();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.but_supply = new System.Windows.Forms.Button();
            this.but_product = new System.Windows.Forms.Button();
            this.but_producer = new System.Windows.Forms.Button();
            this.but_category = new System.Windows.Forms.Button();
            this.but_discount = new System.Windows.Forms.Button();
            this.but_user = new System.Windows.Forms.Button();
            this.but_report = new System.Windows.Forms.Button();
            this.but_balance = new System.Windows.Forms.Button();
            this.but_storage = new System.Windows.Forms.Button();
            this.menuStrip1.SuspendLayout();
            this.flowLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.menuStrip1.GripStyle = System.Windows.Forms.ToolStripGripStyle.Visible;
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.менюToolStripMenuItem,
            this.інфоToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 395);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(689, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // менюToolStripMenuItem
            // 
            this.менюToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.логінToolStripMenuItem,
            this.toolStripSeparator1,
            this.поставкиToolStripMenuItem,
            this.товариToolStripMenuItem,
            this.виробникиToolStripMenuItem,
            this.категоріїToolStripMenuItem,
            this.знижкиToolStripMenuItem,
            this.користувачіToolStripMenuItem,
            this.звітиToolStripMenuItem,
            this.балансToolStripMenuItem,
            this.toolStripSeparator2,
            this.вихідToolStripMenuItem});
            this.менюToolStripMenuItem.Name = "менюToolStripMenuItem";
            this.менюToolStripMenuItem.Size = new System.Drawing.Size(53, 20);
            this.менюToolStripMenuItem.Text = "Меню";
            // 
            // логінToolStripMenuItem
            // 
            this.логінToolStripMenuItem.Name = "логінToolStripMenuItem";
            this.логінToolStripMenuItem.Size = new System.Drawing.Size(141, 22);
            this.логінToolStripMenuItem.Text = "Логін";
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(138, 6);
            // 
            // поставкиToolStripMenuItem
            // 
            this.поставкиToolStripMenuItem.Name = "поставкиToolStripMenuItem";
            this.поставкиToolStripMenuItem.Size = new System.Drawing.Size(141, 22);
            this.поставкиToolStripMenuItem.Text = "Поставки";
            this.поставкиToolStripMenuItem.Click += new System.EventHandler(this.but_supply_Click);
            // 
            // товариToolStripMenuItem
            // 
            this.товариToolStripMenuItem.Name = "товариToolStripMenuItem";
            this.товариToolStripMenuItem.Size = new System.Drawing.Size(141, 22);
            this.товариToolStripMenuItem.Text = "Товари";
            this.товариToolStripMenuItem.Click += new System.EventHandler(this.but_product_Click);
            // 
            // виробникиToolStripMenuItem
            // 
            this.виробникиToolStripMenuItem.Name = "виробникиToolStripMenuItem";
            this.виробникиToolStripMenuItem.Size = new System.Drawing.Size(141, 22);
            this.виробникиToolStripMenuItem.Text = "Виробники";
            // 
            // категоріїToolStripMenuItem
            // 
            this.категоріїToolStripMenuItem.Name = "категоріїToolStripMenuItem";
            this.категоріїToolStripMenuItem.Size = new System.Drawing.Size(141, 22);
            this.категоріїToolStripMenuItem.Text = "Категорії";
            // 
            // знижкиToolStripMenuItem
            // 
            this.знижкиToolStripMenuItem.Name = "знижкиToolStripMenuItem";
            this.знижкиToolStripMenuItem.Size = new System.Drawing.Size(141, 22);
            this.знижкиToolStripMenuItem.Text = "Знижки";
            // 
            // користувачіToolStripMenuItem
            // 
            this.користувачіToolStripMenuItem.Name = "користувачіToolStripMenuItem";
            this.користувачіToolStripMenuItem.Size = new System.Drawing.Size(141, 22);
            this.користувачіToolStripMenuItem.Text = "Користувачі";
            // 
            // звітиToolStripMenuItem
            // 
            this.звітиToolStripMenuItem.Name = "звітиToolStripMenuItem";
            this.звітиToolStripMenuItem.Size = new System.Drawing.Size(141, 22);
            this.звітиToolStripMenuItem.Text = "Звіти";
            // 
            // балансToolStripMenuItem
            // 
            this.балансToolStripMenuItem.Name = "балансToolStripMenuItem";
            this.балансToolStripMenuItem.Size = new System.Drawing.Size(141, 22);
            this.балансToolStripMenuItem.Text = "Баланс";
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(138, 6);
            // 
            // вихідToolStripMenuItem
            // 
            this.вихідToolStripMenuItem.Name = "вихідToolStripMenuItem";
            this.вихідToolStripMenuItem.Size = new System.Drawing.Size(141, 22);
            this.вихідToolStripMenuItem.Text = "Вихід";
            // 
            // інфоToolStripMenuItem
            // 
            this.інфоToolStripMenuItem.Name = "інфоToolStripMenuItem";
            this.інфоToolStripMenuItem.Size = new System.Drawing.Size(45, 20);
            this.інфоToolStripMenuItem.Text = "Інфо";
            // 
            // label_name
            // 
            this.label_name.AutoSize = true;
            this.label_name.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_name.ForeColor = System.Drawing.SystemColors.Control;
            this.label_name.Location = new System.Drawing.Point(43, 74);
            this.label_name.Name = "label_name";
            this.label_name.Size = new System.Drawing.Size(47, 25);
            this.label_name.TabIndex = 1;
            this.label_name.Text = "Ім\'я";
            // 
            // but_Exit
            // 
            this.but_Exit.BackColor = System.Drawing.Color.WhiteSmoke;
            this.but_Exit.Font = new System.Drawing.Font("Microsoft YaHei UI", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.but_Exit.Location = new System.Drawing.Point(591, 74);
            this.but_Exit.Name = "but_Exit";
            this.but_Exit.Size = new System.Drawing.Size(86, 51);
            this.but_Exit.TabIndex = 2;
            this.but_Exit.Text = "Вихід";
            this.but_Exit.UseVisualStyleBackColor = false;
            this.but_Exit.Click += new System.EventHandler(this.but_Exit_Click);
            this.but_Exit.MouseLeave += new System.EventHandler(this.but_Exit_MouseLeave);
            this.but_Exit.MouseHover += new System.EventHandler(this.but_Exit_MouseHover);
            // 
            // label_who
            // 
            this.label_who.AutoSize = true;
            this.label_who.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_who.ForeColor = System.Drawing.SystemColors.Control;
            this.label_who.Location = new System.Drawing.Point(44, 114);
            this.label_who.Name = "label_who";
            this.label_who.Size = new System.Drawing.Size(46, 24);
            this.label_who.TabIndex = 4;
            this.label_who.Text = "Хто";
            // 
            // label_data
            // 
            this.label_data.AutoSize = true;
            this.label_data.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_data.ForeColor = System.Drawing.SystemColors.Control;
            this.label_data.Location = new System.Drawing.Point(41, 360);
            this.label_data.Name = "label_data";
            this.label_data.Size = new System.Drawing.Size(49, 24);
            this.label_data.TabIndex = 14;
            this.label_data.Text = "data";
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.Controls.Add(this.but_supply);
            this.flowLayoutPanel1.Controls.Add(this.but_product);
            this.flowLayoutPanel1.Controls.Add(this.but_producer);
            this.flowLayoutPanel1.Controls.Add(this.but_category);
            this.flowLayoutPanel1.Controls.Add(this.but_discount);
            this.flowLayoutPanel1.Controls.Add(this.but_user);
            this.flowLayoutPanel1.Controls.Add(this.but_report);
            this.flowLayoutPanel1.Controls.Add(this.but_balance);
            this.flowLayoutPanel1.Location = new System.Drawing.Point(42, 157);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(604, 186);
            this.flowLayoutPanel1.TabIndex = 15;
            // 
            // but_supply
            // 
            this.but_supply.BackColor = System.Drawing.SystemColors.Control;
            this.but_supply.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.but_supply.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Bold);
            this.but_supply.ForeColor = System.Drawing.SystemColors.MenuText;
            this.but_supply.Location = new System.Drawing.Point(3, 3);
            this.but_supply.Name = "but_supply";
            this.but_supply.Size = new System.Drawing.Size(145, 87);
            this.but_supply.TabIndex = 0;
            this.but_supply.Text = "Поставка";
            this.but_supply.UseVisualStyleBackColor = false;
            this.but_supply.Click += new System.EventHandler(this.but_supply_Click);
            // 
            // but_product
            // 
            this.but_product.BackColor = System.Drawing.SystemColors.Control;
            this.but_product.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Bold);
            this.but_product.ForeColor = System.Drawing.SystemColors.ControlText;
            this.but_product.Location = new System.Drawing.Point(154, 3);
            this.but_product.Name = "but_product";
            this.but_product.Size = new System.Drawing.Size(145, 87);
            this.but_product.TabIndex = 1;
            this.but_product.Text = "Товари";
            this.but_product.UseVisualStyleBackColor = false;
            this.but_product.Click += new System.EventHandler(this.but_product_Click);
            // 
            // but_producer
            // 
            this.but_producer.BackColor = System.Drawing.SystemColors.Control;
            this.but_producer.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Bold);
            this.but_producer.ForeColor = System.Drawing.SystemColors.MenuText;
            this.but_producer.Location = new System.Drawing.Point(305, 3);
            this.but_producer.Name = "but_producer";
            this.but_producer.Size = new System.Drawing.Size(145, 87);
            this.but_producer.TabIndex = 2;
            this.but_producer.Text = "Виробники";
            this.but_producer.UseVisualStyleBackColor = false;
            // 
            // but_category
            // 
            this.but_category.BackColor = System.Drawing.SystemColors.Control;
            this.but_category.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Bold);
            this.but_category.ForeColor = System.Drawing.SystemColors.MenuText;
            this.but_category.Location = new System.Drawing.Point(456, 3);
            this.but_category.Name = "but_category";
            this.but_category.Size = new System.Drawing.Size(145, 87);
            this.but_category.TabIndex = 3;
            this.but_category.Text = "Категорії";
            this.but_category.UseVisualStyleBackColor = false;
            // 
            // but_discount
            // 
            this.but_discount.BackColor = System.Drawing.SystemColors.Control;
            this.but_discount.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Bold);
            this.but_discount.ForeColor = System.Drawing.SystemColors.MenuText;
            this.but_discount.Location = new System.Drawing.Point(3, 96);
            this.but_discount.Name = "but_discount";
            this.but_discount.Size = new System.Drawing.Size(145, 87);
            this.but_discount.TabIndex = 4;
            this.but_discount.Text = "Знижки";
            this.but_discount.UseVisualStyleBackColor = false;
            // 
            // but_user
            // 
            this.but_user.BackColor = System.Drawing.SystemColors.Control;
            this.but_user.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.but_user.ForeColor = System.Drawing.SystemColors.MenuText;
            this.but_user.Location = new System.Drawing.Point(154, 96);
            this.but_user.Name = "but_user";
            this.but_user.Size = new System.Drawing.Size(145, 87);
            this.but_user.TabIndex = 5;
            this.but_user.Text = "Користувачі";
            this.but_user.UseVisualStyleBackColor = false;
            // 
            // but_report
            // 
            this.but_report.BackColor = System.Drawing.SystemColors.Control;
            this.but_report.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Bold);
            this.but_report.ForeColor = System.Drawing.SystemColors.MenuText;
            this.but_report.Location = new System.Drawing.Point(305, 96);
            this.but_report.Name = "but_report";
            this.but_report.Size = new System.Drawing.Size(145, 87);
            this.but_report.TabIndex = 6;
            this.but_report.Text = "Звіти";
            this.but_report.UseVisualStyleBackColor = false;
            // 
            // but_balance
            // 
            this.but_balance.BackColor = System.Drawing.SystemColors.Control;
            this.but_balance.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Bold);
            this.but_balance.ForeColor = System.Drawing.SystemColors.MenuText;
            this.but_balance.Location = new System.Drawing.Point(456, 96);
            this.but_balance.Name = "but_balance";
            this.but_balance.Size = new System.Drawing.Size(145, 87);
            this.but_balance.TabIndex = 7;
            this.but_balance.Text = "Баланс";
            this.but_balance.UseVisualStyleBackColor = false;
            this.but_balance.Click += new System.EventHandler(this.but_balance_Click);
            // 
            // but_storage
            // 
            this.but_storage.BackColor = System.Drawing.Color.DarkGray;
            this.but_storage.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.but_storage.Location = new System.Drawing.Point(498, 74);
            this.but_storage.Name = "but_storage";
            this.but_storage.Size = new System.Drawing.Size(87, 51);
            this.but_storage.TabIndex = 16;
            this.but_storage.Text = "Склад";
            this.but_storage.UseVisualStyleBackColor = false;
            this.but_storage.Click += new System.EventHandler(this.but_storage_Click);
            // 
            // AdminPanel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkSlateGray;
            this.ClientSize = new System.Drawing.Size(689, 419);
            this.Controls.Add(this.but_storage);
            this.Controls.Add(this.flowLayoutPanel1);
            this.Controls.Add(this.label_data);
            this.Controls.Add(this.label_who);
            this.Controls.Add(this.but_Exit);
            this.Controls.Add(this.label_name);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "AdminPanel";
            this.Text = "AdminPanel";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.flowLayoutPanel1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem менюToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem логінToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripMenuItem поставкиToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem товариToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem виробникиToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem категоріїToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem знижкиToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem користувачіToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem звітиToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem балансToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripMenuItem вихідToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem інфоToolStripMenuItem;
        private System.Windows.Forms.Label label_name;
        private System.Windows.Forms.Button but_Exit;
        private System.Windows.Forms.Label label_who;
        private System.Windows.Forms.Label label_data;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.Button but_supply;
        private System.Windows.Forms.Button but_product;
        private System.Windows.Forms.Button but_producer;
        private System.Windows.Forms.Button but_category;
        private System.Windows.Forms.Button but_discount;
        private System.Windows.Forms.Button but_user;
        private System.Windows.Forms.Button but_report;
        private System.Windows.Forms.Button but_balance;
        private System.Windows.Forms.Button but_storage;
    }
}