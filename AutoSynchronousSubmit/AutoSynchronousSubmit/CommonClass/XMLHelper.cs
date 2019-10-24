using Model.SubmitModel;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading;
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
        

        public  static void BackupBizFile(string p,string localPath)
        {

            string backupPath = localPath + "/BackUp"; // 本地报文备份到BackUp文件夹下
            string analysisPath = localPath + "/Analysis"; // 解析报文路径
            if (!Directory.Exists(backupPath)) { Directory.CreateDirectory(backupPath); }
            if (!Directory.Exists(analysisPath)) { Directory.CreateDirectory(analysisPath); }

           
            File.Copy(p, backupPath+"/"+Path.GetFileName(p),true);
            File.Copy(p, analysisPath + "/" + Path.GetFileName(p), true);
            File.Delete(p);

           

        }


        public   static void GroupByCreateDate(string p,string localPath)
        {

                string createDate = GetBizXmlCreateDate(p).Substring(0, 10);
                string newPath = localPath + "\\" + createDate;
                if (!Directory.Exists(newPath)) { Directory.CreateDirectory(newPath); }
                //File.Move(p, newPath + "\\" + Path.GetFileName(p));
                File.Copy(p, newPath + "\\" + Path.GetFileName(p),true);
                File.Delete(p);
                
           
        }

        public static string GetBizXmlCreateDate(string xmlPath)
        {
            try
            {
                XElement root = XElement.Load(xmlPath);
                //获取报文创建时间
                string createdate = root.Element("Head").Element("CreateDate").Value;

                return createdate;
            }
            catch (Exception ex)
            {
                return "无报文创建时间";
                throw ex;
            }
        }

       

    }
}
