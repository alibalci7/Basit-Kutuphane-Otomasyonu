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
    public partial class GirisForm : Form
    {
        GirisORM gORM = new GirisORM();
        
        public GirisForm()
        {
            InitializeComponent();
        }

        private void btn_GirisYap_Click(object sender, EventArgs e)
        {
            Giris g = new Giris();
            g.KullaniciAdi = txt_KullaniciAdi.Text;
            g.Parola = txt_Parola.Text;
            DataTable dt = gORM.Select(g);
            if (dt.Rows.Count > 0)
            {
                DataRow dr = dt.Rows[0];
                g.PersonelID = Convert.ToInt32(dr["PersonelID"].ToString());
                GirisORM.aktifPersonel = g;
                Form1 f1 = new Form1();
                f1.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Hatalı Giriş Yaptınız!");
            }
        }
    }
}
