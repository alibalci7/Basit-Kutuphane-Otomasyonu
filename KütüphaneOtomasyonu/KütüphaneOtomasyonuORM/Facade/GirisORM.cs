using KütüphaneOtomasyonuORM.Entity;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KütüphaneOtomasyonuORM.Facade
{
    public class GirisORM:BaseORM<Giris>
    {
        public static Giris aktifPersonel;

        public DataTable Select(Giris g)
        {
            SqlDataAdapter adp = new SqlDataAdapter(string.Format("prc_Giris_Select"), Tools.Baglanti);
            adp.SelectCommand.CommandType = CommandType.StoredProcedure;
            adp.SelectCommand.Parameters.AddWithValue("@KullaniciAdi", g.KullaniciAdi);
            adp.SelectCommand.Parameters.AddWithValue("@Parola", g.Parola);
            DataTable dt = new DataTable();
            adp.Fill(dt);
            return dt;
        }
    }
}
