namespace KütüphaneOtomasyonu.WinFormUI
{
    partial class UyelerForm
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
            this.cmb_Kategoriler = new System.Windows.Forms.ComboBox();
            this.txt_Aranacakİfade = new System.Windows.Forms.TextBox();
            this.btn_Bul = new System.Windows.Forms.Button();
            this.btn_Listele = new System.Windows.Forms.Button();
            this.btn_Ekle = new System.Windows.Forms.Button();
            this.btn_Sil = new System.Windows.Forms.Button();
            this.btn_Guncelle = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(30, 27);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(122, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Aranacak Kriter:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.Location = new System.Drawing.Point(173, 27);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(122, 20);
            this.label2.TabIndex = 1;
            this.label2.Text = "Aranacak İfade:";
            // 
            // cmb_Kategoriler
            // 
            this.cmb_Kategoriler.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmb_Kategoriler.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.cmb_Kategoriler.FormattingEnabled = true;
            this.cmb_Kategoriler.Location = new System.Drawing.Point(34, 59);
            this.cmb_Kategoriler.Name = "cmb_Kategoriler";
            this.cmb_Kategoriler.Size = new System.Drawing.Size(118, 28);
            this.cmb_Kategoriler.TabIndex = 2;
            // 
            // txt_Aranacakİfade
            // 
            this.txt_Aranacakİfade.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txt_Aranacakİfade.Location = new System.Drawing.Point(177, 59);
            this.txt_Aranacakİfade.Name = "txt_Aranacakİfade";
            this.txt_Aranacakİfade.Size = new System.Drawing.Size(140, 26);
            this.txt_Aranacakİfade.TabIndex = 3;
            // 
            // btn_Bul
            // 
            this.btn_Bul.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btn_Bul.Location = new System.Drawing.Point(345, 23);
            this.btn_Bul.Name = "btn_Bul";
            this.btn_Bul.Size = new System.Drawing.Size(74, 62);
            this.btn_Bul.TabIndex = 4;
            this.btn_Bul.Text = "Bul";
            this.btn_Bul.UseVisualStyleBackColor = true;
            this.btn_Bul.Click += new System.EventHandler(this.btn_Bul_Click);
            // 
            // btn_Listele
            // 
            this.btn_Listele.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btn_Listele.Location = new System.Drawing.Point(442, 12);
            this.btn_Listele.Name = "btn_Listele";
            this.btn_Listele.Size = new System.Drawing.Size(91, 75);
            this.btn_Listele.TabIndex = 5;
            this.btn_Listele.Text = "Tüm Üyeleri Listele";
            this.btn_Listele.UseVisualStyleBackColor = true;
            this.btn_Listele.Click += new System.EventHandler(this.btn_Listele_Click);
            // 
            // btn_Ekle
            // 
            this.btn_Ekle.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btn_Ekle.Location = new System.Drawing.Point(551, 27);
            this.btn_Ekle.Name = "btn_Ekle";
            this.btn_Ekle.Size = new System.Drawing.Size(74, 62);
            this.btn_Ekle.TabIndex = 6;
            this.btn_Ekle.Text = "Ekle";
            this.btn_Ekle.UseVisualStyleBackColor = true;
            this.btn_Ekle.Click += new System.EventHandler(this.btn_Ekle_Click);
            // 
            // btn_Sil
            // 
            this.btn_Sil.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btn_Sil.Location = new System.Drawing.Point(643, 27);
            this.btn_Sil.Name = "btn_Sil";
            this.btn_Sil.Size = new System.Drawing.Size(74, 62);
            this.btn_Sil.TabIndex = 7;
            this.btn_Sil.Text = "Sil";
            this.btn_Sil.UseVisualStyleBackColor = true;
            this.btn_Sil.Click += new System.EventHandler(this.btn_Sil_Click);
            // 
            // btn_Guncelle
            // 
            this.btn_Guncelle.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btn_Guncelle.Location = new System.Drawing.Point(732, 27);
            this.btn_Guncelle.Name = "btn_Guncelle";
            this.btn_Guncelle.Size = new System.Drawing.Size(82, 62);
            this.btn_Guncelle.TabIndex = 8;
            this.btn_Guncelle.Text = "Güncelle";
            this.btn_Guncelle.UseVisualStyleBackColor = true;
            this.btn_Guncelle.Click += new System.EventHandler(this.btn_Guncelle_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(34, 111);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(780, 331);
            this.dataGridView1.TabIndex = 9;
            // 
            // UyelerForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(843, 486);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.btn_Guncelle);
            this.Controls.Add(this.btn_Sil);
            this.Controls.Add(this.btn_Ekle);
            this.Controls.Add(this.btn_Listele);
            this.Controls.Add(this.btn_Bul);
            this.Controls.Add(this.txt_Aranacakİfade);
            this.Controls.Add(this.cmb_Kategoriler);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "UyelerForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Text = "UyelerForm";
            this.Load += new System.EventHandler(this.UyelerForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cmb_Kategoriler;
        private System.Windows.Forms.TextBox txt_Aranacakİfade;
        private System.Windows.Forms.Button btn_Bul;
        private System.Windows.Forms.Button btn_Listele;
        private System.Windows.Forms.Button btn_Ekle;
        private System.Windows.Forms.Button btn_Sil;
        private System.Windows.Forms.Button btn_Guncelle;
        private System.Windows.Forms.DataGridView dataGridView1;
    }
}