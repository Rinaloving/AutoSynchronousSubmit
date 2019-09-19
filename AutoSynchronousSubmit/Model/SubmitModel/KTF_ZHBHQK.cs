
using NPoco;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Model.SubmitModel
{
    #region KTF_ZHBHQK
    /// <summary>
    ///  (KTF_ZHBHQK)
    /// </summary>
    [TableName("KTF_ZHBHQK")]
    [PrimaryKey("PID")]
    public class KTF_ZHBHQK
    {


        [Column("ZHDM")]
        public string ZHDM { get; set; }
        [Column("BHYY")]
        public string BHYY { get; set; }
        [Column("BHNR")]
        public string BHNR { get; set; }
        [Column("DJSJ")]
        public DateTime DJSJ { get; set; }
        [Column("DBR")]
        public string DBR { get; set; }
        [Column("QXDM")]
        public string QXDM { get; set; }
        [Column("PID")]
        public string PID { get; set; }
        [Column("CREATETIME")]
        public DateTime CREATETIME { get; set; }

        public KTF_ZHBHQK()
        {
        }






    }
    #endregion
}

