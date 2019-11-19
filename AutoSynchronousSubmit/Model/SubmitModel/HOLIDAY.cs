
using NPoco;
using System;

namespace Entitys
{
    /// <summary>
    /// 
    /// </summary>
    public class HOLIDAY
    {

        [Column("DAY")]
        public DateTime DAY { get; set; }

        [Column("STATUS")]
        public string STATUS { get; set; }
    }
}
