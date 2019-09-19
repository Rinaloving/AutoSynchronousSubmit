
using NPoco;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Model.SubmitModel
{
    #region QLF_QL_NYDSYQ
    /// <summary>
    ///  (QLF_QL_NYDSYQ)
    /// </summary>
    [TableName("QLF_QL_NYDSYQ")]
    [PrimaryKey("PID")]
    public class QLF_QL_NYDSYQ
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
        [Column("ZL")]
        public string ZL { get; set; }
        [Column("FBFDM")]
        public string FBFDM { get; set; }
        [Column("FBFMC")]
        public string FBFMC { get; set; }
        [Column("CBMJ")]
        public decimal CBMJ { get; set; }
        [Column("CBQSSJ")]
        public DateTime CBQSSJ { get; set; }
        [Column("CBJSSJ")]
        public DateTime CBJSSJ { get; set; }
        [Column("TDSYQXZ")]
        public string TDSYQXZ { get; set; }
        [Column("SYTTLX")]
        public string SYTTLX { get; set; }
        [Column("YZYFS")]
        public string YZYFS { get; set; }
        [Column("CYZL")]
        public string CYZL { get; set; }
        [Column("SYZCL")]
        public decimal SYZCL { get; set; }
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

        public QLF_QL_NYDSYQ()
        {
        }






    }
    #endregion
}

