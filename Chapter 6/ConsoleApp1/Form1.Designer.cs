namespace ConsoleApp1
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
            this.tbAsal = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.tbTujuan = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.tbBerat = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.rbPos = new System.Windows.Forms.RadioButton();
            this.rbJne = new System.Windows.Forms.RadioButton();
            this.rbTiki = new System.Windows.Forms.RadioButton();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(16, 28);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(338, 46);
            this.label1.TabIndex = 0;
            this.label1.Text = "Cek Harga Ongkir";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(20, 96);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(206, 25);
            this.label2.TabIndex = 1;
            this.label2.Text = "Kota / Kabupaten asal";
            // 
            // tbAsal
            // 
            this.tbAsal.Location = new System.Drawing.Point(25, 124);
            this.tbAsal.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tbAsal.Name = "tbAsal";
            this.tbAsal.Size = new System.Drawing.Size(348, 22);
            this.tbAsal.TabIndex = 2;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(20, 188);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(223, 25);
            this.label3.TabIndex = 3;
            this.label3.Text = "Kota / Kabupaten tujuan";
            // 
            // tbTujuan
            // 
            this.tbTujuan.Location = new System.Drawing.Point(25, 217);
            this.tbTujuan.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tbTujuan.Name = "tbTujuan";
            this.tbTujuan.Size = new System.Drawing.Size(348, 22);
            this.tbTujuan.TabIndex = 4;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(20, 287);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(121, 25);
            this.label4.TabIndex = 5;
            this.label4.Text = "Berat (gram)";
            // 
            // tbBerat
            // 
            this.tbBerat.Location = new System.Drawing.Point(25, 315);
            this.tbBerat.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tbBerat.Name = "tbBerat";
            this.tbBerat.Size = new System.Drawing.Size(348, 22);
            this.tbBerat.TabIndex = 6;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(25, 448);
            this.button1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(349, 28);
            this.button1.TabIndex = 10;
            this.button1.Text = "Cek Harga Layanan";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Location = new System.Drawing.Point(479, 87);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.groupBox1.Size = new System.Drawing.Size(553, 388);
            this.groupBox1.TabIndex = 11;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Detail Layanan";
            // 
            // rbPos
            // 
            this.rbPos.AutoSize = true;
            this.rbPos.Location = new System.Drawing.Point(25, 380);
            this.rbPos.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.rbPos.Name = "rbPos";
            this.rbPos.Size = new System.Drawing.Size(58, 21);
            this.rbPos.TabIndex = 12;
            this.rbPos.TabStop = true;
            this.rbPos.Text = "POS";
            this.rbPos.UseVisualStyleBackColor = true;
            // 
            // rbJne
            // 
            this.rbJne.AutoSize = true;
            this.rbJne.Location = new System.Drawing.Point(147, 380);
            this.rbJne.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.rbJne.Name = "rbJne";
            this.rbJne.Size = new System.Drawing.Size(55, 21);
            this.rbJne.TabIndex = 13;
            this.rbJne.TabStop = true;
            this.rbJne.Text = "JNE";
            this.rbJne.UseVisualStyleBackColor = true;
            // 
            // rbTiki
            // 
            this.rbTiki.AutoSize = true;
            this.rbTiki.Location = new System.Drawing.Point(268, 380);
            this.rbTiki.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.rbTiki.Name = "rbTiki";
            this.rbTiki.Size = new System.Drawing.Size(53, 21);
            this.rbTiki.TabIndex = 14;
            this.rbTiki.TabStop = true;
            this.rbTiki.Text = "TIKI";
            this.rbTiki.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1067, 554);
            this.Controls.Add(this.rbTiki);
            this.Controls.Add(this.rbJne);
            this.Controls.Add(this.rbPos);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.tbBerat);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.tbTujuan);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.tbAsal);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tbAsal;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox tbTujuan;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox tbBerat;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton rbPos;
        private System.Windows.Forms.RadioButton rbJne;
        private System.Windows.Forms.RadioButton rbTiki;
    }
}