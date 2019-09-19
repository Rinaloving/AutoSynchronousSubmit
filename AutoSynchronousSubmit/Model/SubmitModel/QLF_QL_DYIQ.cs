
using NPoco;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Model.SubmitModel
{
    #region QLF_QL_DYIQ
    /// <summary>
    ///  (QLF_QL_DYIQ)
    /// </summary>
    [TableName("QLF_QL_DYIQ")]
    [PrimaryKey("PID")]
    public class QLF_QL_DYIQ
    {


        [Column("YSDM")]
        public string YSDM { get; set; }
        [Column("YWH")]
        public string YWH { get; set; }
        [Column("GYDBDCDYH")]
        public string GYDBDCDYH { get; set; }
        [Column("GYDQLR")]
        public string GYDQLR { get; set; }
        [Column("GYDQLRZJZL")]
        public string GYDQLRZJZL { get; set; }
        [Column("GYDQLRZJH")]
        public string GYDQLRZJH { get; set; }
        [Column("XYDBDCDYH")]
        public string XYDBDCDYH { get; set; }
        [Column("XYDZL")]
        public string XYDZL { get; set; }
        [Column("XYDQLR")]
        public string XYDQLR { get; set; }
        [Column("XYDQLRZJZL")]
        public string XYDQLRZJZL { get; set; }
        [Column("XYDQLRZJZH")]
        public string XYDQLRZJZH { get; set; }
        [Column("DJLX")]
        public string DJLX { get; set; }
        [Column("DJYY")]
        public string DJYY { get; set; }
        [Column("DYQNR")]
        public string DYQNR { get; set; }
        [Column("BDCDJZMH")]
        public string BDCDJZMH { get; set; }
        [Column("QLQSSJ")]
        public DateTime QLQSSJ { get; set; }
        [Column("QLJSSJ")]
        public DateTime QLJSSJ { get; set; }
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

        public QLF_QL_DYIQ()
        {
        }






    }
    #endregion
}

