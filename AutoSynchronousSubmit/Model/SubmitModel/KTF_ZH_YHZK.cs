
using NPoco;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Model.SubmitModel
{
    #region KTF_ZH_YHZK
    /// <summary>
    ///  (KTF_ZH_YHZK)
    /// </summary>
    [TableName("KTF_ZH_YHZK")]
    [PrimaryKey("PID")]
    public class KTF_ZH_YHZK
    {


        [Column("ZHDM")]
        public string ZHDM { get; set; }
        [Column("YHFS")]
        public string YHFS { get; set; }
        [Column("YHMJ")]
        public decimal YHMJ { get; set; }
        [Column("JTYT")]
        public string JTYT { get; set; }
        [Column("SYJES")]
        public decimal SYJES { get; set; }
        [Column("QXDM")]
        public string QXDM { get; set; }
        [Column("PID")]
        public string PID { get; set; }
        [Column("CREATETIME")]
        public DateTime CREATETIME { get; set; }

        public KTF_ZH_YHZK()
        {
        }






    }
    #endregion
}

