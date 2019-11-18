using SqlSugar;

namespace Entitys
{
    /// <summary>
    /// 
    /// </summary>
    public class HOLIDAY
    {
        /// <summary>
        /// 
        /// </summary>
        public HOLIDAY()
        {
        }

        private System.DateTime _DAY;
        /// <summary>
        /// 
        /// </summary>
        public System.DateTime DAY { get { return this._DAY; } set { this._DAY = value; } }

        private System.String _STATUS;
        /// <summary>
        /// 
        /// </summary>
        public System.String STATUS { get { return this._STATUS; } set { this._STATUS = value; } }
    }
}
