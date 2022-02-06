using ClipSaver.Forms;
using System;

using System.Drawing;
using System.IO;
using System.Reflection;
using System.Threading;

using System.Windows.Forms;
using Vip.Notification;
using static ClipSaver.Nativs;

namespace ClipSaver
{
    public partial class Form1 : Form
    {

        public static bool iamhidden = true;
        public static bool programitclly = true;
        public static bool programitclly2 = true;
        public static bool programitclly3 = true;
        public static bool programitclly4 = true;

        
        private IntPtr _ClipboardViewerNext;
        protected override void WndProc(ref System.Windows.Forms.Message m)
        {
            const int WM_DRAWCLIPBOARD = 0x308;

            switch (m.Msg)
            {
                case WM_DRAWCLIPBOARD:
                    try
                    {
                        if (isrunning)
                        {

                            string copiedtext = null;
                            try
                            {
                                copiedtext = ClipboardCom.GetText();
                            }
                            catch (Exception e) {
                                copiedtext = null;
                            }
                            if (copiedtext != null && copiedtext.Length > 0 && statics.LastClip != copiedtext)
                            {
                                statics.LastClip = copiedtext;

                                if (CheclDoublecate.Checked == true)
                                {
                                    if (CheckDouble(copiedtext))
                                    {
                                        goto skippit;
                                    }
                                }

                               

                                string windowname = "";

                                if (CheckWindow.Checked == true)
                                {
                                    windowname = Nativs.GetForegroundWindowTitle();
                                }
                                else
                                {
                                    windowname = "Not Saved";
                                }

                                Configer.SaveData(Tools.EBase64(statics.LastClip + "•" + DateTime.Now.ToString()+ "•" + windowname));
                                Configer.WriteToxml(Configer.Targets.lastclip, Tools.EBase64(statics.LastClip));
                               
                                    Loger(new object[] { statics.LastClip, DateTime.Now.ToString(),windowname });
                                

                            }
                        }

                    
                    }
                    catch (Exception e) { }
                skippit:
                    break;
                default:
                    base.WndProc(ref m);
                    break;
            }
        }

        public bool CheckDouble(string text) {
            if (dataGridView1.Rows.Count >0)
            {
                foreach (DataGridViewRow row in dataGridView1.Rows)
                {
                    try
                    {
                        if (row.Cells[0].Value.ToString() == text)
                        {
                            return true;
                        }
                    }
                    catch (Exception e) { }
                }
            }
            return false;
        }

        public Form1()
        {
            InitializeComponent();
        }

        private void DrakeUIButtonIcon3_Click(object sender, EventArgs e)
        {
            this.ShowInTaskbar = false;
            this.Hide();
            iamhidden = true;
            this.WindowState = FormWindowState.Minimized;
            Configer.showalert("Hello iam still here.");
            _ClipboardViewerNext = SetClipboardViewer(this.Handle);
        }
     
        private void Form1_Load(object sender, EventArgs e)
        {

            typeof(DataGridView).InvokeMember(
   "DoubleBuffered",
   BindingFlags.NonPublic | BindingFlags.Instance | BindingFlags.SetProperty,
   null,
   dataGridView1,
   new object[] { true });



            CheckWindow.Checked = statics.mysettings.Save_Windows_Name;
            CheclDoublecate.Checked = statics.mysettings.Save_Windows_Name;
            CheckClose.Checked = statics.mysettings.dontclose;



            _ClipboardViewerNext = SetClipboardViewer(this.Handle);

            this.Opacity = 0;
            Splash S = new Splash();
            S.ShowDialog();
            S.Dispose();
            if (!File.Exists(statics.ConfigPath))
            {
                File.Create(statics.ConfigPath).Dispose();
                File.WriteAllText(statics.ConfigPath,Properties.Resources.DefultConf);
            }

            if (!File.Exists(statics.datapath))
            {
                File.Create(statics.datapath).Dispose();
                File.WriteAllText(statics.datapath, Properties.Resources.Defulydata);
            }

            statics.LastClip = Configer.Readxml(Configer.Targets.lastclip);
            if (statics.LastClip != "null" && statics.LastClip.Length >0)
            {
                statics.LastClip = Tools.DBase64(statics.LastClip);
            }
            //MessageBox.Show(statics.LastClip);
            if (statics.isFromStartUp)
            {
                this.ShowInTaskbar = false;
               // this.Hide();
                iamhidden = true;
                this.WindowState = FormWindowState.Minimized;
                Worker();
                //  Alert.ShowCustom("Clip Saver Started Working", false, Properties.Resources.mylogo, Color.Lime);
                Alert.ShowSucess("Clip Saver Started Working");
                this.Opacity = 1;
            }
            else
            {
                this.Opacity = 1;
                iamhidden = false;
                checkstartup.Checked = Convert.ToBoolean(Configer.Readxml(Configer.Targets.tostartup));

                string[] olddata = Configer.LoadData();
                if (olddata != null)
                {
                    foreach (var d in olddata)
                    {
                        try
                        {
                            if (d != null)
                            {
                                string datatext = Tools.DBase64(d);
                                string[] arry = datatext.Split('•');

                                Loger(new object[] { arry[0], arry[1],arry[2] });
                            }
                            

                        }
                        catch (Exception ee) { }

                    }
                }
            }

        
        }

        delegate void Logit(object[] obj);
        public void Loger(object[] obj)
        {
            if (dataGridView1.InvokeRequired)
            {
                Logit logr = new Logit(Loger);
                this.dataGridView1.Invoke(logr, new object[] { obj});
                return;
            }
            else
            {

                dataGridView1.Rows.Add(obj[0], obj[1],obj[2]);
                dataGridView1.FirstDisplayedScrollingRowIndex = dataGridView1.RowCount - 1;
            }
        }
        public Boolean isrunning = false;
        private void Worker()
        {

            if (isrunning)
            {
                return;
            }
            
            isrunning = true;
            startbtn.Enabled = false;
            stopbtn.Enabled = true;
            stats.Text = "ClipSaver is Running...";
            stats.ForeColor = Color.Lime;

        }

        private void OpenToolStripMenuItem_Click(object sender, EventArgs e)
        {
            iamhidden = false;
            this.ShowInTaskbar = true;
            this.WindowState = FormWindowState.Normal;
            this.Show();
            _ClipboardViewerNext = SetClipboardViewer(this.Handle);
        }

        private void NotifyIcon1_MouseClick(object sender, MouseEventArgs e)
        {
            ctxminu.Show(MousePosition);
        }

        private void ExitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Environment.Exit(0);
        }

        private void Checkstartup_ValueChanged(object sender, bool value)
        {
            if (!programitclly)
            {
                if (checkstartup.Checked == true)
                {
                    Configer.WriteToxml(Configer.Targets.tostartup, "true");
                    Alert.ShowSucess("Program Add to Windows Startup");
                    Configer.Hanelstartup(true);
                }
                else
                {
                    Configer.WriteToxml(Configer.Targets.tostartup, "false");
                    Alert.ShowWarning("Program removed from Windows Startup");
                    Configer.Hanelstartup(false);
                }
            }
            programitclly = false;
        }

        private void DrakeUIButtonIcon1_Click(object sender, EventArgs e)
        {
            Worker();
            startbtn.Enabled = false;
            stopbtn.Enabled = true;
          //  Alert.ShowCustom("Clip Saver Started Working", false, Properties.Resources.mylogo, Color.Lime);
            Alert.ShowSucess("Clip Saver Started Working");
            stats.Text = "ClipSaver is Running...";
            stats.ForeColor = Color.Lime;
        }

        private void DrakeUIButtonIcon2_Click(object sender, EventArgs e)
        {
            isrunning = false;
            startbtn.Enabled = true;
            stopbtn.Enabled = false;
            //   Alert.ShowCustom("Clip Saver Stoped", false, Properties.Resources.mylogo, Color.Red);
            Alert.ShowWarning("Clip Saver Stoped");
            stats.Text = "ClipSaver is Not Running...";
            stats.ForeColor = Color.Red;

        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (CheckClose.Checked)
            {
                if (this.WindowState != FormWindowState.Minimized)
                {
                    this.ShowInTaskbar = false;
                    this.Hide();
                    iamhidden = true;
                    this.WindowState = FormWindowState.Minimized;
                    Configer.showalert("Hello iam still here.");
                    _ClipboardViewerNext = SetClipboardViewer(this.Handle);
                    e.Cancel = true;
                }
            }

          
        
         
        }

        private void CheckWindow_ValueChanged(object sender, bool value)
        {
            if (!programitclly2)
            {
                if (CheckWindow.Checked == true)
                {
                    statics.mysettings.Save_Windows_Name = true;
                    statics.mysettings.Save();
                }
                else
                {
                    statics.mysettings.Save_Windows_Name = false;
                    statics.mysettings.Save();
                    
                }
            }
            programitclly2 = false;
        }

        private void Form1_Resize(object sender, EventArgs e)
        {
          //  drakeUITabControl1.ItemSize.Width = this.Width / 3;

            drakeUITabControl1.ItemSize = new Size((this.Width / 3)-10, drakeUITabControl1.ItemSize.Height);
        }

        private void EnableToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Worker();
            startbtn.Enabled = false;
            stopbtn.Enabled = true;
            //  Alert.ShowCustom("Clip Saver Started Working", false, Properties.Resources.mylogo, Color.Lime);
            Alert.ShowSucess("Clip Saver Started Working");
            stats.Text = "ClipSaver is Running...";
            stats.ForeColor = Color.Lime;
        }

        private void DisableToolStripMenuItem_Click(object sender, EventArgs e)
        {
            isrunning = false;
            startbtn.Enabled = true;
            stopbtn.Enabled = false;
            //   Alert.ShowCustom("Clip Saver Stoped", false, Properties.Resources.mylogo, Color.Red);
            Alert.ShowWarning("Clip Saver Stoped");
            stats.Text = "ClipSaver is Not Running...";
            stats.ForeColor = Color.Red;
        }

        private void DrakeUIButtonIcon1_Click_1(object sender, EventArgs e)
        {
            if (MessageBox.Show("Are you Sure You Want to \n Delete All Saved Logs.","Warning",MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                if (File.Exists(statics.datapath))
                {
                    File.Delete(statics.datapath);
                    File.WriteAllText(statics.datapath, Properties.Resources.Defulydata);
                    dataGridView1.Rows.Clear();
                }
            }
        }

        private void CheclDoublecate_ValueChanged(object sender, bool value)
        {
            if (!programitclly3)
            {
                if (CheclDoublecate.Checked == true)
                {
                    statics.mysettings.Anti_doublecate = true;
                    statics.mysettings.Save();
                }
                else
                {
                    statics.mysettings.Anti_doublecate = false;
                    statics.mysettings.Save();

                }
            }
            programitclly3 = false;
        }

        private void CheckClose_ValueChanged(object sender, bool value)
        {
            if (!programitclly4)
            {
                if (CheckClose.Checked == true)
                {
                    statics.mysettings.dontclose = true;
                    statics.mysettings.Save();
                }
                else
                {
                    statics.mysettings.dontclose = false;
                    statics.mysettings.Save();

                }
            }
            programitclly4 = false;
        }



        private void DataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dataGridView1.SelectedRows[0].Index > -1)
            {
                DataGridViewRow Trow = dataGridView1.SelectedRows[0];
                Clipboard.SetText(Trow.Cells[0].Value.ToString());
                Alert.ShowSucess("Text Copied Successfully ✔");
            }
         
        }
    }
}
