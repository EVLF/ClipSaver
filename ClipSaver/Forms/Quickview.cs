using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Vip.Notification;

namespace ClipSaver.Forms
{
    public partial class Quickview : Form
    {
        [DllImport("user32.dll")]
        private static extern int SetForegroundWindow(IntPtr hwnd);

        /// <summary>
        /// onVisible focus input username text box
        /// </summary>
        protected override void OnVisibleChanged(EventArgs e)
        {
            SetForegroundWindow(this.Handle);
            base.OnVisibleChanged(e);
        }
        private string[] thedata;
       
        public Quickview(string[] data)
        {
            InitializeComponent();
            thedata = data;
          
        }

        private void Quickview_Load(object sender, EventArgs e)
        {


            typeof(DataGridView).InvokeMember(
   "DoubleBuffered",
   BindingFlags.NonPublic | BindingFlags.Instance | BindingFlags.SetProperty,
   null,
   DGV,
   new object[] { true });

            Location = MousePosition;
            foreach (string s in thedata)
            {
                if (s != null && s.Length >0)
                {
                    DGV.Rows.Add(s);
                }
            }

            Location = new Point(Screen.PrimaryScreen.WorkingArea.Width - Width, 0);
            DGV.FirstDisplayedScrollingRowIndex = DGV.RowCount - 1;
            Nativs.ShowInactiveTopmost(this);
        }

        private void DrakeUIButton1_Click(object sender, EventArgs e)
        {
            this.Close();
            Form1.vew = null;
        }

        private void DGV_CellClick(object sender, DataGridViewCellEventArgs e)
        {
           
        }

        private void Quickview_Deactivate(object sender, EventArgs e)
        {
            this.Close();
            Form1.vew = null;
        }

        private void DGV_CellClick_1(object sender, DataGridViewCellEventArgs e)
        {
            if (DGV.SelectedRows[0].Index > -1)
            {
                DataGridViewRow Trow = DGV.SelectedRows[0];

                Clipboard.SetText(Trow.Cells[0].Value.ToString());

                Alert.ShowSucess("Text Copied Successfully ✔");
                this.Close();
                Form1.vew = null;
            }
        }


        public DataGridViewRow oldrow = null;
        List<string> ignors =new List<string>();
        private void DrakeUIButtonIcon1_Click(object sender, EventArgs e)
        {
            
            if (SearchText.Text.Length > 0)
            {
                string searchValue = SearchText.Text;
                bool notfound = true;
                DGV.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
                try
                {
                    foreach (DataGridViewRow row in DGV.Rows)
                    {
                        try
                        {
                            if (row.Cells[0].Value.ToString().ToLower().Contains(searchValue.ToLower()) && row != oldrow && !ignors.Contains(row.Index.ToString()))
                            {
                                ignors.Add(row.Index.ToString());
                                DGV.ClearSelection();
                                oldrow = row;
                                row.Selected = true;
                                notfound = false;
                                DGV.FirstDisplayedScrollingRowIndex = DGV.SelectedRows[0].Index;
                                break;
                            }
                        }
                        catch (Exception ee) { }
                    }
                    if (notfound)
                    {
                        Alert.ShowInformation("No More Result");
                        ignors.Clear();
                    }
                }
                catch (Exception exc)
                {
                     //MessageBox.Show(exc.Message);
                }
            }
        }

        private void Quickview_FormClosed(object sender, FormClosedEventArgs e)
        {
            ignors.Clear();
        }
    }
}
