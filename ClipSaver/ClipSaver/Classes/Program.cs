using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ClipSaver
{
    static class Program
    {

       public static Mutex mutex = new System.Threading.Mutex(false, "CilpSaverMUTEX");
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main(string[] args)
        {
           
            try
            {
                if (mutex.WaitOne(0, false))
                {
                    // Run the application
                    if (args.Length > 0)
                    {
                        if (args[0].Replace("/", "") == "fromstart")
                        {
                            statics.isFromStartUp = true;
                        }

                    }
                    Application.EnableVisualStyles();
                    Application.SetCompatibleTextRenderingDefault(false);
                    Application.Run(new Form1());
                }
                else
                {
                    MessageBox.Show("The Application is Already Running.");
                }
            }
            finally
            {
                if (mutex != null)
                {
                    mutex.Close();
                    mutex = null;
                }
            }

           

           
        }
    }
}
