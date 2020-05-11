using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KütüphaneOtomasyonuORM.Entity
{
    public class Kitap
    {
        public int Id { get; set; }

        public string KitapAdi { get; set; }

        public string KitapYazari { get; set; }

        public string BasımYeri { get; set; }

        public string BasımYili { get; set; }

        public string SayfaSayisi { get; set; }

    }
}
