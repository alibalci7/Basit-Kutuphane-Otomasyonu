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
    public partial class PersonellerEkleGuncelleForm : Form
    {
        public string Adi, Soyadi, Adres, TelNo, Tckn, MailAdresi;
        public int Id;
        public bool Cinsiyet, temizle;
        PersonellerORM pORM = new PersonellerORM();

        private void btn_Guncelle_Click(object sender, EventArgs e)
        {
            EkleGuncelle(İslemTipi.Update);
        }

        private void btn_Ekle_Click(object sender, EventArgs e)
        {
            EkleGuncelle(İslemTipi.Insert);
        }

        public PersonellerEkleGuncelleForm()
        {
            InitializeComponent();
        }

        private void PersonellerEkleGuncelleForm_Load(object sender, EventArgs e)
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

        public void TextBoxTemizle()
        {
            foreach (Control item in this.Controls)
            {
                if (item is TextBox || item is MaskedTextBox)
                    item.Text = "";
            }
        }

        void EkleGuncelle(İslemTipi it)
        {
            try
            {
                Personeller p = new Personeller();
                p.Adi = txt_Adi.Text;
                p.Soyadi = txt_Soyadi.Text;
                p.Adres = txt_Adres.Text;
                p.TelNo = mskt_TelNo.Text;
                p.Tckn = mskt_TC.Text;
                p.MailAdresi = txt_MailAdresi.Text;
                if (rdb_Erkek.Checked)
                    p.Cinsiyet = false;
                if (rdb_Kadin.Checked)
                    p.Cinsiyet = true;

                DataTable dt = pORM.EklmeKontrolSelect(p);
                if (dt.Rows.Count > 0)
                {
                    MessageBox.Show("Bu personel zaten kütüphanede mevcuttur.");
                }
                else
                {
                    bool sonuc;
                    switch (it)
                    {
                        case İslemTipi.Insert:
                            sonuc = pORM.Insert(p);
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
                            p.Id = Id;
                            sonuc = pORM.Update(p);
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

        enum İslemTipi
        {
            Insert,
            Update
        }
    }
}
