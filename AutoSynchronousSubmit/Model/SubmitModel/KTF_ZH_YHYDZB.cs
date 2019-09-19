
using NPoco;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Model.SubmitModel
{
    #region KTF_ZH_YHYDZB
    /// <summary>
    ///  (KTF_ZH_YHYDZB)
    /// </summary>
    [TableName("KTF_ZH_YHYDZB")]
    [PrimaryKey("PID")]
    public class KTF_ZH_YHYDZB
    {


        [Column("ZHHDDM")]
        public string ZHHDDM { get; set; }
        [Column("XH")]
        public int XH { get; set; }
        [Column("BW")]
        public decimal BW { get; set; }
        [Column("DJ")]
        public decimal DJ { get; set; }
        [Column("QXDM")]
        public string QXDM { get; set; }
        [Column("PID")]
        public string PID { get; set; }
        [Column("CREATETIME")]
        public DateTime CREATETIME { get; set; }

        public KTF_ZH_YHYDZB()
        {
        }






    }
    #endregion
}

