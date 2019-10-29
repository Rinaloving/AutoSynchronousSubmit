using Model.SubmitModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.SubmitDal
{
    public class MsgtimerecordDAL : BaseDAL<MSGTIMERECORD>
    {

        public new object Insert(string tablename, string pkey, bool b, MSGTIMERECORD endtity)
        {
            return context.Insert(tablename, pkey, b, endtity);
        }

        public new ICollection<MSGTIMERECORD> Query(string sql)
        {
            return context.Fetch<MSGTIMERECORD>(sql);
        }
    }
}
