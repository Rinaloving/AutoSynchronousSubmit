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
            //BizandrepManager bm = new BizandrepManager();
            //string sql = @"select * from bizandrep";
            //var result = bm.Query(sql);

            string path = @"D:\dzxml\371425\BizMsg";

            List<dynamic> entities = GetSmtInstance(path);

            var result = "";



        }

        public List<dynamic> GetSmtInstance(string path)
        {
            List<dynamic> lst = new List<dynamic>();
            string[] files = XMLHelper.GetBizFile(path);
            foreach (var item in files)
            {
                Head head = XMLHelper.GetBizHeadInfo(item);
                IEnumerable<XNode> val = XElement.Load(item).Element("Data").Nodes(); // 获取子节点值
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
