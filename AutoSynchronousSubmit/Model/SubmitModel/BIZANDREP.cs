using NPoco;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model.SubmitModel
{
    [TableName("BIZANDREP")]
    [PrimaryKey("PID")]
    public class BIZANDREP
    {
        public string PID { get; set; }
        [Column("YWH")]
        public string YWH { get; set; }
        [Column("STATUS")]
        public decimal STATUS { get; set; }
        [Column("BIZMSGID")]
        public string BIZMSGID { get; set; }
        [Column("REPTEXT")]
        public string REPTEXT { get; set; }
        [Column("BIZFILEPATH")]
        public string BIZFILEPATH { get; set; }
        [Column("REPFILEPATH")]
        public string REPFILEPATH { get; set; }
        [Column("QXDM")]
        public string QXDM { get; set; }
        [Column("CREATETIME")]
        public DateTime CREATETIME { get; set; }

        public BIZANDREP()
        {

        }

    }
}
