
using NPoco;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Model.SubmitModel
{
    #region QLF_QL_ZXDJ
    /// <summary>
    ///  (QLF_QL_ZXDJ)
    /// </summary>
    [TableName("QLF_QL_ZXDJ")]
    [PrimaryKey("PID")]
    public class QLF_QL_ZXDJ
    {


        [Column("YSDM")]
        public string YSDM { get; set; }
        [Column("BDCDYH")]
        public string BDCDYH { get; set; }
        [Column("BDCQZH")]
        public string BDCQZH { get; set; }
        [Column("YWH")]
        public string YWH { get; set; }
        [Column("ZXYWH")]
        public string ZXYWH { get; set; }
        [Column("ZXSJ")]
        public DateTime ZXSJ { get; set; }
        [Column("QXDM")]
        public string QXDM { get; set; }
        [Column("DJJG")]
        public string DJJG { get; set; }
        [Column("DBR")]
        public string DBR { get; set; }
        [Column("DJSJ")]
        public DateTime DJSJ { get; set; }
        [Column("BZ")]
        public string BZ { get; set; }
        [Column("PID")]
        public string PID { get; set; }
        [Column("CREATETIME")]
        public DateTime CREATETIME { get; set; }

        public QLF_QL_ZXDJ()
        {
        }






    }
    #endregion
}

