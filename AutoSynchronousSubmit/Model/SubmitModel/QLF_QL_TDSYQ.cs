
using NPoco;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Model.SubmitModel
{
    #region QLF_QL_TDSYQ
    /// <summary>
    ///  (QLF_QL_TDSYQ)
    /// </summary>
    [TableName("QLF_QL_TDSYQ")]
    [PrimaryKey("PID")]
    public class QLF_QL_TDSYQ
    {


        [Column("YSDM")]
        public string YSDM { get; set; }
        [Column("ZDDM")]
        public string ZDDM { get; set; }
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
        [Column("MJDW")]
        public string MJDW { get; set; }
        [Column("NYDMJ")]
        public decimal NYDMJ { get; set; }
        [Column("GDMJ")]
        public decimal GDMJ { get; set; }
        [Column("LDMJ")]
        public decimal LDMJ { get; set; }
        [Column("CDMJ")]
        public decimal CDMJ { get; set; }
        [Column("QTNYDMJ")]
        public decimal QTNYDMJ { get; set; }
        [Column("JSYDMJ")]
        public decimal JSYDMJ { get; set; }
        [Column("WLYDMJ")]
        public decimal WLYDMJ { get; set; }
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
        [Column("PID")]
        public string PID { get; set; }
        [Column("CREATETIME")]
        public DateTime CREATETIME { get; set; }

        public QLF_QL_TDSYQ()
        {
        }






    }
    #endregion
}

