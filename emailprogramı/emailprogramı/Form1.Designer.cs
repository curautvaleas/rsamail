namespace emailprogrami
{
    partial class Form1
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtkimden = new System.Windows.Forms.TextBox();
            this.txtkime = new System.Windows.Forms.TextBox();
            this.txtkonu = new System.Windows.Forms.TextBox();
            this.txtmsg = new System.Windows.Forms.TextBox();
            this.btngönder = new System.Windows.Forms.Button();
            this.btndec = new System.Windows.Forms.Button();
            this.txtDec = new System.Windows.Forms.TextBox();
            this.txtKey = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 29);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(48, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Kimden :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 107);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(82, 13);
            this.label2.TabIndex = 0;
            this.label2.Text = "Mesajın Konusu";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 68);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(39, 13);
            this.label3.TabIndex = 0;
            this.label3.Text = "Kime : ";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 159);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(44, 13);
            this.label4.TabIndex = 0;
            this.label4.Text = "Mesaj : ";
            // 
            // txtkimden
            // 
            this.txtkimden.Location = new System.Drawing.Point(105, 26);
            this.txtkimden.Name = "txtkimden";
            this.txtkimden.Size = new System.Drawing.Size(140, 20);
            this.txtkimden.TabIndex = 1;
            // 
            // txtkime
            // 
            this.txtkime.Location = new System.Drawing.Point(105, 65);
            this.txtkime.Name = "txtkime";
            this.txtkime.Size = new System.Drawing.Size(140, 20);
            this.txtkime.TabIndex = 1;
            // 
            // txtkonu
            // 
            this.txtkonu.Location = new System.Drawing.Point(105, 100);
            this.txtkonu.Name = "txtkonu";
            this.txtkonu.Size = new System.Drawing.Size(140, 20);
            this.txtkonu.TabIndex = 1;
            // 
            // txtmsg
            // 
            this.txtmsg.Location = new System.Drawing.Point(12, 175);
            this.txtmsg.Multiline = true;
            this.txtmsg.Name = "txtmsg";
            this.txtmsg.Size = new System.Drawing.Size(233, 102);
            this.txtmsg.TabIndex = 1;
            // 
            // btngönder
            // 
            this.btngönder.Location = new System.Drawing.Point(161, 283);
            this.btngönder.Name = "btngönder";
            this.btngönder.Size = new System.Drawing.Size(75, 23);
            this.btngönder.TabIndex = 2;
            this.btngönder.Text = "Gönder";
            this.btngönder.UseVisualStyleBackColor = true;
            this.btngönder.Click += new System.EventHandler(this.button1_Click);
            // 
            // btndec
            // 
            this.btndec.Location = new System.Drawing.Point(161, 581);
            this.btndec.Name = "btndec";
            this.btndec.Size = new System.Drawing.Size(75, 23);
            this.btndec.TabIndex = 3;
            this.btndec.Text = "Şifre Çöz";
            this.btndec.UseVisualStyleBackColor = true;
            this.btndec.Click += new System.EventHandler(this.btndec_Click);
            // 
            // txtDec
            // 
            this.txtDec.Location = new System.Drawing.Point(12, 479);
            this.txtDec.Multiline = true;
            this.txtDec.Name = "txtDec";
            this.txtDec.Size = new System.Drawing.Size(229, 96);
            this.txtDec.TabIndex = 4;
            this.txtDec.Click += new System.EventHandler(this.txtDec_Click);
            // 
            // txtKey
            // 
            this.txtKey.Location = new System.Drawing.Point(12, 352);
            this.txtKey.Multiline = true;
            this.txtKey.Name = "txtKey";
            this.txtKey.Size = new System.Drawing.Size(229, 96);
            this.txtKey.TabIndex = 5;
            this.txtKey.Click += new System.EventHandler(this.txtKey_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(12, 463);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(41, 13);
            this.label5.TabIndex = 6;
            this.label5.Text = "Mesaj :";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(10, 336);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(50, 13);
            this.label6.TabIndex = 7;
            this.label6.Text = "Anahtar :";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(268, 616);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txtKey);
            this.Controls.Add(this.txtDec);
            this.Controls.Add(this.btndec);
            this.Controls.Add(this.btngönder);
            this.Controls.Add(this.txtmsg);
            this.Controls.Add(this.txtkonu);
            this.Controls.Add(this.txtkime);
            this.Controls.Add(this.txtkimden);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtkimden;
        private System.Windows.Forms.TextBox txtkime;
        private System.Windows.Forms.TextBox txtkonu;
        private System.Windows.Forms.TextBox txtmsg;
        private System.Windows.Forms.Button btngönder;
        private System.Windows.Forms.Button btndec;
        private System.Windows.Forms.TextBox txtDec;
        private System.Windows.Forms.TextBox txtKey;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
    }
}

