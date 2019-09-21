using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AutoSynchronousSubmit.CommonClass
{
    public class SystemHandler
    {

        public static readonly string assPath = System.Windows.Forms.Application.StartupPath + "/Model.dll";

        //Configuration config = System.Configuration.ConfigurationManager.OpenExeConfiguration(ConfigurationUserLevel.None);

        public static readonly string localBizFilePath  = System.Configuration.ConfigurationManager.OpenExeConfiguration(ConfigurationUserLevel.None).AppSettings.Settings["localBizFilePath"].Value; 


        public  static readonly string restartTime = System.Configuration.ConfigurationManager.OpenExeConfiguration(ConfigurationUserLevel.None).AppSettings.Settings["Interval"].Value;


    }
}
