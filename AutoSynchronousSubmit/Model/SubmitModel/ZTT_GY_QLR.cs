
using NPoco;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Model.SubmitModel
{
    #region ZTT_GY_QLR
    /// <summary>
    ///  (ZTT_GY_QLR)
    /// </summary>
    [TableName("ZTT_GY_QLR")]
    [PrimaryKey("PID")]
    public class ZTT_GY_QLR
    {


        [Column("YSDM")]
        public string YSDM { get; set; }
        [Column("BDCDYH")]
        public string BDCDYH { get; set; }
        [Column("SXH")]
        public decimal SXH { get; set; }
        [Column("QLRMC")]
        public string QLRMC { get; set; }
        [Column("BDCQZH")]
        public string BDCQZH { get; set; }
        [Column("QZYSXLH")]
        public string QZYSXLH { get; set; }
        [Column("SFCZR")]
        public string SFCZR { get; set; }
        [Column("ZJZL")]
        public string ZJZL { get; set; }
        [Column("ZJH")]
        public string ZJH { get; set; }
        [Column("FZJG")]
        public string FZJG { get; set; }
        [Column("SSHY")]
        public string SSHY { get; set; }
        [Column("GJ")]
        public string GJ { get; set; }
        [Column("HJSZSS")]
        public string HJSZSS { get; set; }
        [Column("XB")]
        public string XB { get; set; }
        [Column("DH")]
        public string DH { get; set; }
        [Column("DZ")]
        public string DZ { get; set; }
        [Column("YB")]
        public string YB { get; set; }
        [Column("GZDW")]
        public string GZDW { get; set; }
        [Column("DZYJ")]
        public string DZYJ { get; set; }
        [Column("QLRLX")]
        public string QLRLX { get; set; }
        [Column("QLBL")]
        public string QLBL { get; set; }
        [Column("GYFS")]
        public string GYFS { get; set; }
        [Column("GYQK")]
        public string GYQK { get; set; }
        [Column("BZ")]
        public string BZ { get; set; }
        [Column("QXDM")]
        public string QXDM { get; set; }
        [Column("CASENUM")]
        public string CASENUM { get; set; }
        [Column("PID")]
        public string PID { get; set; }
        [Column("CREATETIME")]
        public DateTime CREATETIME { get; set; }

        public ZTT_GY_QLR()
        {
        }






    }
    #endregion
}

