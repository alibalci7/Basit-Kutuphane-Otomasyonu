using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace KütüphaneOtomasyonuORM
{
    public class BaseORM<T> : IORM<T> where T : class
    {
        private string className;

        public string ClassName
        {
            get
            {
                className = typeof(T).Name;
                return className;
            }
        }

        public DataTable Bul(string kolon, string kelime)
        {
            SqlDataAdapter adp;
            if (ClassName == "Kitap")
                 adp= new SqlDataAdapter(string.Format("select * from " + ClassName + " where " + kolon + "=@Kelime"), Tools.Baglanti);
            else
            {
                adp = new SqlDataAdapter(string.Format("select "+ClassName+".Id, Adi, Soyadi, Adres, Tckn, TelNo, MailAdresi, Cinsiyet from " + ClassName + " , Cins c where " + kolon + "=@Kelime and CinsiyetID=c.Id"), Tools.Baglanti);
            }
            adp.SelectCommand.Parameters.AddWithValue("@Kelime", kelime);
            DataTable dt = new DataTable();
            adp.Fill(dt);
            return dt;
        }

        public bool Delete(T entity)
        {
            SqlCommand cmd = new SqlCommand(string.Format("prc_{0}_Delete", ClassName), Tools.Baglanti);
            cmd.CommandType = CommandType.StoredProcedure;

            Tools.Parametreler<T>(entity, KomutTipi.Delete, cmd);

            return Tools.Exec(cmd);
        }

        public DataTable EklmeKontrolSelect(T entity)
        {
            SqlDataAdapter adp = new SqlDataAdapter(string.Format("prc_{0}EklemeKontrol_Select", ClassName), Tools.Baglanti);
            adp.SelectCommand.CommandType = CommandType.StoredProcedure;

            Tools.Parametreler<T>(entity, adp);

            DataTable dt = new DataTable();
            adp.Fill(dt);
            return dt;
        }

        public bool Insert(T entity)
        {
            SqlCommand cmd = new SqlCommand(string.Format("prc_{0}_Insert", ClassName), Tools.Baglanti);
            cmd.CommandType = CommandType.StoredProcedure;

            Tools.Parametreler<T>(entity, KomutTipi.Insert, cmd);

            return Tools.Exec(cmd);
        }

        public object InsertScalar(T entity)
        {
            SqlCommand cmd = new SqlCommand(string.Format("prc_{0}_Insert", ClassName), Tools.Baglanti);
            cmd.CommandType = CommandType.StoredProcedure;

            Tools.Parametreler<T>(entity, KomutTipi.Insert, cmd);
            object deger= Tools.ExecScalar(cmd);
            return deger;
        }

        public DataTable KategorilerSelect()
        {
            SqlDataAdapter adp = new SqlDataAdapter(string.Format("prc_{0}Kategori_Select", ClassName), Tools.Baglanti);
            adp.SelectCommand.CommandType = CommandType.StoredProcedure;
            DataTable dt = new DataTable();
            adp.Fill(dt);
            return dt;
        }

        public DataTable Select()
        {
            SqlDataAdapter adp = new SqlDataAdapter(string.Format("prc_{0}_Select", ClassName), Tools.Baglanti);
            adp.SelectCommand.CommandType = CommandType.StoredProcedure;
            DataTable dt = new DataTable();
            adp.Fill(dt);
            return dt;
        }

        public bool Update(T entity)
        {
            SqlCommand cmd = new SqlCommand(string.Format("prc_{0}_Update", ClassName), Tools.Baglanti);
            cmd.CommandType = CommandType.StoredProcedure;

            Tools.Parametreler<T>(entity, KomutTipi.Update, cmd);

            return Tools.Exec(cmd);
        }
    }
}
