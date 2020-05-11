using KütüphaneOtomasyonuORM.Entity;
using KütüphaneOtomasyonuORM.Facade;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace KütüphaneOtomasyonu.WinFormUI
{
    public partial class KitapForm : Form
    {
        KitapORM kORM = new KitapORM();
        DepoORM dORM = new DepoORM();
        KitapEkleGuncelleForm kegf = new KitapEkleGuncelleForm();

        public KitapForm()
        {
            InitializeComponent();
        }

        private void KitapForm_Load(object sender, EventArgs e)
        {
            DataTable dt= kORM.KategorilerSelect();
            dt.Rows.RemoveAt(0);
            cmb_Kategoriler.DataSource = dt;
            cmb_Kategoriler.DisplayMember = "COLUMN_NAME";
            Listele();
        }

        private void btn_Bul_Click(object sender, EventArgs e)
        {
            string kolon = cmb_Kategoriler.Text;
            string kelime = txt_AranacakKelime.Text;
            dataGridView1.DataSource = kORM.Bul(kolon, kelime);
        }

        private void btn_Listele_Click(object sender, EventArgs e)
        {
            Listele();
        }

        void Listele()
        {
            dataGridView1.DataSource = kORM.Select();
            dataGridView1.Columns[0].Visible = false;
        }

        private void btn_Sil_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count > 0)
            {
                DialogResult dr = MessageBox.Show("Emin misiniz?", "Kitap Silme", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Warning);
                if (dr == DialogResult.Yes)
                {
                    foreach (DataGridViewRow drow in dataGridView1.SelectedRows)
                    {
                        int numara = Convert.ToInt32(drow.Cells["Id"].Value);
                        Kitap k = new Kitap();
                        Depo d = new Depo();
                        d.KitapID = numara;
                        k.Id = numara;
                        kORM.Delete(k);
                        dORM.Delete(d);
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
            kegf.temizle = true;
            kegf.ShowDialog();
        }

        private void btn_Guncelle_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count == 1)
            {
                kegf.temizle = false;
                kegf.Id = Convert.ToInt32(dataGridView1.CurrentRow.Cells[0].Value);
                kegf.KitapAdi = dataGridView1.CurrentRow.Cells[1].Value.ToString();
                kegf.KitapYazari = dataGridView1.CurrentRow.Cells[2].Value.ToString();
                kegf.BasımYeri = dataGridView1.CurrentRow.Cells[3].Value.ToString();
                kegf.BasımYili = dataGridView1.CurrentRow.Cells[4].Value.ToString();
                kegf.SayfaSayisi = dataGridView1.CurrentRow.Cells[5].Value.ToString();
                kegf.ShowDialog();
            }
            else
            {
                MessageBox.Show("Lütfen bir satır seçiniz.");
            }
        }

    }
}
