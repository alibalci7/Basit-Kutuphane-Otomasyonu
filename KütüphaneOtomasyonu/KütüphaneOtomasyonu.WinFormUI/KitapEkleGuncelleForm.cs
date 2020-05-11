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
    public partial class KitapEkleGuncelleForm : Form
    {
        KitapORM kORM = new KitapORM();
        DepoORM dORM = new DepoORM();

        public string KitapAdi, KitapYazari, BasımYeri, BasımYili, SayfaSayisi;
        public int Id;
        public bool temizle;

        enum İslemTipi
        {
            Insert,
            Update
        }

        private void btn_Guncelle_Click(object sender, EventArgs e)
        {
            EkleGuncelle(İslemTipi.Update);
        }

        private void KitapEkleGuncelleForm_Load(object sender, EventArgs e)
        {
            txt_KitapAdi.Text = KitapAdi;
            txt_KitapYazari.Text = KitapYazari;
            txt_BasimYeri.Text = BasımYeri;
            txt_SayfaSayisi.Text = SayfaSayisi;
            mskt_BasimYili.Text = BasımYili;
            if (temizle)
                TextBoxTemizle();
        }

        public KitapEkleGuncelleForm()
        {
            InitializeComponent();
        }

        private void btn_Ekle_Click(object sender, EventArgs e)
        {
            EkleGuncelle(İslemTipi.Insert);         
        }

        void TextBoxTemizle()
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
                Kitap k = new Kitap();
                Depo d = new Depo();
                k.KitapAdi = txt_KitapAdi.Text;
                k.KitapYazari = txt_KitapYazari.Text;
                k.BasımYeri = txt_BasimYeri.Text;
                k.BasımYili = mskt_BasimYili.Text;
                k.SayfaSayisi = txt_SayfaSayisi.Text;
                d.RafNo = txt_RafNo.Text;
                d.Adet = Convert.ToInt32(txt_Adet.Text);

                DataTable dt = kORM.EklmeKontrolSelect(k);
                if (dt.Rows.Count > 0)
                {
                    MessageBox.Show("Bu kitap zaten kütüphanede mevcuttur.");
                }
                else
                {
                    switch (it)
                    {
                        case İslemTipi.Insert:
                            object deger = kORM.InsertScalar(k);
                            int kid = Convert.ToInt32(deger);
                            if (kid>0)
                            {
                                d.KitapID = kid;
                                bool s = dORM.Insert(d);
                                if (s)
                                {
                                    MessageBox.Show("Kayıt Ekleme Başarılı");
                                    TextBoxTemizle();
                                }
                                else
                                {
                                    bool silme = kORM.Delete(k);
                                    MessageBox.Show("Kayıt Ekleme Hatalı!");
                                }                               
                            }
                            else
                            {
                                MessageBox.Show("Kayıt Ekleme Hatalı!");
                            }
                            break;
                        case İslemTipi.Update:
                            k.Id = Id;
                            d.KitapID = Id;
                            bool sonuc = kORM.Update(k);
                            if (sonuc)
                            {
                                bool s = dORM.Update(d);
                                if (s)
                                {
                                    MessageBox.Show("Kayıt Güncelleme Başarılı");
                                    TextBoxTemizle();
                                }
                                else
                                {
                                    MessageBox.Show("Kayıt Güncelleme Hatalı!");
                                }                              
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
    }
}
