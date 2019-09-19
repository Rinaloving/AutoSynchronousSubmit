using NPoco;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model.SubmitModel
{
    [TableName("ACCESSLOG")]
    [PrimaryKey("PID")]
    public class ACCESSLOG {
        [Column("PID")]
        public string PID { get; set; }
        [Column("AREACODE")]
        public string AREACODE { get; set; }
        [Column("AREANAME")]
        public string AREANAME { get; set; }
        [Column("ACCESSDATE")]
        public string ACCESSDATE { get; set; }
        [Column("REMARK")]
        public string REMARK { get; set; }
        [Column("LOGTYPE")]
        public string LOGTYPE { get; set; }
        [Column("TOTALNUM")]
        public decimal TOTALNUM { get; set; }
        [Column("FIRSTREG")]
        public decimal FIRSTREG { get; set; }
        [Column("TRANSFERREG")]
        public decimal TRANSFERREG { get; set; }
        [Column("CHANGEREG")]
        public decimal CHANGEREG { get; set; }
        [Column("LOGOUTREG")]
        public decimal LOGOUTREG { get; set; }
        [Column("RIVISEREG")]
        public decimal RIVISEREG { get; set; }
        [Column("DISSENTINGREG")]
        public decimal DISSENTINGREG { get; set; }
        [Column("ADVANCEREG")]
        public decimal ADVANCEREG { get; set; }
        [Column("SEIZEREG")]
        public decimal SEIZEREG { get; set; }
        [Column("EASEMENTREG")]
        public decimal EASEMENTREG { get; set; }
        [Column("MORTGAGEREG")]
        public decimal MORTGAGEREG { get; set; }

        public ACCESSLOG()
        {
        }
    }
}
