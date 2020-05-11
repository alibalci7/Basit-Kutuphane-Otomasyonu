namespace KütüphaneOtomasyonu.WinFormUI
{
    partial class PersonellerEkleGuncelleForm
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
            this.btn_Guncelle = new System.Windows.Forms.Button();
            this.btn_Ekle = new System.Windows.Forms.Button();
            this.mskt_TelNo = new System.Windows.Forms.MaskedTextBox();
            this.rdb_Kadin = new System.Windows.Forms.RadioButton();
            this.rdb_Erkek = new System.Windows.Forms.RadioButton();
            this.txt_MailAdresi = new System.Windows.Forms.TextBox();
            this.mskt_TC = new System.Windows.Forms.MaskedTextBox();
            this.txt_Adres = new System.Windows.Forms.TextBox();
            this.txt_Soyadi = new System.Windows.Forms.TextBox();
            this.txt_Adi = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btn_Guncelle
            // 
            this.btn_Guncelle.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btn_Guncelle.Location = new System.Drawing.Point(293, 467);
            this.btn_Guncelle.Name = "btn_Guncelle";
            this.btn_Guncelle.Size = new System.Drawing.Size(102, 51);
            this.btn_Guncelle.TabIndex = 9;
            this.btn_Guncelle.Text = "Güncelle";
            this.btn_Guncelle.UseVisualStyleBackColor = true;
            this.btn_Guncelle.Click += new System.EventHandler(this.btn_Guncelle_Click);
            // 
            // btn_Ekle
            // 
            this.btn_Ekle.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btn_Ekle.Location = new System.Drawing.Point(191, 467);
            this.btn_Ekle.Name = "btn_Ekle";
            this.btn_Ekle.Size = new System.Drawing.Size(84, 51);
            this.btn_Ekle.TabIndex = 8;
            this.btn_Ekle.Text = "Ekle";
            this.btn_Ekle.UseVisualStyleBackColor = true;
            this.btn_Ekle.Click += new System.EventHandler(this.btn_Ekle_Click);
            // 
            // mskt_TelNo
            // 
            this.mskt_TelNo.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.mskt_TelNo.Location = new System.Drawing.Point(191, 166);
            this.mskt_TelNo.Mask = "0000000000";
            this.mskt_TelNo.Name = "mskt_TelNo";
            this.mskt_TelNo.Size = new System.Drawing.Size(204, 29);
            this.mskt_TelNo.TabIndex = 18;
            this.mskt_TelNo.ValidatingType = typeof(int);
            // 
            // rdb_Kadin
            // 
            this.rdb_Kadin.AutoSize = true;
            this.rdb_Kadin.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.rdb_Kadin.Location = new System.Drawing.Point(293, 277);
            this.rdb_Kadin.Name = "rdb_Kadin";
            this.rdb_Kadin.Size = new System.Drawing.Size(67, 24);
            this.rdb_Kadin.TabIndex = 6;
            this.rdb_Kadin.TabStop = true;
            this.rdb_Kadin.Text = "Kadın";
            this.rdb_Kadin.UseVisualStyleBackColor = true;
            // 
            // rdb_Erkek
            // 
            this.rdb_Erkek.AutoSize = true;
            this.rdb_Erkek.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.rdb_Erkek.Location = new System.Drawing.Point(191, 277);
            this.rdb_Erkek.Name = "rdb_Erkek";
            this.rdb_Erkek.Size = new System.Drawing.Size(68, 24);
            this.rdb_Erkek.TabIndex = 5;
            this.rdb_Erkek.TabStop = true;
            this.rdb_Erkek.Text = "Erkek";
            this.rdb_Erkek.UseVisualStyleBackColor = true;
            // 
            // txt_MailAdresi
            // 
            this.txt_MailAdresi.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txt_MailAdresi.Location = new System.Drawing.Point(191, 212);
            this.txt_MailAdresi.Name = "txt_MailAdresi";
            this.txt_MailAdresi.Size = new System.Drawing.Size(204, 29);
            this.txt_MailAdresi.TabIndex = 4;
            // 
            // mskt_TC
            // 
            this.mskt_TC.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.mskt_TC.Location = new System.Drawing.Point(191, 125);
            this.mskt_TC.Mask = "00000000000";
            this.mskt_TC.Name = "mskt_TC";
            this.mskt_TC.Size = new System.Drawing.Size(204, 29);
            this.mskt_TC.TabIndex = 3;
            this.mskt_TC.ValidatingType = typeof(int);
            // 
            // txt_Adres
            // 
            this.txt_Adres.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txt_Adres.Location = new System.Drawing.Point(191, 334);
            this.txt_Adres.Multiline = true;
            this.txt_Adres.Name = "txt_Adres";
            this.txt_Adres.Size = new System.Drawing.Size(204, 93);
            this.txt_Adres.TabIndex = 7;
            // 
            // txt_Soyadi
            // 
            this.txt_Soyadi.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txt_Soyadi.Location = new System.Drawing.Point(191, 76);
            this.txt_Soyadi.Name = "txt_Soyadi";
            this.txt_Soyadi.Size = new System.Drawing.Size(204, 29);
            this.txt_Soyadi.TabIndex = 2;
            // 
            // txt_Adi
            // 
            this.txt_Adi.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txt_Adi.Location = new System.Drawing.Point(191, 28);
            this.txt_Adi.Name = "txt_Adi";
            this.txt_Adi.Size = new System.Drawing.Size(204, 29);
            this.txt_Adi.TabIndex = 1;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label7.Location = new System.Drawing.Point(51, 271);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(80, 24);
            this.label7.TabIndex = 22;
            this.label7.Text = "Cinsiyet:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label6.Location = new System.Drawing.Point(51, 212);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(108, 24);
            this.label6.TabIndex = 21;
            this.label6.Text = "Mail Adresi:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label5.Location = new System.Drawing.Point(51, 166);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(77, 24);
            this.label5.TabIndex = 19;
            this.label5.Text = "Tel. No:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label4.Location = new System.Drawing.Point(51, 122);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(75, 24);
            this.label4.TabIndex = 17;
            this.label4.Text = "TC. No:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.Location = new System.Drawing.Point(51, 334);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(65, 24);
            this.label3.TabIndex = 14;
            this.label3.Text = "Adres:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.Location = new System.Drawing.Point(51, 76);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(72, 24);
            this.label2.TabIndex = 13;
            this.label2.Text = "Soyadı:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(51, 28);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(43, 24);
            this.label1.TabIndex = 11;
            this.label1.Text = "Adı:";
            // 
            // PersonellerEkleGuncelleForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(907, 557);
            this.Controls.Add(this.btn_Guncelle);
            this.Controls.Add(this.btn_Ekle);
            this.Controls.Add(this.mskt_TelNo);
            this.Controls.Add(this.rdb_Kadin);
            this.Controls.Add(this.rdb_Erkek);
            this.Controls.Add(this.txt_MailAdresi);
            this.Controls.Add(this.mskt_TC);
            this.Controls.Add(this.txt_Adres);
            this.Controls.Add(this.txt_Soyadi);
            this.Controls.Add(this.txt_Adi);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "PersonellerEkleGuncelleForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "PersonellerEkleGuncelleForm";
            this.Load += new System.EventHandler(this.PersonellerEkleGuncelleForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_Guncelle;
        private System.Windows.Forms.Button btn_Ekle;
        private System.Windows.Forms.MaskedTextBox mskt_TelNo;
        private System.Windows.Forms.RadioButton rdb_Kadin;
        private System.Windows.Forms.RadioButton rdb_Erkek;
        private System.Windows.Forms.TextBox txt_MailAdresi;
        private System.Windows.Forms.MaskedTextBox mskt_TC;
        private System.Windows.Forms.TextBox txt_Adres;
        private System.Windows.Forms.TextBox txt_Soyadi;
        private System.Windows.Forms.TextBox txt_Adi;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
    }
}