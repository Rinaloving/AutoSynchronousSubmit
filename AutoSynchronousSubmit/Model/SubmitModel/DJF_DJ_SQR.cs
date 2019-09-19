
using NPoco;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Model.SubmitModel
{
    #region DJF_DJ_SQR
    /// <summary>
    ///  (DJF_DJ_SQR)
    /// </summary>
    [TableName("DJF_DJ_SQR")]
    [PrimaryKey("PID")]
    public class DJF_DJ_SQR
    {


        [Column("YWH")]
        public string YWH { get; set; }
        [Column("YSDM")]
        public string YSDM { get; set; }
        [Column("QLRMC")]
        public string QLRMC { get; set; }
        [Column("QLRZJZL")]
        public string QLRZJZL { get; set; }
        [Column("QLRZJH")]
        public string QLRZJH { get; set; }
        [Column("QLRTXDZ")]
        public string QLRTXDZ { get; set; }
        [Column("QLRYB")]
        public string QLRYB { get; set; }
        [Column("QLRFRMC")]
        public string QLRFRMC { get; set; }
        [Column("QLFRDH")]
        public string QLFRDH { get; set; }
        [Column("QLRDLRMC")]
        public string QLRDLRMC { get; set; }
        [Column("QLRDLRDH")]
        public string QLRDLRDH { get; set; }
        [Column("QLRDLJG")]
        public string QLRDLJG { get; set; }
        [Column("YWRMC")]
        public string YWRMC { get; set; }
        [Column("YWRZJZL")]
        public string YWRZJZL { get; set; }
        [Column("YWRZJH")]
        public string YWRZJH { get; set; }
        [Column("YWRTXDZ")]
        public string YWRTXDZ { get; set; }
        [Column("YWRYB")]
        public string YWRYB { get; set; }
        [Column("YWRFRMC")]
        public string YWRFRMC { get; set; }
        [Column("YWRFRDH")]
        public string YWRFRDH { get; set; }
        [Column("YWRDLRMC")]
        public string YWRDLRMC { get; set; }
        [Column("YWRDLRDH")]
        public string YWRDLRDH { get; set; }
        [Column("YWRDLJG")]
        public string YWRDLJG { get; set; }
        [Column("BZ")]
        public string BZ { get; set; }
        [Column("QXDM")]
        public string QXDM { get; set; }
        [Column("PID")]
        public string PID { get; set; }
        [Column("CREATETIME")]
        public DateTime CREATETIME { get; set; }

        public DJF_DJ_SQR()
        {
        }






    }
    #endregion
}

