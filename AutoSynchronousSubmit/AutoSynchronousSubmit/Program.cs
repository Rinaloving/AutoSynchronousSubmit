using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AutoSynchronousSubmit
{
    static class Program
    {
        /// <summary>
        /// 应用程序的主入口点。
        /// </summary>
        [STAThread]
        static void Main()
        {
            bool runone;

            System.Threading.Mutex run = new System.Threading.Mutex(true,"monitor",out runone);
            if (runone)
            {
                Application.EnableVisualStyles();
                Application.SetCompatibleTextRenderingDefault(false);
                Application.Run(new SynchronousSubmit());
            }
            else
            {
                MessageBox.Show("已经运行了一个实例。");
            }

           
        }
    }
}
