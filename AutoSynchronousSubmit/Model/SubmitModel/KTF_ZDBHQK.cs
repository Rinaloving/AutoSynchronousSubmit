
using NPoco;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Model.SubmitModel
{
    #region KTF_ZDBHQK
    /// <summary>
    ///  (KTF_ZDBHQK)
    /// </summary>
    [TableName("KTF_ZDBHQK")]
    [PrimaryKey("PID")]
    public class KTF_ZDBHQK
    {


        [Column("ZDDM")]
        public string ZDDM { get; set; }
        [Column("BHYY")]
        public string BHYY { get; set; }
        [Column("BHNR")]
        public string BHNR { get; set; }
        [Column("DJSJ")]
        public DateTime DJSJ { get; set; }
        [Column("DBR")]
        public string DBR { get; set; }
        [Column("FJ")]
        public string FJ { get; set; }
        [Column("QXDM")]
        public string QXDM { get; set; }
        [Column("PID")]
        public string PID { get; set; }
        [Column("CREATETIME")]
        public DateTime CREATETIME { get; set; }

        public KTF_ZDBHQK()
        {
        }






    }
    #endregion
}

