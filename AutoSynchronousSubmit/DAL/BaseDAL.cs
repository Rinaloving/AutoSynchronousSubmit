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
            throw new NotImplementedException();
        }
    }
}