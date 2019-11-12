﻿using DAL.DbHelper;
using IDAL;
using NPoco;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public abstract class BaseDAL<T> : IBaseIDAL<T> where T : class
    {

        protected IDatabase context = DbContextFactory.ConnectSJOracleDb;

        public int Delete(T entity)
        {
            throw new NotImplementedException();
        }

        public int Insert(T entity)
        {
            throw new NotImplementedException();
        }

        public object Insert(string entityName, string pkey, bool b, T endtity)
        {
            return context.Insert(entityName,pkey,b,endtity);
        }

        public ICollection<T> Query(string sql)
        {
           return context.Fetch<T>(sql);
        }

        public IQueryable<T> Select()
        {
            throw new NotImplementedException();
        }

        public T Select(int key)
        {
            throw new NotImplementedException();
        }

        public int Update(T entity)
        {
            return context.Update(entity);
        }

        public int Update(object poco, object primaryKeyValue, IEnumerable<string> columns)
        {
            return context.Update(poco,primaryKeyValue,columns);
        }
    }
}
