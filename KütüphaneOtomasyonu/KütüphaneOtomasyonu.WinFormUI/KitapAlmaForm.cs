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
    public partial class KitapAlmaForm : Form
    {
        KitapAlmaVermeORM kavORM = new KitapAlmaVermeORM();

        public KitapAlmaForm()
        {
            InitializeComponent();
        }

        private void KitapAlmaForm_Load(object sender, EventArgs e)
        {
            Listele();
        }

        void Listele()
        {
            DataTable dt = kavORM.Select();
            dataGridView1.DataSource = dt;
        }

        private void btn_KitapAl_Click(object sender, EventArgs e)
        {
            try
            {
                KitapAlmaVerme kav = new KitapAlmaVerme();
                kav.KitapAdi = txt_KitapAdi.Text;
                kav.KitapYazari = txt_KitapYazari.Text;
                kav.Tckn = mskt_UyeTcNo.Text;
                kav.VerenPersonelID = GirisORM.aktifPersonel.PersonelID;
                bool sonuc = kavORM.Update(kav);
                if (sonuc)
                {
                    MessageBox.Show("Kitap üyeden alındı");
                    TextTemizle();
                    Listele();
                }
                else
                {
                    MessageBox.Show("Kitap üyeden alınamadı. Tekrar deneyin.");
                }
            }
            catch (Exception ex)
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
