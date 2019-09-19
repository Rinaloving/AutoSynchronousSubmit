using BLL.SubmitBll;
using CCWin;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

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

        }
    }
}
