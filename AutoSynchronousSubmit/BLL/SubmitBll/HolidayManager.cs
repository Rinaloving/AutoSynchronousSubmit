using DAL.SubmitDal;
using Entitys;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL.SubmitBll
{
    public class HolidayManager
    {
        private HolidayDAL hd = new HolidayDAL();

        public ICollection<HOLIDAY> Query(string sql)
        {

            return hd.Query(sql);
        }


    }
}
