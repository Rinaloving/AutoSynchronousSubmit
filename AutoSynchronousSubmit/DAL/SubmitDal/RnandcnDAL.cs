using Model.SubmitModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.SubmitDal
{
    public class RnandcnDAL : BaseDAL<RNANDCN>
    {
        public new object Insert(string tablename, string pkey, bool b, RNANDCN endtity)
        {
            return context.Insert(tablename, pkey, b, endtity);
        }


    }
}
