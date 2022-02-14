using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ClipSaver
{
    class Constants
    {
        public static string ConfigPath =Application.StartupPath+ @"\"+ "CONF.xml";
        public static string datapath =Application.StartupPath+ @"\"+ "Data.xml";
        public static string LastClip = "";
        public static Properties.Settings mysettings = new Properties.Settings();
        public static Boolean isFromStartUp =false;


        public const int NOMOD = 0x0000;
        public const int ALT = 0x0001;
        public const int CTRL = 0x0002;
        public const int SHIFT = 0x0004;
        public const int WIN = 0x0008;
        public const int WM_HOTKEY_MSG_ID = 0x0312;
    }
}
