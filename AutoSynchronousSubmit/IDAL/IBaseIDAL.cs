using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IDAL
{
    public interface IBaseIDAL<T> where T : class
    {
        IQueryable<T> Select();


        ICollection<T> Query(string sql);

        T Select(int key);

        int Insert(T entity);

        object Insert(string entityName, string pkey, bool b, T endtity);


        int Update(T entity);

        int Delete(T entity);


    }
}
