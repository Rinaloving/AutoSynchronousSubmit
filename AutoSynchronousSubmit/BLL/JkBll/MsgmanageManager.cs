using AutoSubmit.JkModel;
using DAL.JkDal;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL.JkBll
{
    public class MsgmanageManager
    {
        private MsgmanageDAL msg = new MsgmanageDAL();

        public ICollection<MSGMANAGE> Query(string sql)
        {

            return msg.Query(sql);
        }


    }
}
