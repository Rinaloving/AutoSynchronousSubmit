
using NPoco;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Model.SubmitModel
{
    #region QLF_QL_YGDJ
    /// <summary>
    ///  (QLF_QL_YGDJ)
    /// </summary>
    [TableName("QLF_QL_YGDJ")]
    [PrimaryKey("PID")]
    public class QLF_QL_YGDJ
    {


        [Column("YSDM")]
        public string YSDM { get; set; }
        [Column("BDCDYH")]
        public string BDCDYH { get; set; }
        [Column("YWH")]
        public string YWH { get; set; }
        [Column("SCYWH")]
        public string SCYWH { get; set; }
        [Column("BDCZL")]
        public string BDCZL { get; set; }
        [Column("YWR")]
        public string YWR { get; set; }
        [Column("YWRZJZL")]
        public string YWRZJZL { get; set; }
        [Column("YWRZJH")]
        public string YWRZJH { get; set; }
        [Column("YGDJZL")]
        public string YGDJZL { get; set; }
        [Column("DJLX")]
        public string DJLX { get; set; }
        [Column("DJYY")]
        public string DJYY { get; set; }
        [Column("TDSYQR")]
        public string TDSYQR { get; set; }
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
        [Column("QDJG")]
        public decimal QDJG { get; set; }
        [Column("BDCDJZMH")]
        public string BDCDJZMH { get; set; }
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

        public QLF_QL_YGDJ()
        {
        }






    }
    #endregion
}

