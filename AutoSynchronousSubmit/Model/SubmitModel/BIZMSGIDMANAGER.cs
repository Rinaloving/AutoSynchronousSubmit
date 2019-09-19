using NPoco;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model.SubmitModel
{

    [TableName("BIZMSGIDMANAGER")]
    [PrimaryKey("PID")]
    public class BIZMSGIDMANAGER
    {
        [Column("PID")]
        public string PID { get; set; }
        [Column("QXDM")]
        public string QXDM { get; set; }
        [Column("YYMMDD")]
        public string YYMMDD { get; set; }
        [Column("FLOWID")]
        public decimal FLOWID { get; set; }

        public BIZMSGIDMANAGER()
        {
        }


    }
}
