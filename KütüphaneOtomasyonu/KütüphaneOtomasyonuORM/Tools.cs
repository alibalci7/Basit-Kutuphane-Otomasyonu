using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Configuration;
using System.Data;
using System.Reflection;

namespace KütüphaneOtomasyonuORM
{
    public class Tools
    {
        private static SqlConnection baglanti;

        public static SqlConnection Baglanti
        {
            get
            {
                if (baglanti == null)
                {
                    baglanti = new SqlConnection(ConfigurationManager.ConnectionStrings["Baglanti"].ConnectionString);
                }                
                return baglanti;
            }
        }

        public static bool Exec(SqlCommand cmd)
        {
            try
            {
                if (cmd.Connection.State != ConnectionState.Open)
                {
                    cmd.Connection.Open();
                }
                int etk = cmd.ExecuteNonQuery();

                return etk > 0 ? true : false;
            }
            catch
            {
                return false;
            }
            finally
            {
                if (cmd.Connection.State != ConnectionState.Closed)
                {
                    cmd.Connection.Close();
                }
            }
            
        }

        public static object ExecScalar(SqlCommand cmd)
        {
            try
            {
                if (cmd.Connection.State != ConnectionState.Open)
                {
                    cmd.Connection.Open();
                }

                object deger= cmd.ExecuteScalar();
                return deger;
            }
            catch
            {
                return 0;
            }
            finally
            {
                if (cmd.Connection.State != ConnectionState.Closed)
                {
                    cmd.Connection.Close();
                }
            }
        }

        public static void Parametreler<T>(T entity, KomutTipi kt, SqlCommand cmd)
        {
            PropertyInfo[] pis = typeof(T).GetProperties();
            foreach (PropertyInfo pi in pis)
            {
                string name = pi.Name;
                if (name == "Id" && kt==KomutTipi.Insert)
                {
                    continue;
                }
                else if (name!= "Id" && kt == KomutTipi.Delete)
                {
                    continue;
                }
                object val = pi.GetValue(entity);
                cmd.Parameters.AddWithValue("@" + name, val);
            }
        }

        public static void Parametreler<T>(T entity, SqlDataAdapter adp)
        {
            PropertyInfo[] pis = typeof(T).GetProperties();
            foreach (PropertyInfo pi in pis)
            {
                string name = pi.Name;
                if (name == "Id")
                {
                    continue;
                }
                object val = pi.GetValue(entity);
                adp.SelectCommand.Parameters.AddWithValue("@" + name, val);
            }
        
        }

    }
}
