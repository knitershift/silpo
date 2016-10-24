namespace Shop
{
    partial class Cashbox
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
            this.listBox_queue = new System.Windows.Forms.ListBox();
            this.listView_queue = new System.Windows.Forms.ListView();
            this.columnHeader4 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader5 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader6 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader7 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.materialLabel_queue = new MaterialSkin.Controls.MaterialLabel();
            this.materialLabel_list = new MaterialSkin.Controls.MaterialLabel();
            this.materialLabel_pay = new MaterialSkin.Controls.MaterialLabel();
            this.materialSingleLineTextField_sum = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.materialFlatButton_ok = new MaterialSkin.Controls.MaterialFlatButton();
            this.materialFlatButton_away = new MaterialSkin.Controls.MaterialFlatButton();
            this.label_hello = new System.Windows.Forms.Label();
            this.label_name = new System.Windows.Forms.Label();
            this.label_userid = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // listBox_queue
            // 
            this.listBox_queue.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.listBox_queue.FormattingEnabled = true;
            this.listBox_queue.Location = new System.Drawing.Point(20, 189);
            this.listBox_queue.Name = "listBox_queue";
            this.listBox_queue.Size = new System.Drawing.Size(120, 225);
            this.listBox_queue.TabIndex = 0;
            this.listBox_queue.SelectedIndexChanged += new System.EventHandler(this.Select);
            // 
            // listView_queue
            // 
            this.listView_queue.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.listView_queue.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader4,
            this.columnHeader5,
            this.columnHeader6,
            this.columnHeader7});
            this.listView_queue.Location = new System.Drawing.Point(200, 189);
            this.listView_queue.Name = "listView_queue";
            this.listView_queue.Size = new System.Drawing.Size(391, 225);
            this.listView_queue.TabIndex = 1;
            this.listView_queue.UseCompatibleStateImageBehavior = false;
            this.listView_queue.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader4
            // 
            this.columnHeader4.Text = "Id_order";
            // 
            // columnHeader5
            // 
            this.columnHeader5.Text = "Продукт";
            this.columnHeader5.Width = 198;
            // 
            // columnHeader6
            // 
            this.columnHeader6.Text = "Кількість";
            // 
            // columnHeader7
            // 
            this.columnHeader7.Text = "Вартість";
            // 
            // materialLabel_queue
            // 
            this.materialLabel_queue.AutoSize = true;
            this.materialLabel_queue.BackColor = System.Drawing.Color.White;
            this.materialLabel_queue.Depth = 0;
            this.materialLabel_queue.Font = new System.Drawing.Font("Roboto", 11F);
            this.materialLabel_queue.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel_queue.Location = new System.Drawing.Point(19, 157);
            this.materialLabel_queue.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel_queue.Name = "materialLabel_queue";
            this.materialLabel_queue.Size = new System.Drawing.Size(49, 19);
            this.materialLabel_queue.TabIndex = 2;
            this.materialLabel_queue.Text = "Черга";
            // 
            // materialLabel_list
            // 
            this.materialLabel_list.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.materialLabel_list.BackColor = System.Drawing.Color.White;
            this.materialLabel_list.Depth = 0;
            this.materialLabel_list.Font = new System.Drawing.Font("Roboto", 11F);
            this.materialLabel_list.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel_list.Location = new System.Drawing.Point(204, 157);
            this.materialLabel_list.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel_list.Name = "materialLabel_list";
            this.materialLabel_list.Size = new System.Drawing.Size(68, 23);
            this.materialLabel_list.TabIndex = 3;
            this.materialLabel_list.Text = "Список товарів";
            // 
            // materialLabel_pay
            // 
            this.materialLabel_pay.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.materialLabel_pay.BackColor = System.Drawing.Color.White;
            this.materialLabel_pay.Depth = 0;
            this.materialLabel_pay.Font = new System.Drawing.Font("Roboto", 11F);
            this.materialLabel_pay.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel_pay.Location = new System.Drawing.Point(209, 482);
            this.materialLabel_pay.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel_pay.Name = "materialLabel_pay";
            this.materialLabel_pay.Size = new System.Drawing.Size(90, 30);
            this.materialLabel_pay.TabIndex = 4;
            this.materialLabel_pay.Text = "до сплати";
            // 
            // materialSingleLineTextField_sum
            // 
            this.materialSingleLineTextField_sum.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.materialSingleLineTextField_sum.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.materialSingleLineTextField_sum.Depth = 0;
            this.materialSingleLineTextField_sum.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.materialSingleLineTextField_sum.Hint = "";
            this.materialSingleLineTextField_sum.Location = new System.Drawing.Point(305, 482);
            this.materialSingleLineTextField_sum.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialSingleLineTextField_sum.Name = "materialSingleLineTextField_sum";
            this.materialSingleLineTextField_sum.PasswordChar = '\0';
            this.materialSingleLineTextField_sum.SelectedText = "";
            this.materialSingleLineTextField_sum.SelectionLength = 0;
            this.materialSingleLineTextField_sum.SelectionStart = 0;
            this.materialSingleLineTextField_sum.Size = new System.Drawing.Size(40, 23);
            this.materialSingleLineTextField_sum.TabIndex = 5;
            this.materialSingleLineTextField_sum.UseSystemPasswordChar = false;
            // 
            // materialFlatButton_ok
            // 
            this.materialFlatButton_ok.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.materialFlatButton_ok.AutoSize = true;
            this.materialFlatButton_ok.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.materialFlatButton_ok.BackColor = System.Drawing.SystemColors.Highlight;
            this.materialFlatButton_ok.Depth = 0;
            this.materialFlatButton_ok.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.materialFlatButton_ok.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.materialFlatButton_ok.Location = new System.Drawing.Point(483, 476);
            this.materialFlatButton_ok.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.materialFlatButton_ok.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialFlatButton_ok.Name = "materialFlatButton_ok";
            this.materialFlatButton_ok.Primary = false;
            this.materialFlatButton_ok.Size = new System.Drawing.Size(108, 36);
            this.materialFlatButton_ok.TabIndex = 6;
            this.materialFlatButton_ok.Text = "Підтвердити";
            this.materialFlatButton_ok.UseVisualStyleBackColor = false;
            this.materialFlatButton_ok.Click += new System.EventHandler(this.materialFlatButton_ok_Click);
            // 
            // materialFlatButton_away
            // 
            this.materialFlatButton_away.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.materialFlatButton_away.AutoSize = true;
            this.materialFlatButton_away.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.materialFlatButton_away.BackColor = System.Drawing.Color.Maroon;
            this.materialFlatButton_away.Depth = 0;
            this.materialFlatButton_away.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.materialFlatButton_away.FlatAppearance.BorderSize = 3;
            this.materialFlatButton_away.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Lime;
            this.materialFlatButton_away.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Green;
            this.materialFlatButton_away.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(209)));
            this.materialFlatButton_away.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.materialFlatButton_away.Location = new System.Drawing.Point(533, 144);
            this.materialFlatButton_away.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.materialFlatButton_away.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialFlatButton_away.Name = "materialFlatButton_away";
            this.materialFlatButton_away.Primary = false;
            this.materialFlatButton_away.Size = new System.Drawing.Size(58, 36);
            this.materialFlatButton_away.TabIndex = 7;
            this.materialFlatButton_away.Text = "Вийти";
            this.materialFlatButton_away.UseVisualStyleBackColor = false;
            this.materialFlatButton_away.Click += new System.EventHandler(this.materialFlatButton_away_Click);
            // 
            // label_hello
            // 
            this.label_hello.AutoSize = true;
            this.label_hello.BackColor = System.Drawing.Color.MintCream;
            this.label_hello.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label_hello.Location = new System.Drawing.Point(20, 78);
            this.label_hello.Name = "label_hello";
            this.label_hello.Size = new System.Drawing.Size(64, 18);
            this.label_hello.TabIndex = 8;
            this.label_hello.Text = "Вітаємо";
            // 
            // label_name
            // 
            this.label_name.AutoSize = true;
            this.label_name.BackColor = System.Drawing.Color.MintCream;
            this.label_name.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label_name.Location = new System.Drawing.Point(105, 78);
            this.label_name.Name = "label_name";
            this.label_name.Size = new System.Drawing.Size(32, 18);
            this.label_name.TabIndex = 9;
            this.label_name.Text = "test";
            // 
            // label_userid
            // 
            this.label_userid.AutoSize = true;
            this.label_userid.BackColor = System.Drawing.Color.MintCream;
            this.label_userid.Location = new System.Drawing.Point(20, 119);
            this.label_userid.Name = "label_userid";
            this.label_userid.Size = new System.Drawing.Size(27, 13);
            this.label_userid.TabIndex = 10;
            this.label_userid.Text = "user";
            this.label_userid.Visible = false;
            // 
            // Cashbox
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.BackColor = System.Drawing.Color.Teal;
            this.ClientSize = new System.Drawing.Size(635, 530);
            this.Controls.Add(this.label_userid);
            this.Controls.Add(this.label_name);
            this.Controls.Add(this.label_hello);
            this.Controls.Add(this.materialFlatButton_away);
            this.Controls.Add(this.materialFlatButton_ok);
            this.Controls.Add(this.materialSingleLineTextField_sum);
            this.Controls.Add(this.materialLabel_pay);
            this.Controls.Add(this.materialLabel_list);
            this.Controls.Add(this.materialLabel_queue);
            this.Controls.Add(this.listView_queue);
            this.Controls.Add(this.listBox_queue);
            this.Name = "Cashbox";
            this.Text = "Каса";
            this.Load += new System.EventHandler(this.Cashbox_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox listBox_queue;
        private System.Windows.Forms.ListView listView_queue;
        private MaterialSkin.Controls.MaterialLabel materialLabel_queue;
        private MaterialSkin.Controls.MaterialLabel materialLabel_list;
        private MaterialSkin.Controls.MaterialLabel materialLabel_pay;
        private MaterialSkin.Controls.MaterialSingleLineTextField materialSingleLineTextField_sum;
        private MaterialSkin.Controls.MaterialFlatButton materialFlatButton_ok;
        private MaterialSkin.Controls.MaterialFlatButton materialFlatButton_away;
        private System.Windows.Forms.ColumnHeader columnHeader4;
        private System.Windows.Forms.ColumnHeader columnHeader5;
        private System.Windows.Forms.ColumnHeader columnHeader6;
        private System.Windows.Forms.ColumnHeader columnHeader7;
        private System.Windows.Forms.Label label_hello;
        private System.Windows.Forms.Label label_name;
        private System.Windows.Forms.Label label_userid;
    }
}