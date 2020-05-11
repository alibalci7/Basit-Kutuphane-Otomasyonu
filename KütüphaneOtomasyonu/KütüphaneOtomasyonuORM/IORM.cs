using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KütüphaneOtomasyonuORM
{
    public interface IORM<T> where T:class
    {
        DataTable Select();

        bool Insert(T entity);

        object InsertScalar(T entity);

        bool Update(T entity);

        bool Delete(T entity);

        DataTable EklmeKontrolSelect(T entity);

        DataTable KategorilerSelect();

        DataTable Bul(string kolon, string kelime);

    }
}
