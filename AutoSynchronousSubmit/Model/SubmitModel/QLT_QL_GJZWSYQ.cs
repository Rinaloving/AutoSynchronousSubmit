
using NPoco;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Model.SubmitModel
{
    #region QLT_QL_GJZWSYQ
    /// <summary>
    ///  (QLT_QL_GJZWSYQ)
    /// </summary>
    [TableName("QLT_QL_GJZWSYQ")]
    [PrimaryKey("PID")]
    public class QLT_QL_GJZWSYQ
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
        [Column("TDHYSYQR")]
        public string TDHYSYQR { get; set; }
        [Column("TDHYSYMJ")]
        public decimal TDHYSYMJ { get; set; }
        [Column("TDHYSYQSSJ")]
        public DateTime TDHYSYQSSJ { get; set; }
        [Column("TDHYSYJSSJ")]
        public DateTime TDHYSYJSSJ { get; set; }
        [Column("GJZWLX")]
        public string GJZWLX { get; set; }
        [Column("GJZWGHYH")]
        public string GJZWGHYH { get; set; }
        [Column("GJZWMJ")]
        public decimal GJZWMJ { get; set; }
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
        [Column("GJZWPMT")]
        public byte[] GJZWPMT { get; set; }
        [Column("QSZT")]
        public string QSZT { get; set; }
        [Column("PID")]
        public string PID { get; set; }
        [Column("CREATETIME")]
        public DateTime CREATETIME { get; set; }

        public QLT_QL_GJZWSYQ()
        {
        }






    }
    #endregion
}

