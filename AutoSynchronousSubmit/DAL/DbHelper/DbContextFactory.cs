﻿using NPoco;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.DbHelper
{
    /// <summary>
    /// 上下文对象单例工厂
    /// </summary>
    public class DbContextFactory
    {
        private static IDatabase db = null;

        public  static IDatabase ConnectSJOracleDb
        {
            get
            {
                if (db == null) db = new Database("sjsubmit"); // 连接配置必需要放在启动项的App.config配置文件里
                return db;
                
            }
        }

    }
}