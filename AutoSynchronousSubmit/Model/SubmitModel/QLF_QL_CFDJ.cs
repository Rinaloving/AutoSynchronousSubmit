
using NPoco;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Model.SubmitModel
{
    #region QLF_QL_CFDJ
    /// <summary>
    ///  (QLF_QL_CFDJ)
    /// </summary>
    [TableName("QLF_QL_CFDJ")]
    [PrimaryKey("PID")]
    public class QLF_QL_CFDJ
    {


        [Column("YSDM")]
        public string YSDM { get; set; }
        [Column("BDCDYH")]
        public string BDCDYH { get; set; }
        [Column("YWH")]
        public string YWH { get; set; }
        [Column("CFJG")]
        public string CFJG { get; set; }
        [Column("CFLX")]
        public string CFLX { get; set; }
        [Column("CFWJ")]
        public string CFWJ { get; set; }
        [Column("CFWH")]
        public string CFWH { get; set; }
        [Column("CFQSSJ")]
        public DateTime CFQSSJ { get; set; }
        [Column("CFJSSJ")]
        public DateTime CFJSSJ { get; set; }
        [Column("CFFW")]
        public string CFFW { get; set; }
        [Column("QXDM")]
        public string QXDM { get; set; }
        [Column("DJJG")]
        public string DJJG { get; set; }
        [Column("DBR")]
        public string DBR { get; set; }
        [Column("DJSJ")]
        public DateTime DJSJ { get; set; }
        [Column("JFYWH")]
        public string JFYWH { get; set; }
        [Column("JFJG")]
        public string JFJG { get; set; }
        [Column("JFWJ")]
        public string JFWJ { get; set; }
        [Column("JFWH")]
        public string JFWH { get; set; }
        [Column("JFDBR")]
        public string JFDBR { get; set; }
        [Column("JFDJSJ")]
        public DateTime JFDJSJ { get; set; }
        [Column("FJ")]
        public string FJ { get; set; }
        [Column("QSZT")]
        public string QSZT { get; set; }
        [Column("PID")]
        public string PID { get; set; }
        [Column("CREATETIME")]
        public DateTime CREATETIME { get; set; }

        public QLF_QL_CFDJ()
        {
        }






    }
    #endregion
}

