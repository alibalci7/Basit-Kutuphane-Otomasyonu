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
    public partial class UyelerEkleGuncelleForm : Form
    {
        public string Adi, Soyadi, Adres, TelNo, Tckn, MailAdresi;
        public int Id;
        public bool Cinsiyet,temizle;

        UyelerORM uORM = new UyelerORM();

        private void btn_Ekle_Click(object sender, EventArgs e)
        {
            EkleGuncelle(İslemTipi.Insert);
        }

        private void btn_Guncelle_Click(object sender, EventArgs e)
        {
            EkleGuncelle(İslemTipi.Update);
        }

        public UyelerEkleGuncelleForm()
        {
            InitializeComponent();
        }

        private void UyelerEkleGuncelleForm_Load(object sender, EventArgs e)
        {       
            txt_Adi.Text = Adi;
            txt_Adres.Text = Adres;
            txt_Soyadi.Text = Soyadi;
            txt_MailAdresi.Text = MailAdresi;
            mskt_TC.Text = Tckn;
            mskt_TelNo.Text = TelNo;
            if (Cinsiyet)
                rdb_Kadin.Select();
            else
                rdb_Erkek.Select();
            if (temizle)
                TextBoxTemizle();
        }

        void EkleGuncelle(İslemTipi it)
        {
            try
            {
                Uyeler u = new Uyeler();
                u.Adi = txt_Adi.Text;
                u.Soyadi = txt_Soyadi.Text;
                u.Adres = txt_Adres.Text;
                u.TelNo = mskt_TelNo.Text;
                u.Tckn = mskt_TC.Text;
                u.MailAdresi = txt_MailAdresi.Text;
                if (rdb_Erkek.Checked)
                    u.Cinsiyet = false;
                if (rdb_Kadin.Checked)
                    u.Cinsiyet = true;

                DataTable dt = uORM.EklmeKontrolSelect(u);
                if (dt.Rows.Count > 0)
                {
                    MessageBox.Show("Bu üye zaten kütüphanede mevcuttur.");
                }
                else
                {
                    bool sonuc;
                    switch (it)
                    {
                        case İslemTipi.Insert:
                            sonuc = uORM.Insert(u);
                            if (sonuc)
                            {
                                MessageBox.Show("Kayıt Ekleme Başarılı");
                                TextBoxTemizle();
                            }
                            else
                            {
                                MessageBox.Show("Kayıt Ekleme Hatalı!");
                            }
                            break;
                        case İslemTipi.Update:
                            u.Id = Id;
                            sonuc = uORM.Update(u);
                            if (sonuc)
                            {
                                MessageBox.Show("Kayıt Güncelleme Başarılı");
                                TextBoxTemizle();
                            }
                            else
                            {
                                MessageBox.Show("Kayıt Güncelleme Hatalı!");
                            }
                            break;
                    }

                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message.ToString());
            }
        }

        public void TextBoxTemizle()
        {
            foreach (Control item in this.Controls)
            {
                if (item is TextBox || item is MaskedTextBox)
                    item.Text = "";
            }
        }

        enum İslemTipi
        {
            Insert,
            Update
        }

    }
}
