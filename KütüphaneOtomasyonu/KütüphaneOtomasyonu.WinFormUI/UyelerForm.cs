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
    public partial class UyelerForm : Form
    {
        UyelerORM uORM = new UyelerORM();
        UyelerEkleGuncelleForm uegf = new UyelerEkleGuncelleForm();

        public UyelerForm()
        {
            InitializeComponent();
        }

        private void UyelerForm_Load(object sender, EventArgs e)
        {
            DataTable dt = uORM.KategorilerSelect();
            dt.Rows.RemoveAt(7);
            dt.Rows.RemoveAt(6);
            dt.Rows.RemoveAt(3);
            dt.Rows.RemoveAt(0);
            cmb_Kategoriler.DataSource = dt;
            cmb_Kategoriler.DisplayMember = "COLUMN_NAME";
            Listele();
        }

        void Listele()
        {
            dataGridView1.DataSource = uORM.Select();
            dataGridView1.Columns["Id"].Visible = false;

        }

        private void btn_Bul_Click(object sender, EventArgs e)
        {
            string kolon = cmb_Kategoriler.Text;
            string kelime = txt_Aranacakİfade.Text;
            dataGridView1.DataSource = uORM.Bul(kolon, kelime);
        }

        private void btn_Listele_Click(object sender, EventArgs e)
        {
            Listele();
        }

        private void btn_Sil_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count > 0)
            {
                DialogResult dr = MessageBox.Show("Emin misiniz?", "Üye Silme", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Warning);
                if (dr == DialogResult.Yes)
                {
                    foreach (DataGridViewRow drow in dataGridView1.SelectedRows)
                    {
                        int numara = Convert.ToInt32(drow.Cells["Id"].Value);
                        Uyeler u = new Uyeler();
                        u.Id = numara;
                        uORM.Delete(u);
                        Listele();
                    }
                }

            }
            else
            {
                MessageBox.Show("Lütfen Satır Seçiniz.");
            }

        }

        private void btn_Ekle_Click(object sender, EventArgs e)
        {
            uegf.temizle = true;
            uegf.ShowDialog();
        }

        private void btn_Guncelle_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count == 1)
            {
                uegf.temizle = false;
                uegf.Id = Convert.ToInt32(dataGridView1.CurrentRow.Cells[0].Value);
                uegf.Adi = dataGridView1.CurrentRow.Cells[1].Value.ToString();
                uegf.Soyadi = dataGridView1.CurrentRow.Cells[2].Value.ToString();
                uegf.Adres = dataGridView1.CurrentRow.Cells[3].Value.ToString();
                uegf.Tckn = dataGridView1.CurrentRow.Cells[4].Value.ToString();
                uegf.TelNo = dataGridView1.CurrentRow.Cells[5].Value.ToString();
                uegf.MailAdresi = dataGridView1.CurrentRow.Cells[6].Value.ToString();
                switch (dataGridView1.CurrentRow.Cells[7].Value.ToString() )
                {
                    case "Erkek":
                        uegf.Cinsiyet = false;
                        break;
                    case "Kadın":
                        uegf.Cinsiyet = true;
                        break;
                }  
                uegf.ShowDialog();
            }
            else
            {
                MessageBox.Show("Lütfen bir satır seçiniz.");
            }
        }
    }
}
