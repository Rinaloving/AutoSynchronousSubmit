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
using System.IO;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml;
using System.Xml.Linq;

namespace AutoSynchronousSubmit
{
    public partial class SynchronousSubmit : CCSkinMain
    {

       
       // CircularProgressBar.CircularProgressBar cbar = new CircularProgressBar.CircularProgressBar();



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


            richTextBox1.AppendText("开启任务:" + DateTime.Now.ToString() + "\n");
            //测试进度条
            string path = SystemHandler.localBizFilePath;
            UpdateCircleBar(100,path);


            //richTextBox1.AppendText("完成任务:" + DateTime.Now.ToString() + "\n");




        }

        public void AnalysisBizFileToSubmit(string[] files)
        {
            

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

        public  void  UpdateCircleBar(long lenth,string path)
        {
            string[] files = XMLHelper.GetBizFile(path);
            Thread thread = new Thread(new ThreadStart(new Action(delegate {
                for (int i = 0; i <= lenth; i++)
                {
                    Thread.Sleep(100);

                    AnalysisBizFileToSubmit(files);
                    //richTextBox1.AppendText("解析报文: " + Path.GetFileName(path) + " 完成！\n");
                    this.circleProgramBar1.Progress = i + 1;
                    Action<int> action = (data) =>
                    {
                        this.richTextBox1.AppendText("解析报文: " + Path.GetFileName(files[i]) + " 完成！\n");
                        
                    };

                    Invoke(action, i);
                }

            })));
            thread.IsBackground = true;
            thread.Start();


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
            else if (fields[i].PropertyType.FullName == "System.Int32")
            {
                result = Convert.ToInt32(value);
            }
            else
            {
                result = value;
            }

            return result;
        }

        private void SynchronousSubmit_Load(object sender, EventArgs e)
        {
            //circularProgressBar1.Value = 0;
            //circularProgressBar1.Maximum = 100;
            //circularProgressBar1.Minimum = 0;
   
        }

        private void TmiClose_Click(object sender, EventArgs e)
        {

        }
    }
}
