using DAL.DbHelper;
using Model.SubmitModel;
using NPoco;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.SubmitDal
{
    public class BizandrepDAL : BaseDAL<BIZANDREP>
    {

        public new ICollection<BIZANDREP> Query(string sql)
        {
            return context.Fetch<BIZANDREP>(sql);
        }


    }
}
