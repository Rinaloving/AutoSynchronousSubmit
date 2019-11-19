using Entitys;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.SubmitDal
{
    public class HolidayDAL : BaseDAL<HOLIDAY>
    {

        public new ICollection<HOLIDAY> Query(string sql)
        {
            return context.Fetch<HOLIDAY>(sql);
        }
    }
}
