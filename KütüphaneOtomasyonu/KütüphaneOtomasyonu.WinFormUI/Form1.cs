using KütüphaneOtomasyonuORM.Facade;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace KütüphaneOtomasyonu.WinFormUI
{
    public partial class Form1 : Form
    {
        KitapForm kForm = new KitapForm();
        UyelerForm uForm = new UyelerForm();
        PersonellerForm pForm = new PersonellerForm();
        KitapSorgulamaForm ksForm = new KitapSorgulamaForm();
        KullaniciEkleForm keForm = new KullaniciEkleForm();
        KitapOduncVermeForm kovForm = new KitapOduncVermeForm();
        KitapAlmaForm kaForm = new KitapAlmaForm();

        public Form1()
        {
            InitializeComponent();
        }

        private void kitapİşlemleriToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (kForm.IsDisposed)
                kForm = new KitapForm();
            kForm.MdiParent = this;
            kForm.Show();
        }

        private void üyeİşlemleriToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (uForm.IsDisposed)
                uForm = new UyelerForm();
            uForm.MdiParent = this;
            uForm.Show();
        }

        private void personelİşlemleriToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (pForm.IsDisposed)
                pForm = new PersonellerForm();
            pForm.MdiParent = this;
            pForm.Show();
        }

        private void kitapSorgulamaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (ksForm.IsDisposed)
                ksForm = new KitapSorgulamaForm();
            ksForm.MdiParent = this;
            ksForm.Show();
        }

        private void çıkışYapToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DialogResult dr = MessageBox.Show("Emin misiniz", "Çıkış", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question);
            if (dr == DialogResult.Yes)
            {
                GirisORM.aktifPersonel = null;
                GirisForm gf = new GirisForm();
                gf.Show();
                this.Hide();
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            if(GirisORM.aktifPersonel.KullaniciAdi != "admin")
            {
                menuStrip1.Items["PersonelİşlemleriToolStripMenuItem"].Enabled = false;
                menuStrip1.Items["kullanıcıEkleToolStripMenuItem"].Enabled = false;
            }
        }

        private void kullanıcıEkleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (keForm.IsDisposed)
                keForm = new KullaniciEkleForm();
            keForm.MdiParent = this;
            keForm.Show();
        }

        private void ödünçVermeAlmaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (kovForm.IsDisposed)
                kovForm = new KitapOduncVermeForm();
            kovForm.MdiParent = this;
            kovForm.Show();
        }

        private void kitapİadeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (kaForm.IsDisposed)
                ksForm = new KitapSorgulamaForm();
            kaForm.MdiParent = this;
            kaForm.Show();
        }
    }
}
