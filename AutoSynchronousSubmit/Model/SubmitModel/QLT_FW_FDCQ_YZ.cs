
using NPoco;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Model.SubmitModel
{
    #region QLT_FW_FDCQ_YZ
    /// <summary>
    ///  (QLT_FW_FDCQ_YZ)
    /// </summary>
    [TableName("QLT_FW_FDCQ_YZ")]
    [PrimaryKey("PID")]
    public class QLT_FW_FDCQ_YZ
    {


        [Column("YSDM")]
        public string YSDM { get; set; }
        [Column("BDCDYH")]
        public string BDCDYH { get; set; }
        [Column("YWH")]
        public string YWH { get; set; }
        [Column("QLLX")]
        public string QLLX { get; set; }
        [Column("DJLX")]
        public string DJLX { get; set; }
        [Column("DJYY")]
        public string DJYY { get; set; }
        [Column("FDZL")]
        public string FDZL { get; set; }
        [Column("TDSYQR")]
        public string TDSYQR { get; set; }
        [Column("DYTDMJ")]
        public decimal DYTDMJ { get; set; }
        [Column("FTTDMJ")]
        public decimal FTTDMJ { get; set; }
        [Column("TDSYQSSJ")]
        public DateTime TDSYQSSJ { get; set; }
        [Column("TDSYJSSJ")]
        public DateTime TDSYJSSJ { get; set; }
        [Column("FDCJYJG")]
        public decimal FDCJYJG { get; set; }
        [Column("GHYT")]
        public string GHYT { get; set; }
        [Column("FWXZ")]
        public string FWXZ { get; set; }
        [Column("FWJG")]
        public string FWJG { get; set; }
        [Column("SZC")]
        public decimal SZC { get; set; }
        [Column("ZCS")]
        public decimal ZCS { get; set; }
        [Column("JZMJ")]
        public decimal JZMJ { get; set; }
        [Column("ZYJZMJ")]
        public decimal ZYJZMJ { get; set; }
        [Column("FTJZMJ")]
        public decimal FTJZMJ { get; set; }
        [Column("JGSJ")]
        public DateTime JGSJ { get; set; }
        [Column("BDCQZH")]
        public string BDCQZH { get; set; }
        [Column("QXDM")]
        public string QXDM { get; set; }
        [Column("DJJG")]
        public string DJJG { get; set; }
        [Column("DBR")]
        public string DBR { get; set; }
        [Column("DJSJ")]
        public DateTime DJSJ { get; set; }
        [Column("FJ")]
        public string FJ { get; set; }
        [Column("QSZT")]
        public string QSZT { get; set; }
        [Column("PID")]
        public string PID { get; set; }
        [Column("CREATETIME")]
        public DateTime CREATETIME { get; set; }

        public QLT_FW_FDCQ_YZ()
        {
        }






    }
    #endregion
}

