using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KütüphaneOtomasyonuORM.Entity
{
    public class Personeller
    {
        public int Id { get; set; }

        public string Adi { get; set; }

        public string Soyadi { get; set; }

        public string Adres { get; set; }

        public string Tckn { get; set; }

        public string TelNo { get; set; }

        public string MailAdresi { get; set; }

        public bool Cinsiyet { get; set; }

    }
}
