using NPoco;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model.SubmitModel
{
    [TableName("KTT_FW_ZRZ")]
    [PrimaryKey("PID")]
    public class KTT_FW_ZRZ
    {
       
        [Column("BSM")]
        public decimal BSM { get; set; }
        [Column("YSDM")]
        public string YSDM { get; set; }
        [Column("BDCDYH")]
        public string BDCDYH { get; set; }
        [Column("ZDDM")]
        public string ZDDM { get; set; }
        [Column("ZRZH")]
        public string ZRZH { get; set; }
        [Column("XMMC")]
        public string XMMC { get; set; }
        [Column("JZWMC")]
        public string JZWMC { get; set; }
        [Column("JGRQ")]
        public DateTime JGRQ { get; set; }
        [Column("JZWGD")]
        public decimal JZWGD { get; set; }
        [Column("ZZDMJ")]
        public decimal ZZDMJ { get; set; }
        [Column("ZYDMJ")]
        public decimal ZYDMJ { get; set; }
        [Column("YCJZMJ")]
        public decimal YCJZMJ { get; set; }
        [Column("SCJZMJ")]
        public decimal SCJZMJ { get; set; }
        [Column("ZCS")]
        public decimal ZCS { get; set; }
        [Column("DSCS")]
        public decimal DSCS { get; set; }
        [Column("DXCS")]
        public decimal DXCS { get; set; }
        [Column("DXSD")]
        public decimal DXSD { get; set; }
        [Column("GHYT")]
        public string GHYT { get; set; }
        [Column("FWJG")]
        public string FWJG { get; set; }
        [Column("ZTS")]
        public int ZTS { get; set; }
        [Column("JZWJBYT")]
        public string JZWJBYT { get; set; }
        [Column("DAH")]
        public string DAH { get; set; }
        [Column("BZ")]
        public string BZ { get; set; }
        [Column("ZT")]
        public string ZT { get; set; }
        [Column("QXDM")]
        public string QXDM { get; set; }

        [Column("PID")]
        public string PID { get; set; }
        [Column("CREATETIME")]
        public DateTime CREATETIME { get; set; }

        public KTT_FW_ZRZ()
        {
        }



    }
}
