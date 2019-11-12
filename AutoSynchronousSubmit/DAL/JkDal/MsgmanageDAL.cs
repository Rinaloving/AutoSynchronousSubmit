using AutoSubmit.JkModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.JkDal
{
    public class MsgmanageDAL :  JKBaseDAL<MSGMANAGE>
    {

        public new ICollection<MSGMANAGE> Query(string sql)
        {
            return context.Fetch<MSGMANAGE>(sql);
        }
    }
}
