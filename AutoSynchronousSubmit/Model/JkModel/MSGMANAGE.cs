
using NPoco;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace AutoSubmit.JkModel
{
	#region MSGMANAGE
	/// <summary>
	///  (MSGMANAGE)
	/// </summary>
    [TableName("MSGMANAGE")]
    [PrimaryKey("MSGID")]
	public class MSGMANAGE
	{
		
         
        [Column("MSGID")]
		public string MSGID{get;set;}
        [Column("BIZMSGID")]
		public string BIZMSGID{get;set;}
        [Column("ASID")]
		public string ASID{get;set;}
        [Column("AREACODE")]
		public string AREACODE{get;set;}
        [Column("RECTYPE")]
		public string RECTYPE{get;set;}
        [Column("RIGHTTYPE")]
		public string RIGHTTYPE{get;set;}
        [Column("REGTYPE")]
		public string REGTYPE{get;set;}
        [Column("CREATEDATE")]
		public DateTime CREATEDATE{get;set;}
        [Column("RECFLOWID")]
		public string RECFLOWID{get;set;}
        [Column("ESTATENUM")]
		public string ESTATENUM{get;set;}
        [Column("PRECERTID")]
		public string PRECERTID{get;set;}
        [Column("RECDATE")]
		public DateTime RECDATE{get;set;}
        [Column("UPTIME")]
		public DateTime UPTIME{get;set;}
        [Column("UPSTATUS")]
		public decimal UPSTATUS{get;set;}
        [Column("REPCODE")]
		public string REPCODE{get;set;}
        [Column("REPDESC")]
		public string REPDESC{get;set;}
        [Column("REGORGID")]
		public string REGORGID{get;set;}
		
		public MSGMANAGE()
		{
		}

		

		
		
		
	}
	#endregion
}

