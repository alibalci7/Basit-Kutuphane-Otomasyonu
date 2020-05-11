namespace KütüphaneOtomasyonu.WinFormUI
{
    partial class Form1
    {
        /// <summary>
        ///Gerekli tasarımcı değişkeni.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///Kullanılan tüm kaynakları temizleyin.
        /// </summary>
        ///<param name="disposing">yönetilen kaynaklar dispose edilmeliyse doğru; aksi halde yanlış.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer üretilen kod

        /// <summary>
        /// Tasarımcı desteği için gerekli metot - bu metodun 
        ///içeriğini kod düzenleyici ile değiştirmeyin.
        /// </summary>
        private void InitializeComponent()
        {
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.kitapİşlemleriToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.üyeİşlemleriToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.personelİşlemleriToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.kullanıcıEkleToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ödünçVermeAlmaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.kitapSorgulamaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.çıkışYapToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.kitapİadeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.kitapİşlemleriToolStripMenuItem,
            this.üyeİşlemleriToolStripMenuItem,
            this.personelİşlemleriToolStripMenuItem,
            this.kullanıcıEkleToolStripMenuItem,
            this.ödünçVermeAlmaToolStripMenuItem,
            this.kitapİadeToolStripMenuItem,
            this.kitapSorgulamaToolStripMenuItem,
            this.çıkışYapToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1099, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // kitapİşlemleriToolStripMenuItem
            // 
            this.kitapİşlemleriToolStripMenuItem.Name = "kitapİşlemleriToolStripMenuItem";
            this.kitapİşlemleriToolStripMenuItem.Size = new System.Drawing.Size(93, 20);
            this.kitapİşlemleriToolStripMenuItem.Text = "Kitap İşlemleri";
            this.kitapİşlemleriToolStripMenuItem.Click += new System.EventHandler(this.kitapİşlemleriToolStripMenuItem_Click);
            // 
            // üyeİşlemleriToolStripMenuItem
            // 
            this.üyeİşlemleriToolStripMenuItem.Name = "üyeİşlemleriToolStripMenuItem";
            this.üyeİşlemleriToolStripMenuItem.Size = new System.Drawing.Size(86, 20);
            this.üyeİşlemleriToolStripMenuItem.Text = "Üye İşlemleri";
            this.üyeİşlemleriToolStripMenuItem.Click += new System.EventHandler(this.üyeİşlemleriToolStripMenuItem_Click);
            // 
            // personelİşlemleriToolStripMenuItem
            // 
            this.personelİşlemleriToolStripMenuItem.Name = "personelİşlemleriToolStripMenuItem";
            this.personelİşlemleriToolStripMenuItem.Size = new System.Drawing.Size(111, 20);
            this.personelİşlemleriToolStripMenuItem.Text = "Personel İşlemleri";
            this.personelİşlemleriToolStripMenuItem.Click += new System.EventHandler(this.personelİşlemleriToolStripMenuItem_Click);
            // 
            // kullanıcıEkleToolStripMenuItem
            // 
            this.kullanıcıEkleToolStripMenuItem.Name = "kullanıcıEkleToolStripMenuItem";
            this.kullanıcıEkleToolStripMenuItem.Size = new System.Drawing.Size(88, 20);
            this.kullanıcıEkleToolStripMenuItem.Text = "Kullanıcı Ekle";
            this.kullanıcıEkleToolStripMenuItem.Click += new System.EventHandler(this.kullanıcıEkleToolStripMenuItem_Click);
            // 
            // ödünçVermeAlmaToolStripMenuItem
            // 
            this.ödünçVermeAlmaToolStripMenuItem.Name = "ödünçVermeAlmaToolStripMenuItem";
            this.ödünçVermeAlmaToolStripMenuItem.Size = new System.Drawing.Size(121, 20);
            this.ödünçVermeAlmaToolStripMenuItem.Text = "Kitap Ödünç Verme";
            this.ödünçVermeAlmaToolStripMenuItem.Click += new System.EventHandler(this.ödünçVermeAlmaToolStripMenuItem_Click);
            // 
            // kitapSorgulamaToolStripMenuItem
            // 
            this.kitapSorgulamaToolStripMenuItem.Name = "kitapSorgulamaToolStripMenuItem";
            this.kitapSorgulamaToolStripMenuItem.Size = new System.Drawing.Size(106, 20);
            this.kitapSorgulamaToolStripMenuItem.Text = "Kitap Sorgulama";
            this.kitapSorgulamaToolStripMenuItem.Click += new System.EventHandler(this.kitapSorgulamaToolStripMenuItem_Click);
            // 
            // çıkışYapToolStripMenuItem
            // 
            this.çıkışYapToolStripMenuItem.Name = "çıkışYapToolStripMenuItem";
            this.çıkışYapToolStripMenuItem.Size = new System.Drawing.Size(66, 20);
            this.çıkışYapToolStripMenuItem.Text = "Çıkış Yap";
            this.çıkışYapToolStripMenuItem.Click += new System.EventHandler(this.çıkışYapToolStripMenuItem_Click);
            // 
            // kitapİadeToolStripMenuItem
            // 
            this.kitapİadeToolStripMenuItem.Name = "kitapİadeToolStripMenuItem";
            this.kitapİadeToolStripMenuItem.Size = new System.Drawing.Size(71, 20);
            this.kitapİadeToolStripMenuItem.Text = "Kitap İade";
            this.kitapİadeToolStripMenuItem.Click += new System.EventHandler(this.kitapİadeToolStripMenuItem_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1099, 543);
            this.Controls.Add(this.menuStrip1);
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem kitapİşlemleriToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem üyeİşlemleriToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem personelİşlemleriToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ödünçVermeAlmaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem kitapSorgulamaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem çıkışYapToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem kullanıcıEkleToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem kitapİadeToolStripMenuItem;
    }
}

