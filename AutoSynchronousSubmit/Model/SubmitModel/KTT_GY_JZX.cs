
using NPoco;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Model.SubmitModel
{
    #region KTT_GY_JZX
    /// <summary>
    ///  (KTT_GY_JZX)
    /// </summary>
    [TableName("KTT_GY_JZX")]
    [PrimaryKey("PID")]
    public class KTT_GY_JZX
    {


        [Column("BSM")]
        public decimal BSM { get; set; }
        [Column("ZDZHDM")]
        public string ZDZHDM { get; set; }
        [Column("YSDM")]
        public string YSDM { get; set; }
        [Column("JZXCD")]
        public decimal JZXCD { get; set; }
        [Column("JZXLB")]
        public string JZXLB { get; set; }
        [Column("JZXWZ")]
        public string JZXWZ { get; set; }
        [Column("JXXZ")]
        public string JXXZ { get; set; }
        [Column("QSJXXYSBH")]
        public string QSJXXYSBH { get; set; }
        [Column("QSJXXYS")]
        public string QSJXXYS { get; set; }
        [Column("QSZYYYSBH")]
        public string QSZYYYSBH { get; set; }
        [Column("QSZYYYS")]
        public string QSZYYYS { get; set; }
        [Column("PID")]
        public string PID { get; set; }
        [Column("CREATETIME")]
        public DateTime CREATETIME { get; set; }

        public KTT_GY_JZX()
        {
        }






    }
    #endregion
}

