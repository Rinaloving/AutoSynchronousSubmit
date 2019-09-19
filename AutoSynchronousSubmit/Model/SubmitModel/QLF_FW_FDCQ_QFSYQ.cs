
using NPoco;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Model.SubmitModel
{
    #region QLF_FW_FDCQ_QFSYQ
    /// <summary>
    ///  (QLF_FW_FDCQ_QFSYQ)
    /// </summary>
    [TableName("QLF_FW_FDCQ_QFSYQ")]
    [PrimaryKey("PID")]
    public class QLF_FW_FDCQ_QFSYQ
    {


        [Column("YSDM")]
        public string YSDM { get; set; }
        [Column("BDCDYH")]
        public string BDCDYH { get; set; }
        [Column("YWH")]
        public string YWH { get; set; }
        [Column("QLLX")]
        public string QLLX { get; set; }
        [Column("JGZWBH")]
        public string JGZWBH { get; set; }
        [Column("JGZWMC")]
        public string JGZWMC { get; set; }
        [Column("JGZWSL")]
        public int JGZWSL { get; set; }
        [Column("JGZWMJ")]
        public decimal JGZWMJ { get; set; }
        [Column("FTTDMJ")]
        public decimal FTTDMJ { get; set; }
        [Column("QXDM")]
        public string QXDM { get; set; }
        [Column("DJJG")]
        public string DJJG { get; set; }
        [Column("DJSJ")]
        public string DJSJ { get; set; }
        [Column("DBR")]
        public DateTime DBR { get; set; }
        [Column("FJ")]
        public string FJ { get; set; }
        [Column("QSZT")]
        public string QSZT { get; set; }
        [Column("PID")]
        public string PID { get; set; }
        [Column("CREATETIME")]
        public DateTime CREATETIME { get; set; }

        public QLF_FW_FDCQ_QFSYQ()
        {
        }






    }
    #endregion
}

