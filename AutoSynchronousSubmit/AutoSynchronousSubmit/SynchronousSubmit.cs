using AutoSynchronousSubmit.CommonClass;
using BLL.SubmitBll;
using CCWin;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
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

            string[] files = XMLHelper.GetBizFile(path);
            foreach (var item in files)
            {
               var val =  XElement.Load(item).Element("Data").Nodes(); // 获取子节点值
                foreach (var it in val)
                {
                    var val2 = it.; // 获取子节点值
                }
              
                var result = "";

            }
            


        }
    }
}
