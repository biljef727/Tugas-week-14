namespace WindowsFormsApp2
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
            this.textmasuk = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.textasal = new System.Windows.Forms.TextBox();
            this.textakhir = new System.Windows.Forms.TextBox();
            this.btnubah = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.lblHasil = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(122, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Masukkan Kalimat";
            // 
            // textmasuk
            // 
            this.textmasuk.Location = new System.Drawing.Point(141, 13);
            this.textmasuk.Name = "textmasuk";
            this.textmasuk.Size = new System.Drawing.Size(339, 22);
            this.textmasuk.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(13, 51);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(111, 17);
            this.label2.TabIndex = 2;
            this.label2.Text = "Masukkan Huruf";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(277, 56);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(57, 17);
            this.label3.TabIndex = 3;
            this.label3.Text = "Menjadi";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // textasal
            // 
            this.textasal.Location = new System.Drawing.Point(141, 51);
            this.textasal.Name = "textasal";
            this.textasal.Size = new System.Drawing.Size(122, 22);
            this.textasal.TabIndex = 4;
            // 
            // textakhir
            // 
            this.textakhir.Location = new System.Drawing.Point(347, 51);
            this.textakhir.Name = "textakhir";
            this.textakhir.Size = new System.Drawing.Size(133, 22);
            this.textakhir.TabIndex = 5;
            // 
            // btnubah
            // 
            this.btnubah.Location = new System.Drawing.Point(141, 93);
            this.btnubah.Name = "btnubah";
            this.btnubah.Size = new System.Drawing.Size(339, 37);
            this.btnubah.TabIndex = 6;
            this.btnubah.Text = "Konversi!";
            this.btnubah.UseVisualStyleBackColor = true;
            this.btnubah.Click += new System.EventHandler(this.button1_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(16, 158);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(47, 17);
            this.label4.TabIndex = 7;
            this.label4.Text = "Hasil :";
            // 
            // lblHasil
            // 
            this.lblHasil.AutoSize = true;
            this.lblHasil.Location = new System.Drawing.Point(138, 158);
            this.lblHasil.Name = "lblHasil";
            this.lblHasil.Size = new System.Drawing.Size(12, 17);
            this.lblHasil.TabIndex = 8;
            this.lblHasil.Text = ".";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lblHasil);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.btnubah);
            this.Controls.Add(this.textakhir);
            this.Controls.Add(this.textasal);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.textmasuk);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textmasuk;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textasal;
        private System.Windows.Forms.TextBox textakhir;
        private System.Windows.Forms.Button btnubah;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label lblHasil;
    }
}

