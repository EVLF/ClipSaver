using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ClipSaver
{
    class statics
    {
        public static string ConfigPath =Application.StartupPath+ @"\"+ "CONF.xml";
        public static string datapath =Application.StartupPath+ @"\"+ "Data.xml";
        public static string LastClip = "";
        public static Properties.Settings mysettings = new Properties.Settings();
        public static Boolean isFromStartUp =false;
    }
}
