
using NPoco;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Model.SubmitModel
{
    #region QLF_FW_FDCQ_DZ_XM
    /// <summary>
    ///  (QLF_FW_FDCQ_DZ_XM)
    /// </summary>
    [TableName("QLF_FW_FDCQ_DZ_XM")]
    [PrimaryKey("PID")]
    public class QLF_FW_FDCQ_DZ_XM
    {


        [Column("BDCDYH")]
        public string BDCDYH { get; set; }
        [Column("ZH")]
        public string ZH { get; set; }
        [Column("XMMC")]
        public string XMMC { get; set; }
        [Column("ZCS")]
        public decimal ZCS { get; set; }
        [Column("GHYT")]
        public string GHYT { get; set; }
        [Column("FWJG")]
        public string FWJG { get; set; }
        [Column("JZMJ")]
        public decimal JZMJ { get; set; }
        [Column("JGSJ")]
        public DateTime JGSJ { get; set; }
        [Column("ZTS")]
        public decimal ZTS { get; set; }
        [Column("QXDM")]
        public string QXDM { get; set; }
        [Column("PID")]
        public string PID { get; set; }
        [Column("CREATETIME")]
        public DateTime CREATETIME { get; set; }

        public QLF_FW_FDCQ_DZ_XM()
        {
        }






    }
    #endregion
}

