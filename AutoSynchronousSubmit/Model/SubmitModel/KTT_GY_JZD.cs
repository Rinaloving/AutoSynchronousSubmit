
using NPoco;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Model.SubmitModel
{
    #region KTT_GY_JZD
    /// <summary>
    ///  (KTT_GY_JZD)
    /// </summary>
    [TableName("KTT_GY_JZD")]
    [PrimaryKey("PID")]
    public class KTT_GY_JZD
    {


        [Column("BSM")]
        public decimal BSM { get; set; }
        [Column("ZDZHDM")]
        public string ZDZHDM { get; set; }
        [Column("YSDM")]
        public string YSDM { get; set; }
        [Column("JZDH")]
        public string JZDH { get; set; }
        [Column("SXH")]
        public decimal SXH { get; set; }
        [Column("JBLX")]
        public string JBLX { get; set; }
        [Column("JZDLX")]
        public string JZDLX { get; set; }
        [Column("XZBZ")]
        public decimal XZBZ { get; set; }
        [Column("YZBZ")]
        public decimal YZBZ { get; set; }
        [Column("QXDM")]
        public string QXDM { get; set; }
        [Column("PID")]
        public string PID { get; set; }
        [Column("CREATETIME")]
        public DateTime CREATETIME { get; set; }

        public KTT_GY_JZD()
        {
        }






    }
    #endregion
}

