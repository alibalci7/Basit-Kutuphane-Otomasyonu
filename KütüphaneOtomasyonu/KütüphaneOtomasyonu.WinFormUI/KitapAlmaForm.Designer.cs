namespace KütüphaneOtomasyonu.WinFormUI
{
    partial class KitapAlmaForm
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
            this.mskt_UyeTcNo = new System.Windows.Forms.MaskedTextBox();
            this.btn_KitapAl = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.txt_KitapYazari = new System.Windows.Forms.TextBox();
            this.txt_KitapAdi = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // mskt_UyeTcNo
            // 
            this.mskt_UyeTcNo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.mskt_UyeTcNo.Location = new System.Drawing.Point(363, 62);
            this.mskt_UyeTcNo.Mask = "00000000000";
            this.mskt_UyeTcNo.Name = "mskt_UyeTcNo";
            this.mskt_UyeTcNo.Size = new System.Drawing.Size(122, 26);
            this.mskt_UyeTcNo.TabIndex = 12;
            this.mskt_UyeTcNo.ValidatingType = typeof(int);
            // 
            // btn_KitapAl
            // 
            this.btn_KitapAl.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btn_KitapAl.Location = new System.Drawing.Point(554, 24);
            this.btn_KitapAl.Name = "btn_KitapAl";
            this.btn_KitapAl.Size = new System.Drawing.Size(120, 64);
            this.btn_KitapAl.TabIndex = 13;
            this.btn_KitapAl.Text = "Kitap İade";
            this.btn_KitapAl.UseVisualStyleBackColor = true;
            this.btn_KitapAl.Click += new System.EventHandler(this.btn_KitapAl_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(21, 115);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(770, 429);
            this.dataGridView1.TabIndex = 14;
            // 
            // txt_KitapYazari
            // 
            this.txt_KitapYazari.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txt_KitapYazari.Location = new System.Drawing.Point(190, 62);
            this.txt_KitapYazari.Name = "txt_KitapYazari";
            this.txt_KitapYazari.Size = new System.Drawing.Size(128, 26);
            this.txt_KitapYazari.TabIndex = 10;
            // 
            // txt_KitapAdi
            // 
            this.txt_KitapAdi.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txt_KitapAdi.Location = new System.Drawing.Point(21, 62);
            this.txt_KitapAdi.Name = "txt_KitapAdi";
            this.txt_KitapAdi.Size = new System.Drawing.Size(128, 26);
            this.txt_KitapAdi.TabIndex = 8;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.Location = new System.Drawing.Point(359, 24);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(93, 20);
            this.label3.TabIndex = 11;
            this.label3.Text = "Üye TC. No:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.Location = new System.Drawing.Point(186, 24);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(98, 20);
            this.label2.TabIndex = 9;
            this.label2.Text = "Kitap Yazarı:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(17, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(76, 20);
            this.label1.TabIndex = 7;
            this.label1.Text = "Kitap Adı:";
            // 
            // KitapAlmaForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(863, 550);
            this.Controls.Add(this.mskt_UyeTcNo);
            this.Controls.Add(this.btn_KitapAl);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.txt_KitapYazari);
            this.Controls.Add(this.txt_KitapAdi);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "KitapAlmaForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Text = "KitapAlmaForm";
            this.Load += new System.EventHandler(this.KitapAlmaForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MaskedTextBox mskt_UyeTcNo;
        private System.Windows.Forms.Button btn_KitapAl;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.TextBox txt_KitapYazari;
        private System.Windows.Forms.TextBox txt_KitapAdi;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
    }
}