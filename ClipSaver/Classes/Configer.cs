using Microsoft.Win32;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;
using Vip.Notification;

namespace ClipSaver
{
    class Configer
    {
       public  enum Targets{
            lastclip= 2
        }



        public static void WriteToxml(Targets Target,string val)
        {
            string target = Gettarget(Target);
            if (target == "null")
            {
                return;
            }
            XElement t = XElement.Load(Constants.ConfigPath);
            t.Element("setting").Element(target).Value = val;
            t.Save(Constants.ConfigPath);
           
        }


        public static string Readxml(Targets Target)
        {
            string target = Gettarget(Target);
            if (target == "null")
            {
                return "null";
            }
            XElement t = XElement.Load(Constants.ConfigPath);
            return t.Element("setting").Element(target).Value;

        }


        public static void SaveData( string data)
        {

            XElement t = XElement.Load(Constants.datapath);
            var a = t.Descendants("setting").FirstOrDefault();
            a.Add(new XElement("data", data));
            t.Save(Constants.datapath);
            

        }

        public static string[] LoadData()
        {

            XElement t = XElement.Load(Constants.datapath);
            int count = t.Element("setting").Elements("data").Count();


            string[] holdarry = new string[count];
            int counter = 0;

            foreach (var status in t.Elements("setting").Elements())
            {
                string tweet = status.Value;
                if (status.Value.Length > 0)
                {
                    holdarry[counter] = tweet;
                    counter += 1;
                }
                else
                {
                    holdarry[counter] = null;
                    counter += 1;
                }
                
            }


            return holdarry;
           

        }

        private static string Gettarget(Targets target)
        {
            switch (target)
            {

                case Targets.lastclip:
                    return "lastclip";
            }
            return "null";
        }

        public static void Hanelstartup(bool addtostartup) {

            using (RegistryKey rk = Registry.CurrentUser.OpenSubKey("SOFTWARE\\Microsoft\\Windows\\CurrentVersion\\Run", true))
            {
                if (addtostartup)
                {

                    rk.SetValue("ClipSaver","\""+ Application.ExecutablePath+"\""+ " /fromstart");
                }
                else
                {
                    try
                    {

                        rk.DeleteValue("ClipSaver");
                    }
                    catch (Exception b) { }
                }

            }

           
        }

        public static void showalert(string msg)
        {
            Alert.ShowCustom(msg, false, Properties.Resources.mylogo, Color.Black);
        }

    }
}
