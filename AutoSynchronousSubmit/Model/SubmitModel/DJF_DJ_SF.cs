
using NPoco;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Model.SubmitModel
{
    #region DJF_DJ_SF
    /// <summary>
    ///  (DJF_DJ_SF)
    /// </summary>
    [TableName("DJF_DJ_SF")]
    [PrimaryKey("PID")]
    public class DJF_DJ_SF
    {


        [Column("YWH")]
        public string YWH { get; set; }
        [Column("YSDM")]
        public string YSDM { get; set; }
        [Column("JFRY")]
        public string JFRY { get; set; }
        [Column("JFRQ")]
        public DateTime JFRQ { get; set; }
        [Column("SFKMMC")]
        public string SFKMMC { get; set; }
        [Column("SFEWSF")]
        public string SFEWSF { get; set; }
        [Column("SFJS")]
        public decimal SFJS { get; set; }
        [Column("SFLX")]
        public string SFLX { get; set; }
        [Column("YSJE")]
        public decimal YSJE { get; set; }
        [Column("ZKHYSJE")]
        public decimal ZKHYSJE { get; set; }
        [Column("SFRY")]
        public string SFRY { get; set; }
        [Column("SFRQ")]
        public DateTime SFRQ { get; set; }
        [Column("FFF")]
        public string FFF { get; set; }
        [Column("SJFFR")]
        public string SJFFR { get; set; }
        [Column("SSJE")]
        public decimal SSJE { get; set; }
        [Column("SFDW")]
        public string SFDW { get; set; }
        [Column("QXDM")]
        public string QXDM { get; set; }
        [Column("PID")]
        public string PID { get; set; }
        [Column("CREATETIME")]
        public DateTime CREATETIME { get; set; }

        public DJF_DJ_SF()
        {
        }






    }
    #endregion
}

