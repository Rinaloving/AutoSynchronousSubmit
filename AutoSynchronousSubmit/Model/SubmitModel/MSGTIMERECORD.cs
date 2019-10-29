using NPoco;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model.SubmitModel
{
    [TableName("MSGTIMERECORD")]
    [PrimaryKey("PID")]
    public class MSGTIMERECORD
    {
        [Column("PID")]
        public string PID { get; set; }

        [Column("BDCDYH")]
        public string BDCDYH { get; set; }

        [Column("QXDM")]
        public string QXDM { get; set; }

        [Column("DJSJ")]
        public DateTime? DJSJ { get; set; }

        [Column("SLSJ")]
        public DateTime? SLSJ { get; set; }

        [Column("CREATETIME")]
        public DateTime? CREATETIME { get; set; }


    }
}
