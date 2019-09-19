
using NPoco;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Model.SubmitModel
{
    #region DJT_DJ_SLSQ
    /// <summary>
    ///  (DJT_DJ_SLSQ)
    /// </summary>
    [TableName("DJT_DJ_SLSQ")]
    [PrimaryKey("PID")]
    public class DJT_DJ_SLSQ
    {


        [Column("YSDM")]
        public string YSDM { get; set; }
        [Column("YWH")]
        public string YWH { get; set; }
        [Column("DJDL")]
        public string DJDL { get; set; }
        [Column("DJXL")]
        public string DJXL { get; set; }
        [Column("QXDM")]
        public string QXDM { get; set; }
        [Column("SQZSBS")]
        public byte SQZSBS { get; set; }
        [Column("SQFBCZ")]
        public byte SQFBCZ { get; set; }
        [Column("SLRY")]
        public string SLRY { get; set; }
        [Column("SLSJ")]
        public DateTime SLSJ { get; set; }
        [Column("ZL")]
        public string ZL { get; set; }
        [Column("TZRXM")]
        public string TZRXM { get; set; }
        [Column("TZFS")]
        public string TZFS { get; set; }
        [Column("TZRDH")]
        public string TZRDH { get; set; }
        [Column("TZRYDDH")]
        public string TZRYDDH { get; set; }
        [Column("TZRDZYJ")]
        public string TZRDZYJ { get; set; }
        [Column("SFWTAJ")]
        public string SFWTAJ { get; set; }
        [Column("JSSJ")]
        public DateTime JSSJ { get; set; }
        [Column("AJZT")]
        public string AJZT { get; set; }
        [Column("BZ")]
        public string BZ { get; set; }
        [Column("PID")]
        public string PID { get; set; }
        [Column("CREATETIME")]
        public DateTime CREATETIME { get; set; }

        public DJT_DJ_SLSQ()
        {
        }






    }
    #endregion
}

