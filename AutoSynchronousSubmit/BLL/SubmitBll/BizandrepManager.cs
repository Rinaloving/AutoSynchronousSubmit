using DAL.SubmitDal;
using Model.SubmitModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL.SubmitBll
{
    public class BizandrepManager
    {

        private BizandrepDAL biz = new BizandrepDAL();

        public ICollection<BIZANDREP> Query(string sql)
        {
           
            return biz.Query(sql);
        }


    }
}
