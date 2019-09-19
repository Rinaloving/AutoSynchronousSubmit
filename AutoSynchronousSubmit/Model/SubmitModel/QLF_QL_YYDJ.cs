
using NPoco;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Model.SubmitModel
{
    #region QLF_QL_YYDJ
    /// <summary>
    ///  (QLF_QL_YYDJ)
    /// </summary>
    [TableName("QLF_QL_YYDJ")]
    [PrimaryKey("PID")]
    public class QLF_QL_YYDJ
    {


        [Column("YSDM")]
        public string YSDM { get; set; }
        [Column("BDCDYH")]
        public string BDCDYH { get; set; }
        [Column("YWH")]
        public string YWH { get; set; }
        [Column("YYSX")]
        public string YYSX { get; set; }
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
        [Column("ZXYYYWH")]
        public string ZXYYYWH { get; set; }
        [Column("ZXYYYY")]
        public string ZXYYYY { get; set; }
        [Column("ZXYYDBR")]
        public string ZXYYDBR { get; set; }
        [Column("ZXYYDJSJ")]
        public DateTime ZXYYDJSJ { get; set; }
        [Column("FJ")]
        public string FJ { get; set; }
        [Column("QSZT")]
        public string QSZT { get; set; }
        [Column("PID")]
        public string PID { get; set; }
        [Column("CREATETIME")]
        public DateTime CREATETIME { get; set; }

        public QLF_QL_YYDJ()
        {
        }






    }
    #endregion
}

