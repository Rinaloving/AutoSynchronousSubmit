using NPoco;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Model.SubmitModel
{
    #region DJF_DJ_FZ
    /// <summary>
    ///  (DJF_DJ_FZ)
    /// </summary>
    [TableName("DJF_DJ_FZ")]
    [PrimaryKey("PID")]
    public class DJF_DJ_FZ
    {


        [Column("YWH")]
        public string YWH { get; set; }
        [Column("YSDM")]
        public string YSDM { get; set; }
        [Column("FZRY")]
        public string FZRY { get; set; }
        [Column("FZSJ")]
        public DateTime FZSJ { get; set; }
        [Column("FZMC")]
        public string FZMC { get; set; }
        [Column("FZSL")]
        public decimal FZSL { get; set; }
        [Column("HFZSH")]
        public string HFZSH { get; set; }
        [Column("LZRXM")]
        public string LZRXM { get; set; }
        [Column("LZRZJLB")]
        public string LZRZJLB { get; set; }
        [Column("LZRZJHM")]
        public string LZRZJHM { get; set; }
        [Column("LZRDH")]
        public string LZRDH { get; set; }
        [Column("LZRDZ")]
        public string LZRDZ { get; set; }
        [Column("LZRYB")]
        public string LZRYB { get; set; }
        [Column("BZ")]
        public string BZ { get; set; }
        [Column("QXDM")]
        public string QXDM { get; set; }
        [Column("PID")]
        public string PID { get; set; }
        [Column("CREATETIME")]
        public DateTime CREATETIME { get; set; }

        public DJF_DJ_FZ()
        {
        }






    }
    #endregion
}

