
using NPoco;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Model.SubmitModel
{
    #region QLF_QL_DYAQ
    /// <summary>
    ///  (QLF_QL_DYAQ)
    /// </summary>
    [TableName("QLF_QL_DYAQ")]
    [PrimaryKey("PID")]
    public class QLF_QL_DYAQ
    {


        [Column("YSDM")]
        public string YSDM { get; set; }
        [Column("BDCDYH")]
        public string BDCDYH { get; set; }
        [Column("SCYWH")]
        public string SCYWH { get; set; }
        [Column("DYJELX")]
        public string DYJELX { get; set; }
        [Column("YWH")]
        public string YWH { get; set; }
        [Column("DYBDCLX")]
        public string DYBDCLX { get; set; }
        [Column("DYR")]
        public string DYR { get; set; }
        [Column("DYFS")]
        public string DYFS { get; set; }
        [Column("DJLX")]
        public string DJLX { get; set; }
        [Column("DJYY")]
        public string DJYY { get; set; }
        [Column("ZJJZWZL")]
        public string ZJJZWZL { get; set; }
        [Column("ZJJZWDYFW")]
        public string ZJJZWDYFW { get; set; }
        [Column("BDBZZQSE")]
        public decimal BDBZZQSE { get; set; }
        [Column("ZWLXQSSJ")]
        public DateTime ZWLXQSSJ { get; set; }
        [Column("ZWLXJSSJ")]
        public DateTime ZWLXJSSJ { get; set; }
        [Column("ZGZQQDSS")]
        public string ZGZQQDSS { get; set; }
        [Column("ZGZQSE")]
        public decimal ZGZQSE { get; set; }
        [Column("ZXDYYWH")]
        public string ZXDYYWH { get; set; }
        [Column("ZXDYYY")]
        public string ZXDYYY { get; set; }
        [Column("ZXSJ")]
        public DateTime ZXSJ { get; set; }
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

        public QLF_QL_DYAQ()
        {
        }






    }
    #endregion
}

