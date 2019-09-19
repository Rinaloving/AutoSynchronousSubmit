
using NPoco;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Model.SubmitModel
{
    #region KTT_ZDJBXX
    /// <summary>
    ///  (KTT_ZDJBXX)
    /// </summary>
    [TableName("KTT_ZDJBXX")]
    [PrimaryKey("PID")]
    public class KTT_ZDJBXX
    {


        [Column("BSM")]
        public decimal BSM { get; set; }
        [Column("YSDM")]
        public string YSDM { get; set; }
        [Column("ZDDM")]
        public string ZDDM { get; set; }
        [Column("BDCDYH")]
        public string BDCDYH { get; set; }
        [Column("ZDTZM")]
        public string ZDTZM { get; set; }
        [Column("ZL")]
        public string ZL { get; set; }
        [Column("ZDMJ")]
        public decimal ZDMJ { get; set; }
        [Column("MJDW")]
        public string MJDW { get; set; }
        [Column("YT")]
        public string YT { get; set; }
        [Column("DJ")]
        public string DJ { get; set; }
        [Column("JG")]
        public decimal JG { get; set; }
        [Column("QLLX")]
        public string QLLX { get; set; }
        [Column("QLXZ")]
        public string QLXZ { get; set; }
        [Column("QLSDFS")]
        public string QLSDFS { get; set; }
        [Column("RJL")]
        public decimal RJL { get; set; }
        [Column("JZMD")]
        public decimal JZMD { get; set; }
        [Column("JZXG")]
        public decimal JZXG { get; set; }
        [Column("ZDSZD")]
        public string ZDSZD { get; set; }
        [Column("ZDSZN")]
        public string ZDSZN { get; set; }
        [Column("ZDSZX")]
        public string ZDSZX { get; set; }
        [Column("ZDSZB")]
        public string ZDSZB { get; set; }
        [Column("ZDT")]
        public string ZDT { get; set; }
        [Column("TFH")]
        public string TFH { get; set; }
        [Column("DJH")]
        public string DJH { get; set; }
        [Column("DAH")]
        public string DAH { get; set; }
        [Column("BZ")]
        public string BZ { get; set; }
        [Column("ZT")]
        public string ZT { get; set; }
        [Column("QXDM")]
        public string QXDM { get; set; }
        [Column("DJSJ")]
        public DateTime DJSJ { get; set; }
        [Column("DBR")]
        public string DBR { get; set; }
        [Column("FJ")]
        public string FJ { get; set; }
        [Column("DJJGBM")]
        public string DJJGBM { get; set; }
        [Column("DJJGMC")]
        public string DJJGMC { get; set; }
        [Column("JDH")]
        public string JDH { get; set; }
        [Column("JFH")]
        public string JFH { get; set; }
        [Column("ZH")]
        public string ZH { get; set; }
        [Column("PID")]
        public string PID { get; set; }
        [Column("CREATETIME")]
        public DateTime CREATETIME { get; set; }

        public KTT_ZDJBXX()
        {
        }






    }
    #endregion
}

