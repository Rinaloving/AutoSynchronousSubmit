using DAL.SubmitDal;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL.SubmitBll
{
    public class RnandcnManager
    {
        private RnandcnDAL ety = new RnandcnDAL();
        public object Insert(string entityName, string pkey, bool b, dynamic endtity)
        {
            return ety.Insert(entityName, pkey, b, endtity);
        }

    }
}
