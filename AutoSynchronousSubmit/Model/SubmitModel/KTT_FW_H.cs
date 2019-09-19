using NPoco;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model.SubmitModel
{
    [TableName("KTT_FW_H")]
    [PrimaryKey("PID")]
    public class KTT_FW_H
    {
        
        [Column("BDCDYH")]
        public string BDCDYH { get; set; }
        [Column("FWBM")]
        public string FWBM { get; set; }
        [Column("YSDM")]
        public string YSDM { get; set; }
        [Column("LJZH")]
        public string LJZH { get; set; }
        [Column("ZRZH")]
        public string ZRZH { get; set; }
        [Column("CH")]
        public string CH { get; set; }
        [Column("ZL")]
        public string ZL { get; set; }
        [Column("MJDW")]
        public string MJDW { get; set; }
        [Column("SJCS")]
        public decimal SJCS { get; set; }
        [Column("HH")]
        public int HH { get; set; }
        [Column("SHBW")]
        public string SHBW { get; set; }
        [Column("HX")]
        public string HX { get; set; }
        [Column("HXJG")]
        public string HXJG { get; set; }
        [Column("FWYT1")]
        public string FWYT1 { get; set; }
        [Column("FWYT2")]
        public string FWYT2 { get; set; }
        [Column("FWYT3")]
        public string FWYT3 { get; set; }
        [Column("YCJZMJ")]
        public decimal YCJZMJ { get; set; }
        [Column("YCTNJZMJ")]
        public decimal YCTNJZMJ { get; set; }
        [Column("YCFTJZMJ")]
        public decimal YCFTJZMJ { get; set; }
        [Column("YCDXBFJZMJ")]
        public decimal YCDXBFJZMJ { get; set; }
        [Column("YCQTJZMJ")]
        public decimal YCQTJZMJ { get; set; }
        [Column("YCFTXS")]
        public decimal YCFTXS { get; set; }
        [Column("SCJZMJ")]
        public decimal SCJZMJ { get; set; }
        [Column("SCTNJZMJ")]
        public decimal SCTNJZMJ { get; set; }
        [Column("SCFTJZMJ")]
        public decimal SCFTJZMJ { get; set; }
        [Column("SCDXBFJZMJ")]
        public decimal SCDXBFJZMJ { get; set; }
        [Column("SCQTJZMJ")]
        public decimal SCQTJZMJ { get; set; }
        [Column("SCFTXS")]
        public decimal SCFTXS { get; set; }
        [Column("GYTDMJ")]
        public decimal GYTDMJ { get; set; }
        [Column("FTTDMJ")]
        public decimal FTTDMJ { get; set; }
        [Column("DYTDMJ")]
        public decimal DYTDMJ { get; set; }
        [Column("FWLX")]
        public string FWLX { get; set; }
        [Column("FWXZ")]
        public string FWXZ { get; set; }
        [Column("FWFHT")]
        public string FWFHT { get; set; }
        [Column("ZT")]
        public string ZT { get; set; }
        [Column("QXDM")]
        public string QXDM { get; set; }
        [Column("PID")]
        public string PID { get; set; }
        [Column("CREATETIME")]
        public DateTime CREATETIME { get; set; }
        [Column("CPID")]
        public string CPID { get; set; }

        public KTT_FW_H()
        {
        }



    }
}
