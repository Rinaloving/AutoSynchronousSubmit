
using NPoco;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Model.SubmitModel
{
	#region ZD_K_103
	/// <summary>
	///  (ZD_K_103)
	/// </summary>
    [TableName("ZD_K_103")]
    [PrimaryKey("PID")]
	public class ZD_K_103
	{
		
         
        [Column("BDCDYH")]
		public string BDCDYH{get;set;}
        [Column("ZDX")]
		public decimal ZDX{get;set;}
        [Column("XH")]
		public int XH{get;set;}
        [Column("XZB")]
		public decimal XZB{get;set;}
        [Column("YZB")]
		public decimal YZB{get;set;}
        [Column("PID")]
		public string PID{get;set;}
        [Column("CREATETIME")]
		public DateTime CREATETIME{get;set;}
		
		public ZD_K_103()
		{
		}

		

		
		
		
	}
	#endregion
}

