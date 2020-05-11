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
    public partial class KitapSorgulamaForm : Form
    {
        DepoORM dORM = new DepoORM();
        KitapORM kORM = new KitapORM();

        public KitapSorgulamaForm()
        {
            InitializeComponent();
        }

        private void KitapSorgulamaForm_Load(object sender, EventArgs e)
        {
            DataTable dt = new DataTable();
            dt= kORM.KategorilerSelect();
            dt.Rows.RemoveAt(0);
            cmb_Kategoriler.DataSource = dt;
            cmb_Kategoriler.DisplayMember = "COLUMN_NAME";
            Listele();

        }

        void Listele()
        {
            dataGridView1.DataSource = dORM.Select();
            dataGridView1.Columns[0].Visible = false;
        }
    }
}
