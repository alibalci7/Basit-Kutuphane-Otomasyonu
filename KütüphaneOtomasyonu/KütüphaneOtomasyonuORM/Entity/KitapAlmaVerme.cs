using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KütüphaneOtomasyonuORM.Entity
{
    public class KitapAlmaVerme
    {
        public KitapAlmaVerme()
        {
            AlmaTarihi = DateTime.Now;
            VermeTarihi = DateTime.Now;
            AlanPersonelID = 0;

        }
        public string KitapAdi { get; set; }

        public string KitapYazari { get; set; }

        public string Tckn { get; set; }

        public int AlanPersonelID { get; set; }

        public int VerenPersonelID { get; set; }

        public DateTime AlmaTarihi { get; set; }

        public DateTime VermeTarihi { get; set; }

    }
}
