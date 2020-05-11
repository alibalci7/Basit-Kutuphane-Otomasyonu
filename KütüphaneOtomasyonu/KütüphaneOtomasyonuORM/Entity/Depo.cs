using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KütüphaneOtomasyonuORM.Entity
{
    public class Depo
    {
        public int Id { get; set; }

        public int KitapID { get; set; }

        public int Adet { get; set; }

        public string RafNo { get; set; }

    }
}
