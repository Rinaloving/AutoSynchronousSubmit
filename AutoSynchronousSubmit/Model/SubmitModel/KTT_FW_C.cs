using NPoco;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model.SubmitModel
{
    [TableName("KTT_FW_C")]
    [PrimaryKey("PID")]
    public class KTT_FW_C
    {
       
        [Column("CH")]
        public string CH { get; set; }
        [Column("ZRZH")]
        public string ZRZH { get; set; }
        [Column("YSDM")]
        public string YSDM { get; set; }
        [Column("SJC")]
        public decimal SJC { get; set; }
        [Column("MYC")]
        public string MYC { get; set; }
        [Column("CJZMJ")]
        public decimal CJZMJ { get; set; }
        [Column("CTNJZMJ")]
        public decimal CTNJZMJ { get; set; }
        [Column("CYTMJ")]
        public decimal CYTMJ { get; set; }
        [Column("CGYJZMJ")]
        public decimal CGYJZMJ { get; set; }
        [Column("CFTJZMJ")]
        public decimal CFTJZMJ { get; set; }
        [Column("CBQMJ")]
        public decimal CBQMJ { get; set; }
        [Column("CG")]
        public decimal CG { get; set; }
        [Column("SPTYMJ")]
        public decimal SPTYMJ { get; set; }
        [Column("QXDM")]
        public string QXDM { get; set; }
        [Column("PID")]
        public string PID { get; set; }
        [Column("CREATETIME")]
        public DateTime CREATETIME { get; set; }
        [Column("ZRZPID")]
        public string ZRZPID { get; set; }
        [Column("LJZPID")]
        public string LJZPID { get; set; }


        public KTT_FW_C()
        {

        }

    }
}
