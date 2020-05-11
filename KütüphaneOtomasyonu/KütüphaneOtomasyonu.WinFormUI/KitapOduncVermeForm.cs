using KütüphaneOtomasyonuORM.Entity;
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
    public partial class KitapOduncVermeForm : Form
    {
        KitapAlmaVermeORM kavORM = new KitapAlmaVermeORM();

        public KitapOduncVermeForm()
        {
            InitializeComponent();
        }

        private void KitapOduncVermeForm_Load(object sender, EventArgs e)
        {
            Listele();
        }

        void Listele()
        {
            DataTable dt = kavORM.Select();
            dataGridView1.DataSource = dt;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                KitapAlmaVerme kav = new KitapAlmaVerme();
                kav.KitapAdi = txt_KitapAdi.Text;
                kav.KitapYazari = txt_KitapYazari.Text;
                kav.Tckn = mskt_UyeTcNo.Text;
                kav.VerenPersonelID = GirisORM.aktifPersonel.PersonelID;
                bool sonuc = kavORM.Insert(kav);
                if (sonuc)
                {
                    MessageBox.Show("Kitap üyeye verildi.");
                    TextTemizle();
                    Listele();
                }
                else
                {
                    MessageBox.Show("Kitap Üyeye verilemedi. Tekrar deneyin.");
                }
            }catch(Exception ex)
            {
                MessageBox.Show(ex.Message.ToString());
            }
           
        }

        void TextTemizle()
        {
            foreach (Control item in this.Controls)
            {
                if (item is TextBox || item is MaskedTextBox)
                    item.Text = "";
            }
        }
    }
}
