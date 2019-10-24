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
using System.Timers;
using System.Windows.Forms;
using System.Xml;
using System.Xml.Linq;

namespace AutoSynchronousSubmit
{
    public partial class SynchronousSubmit : CCSkinMain
    {

        private bool CanToClose = false;
        private bool IsRunning = false;
      
        private DateTime startDate = Convert.ToDateTime(SystemHandler.startDate);
        // CircularProgressBar.CircularProgressBar cbar = new CircularProgressBar.CircularProgressBar();






        public SynchronousSubmit()
        {
            InitializeComponent();
            //读取配置文件定时的时间间隔，配置文件的时间单位为分钟，要转化为毫秒
            try
            {
                string interval = SystemHandler.restartTime;
                this.timer1.Interval = int.Parse(interval) * 60 * 1000;
            }
            catch (Exception ex)
            {
                this.timer1.Interval = 3600000;
                throw ex;
            }


        }



        private void timer_Tick(object sender, EventArgs e)
        {
            if (!IsRunning) return;
            timer1.Tick -= timer_Tick;
            timer1.Enabled = false;

            if (!IsRunning)
            {
                return;
            }
            try
            {
                IsRunning = false;
                this.backgroundWorker1.DoWork += new System.ComponentModel.DoWorkEventHandler(this.backgroundWorker1_DoWork);
                this.backgroundWorker1.ProgressChanged += new System.ComponentModel.ProgressChangedEventHandler(this.backgroundWorker1_ProgressChanged);
                this.backgroundWorker1.RunWorkerCompleted += new System.ComponentModel.RunWorkerCompletedEventHandler(this.backgroundWorker1_RunWorkerCompleted);
                backgroundWorker1.RunWorkerAsync();
            }
            catch (Exception ex) { }
            finally
            {
                IsRunning = false;
            }

           
        }

        private void TmiStart_Click(object sender, EventArgs e)
        {
            this.IsRunning = true;
            RefreshRoles();
            timer1.Start();
            // 测试连接数据库
            //BizandrepManager bm = new BizandrepManager();
            //string sql = @"select * from bizandrep";
            //var result = bm.Query(sql);


            richTextBox1.AppendText("开启任务:" + DateTime.Now.ToString() + "\n");
           


            timer_Tick(null, null);


        }

        public void AnalysisBizFileToSubmit(string file)
        {

           

           
                Head head = XMLHelper.GetBizHeadInfo(file);
                RNANDCN rnandcn = new RNANDCN();
                RnandcnManager rm = new RnandcnManager();
                string today = head.CreateDate.ToString("yyyyMMdd");
                //string today2 = "20191018";
                ICollection<RNANDCN> list = rm.Query("select * from RNANDCN where realeunum = '"+head.PreEstateNum+"' and to_char(createtime,'yyyyMMdd') = '"+ today + "' ");
                if (list.Count==0)
                {
                    InsertRNANDCN(Guid.NewGuid().ToString(), rnandcn, head);
                    List<dynamic> entities = GetSmtInstance(file, head);
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

        public  void  UpdateCircleBar(string path)
        {
            string[] files = XMLHelper.GetBizFile(path);
            int length = files.Length;
            double num = 0d;
            Thread thread = new Thread(new ThreadStart(new Action(delegate {
                for (int i = 0; i <length; i++)
                {
                    Thread.Sleep(10);
                    this.circleProgramBar1.MaxValue = 100;
                    num = (((double)i /length) * 100);
                    AnalysisBizFileToSubmit(files[i]);
                    
                    this.circleProgramBar1.Progress = (int)num + 1;
                    Action<int> action = (data) =>
                    {
                        
                        if (length-i>0)
                        {
                            this.richTextBox1.AppendText("解析报文: " + Path.GetFileName(files[i]) + " 完成！\n");
                        }
                         if(length-i<=1)
                        {
                            this.richTextBox1.AppendText("完成任务:" + DateTime.Now.ToString() + "\n");
                            this.circleProgramBar1.Progress = 100;
                            if (DateTime.Compare(startDate, System.DateTime.Now) < 0)
                            {
                                startDate = startDate.AddDays(1);
                            }
                            else
                            {
                                startDate = System.DateTime.Now;
                            }
                            IsRunning = true;
                        }
                    };

                    Invoke(action, i);
                    
                }

            })));
            thread.IsBackground = true;
            thread.Start();
            

        }

        public void   BackUpBizFileUpdateCircleBar(int lenth, string p,int i,string localPath)
        {

            double num = (((double)i / lenth) * 100);
            //string[] files = XMLHelper.GetBizFile(path);
            Thread thread = new Thread(new ThreadStart(new Action( delegate {
 
                    
                  XMLHelper.BackupBizFile(p, localPath);
  
                  this.circleProgramBar1.MaxValue = 100;
        

                  this.circleProgramBar1.Progress = (int)num + 1;
                    Action<int> action = (data) =>
                    {
                        if (lenth - i > 0)
                        {
                            this.richTextBox1.AppendText("备份报文: " + Path.GetFileName(p) + " 完成！\n");
                        }
                        
                        if (lenth - i <= 1)
                        {
                            this.richTextBox1.AppendText("完成备份任务:" + DateTime.Now.ToString() + "\n");
                            this.circleProgramBar1.Progress = 100;
                        }
                    };

                    Invoke(action, (int)i);

                

            })));
            thread.IsBackground = true;
            thread.Start();


        }

        public void   GroupBizFileUpdateCircleBar(int lenth, string p, int j, string analysisPath )
        {
            double num = (((double)j / lenth) * 100);
            //string[] files = XMLHelper.GetBizFile(path);
            Thread thread = new Thread(new ThreadStart(new Action( delegate {

                
                 XMLHelper.GroupByCreateDate(p, analysisPath); // 执行按日期分组
                
                this.circleProgramBar1.MaxValue = 100;

               

                this.circleProgramBar1.Progress = (int)num + 1;

                Action<int> action = (data) =>
                {
                    if (lenth - j > 0)
                    {
                        this.richTextBox1.AppendText("分类报文: " + Path.GetFileName(p) + " 完成！\n");
                    }

                    
                    if (lenth - j <= 1)
                    {
                        this.richTextBox1.AppendText("完成分类任务:" + DateTime.Now.ToString() + "\n");
                        this.circleProgramBar1.Progress = 100;
                    }
                };

               Invoke(action, (int)j);



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
        /// <summary>
        /// RNANDCN插入一条数据
        /// </summary>
        /// <param name="pid"></param>
        /// <param name="rnandcn"></param>
        /// <param name="head"></param>
        public void InsertRNANDCN(string pid,RNANDCN rnandcn, Head head)
        {
            RnandcnManager rm = new RnandcnManager();
            rnandcn.PID = pid;
            rnandcn.REALEUNUM = head.EstateNum;
            rnandcn.YWH = head.RecFlowID;
            rnandcn.JRYWBM = head.RecType;
            rnandcn.QXDM = head.AreaCode;
            rnandcn.CREATETIME = head.CreateDate;
            
            rm.Insert("RNANDCN", "PID", false, rnandcn);
        }

        public List<dynamic> GetSmtInstance(string file,Head head)
        {
                List<dynamic> lst = new List<dynamic>();
                

            IEnumerable<XNode> val = XElement.Load(file).Element("Data").Nodes(); // 获取子节点值
                foreach (XNode it in val)
                {
                    XElement val2 = (XElement)it; // 获取子节点值 RNANDCN
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
                result = Convert.ToByte(Convert.ToDouble(value)); // 防止报文中有double类型
            }
            else if (fields[i].PropertyType.FullName == "System.Decimal")
            {
                //string str = System.Text.RegularExpressions.Regex.Replace(value.ToString(), @"[^0-9]+", ""); //只保留数字
                string str = System.Text.RegularExpressions.Regex.Replace(value.ToString(), @"[^0-9\.]+", ""); // 只保留数字和小数点
                result = Convert.ToDecimal(str);
            }
            else if (fields[i].PropertyType.FullName == "System.DateTime")
            {
                if (Convert.ToString(value).Length==4)
                {
                    result = new DateTime().AddYears(Convert.ToInt32((value)) - 1);
                }
                else
                {
                    result = Convert.ToDateTime(value);
                }
               
            }
            else if (fields[i].PropertyType.FullName == "System.Int32")
            {
                string str = System.Text.RegularExpressions.Regex.Replace(value.ToString(), @"[^0-9]+", "");
   
                result = Convert.ToInt32(str == "" ? "0" : str);
            }
            else
            {
                result = value;
            }

            return result;
        }

        private async void  backgroundWorker1_DoWork(object sender, DoWorkEventArgs e)
        {




            //测试进度条

            Task t = RunBackUpPrograme();

            t.Wait();

            t = RunAnalysisPrograme();

            t.Wait();

            t = RunSynchrousSubmitPrograme();

            t.Wait();





            //UpdateCircleBar(100, path);

            //new Thread(() =>
            //{

            //    Action<int> action = (data) =>
            //    {
            //        this.richTextBox1.AppendText("我执行了:" + DateTime.Now.ToString() + "\n");
            //    };
            //    Invoke(action, 1);

            //}).Start();

        }
        
        public async Task RunSynchrousSubmitPrograme()
        {
            await Task.Delay(50);
            string localPath = SystemHandler.localBizFilePath;
            string synfilePath = localPath + "/Analysis/" + startDate.ToString("yyyy-MM-dd");
            if (Directory.Exists(synfilePath))
            {
               
                UpdateCircleBar(synfilePath);
            }
            else
            {
                if (DateTime.Compare(startDate, System.DateTime.Now) < 0)
                {
                    startDate = startDate.AddDays(1);
                }
                else
                {
                    startDate = System.DateTime.Now;
                }
                IsRunning = true;
            }
            
            

        }
        /// <summary>
        /// 报文备份
        /// </summary>
        /// <returns></returns>
        public async  Task RunBackUpPrograme()
        {
            await Task.Delay(50);
            string path = SystemHandler.localBizFilePath;
          
           
            //备份并执行按日期分组
            List<string> filelist = Directory.GetFiles(path, "*.xml").ToList();// 获取所有报文
            int i = 0;
            int totalnum = filelist.Count;
            filelist.ForEach( p => {
                Thread.Sleep(50);
                
                BackUpBizFileUpdateCircleBar(totalnum, p, i, path);
                i++;
            });


            return;

          

        }
        /// <summary>
        /// 按日期分类报文
        /// </summary>
        /// <returns></returns>
        public  async Task  RunAnalysisPrograme()
        {
            await Task.Delay(50);
            string path = SystemHandler.localBizFilePath;
            string analysisPath = path + "/Analysis";
            if (!Directory.Exists(analysisPath)) { Directory.CreateDirectory(analysisPath); }
            List<string> analyfilelist = Directory.GetFiles(analysisPath, "*.xml").ToList();// 获取所有报文
            int j = 0;
            int totalnum = analyfilelist.Count;


            analyfilelist.ForEach(p => {
                Thread.Sleep(50);
               
                GroupBizFileUpdateCircleBar(totalnum, p, j, analysisPath);
                j++;
            });

            return ;
        }

        private void backgroundWorker1_ProgressChanged(object sender, ProgressChangedEventArgs e)
        {
            richTextBox1.AppendText(e.UserState.ToString() + "\n");
        }

        private void backgroundWorker1_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            backgroundWorker1.DoWork -= backgroundWorker1_DoWork;
            backgroundWorker1.RunWorkerCompleted -= backgroundWorker1_RunWorkerCompleted;
            backgroundWorker1.ProgressChanged -= backgroundWorker1_ProgressChanged;

            timer1.Tick += timer_Tick;
            timer1.Enabled = true;
        }

        private void SynchronousSubmit_Load(object sender, EventArgs e)
        {
            //circularProgressBar1.Value = 0;
            //circularProgressBar1.Maximum = 100;
            //circularProgressBar1.Minimum = 0;
   
        }

        private void TmiClose_Click(object sender, EventArgs e)
        {
            CanToClose = true;
            this.Close();
        }

        public void RefreshRoles()
        {
            this.tmiStart.Enabled = !this.IsRunning;
            this.tmiStop.Enabled = this.IsRunning;

        }

        private void TmiStop_Click(object sender, EventArgs e)
        {
            this.IsRunning = false;
            RefreshRoles();
            timer1.Stop();
            richTextBox1.AppendText("任务停止:" + DateTime.Now.ToString() + "\n");
        }

        private void NotifyIcon1_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            this.Show();
        }

        private void 显示ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Visible = true;
        }

        private void 隐藏ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Visible = false;
        }

        private void 退出ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }


        
        
    }
}
