
using NPoco;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Model.SubmitModel
{
    #region KTT_FW_LJZ
    /// <summary>
    ///  (KTT_FW_LJZ)
    /// </summary>
    [TableName("KTT_FW_LJZ")]
    [PrimaryKey("PID")]
    public class KTT_FW_LJZ
    {


        [Column("LJZH")]
        public string LJZH { get; set; }
        [Column("ZRZH")]
        public string ZRZH { get; set; }
        [Column("YSDM")]
        public string YSDM { get; set; }
        [Column("MPH")]
        public string MPH { get; set; }
        [Column("YCJZMJ")]
        public decimal YCJZMJ { get; set; }
        [Column("YCDXMJ")]
        public decimal YCDXMJ { get; set; }
        [Column("YCQTMJ")]
        public decimal YCQTMJ { get; set; }
        [Column("SCJZMJ")]
        public decimal SCJZMJ { get; set; }
        [Column("SCDXMJ")]
        public decimal SCDXMJ { get; set; }
        [Column("SCQTMJ")]
        public decimal SCQTMJ { get; set; }
        [Column("JGRQ")]
        public DateTime JGRQ { get; set; }
        [Column("FWJG1")]
        public string FWJG1 { get; set; }
        [Column("FWJG2")]
        public string FWJG2 { get; set; }
        [Column("FWJG3")]
        public string FWJG3 { get; set; }
        [Column("JZWZT")]
        public string JZWZT { get; set; }
        [Column("FWYT1")]
        public string FWYT1 { get; set; }
        [Column("FWYT2")]
        public string FWYT2 { get; set; }
        [Column("FWYT3")]
        public string FWYT3 { get; set; }
        [Column("ZCS")]
        public decimal ZCS { get; set; }
        [Column("DSCS")]
        public decimal DSCS { get; set; }
        [Column("DXCS")]
        public decimal DXCS { get; set; }
        [Column("BZ")]
        public string BZ { get; set; }
        [Column("QXDM")]
        public string QXDM { get; set; }
        [Column("PID")]
        public string PID { get; set; }
        [Column("CREATETIME")]
        public DateTime CREATETIME { get; set; }
        [Column("ZRZPID")]
        public string ZRZPID { get; set; }

        public KTT_FW_LJZ()
        {
        }






    }
    #endregion
}

