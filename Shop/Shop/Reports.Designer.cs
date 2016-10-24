namespace Shop
{
    partial class Reports
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
            this.button1 = new System.Windows.Forms.Button();
            this.button_zalishok = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(62, 97);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(92, 57);
            this.button1.TabIndex = 0;
            this.button1.Text = "test";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button_zalishok
            // 
            this.button_zalishok.Location = new System.Drawing.Point(196, 96);
            this.button_zalishok.Name = "button_zalishok";
            this.button_zalishok.Size = new System.Drawing.Size(89, 58);
            this.button_zalishok.TabIndex = 1;
            this.button_zalishok.Text = "актуальні залишки";
            this.button_zalishok.UseVisualStyleBackColor = true;
            this.button_zalishok.Click += new System.EventHandler(this.button_zalishok_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(62, 182);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(92, 67);
            this.button3.TabIndex = 2;
            this.button3.Text = "test2";
            this.button3.UseVisualStyleBackColor = true;
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(196, 183);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(89, 66);
            this.button4.TabIndex = 3;
            this.button4.Text = "test3";
            this.button4.UseVisualStyleBackColor = true;
            // 
            // Reports
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(361, 315);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button_zalishok);
            this.Controls.Add(this.button1);
            this.Name = "Reports";
            this.Text = "Reports";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button_zalishok;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
    }
}