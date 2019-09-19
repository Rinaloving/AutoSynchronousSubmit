
using NPoco;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Model.SubmitModel
{
    #region DJF_DJ_GD
    /// <summary>
    ///  (DJF_DJ_GD)
    /// </summary>
    [TableName("DJF_DJ_GD")]
    [PrimaryKey("PID")]
    public class DJF_DJ_GD
    {


        [Column("YWH")]
        public string YWH { get; set; }
        [Column("YSDM")]
        public string YSDM { get; set; }
        [Column("DJDL")]
        public string DJDL { get; set; }
        [Column("DJXL")]
        public int DJXL { get; set; }
        [Column("ZL")]
        public string ZL { get; set; }
        [Column("QZHM")]
        public string QZHM { get; set; }
        [Column("WJJS")]
        public decimal WJJS { get; set; }
        [Column("ZYS")]
        public decimal ZYS { get; set; }
        [Column("GDRY")]
        public string GDRY { get; set; }
        [Column("GDSJ")]
        public DateTime GDSJ { get; set; }
        [Column("BZ")]
        public string BZ { get; set; }
        [Column("QXDM")]
        public string QXDM { get; set; }
        [Column("PID")]
        public string PID { get; set; }
        [Column("CREATETIME")]
        public DateTime CREATETIME { get; set; }

        public DJF_DJ_GD()
        {
        }






    }
    #endregion
}

