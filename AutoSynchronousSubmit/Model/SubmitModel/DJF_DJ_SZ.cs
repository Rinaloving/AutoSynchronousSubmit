
using NPoco;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Model.SubmitModel
{
    #region DJF_DJ_SZ
    /// <summary>
    ///  (DJF_DJ_SZ)
    /// </summary>
    [TableName("DJF_DJ_SZ")]
    [PrimaryKey("PID")]
    public class DJF_DJ_SZ
    {


        [Column("YWH")]
        public string YWH { get; set; }
        [Column("YSDM")]
        public string YSDM { get; set; }
        [Column("SZMC")]
        public string SZMC { get; set; }
        [Column("SZZH")]
        public string SZZH { get; set; }
        [Column("YSXLH")]
        public string YSXLH { get; set; }
        [Column("SZRY")]
        public string SZRY { get; set; }
        [Column("SZSJ")]
        public DateTime SZSJ { get; set; }
        [Column("BZ")]
        public string BZ { get; set; }
        [Column("QXDM")]
        public string QXDM { get; set; }
        [Column("PID")]
        public string PID { get; set; }
        [Column("CREATETIME")]
        public DateTime CREATETIME { get; set; }

        public DJF_DJ_SZ()
        {
        }






    }
    #endregion
}

