﻿using DAL.SubmitDal;
using Model.SubmitModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL.SubmitBll
{
    public class MsgtimerecordManager
    {

        private MsgtimerecordDAL ety = new MsgtimerecordDAL();
        public object Insert(string entityName, string pkey, bool b, dynamic endtity)
        {
            return ety.Insert(entityName, pkey, b, endtity);
        }

        public ICollection<MSGTIMERECORD> Query(string sql)
        {
            return ety.Query(sql);
        }
    }
}
