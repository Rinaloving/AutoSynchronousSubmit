using AutoSynchronousSubmit.CommonClass;
using BLL.SubmitBll;
using CCWin;
using Model.SubmitModel;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml;
using System.Xml.Linq;

namespace AutoSynchronousSubmit
{
    public partial class SynchronousSubmit : CCSkinMain
    {
        public SynchronousSubmit()
        {
            InitializeComponent();
        }



        private void timer_Tick(object sender, EventArgs e)
        {

        }

        private void TmiStart_Click(object sender, EventArgs e)
        {
            // 测试连接数据库
            BizandrepManager bm = new BizandrepManager();
            string sql = @"select * from bizandrep";
            var result = bm.Query(sql);

            string path = @"D:\dzxml\371425\BizMsg";

            string[] files = XMLHelper.GetBizFile(path);

            foreach (var file in files)
            {
                List<dynamic> entities = GetSmtInstance(file);
                string[] entityName = GetBizDataSonNodeName(file).ToArray();
                int index = 0;
                foreach (var entity in entities)
                {            
                    EntityManager em = new EntityManager();
                    em.Insert(entityName[index], "PID", false, entity);
                    index++;
                }

            }

           



        }

        public List<string> GetBizDataSonNodeName(string file)
        {
            List<string> nodeNames = new List<string>();
            IEnumerable<XNode> val = XElement.Load(file).Element("Data").Nodes(); // 获取子节点值
            foreach (var it in val)
            {
                XElement nodeName = (XElement)it; // 获取子节点值
               nodeNames.Add(nodeName.Name.ToString()); // 当前节点名
            }
            return nodeNames;
        }

        public List<dynamic> GetSmtInstance(string file)
        {
            List<dynamic> lst = new List<dynamic>();
          
          
                Head head = XMLHelper.GetBizHeadInfo(file);
                IEnumerable<XNode> val = XElement.Load(file).Element("Data").Nodes(); // 获取子节点值
                foreach (XNode it in val)
                {
                    XElement val2 = (XElement)it; // 获取子节点值
                    var currentNodeName = val2.Name; // 当前节点名
                    IEnumerable<XAttribute> m = val2.Attributes();

                    //反射获取表实例
                    Assembly assembly = Assembly.LoadFrom(SystemHandler.assPath);
                    dynamic entity = assembly.CreateInstance("Model.SubmitModel." + currentNodeName);
                    PropertyInfo[] fields = entity.GetType().GetProperties(); // 获取指定对象的所有公共属性

                    for (int i = 0; i < fields.Length; i++)
                    {

                        foreach (XAttribute ia in m)
                        {
                            var value = ia.Value; //属性值
                            var name = ia.Name; // 属性名
                            //如果属性与表中属性相同则赋值给对象
                            if (fields[i].Name.ToString() == name.LocalName)
                            {
                                fields[i].SetValue(entity, ConvertValueType(fields, value.ToString(), i)); // 赋值
                                break;
                            }
                            


                        }

                        if (fields[i].Name.ToString() == "PID")
                        {
                            fields[i].SetValue(entity, ConvertValueType(fields, Guid.NewGuid().ToString(), i)); // 赋值
                        }
                        else if (fields[i].Name.ToString() == "QXDM")
                        {
                            fields[i].SetValue(entity, ConvertValueType(fields, head.AreaCode, i)); // 赋值
                        }
                        else if (fields[i].Name.ToString() == "CASENUM")
                        {
                            fields[i].SetValue(entity, ConvertValueType(fields, head.RecFlowID, i)); // 赋值
                        }
                        else if (fields[i].Name.ToString() == "CREATETIME")
                        {
                            fields[i].SetValue(entity, ConvertValueType(fields, head.CreateDate, i)); // 赋值
                        }
                         
                    }


                    lst.Add(entity);

                }

               

            
            return lst;
        }


        public object ConvertValueType(PropertyInfo[] fields, object value,int i)
        {
            object result = null;
            if (fields[i].PropertyType.FullName == "System.Int16")
            {
                result = Convert.ToDecimal(value);
            }
            else if (fields[i].PropertyType.FullName == "System.Double")
            {
                result = Convert.ToDecimal(value);
            }
            else if (fields[i].PropertyType.FullName == "System.Byte")
            {
                result = Convert.ToByte(value);
            }
            else if (fields[i].PropertyType.FullName == "System.Decimal")
            {
                result = Convert.ToDecimal(value);
            }
            else if (fields[i].PropertyType.FullName == "System.DateTime")
            {
                result = Convert.ToDateTime(value);
            }
            else
            {
                result = value;
            }

            return result;
        }


    }
}
