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
        public static bool programitclly5 = true;

        
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
                            catch (Exception ) {
                                copiedtext = null;
                            }
                            if (copiedtext != null && copiedtext.Length > 0 && Constants.LastClip != copiedtext)
                            {
                                Constants.LastClip = copiedtext;

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

                                Configer.SaveData(Tools.EBase64(Constants.LastClip + "•" + DateTime.Now.ToString()+ "•" + windowname));
                                Configer.WriteToxml(Configer.Targets.lastclip, Tools.EBase64(Constants.LastClip));

                                Loger(new object[] { Constants.LastClip, DateTime.Now.ToString(), windowname });
                                

                            }
                        }

                    
                    }
                    catch (Exception ) { }
                skippit:
                    base.WndProc(ref m);
                    break;

                case Constants.WM_HOTKEY_MSG_ID:
                    HandleHotkey();
                    base.WndProc(ref m);
                    break;

                default:
                    base.WndProc(ref m);
                    break;
            }
        }

        public static Quickview vew;

        private void HandleHotkey()
        {

            if (iamhidden && checkhotkey.Checked == true)
            {

                if (dataGridView1.Rows.Count > 0)
                {
                    string[] hold = new string[dataGridView1.Rows.Count];
                    int cont = 0;
                    foreach (DataGridViewRow item in dataGridView1.Rows)
                    {
                        hold[cont] = item.Cells[0].Value.ToString();
                        cont += 1;
                    }


                    if (vew == null)
                    {
                        vew = new Quickview(hold);
                        
                        vew.Show();
                        
                    }
                   
                }

               

               // iamhidden = false;
               // this.ShowInTaskbar = true;
                
               // drakeUITabControl1.SelectedIndex = 1;
               // this.WindowState = FormWindowState.Normal;

               //// this.Show();
               
               // _ClipboardViewerNext = SetClipboardViewer(this.Handle);
               // ghk = new KeyHandler(Constants.CTRL, Keys.F, this);
               // ghk.Register();
               // drakeUITabControl1.TabVisible = false;
              
               
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
        private KeyHandler ghk;
        public Form1()
        {
            InitializeComponent();
            ghk = new KeyHandler(Constants.ALT + Constants.SHIFT, Keys.S, this);
            ghk.Register();
            
        }

        private void DrakeUIButtonIcon3_Click(object sender, EventArgs e)
        {
            this.ShowInTaskbar = false;
            this.Hide();
            iamhidden = true;
            this.WindowState = FormWindowState.Minimized;
            Configer.showalert("Hello iam still here.");
            _ClipboardViewerNext = SetClipboardViewer(this.Handle);
            ghk = new KeyHandler(Constants.ALT + Constants.SHIFT, Keys.S, this);
            ghk.Register();
        }
     
        private void Form1_Load(object sender, EventArgs e)
        {
            if (!File.Exists(Constants.ConfigPath))
            {
                File.Create(Constants.ConfigPath).Dispose();
                File.WriteAllText(Constants.ConfigPath, Properties.Resources.DefultConf);
            }

            if (!File.Exists(Constants.datapath))
            {
                File.Create(Constants.datapath).Dispose();
                File.WriteAllText(Constants.datapath, Properties.Resources.Defulydata);
            }

            typeof(DataGridView).InvokeMember(
   "DoubleBuffered",
   BindingFlags.NonPublic | BindingFlags.Instance | BindingFlags.SetProperty,
   null,
   dataGridView1,
   new object[] { true });



            CheckWindow.Checked = Constants.mysettings.Save_Windows_Name;
            CheclDoublecate.Checked = Constants.mysettings.Save_Windows_Name;
            CheckClose.Checked = Constants.mysettings.dontclose;
            checkhotkey.Checked = Constants.mysettings.usehotkeys;
            checkstartup.Checked = Constants.mysettings.Add_toStart;



            _ClipboardViewerNext = SetClipboardViewer(this.Handle);
            ghk = new KeyHandler(Constants.ALT + Constants.SHIFT, Keys.S, this);
            ghk.Register();
            this.Opacity = 0;
            Splash S = new Splash();
            S.ShowDialog();
            S.Dispose();
           

            Constants.LastClip = Configer.Readxml(Configer.Targets.lastclip);
            if (Constants.LastClip != "null" && Constants.LastClip.Length >0)
            {
                Constants.LastClip = Tools.DBase64(Constants.LastClip);
            }
            //MessageBox.Show(statics.LastClip);
            if (Constants.isFromStartUp)
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
            ghk = new KeyHandler(Constants.ALT + Constants.SHIFT, Keys.S, this);
            ghk.Register();
        }

        private void NotifyIcon1_MouseClick(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Right)
            {
                ctxminu.Show(MousePosition);
            }
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
                   
                    Constants.mysettings.Add_toStart = true;
                    Constants.mysettings.Save();
                    Alert.ShowSucess("Program Add to Windows Startup");
                    Configer.Hanelstartup(true);
                }
                else
                {
                   
                    Constants.mysettings.Add_toStart = false;
                    Constants.mysettings.Save();
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
                
                }
            }

            _ClipboardViewerNext = SetClipboardViewer(this.Handle);
            ghk = new KeyHandler(Constants.CTRL + Constants.ALT + Constants.SHIFT, Keys.S, this);
            ghk.Register();
            e.Cancel = true;


        }

        private void CheckWindow_ValueChanged(object sender, bool value)
        {
            if (!programitclly2)
            {
                if (CheckWindow.Checked == true)
                {
                    Constants.mysettings.Save_Windows_Name = true;
                    Constants.mysettings.Save();
                }
                else
                {
                    Constants.mysettings.Save_Windows_Name = false;
                    Constants.mysettings.Save();
                    
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
                if (File.Exists(Constants.datapath))
                {
                    File.Delete(Constants.datapath);
                    File.WriteAllText(Constants.datapath, Properties.Resources.Defulydata);
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
                    Constants.mysettings.Anti_doublecate = true;
                    Constants.mysettings.Save();
                }
                else
                {
                    Constants.mysettings.Anti_doublecate = false;
                    Constants.mysettings.Save();

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
                    Constants.mysettings.dontclose = true;
                    Constants.mysettings.Save();
                }
                else
                {
                    Constants.mysettings.dontclose = false;
                    Constants.mysettings.Save();

                }
            }
            programitclly4 = false;
        }



        private void DataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dataGridView1.SelectedRows[0].Index > -1)
            {
                DataGridViewRow Trow = dataGridView1.SelectedRows[0];
                isrunning = false;
                Clipboard.SetText(Trow.Cells[0].Value.ToString());
                isrunning = true;
                Alert.ShowSucess("Text Copied Successfully ✔");
            }
         
        }

        private void Checkhotkey_ValueChanged(object sender, bool value)
        {
            if (!programitclly5)
            {
                if (checkhotkey.Checked == true)
                {
                    Constants.mysettings.usehotkeys = true;
                    Constants.mysettings.Save();
                }
                else
                {
                    Constants.mysettings.usehotkeys = false;
                    Constants.mysettings.Save();

                }
            }
            programitclly5 = false;
        }

        private void NotifyIcon1_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            iamhidden = false;
            this.ShowInTaskbar = true;
            this.WindowState = FormWindowState.Normal;
            this.Show();
            this.TopMost = true;
            _ClipboardViewerNext = SetClipboardViewer(this.Handle);
            ghk = new KeyHandler(Constants.ALT + Constants.SHIFT, Keys.S, this);
            ghk.Register();
        }
    }
}
