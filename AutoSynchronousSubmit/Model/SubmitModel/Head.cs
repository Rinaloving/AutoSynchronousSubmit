using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model.SubmitModel
{
    public class SubmitBaseEntity
    {

    }
    /// <summary>
    /// 报文头
    /// </summary>
    public class Head
    {
        public string BizMsgID { get; set; }
        public string ASID { get; set; }
        public string AreaCode { get; set; }
        public string RecType { get; set; }
        public string RightType { get; set; }
        public string RegType { get; set; }
        public DateTime CreateDate { get; set; }
        public string RecFlowID { get; set; }
        public string RegOrgID { get; set; }
        public string ParcelID { get; set; }
        public string EstateNum { get; set; }
        public string PreEstateNum { get; set; }
        public string PreCertID { get; set; }
        private string m_CertCount = "0";
        public string CertCount { get { return m_CertCount; } set { m_CertCount = value; } }
        private string m_ProofCount = "0";
        public string ProofCount { get; set; }
    }
}
