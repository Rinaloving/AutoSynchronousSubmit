using NPoco;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model.SubmitModel
{
    [TableName("RNANDCN")]
    [PrimaryKey("PID")]
    public class RNANDCN
    {
        //[Column("PID")]
        public string PID { get; set; }
        [Column("REALEUNUM")]
        public string REALEUNUM { get; set; }

        [Column("YWH")]
        public string YWH { get; set; }
        [Column("JRYWBM")]
        public string JRYWBM { get; set; }
        [Column("SCYWH")]
        public string SCYWH { get; set; }
        [Column("QXDM")]
        public string QXDM { get; set; }
        [Column("CREATETIME")]
        public DateTime CREATETIME { get; set; }
        [Column("SFSB")]
        public decimal SFSB { get; set; }

        [Column("CHECKMESSAGE")]
        public string CHECKMESSAGE { get; set; }

        public RNANDCN()
        {
        }

    }
}
