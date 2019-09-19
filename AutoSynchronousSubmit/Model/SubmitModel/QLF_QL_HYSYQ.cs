
using NPoco;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Model.SubmitModel
{
    #region QLF_QL_HYSYQ
    /// <summary>
    ///  (QLF_QL_HYSYQ)
    /// </summary>
    [TableName("QLF_QL_HYSYQ")]
    [PrimaryKey("PID")]
    public class QLF_QL_HYSYQ
    {


        [Column("YSDM")]
        public string YSDM { get; set; }
        [Column("ZHHDDM")]
        public string ZHHDDM { get; set; }
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
        [Column("SYQMJ")]
        public decimal SYQMJ { get; set; }
        [Column("SYQQSSJ")]
        public DateTime SYQQSSJ { get; set; }
        [Column("SYQJSSJ")]
        public DateTime SYQJSSJ { get; set; }
        [Column("SYJZE")]
        public decimal SYJZE { get; set; }
        [Column("SYJBZYJ")]
        public string SYJBZYJ { get; set; }
        [Column("SYJJNQK")]
        public string SYJJNQK { get; set; }
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

        public QLF_QL_HYSYQ()
        {
        }






    }
    #endregion
}

