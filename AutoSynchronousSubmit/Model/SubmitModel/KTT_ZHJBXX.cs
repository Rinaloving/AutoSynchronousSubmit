
using NPoco;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Model.SubmitModel
{
    #region KTT_ZHJBXX
    /// <summary>
    ///  (KTT_ZHJBXX)
    /// </summary>
    [TableName("KTT_ZHJBXX")]
    [PrimaryKey("PID")]
    public class KTT_ZHJBXX
    {


        [Column("BSM")]
        public decimal BSM { get; set; }
        [Column("YSDM")]
        public string YSDM { get; set; }
        [Column("ZHDM")]
        public string ZHDM { get; set; }
        [Column("BDCDYH")]
        public string BDCDYH { get; set; }
        [Column("ZHTZM")]
        public string ZHTZM { get; set; }
        [Column("XMMC")]
        public string XMMC { get; set; }
        [Column("XMXZ")]
        public string XMXZ { get; set; }
        [Column("YHZMJ")]
        public decimal YHZMJ { get; set; }
        [Column("ZHMJ")]
        public decimal ZHMJ { get; set; }
        [Column("DB")]
        public string DB { get; set; }
        [Column("ZHAX")]
        public decimal ZHAX { get; set; }
        [Column("YHLXA")]
        public string YHLXA { get; set; }
        [Column("YHLXB")]
        public string YHLXB { get; set; }
        [Column("YHWZSM")]
        public string YHWZSM { get; set; }
        [Column("HDMC")]
        public string HDMC { get; set; }
        [Column("HDDM")]
        public string HDDM { get; set; }
        [Column("YDFW")]
        public string YDFW { get; set; }
        [Column("YDMJ")]
        public decimal YDMJ { get; set; }
        [Column("HDWZ")]
        public string HDWZ { get; set; }
        [Column("HDYT")]
        public string HDYT { get; set; }
        [Column("ZHT")]
        public string ZHT { get; set; }
        [Column("DAH")]
        public string DAH { get; set; }
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

        public KTT_ZHJBXX()
        {
        }






    }
    #endregion
}

