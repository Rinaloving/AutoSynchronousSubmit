
using NPoco;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Model.SubmitModel
{
    #region FJ_F_100
    /// <summary>
    ///  (FJ_F_100)
    /// </summary>
    [TableName("FJ_F_100")]
    [PrimaryKey("PID")]
    public class FJ_F_100
    {


        [Column("FJMC")]
        public string FJMC { get; set; }
        [Column("FJLX")]
        public string FJLX { get; set; }
        [Column("FJNR")]
        public string FJNR { get; set; }
        [Column("PID")]
        public string PID { get; set; }
        [Column("CREATETIME")]
        public DateTime CREATETIME { get; set; }
        [Column("YWH")]
        public string YWH { get; set; }

        public FJ_F_100()
        {
        }






    }
    #endregion
}

