using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.SubmitDal
{
    public class EntityDAL:BaseDAL<dynamic>
    {
        public new object Insert(string entityName, string pkey, bool b, dynamic endtity)
        {
            return context.Insert(entityName, pkey, b, endtity);
        }


    }
}
