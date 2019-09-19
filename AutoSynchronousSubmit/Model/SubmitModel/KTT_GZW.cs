
using NPoco;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Model.SubmitModel
{
    #region KTT_GZW
    /// <summary>
    ///  (KTT_GZW)
    /// </summary>
    [TableName("KTT_GZW")]
    [PrimaryKey("PID")]
    public class KTT_GZW
    {


        [Column("BSM")]
        public decimal BSM { get; set; }
        [Column("YSDM")]
        public string YSDM { get; set; }
        [Column("BDCDYH")]
        public string BDCDYH { get; set; }
        [Column("ZDZHDM")]
        public string ZDZHDM { get; set; }
        [Column("GZWMC")]
        public string GZWMC { get; set; }
        [Column("ZL")]
        public string ZL { get; set; }
        [Column("MJDW")]
        public string MJDW { get; set; }
        [Column("MJ")]
        public decimal MJ { get; set; }
        [Column("DAH")]
        public string DAH { get; set; }
        [Column("ZT")]
        public string ZT { get; set; }
        [Column("PID")]
        public string PID { get; set; }
        [Column("CREATETIME")]
        public DateTime CREATETIME { get; set; }

        public KTT_GZW()
        {
        }






    }
    #endregion
}

