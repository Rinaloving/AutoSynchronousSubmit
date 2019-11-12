﻿using NPoco;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model.SubmitModel
{
    [TableName("MSGTIMERECORD")]
    [PrimaryKey("PID")]
    public class MSGTIMERECORD
    {
        [Column("PID")]
        public string PID { get; set; }

        [Column("BDCDYH")]
        public string BDCDYH { get; set; }

        [Column("QXDM")]
        public string QXDM { get; set; }

        [Column("DJSJ")]
        public DateTime? DJSJ { get; set; }

        [Column("SLSJ")]
        public DateTime? SLSJ { get; set; }

        [Column("CREATETIME")]
        public DateTime? CREATETIME { get; set; }
        [Column("ZXSJ")]
        public DateTime? ZXSJ { get; set; }
        [Column("QLLX")]
        public string QLLX { get; set; }
        [Column("YWLX")]
        public string YWLX { get; set; }
        [Column("DJLX")]
        public string DJLX { get; set; }
        [Column("YWH")]
        public string YWH { get; set; }
        [Column("AJZT")]
        public string AJZT { get; set; }
        [Column("QSZT")]
        public string QSZT { get; set; }
        [Column("DJXL")]
        public string DJXL { get; set; }

        [Column("UPTIME")]
        public DateTime? UPTIME { get; set; }

        [Column("UPSTATUS")]
        public string UPSTATUS { get; set; }
    }
}