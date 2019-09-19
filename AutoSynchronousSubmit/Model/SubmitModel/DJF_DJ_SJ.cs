
using NPoco;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Model.SubmitModel
{
    #region DJF_DJ_SJ
    /// <summary>
    ///  (DJF_DJ_SJ)
    /// </summary>
    [TableName("DJF_DJ_SJ")]
    [PrimaryKey("PID")]
    public class DJF_DJ_SJ
    {


        [Column("YWH")]
        public string YWH { get; set; }
        [Column("YSDM")]
        public string YSDM { get; set; }
        [Column("SJSJ")]
        public DateTime SJSJ { get; set; }
        [Column("SJLX")]
        public string SJLX { get; set; }
        [Column("SJMC")]
        public string SJMC { get; set; }
        [Column("SJSL")]
        public decimal SJSL { get; set; }
        [Column("SFSJSY")]
        public string SFSJSY { get; set; }
        [Column("SFEWSJ")]
        public string SFEWSJ { get; set; }
        [Column("SFBCSJ")]
        public string SFBCSJ { get; set; }
        [Column("YS")]
        public decimal YS { get; set; }
        [Column("BZ")]
        public string BZ { get; set; }
        [Column("QXDM")]
        public string QXDM { get; set; }
        [Column("PID")]
        public string PID { get; set; }
        [Column("CREATETIME")]
        public DateTime CREATETIME { get; set; }

        public DJF_DJ_SJ()
        {
        }






    }
    #endregion
}

