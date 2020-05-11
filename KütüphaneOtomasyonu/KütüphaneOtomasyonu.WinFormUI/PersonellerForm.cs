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
    public partial class PersonellerForm : Form
    {
        PersonellerORM pORM = new PersonellerORM();
        PersonellerEkleGuncelleForm pegf = new PersonellerEkleGuncelleForm();

        public PersonellerForm()
        {
            InitializeComponent();
        }

        private void PersonellerForm_Load(object sender, EventArgs e)
        {
            DataTable dt = pORM.KategorilerSelect();
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
            dataGridView1.DataSource = pORM.Select();
            dataGridView1.Columns["Id"].Visible = false;

        }

        private void btn_Listele_Click(object sender, EventArgs e)
        {
            Listele();
        }

        private void btn_Bul_Click(object sender, EventArgs e)
        {
            string kolon = cmb_Kategoriler.Text;
            string kelime = txt_Aranacakİfade.Text;
            dataGridView1.DataSource = pORM.Bul(kolon, kelime);
        }

        private void btn_Sil_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count > 0)
            {
                DialogResult dr = MessageBox.Show("Emin misiniz?", "Personel Silme", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Warning);
                if (dr == DialogResult.Yes)
                {
                    foreach (DataGridViewRow drow in dataGridView1.SelectedRows)
                    {
                        int numara = Convert.ToInt32(drow.Cells["Id"].Value);
                        Personeller p = new Personeller();
                        p.Id = numara;
                        pORM.Delete(p);
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
            pegf.temizle = true;
            pegf.ShowDialog();
        }

        private void btn_Guncelle_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count == 1)
            {
                pegf.temizle = false;
                pegf.Id = Convert.ToInt32(dataGridView1.CurrentRow.Cells[0].Value);
                pegf.Adi = dataGridView1.CurrentRow.Cells[1].Value.ToString();
                pegf.Soyadi = dataGridView1.CurrentRow.Cells[2].Value.ToString();
                pegf.Adres = dataGridView1.CurrentRow.Cells[3].Value.ToString();
                pegf.Tckn = dataGridView1.CurrentRow.Cells[4].Value.ToString();
                pegf.TelNo = dataGridView1.CurrentRow.Cells[5].Value.ToString();
                pegf.MailAdresi = dataGridView1.CurrentRow.Cells[6].Value.ToString();
                switch (dataGridView1.CurrentRow.Cells[7].Value.ToString())
                {
                    case "Erkek":
                        pegf.Cinsiyet = false;
                        break;
                    case "Kadın":
                        pegf.Cinsiyet = true;
                        break;
                }
                pegf.ShowDialog();
            }
            else
            {
                MessageBox.Show("Lütfen bir satır seçiniz.");
            }
        }
    }
}
