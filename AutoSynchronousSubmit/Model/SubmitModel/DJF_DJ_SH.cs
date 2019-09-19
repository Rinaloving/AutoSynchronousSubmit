
using NPoco;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Model.SubmitModel
{
    #region DJF_DJ_SH
    /// <summary>
    ///  (DJF_DJ_SH)
    /// </summary>
    [TableName("DJF_DJ_SH")]
    [PrimaryKey("PID")]
    public class DJF_DJ_SH
    {


        [Column("YWH")]
        public string YWH { get; set; }
        [Column("YSDM")]
        public string YSDM { get; set; }
        [Column("JDMC")]
        public string JDMC { get; set; }
        [Column("SXH")]
        public decimal SXH { get; set; }
        [Column("SHRYXM")]
        public string SHRYXM { get; set; }
        [Column("SHKSSJ")]
        public DateTime SHKSSJ { get; set; }
        [Column("SHJSSJ")]
        public DateTime SHJSSJ { get; set; }
        [Column("SHYJ")]
        public string SHYJ { get; set; }
        [Column("CZJG")]
        public string CZJG { get; set; }
        [Column("QXDM")]
        public string QXDM { get; set; }
        [Column("PID")]
        public string PID { get; set; }
        [Column("CREATETIME")]
        public DateTime CREATETIME { get; set; }

        public DJF_DJ_SH()
        {
        }






    }
    #endregion
}

