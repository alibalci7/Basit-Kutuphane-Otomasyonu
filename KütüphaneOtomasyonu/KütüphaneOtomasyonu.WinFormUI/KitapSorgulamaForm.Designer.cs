namespace KütüphaneOtomasyonu.WinFormUI
{
    partial class KitapSorgulamaForm
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
            this.cmb_Kategoriler = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txt_AranacakKelime = new System.Windows.Forms.TextBox();
            this.btn_Ara = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(40, 40);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(122, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Aranacak Kriter:";
            // 
            // cmb_Kategoriler
            // 
            this.cmb_Kategoriler.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmb_Kategoriler.FormattingEnabled = true;
            this.cmb_Kategoriler.Location = new System.Drawing.Point(44, 64);
            this.cmb_Kategoriler.Name = "cmb_Kategoriler";
            this.cmb_Kategoriler.Size = new System.Drawing.Size(121, 21);
            this.cmb_Kategoriler.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.Location = new System.Drawing.Point(191, 40);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(132, 20);
            this.label2.TabIndex = 2;
            this.label2.Text = "Aranacak Kelime:";
            // 
            // txt_AranacakKelime
            // 
            this.txt_AranacakKelime.Location = new System.Drawing.Point(195, 64);
            this.txt_AranacakKelime.Name = "txt_AranacakKelime";
            this.txt_AranacakKelime.Size = new System.Drawing.Size(128, 20);
            this.txt_AranacakKelime.TabIndex = 3;
            // 
            // btn_Ara
            // 
            this.btn_Ara.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btn_Ara.Location = new System.Drawing.Point(357, 41);
            this.btn_Ara.Name = "btn_Ara";
            this.btn_Ara.Size = new System.Drawing.Size(88, 44);
            this.btn_Ara.TabIndex = 4;
            this.btn_Ara.Text = "Ara";
            this.btn_Ara.UseVisualStyleBackColor = true;
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(44, 122);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(890, 451);
            this.dataGridView1.TabIndex = 5;
            // 
            // KitapSorgulamaForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(979, 585);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.btn_Ara);
            this.Controls.Add(this.txt_AranacakKelime);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.cmb_Kategoriler);
            this.Controls.Add(this.label1);
            this.Name = "KitapSorgulamaForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Text = "KitapSorgulamaForm";
            this.Load += new System.EventHandler(this.KitapSorgulamaForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cmb_Kategoriler;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txt_AranacakKelime;
        private System.Windows.Forms.Button btn_Ara;
        private System.Windows.Forms.DataGridView dataGridView1;
    }
}