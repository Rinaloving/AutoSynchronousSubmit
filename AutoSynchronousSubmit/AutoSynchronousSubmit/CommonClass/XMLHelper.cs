using Model.SubmitModel;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace AutoSynchronousSubmit.CommonClass
{
    public class XMLHelper
    {
        /// <summary>
        /// 获取报文总数
        /// </summary>
        /// <param name="path">报文所在文件夹路径</param>
        /// <returns></returns>
        public static string[] GetBizFile(string path)
        {
            return Directory.GetFiles(path,"Biz*.xml");
        }
        public static string GetXmlElementValue(string filepath,string firstnode,string secondnode)
        {
            return XElement.Load(filepath).Element(firstnode).Element(secondnode).Value;
        }
        /// <summary>
        /// 获取报文Head节点信息
        /// </summary>
        /// <param name="filepath"></param>
        /// <returns></returns>
        public static Head GetBizHeadInfo(string filepath)
        {
            Head head = new Head();
            head.BizMsgID = GetXmlElementValue(filepath,"Head","BizMsgID");
            head.ASID = GetXmlElementValue(filepath, "Head", "ASID");
            head.AreaCode = GetXmlElementValue(filepath, "Head", "AreaCode");
            head.RecType = GetXmlElementValue(filepath, "Head", "RecType");
            head.RightType = GetXmlElementValue(filepath, "Head", "RightType");
            head.RegType = GetXmlElementValue(filepath, "Head", "RegType");
            head.CreateDate = Convert.ToDateTime(GetXmlElementValue(filepath, "Head", "CreateDate"));
            head.RecFlowID = GetXmlElementValue(filepath, "Head", "RecFlowID");
            head.RegOrgID = GetXmlElementValue(filepath, "Head", "RegOrgID");
            head.ParcelID = GetXmlElementValue(filepath, "Head", "ParcelID");
            head.EstateNum = GetXmlElementValue(filepath, "Head", "EstateNum");
            head.PreEstateNum = GetXmlElementValue(filepath, "Head", "PreEstateNum");
            head.PreCertID = GetXmlElementValue(filepath, "Head", "PreCertID");

            return head;
        }
        

    }
}
