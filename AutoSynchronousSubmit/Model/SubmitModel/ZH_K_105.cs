
using NPoco;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Model.SubmitModel
{
    #region ZH_K_105
    /// <summary>
    ///  (ZH_K_105)
    /// </summary>
    [TableName("ZH_K_105")]
    [PrimaryKey("PID")]
    public class ZH_K_105
    {


        [Column("BDCDYH")]
        public string BDCDYH { get; set; }
        [Column("ZDX")]
        public decimal ZDX { get; set; }
        [Column("XH")]
        public int XH { get; set; }
        [Column("XZB")]
        public decimal XZB { get; set; }
        [Column("YZB")]
        public decimal YZB { get; set; }
        [Column("PID")]
        public string PID { get; set; }
        [Column("CREATETIME")]
        public DateTime CREATETIME { get; set; }

        public ZH_K_105()
        {
        }






    }
    #endregion
}

