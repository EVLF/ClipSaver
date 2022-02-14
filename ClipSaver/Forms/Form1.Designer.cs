namespace ClipSaver
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            this.startbtn = new DrakeUI.Framework.DrakeUIButtonIcon();
            this.stopbtn = new DrakeUI.Framework.DrakeUIButtonIcon();
            this.drakeUIButtonIcon3 = new DrakeUI.Framework.DrakeUIButtonIcon();
            this.notifyIcon1 = new System.Windows.Forms.NotifyIcon(this.components);
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.txt = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Dat = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Program = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ctxminu = new DrakeUI.Framework.DrakeUIContextMenuStrip();
            this.openToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.enableToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.disableToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.checkstartup = new DrakeUI.Framework.DrakeUICheckBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.drakeUITabControl1 = new DrakeUI.Framework.DrakeUITabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.stats = new System.Windows.Forms.Label();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.drakeUISymbolLabel5 = new DrakeUI.Framework.DrakeUISymbolLabel();
            this.checkhotkey = new DrakeUI.Framework.DrakeUICheckBox();
            this.drakeUISymbolLabel4 = new DrakeUI.Framework.DrakeUISymbolLabel();
            this.CheckClose = new DrakeUI.Framework.DrakeUICheckBox();
            this.drakeUISymbolLabel3 = new DrakeUI.Framework.DrakeUISymbolLabel();
            this.drakeUISymbolLabel2 = new DrakeUI.Framework.DrakeUISymbolLabel();
            this.CheclDoublecate = new DrakeUI.Framework.DrakeUICheckBox();
            this.drakeUIButtonIcon1 = new DrakeUI.Framework.DrakeUIButtonIcon();
            this.drakeUISymbolLabel1 = new DrakeUI.Framework.DrakeUISymbolLabel();
            this.CheckWindow = new DrakeUI.Framework.DrakeUICheckBox();
            this.drakeUIToolTip1 = new DrakeUI.Framework.DrakeUIToolTip(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.ctxminu.SuspendLayout();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.drakeUITabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.tabPage2.SuspendLayout();
            this.tabPage3.SuspendLayout();
            this.SuspendLayout();
            // 
            // startbtn
            // 
            this.startbtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.startbtn.Dock = System.Windows.Forms.DockStyle.Top;
            this.startbtn.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(45)))));
            this.startbtn.FillHoverColor = System.Drawing.Color.Lime;
            this.startbtn.FillPressColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(45)))));
            this.startbtn.FillSelectedColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(45)))));
            this.startbtn.Font = new System.Drawing.Font("Roboto", 12F);
            this.startbtn.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(136)))), ((int)(((byte)(229)))));
            this.startbtn.Location = new System.Drawing.Point(0, 0);
            this.startbtn.Name = "startbtn";
            this.startbtn.Radius = 20;
            this.startbtn.RectColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(45)))));
            this.startbtn.RectDisableColor = System.Drawing.Color.Black;
            this.startbtn.RectHoverColor = System.Drawing.Color.White;
            this.startbtn.RectPressColor = System.Drawing.Color.Lime;
            this.startbtn.RectSelectedColor = System.Drawing.Color.Lime;
            this.startbtn.Size = new System.Drawing.Size(468, 35);
            this.startbtn.Style = DrakeUI.Framework.UIStyle.Custom;
            this.startbtn.TabIndex = 3;
            this.startbtn.Text = "Start";
            this.startbtn.Click += new System.EventHandler(this.DrakeUIButtonIcon1_Click);
            // 
            // stopbtn
            // 
            this.stopbtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.stopbtn.Dock = System.Windows.Forms.DockStyle.Top;
            this.stopbtn.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(45)))));
            this.stopbtn.FillHoverColor = System.Drawing.Color.Red;
            this.stopbtn.FillPressColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(45)))));
            this.stopbtn.FillSelectedColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(45)))));
            this.stopbtn.Font = new System.Drawing.Font("Roboto", 12F);
            this.stopbtn.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(136)))), ((int)(((byte)(229)))));
            this.stopbtn.Location = new System.Drawing.Point(0, 35);
            this.stopbtn.Name = "stopbtn";
            this.stopbtn.Radius = 20;
            this.stopbtn.RectColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(45)))));
            this.stopbtn.RectDisableColor = System.Drawing.Color.Black;
            this.stopbtn.RectHoverColor = System.Drawing.Color.White;
            this.stopbtn.RectPressColor = System.Drawing.Color.Red;
            this.stopbtn.RectSelectedColor = System.Drawing.Color.Red;
            this.stopbtn.Size = new System.Drawing.Size(468, 35);
            this.stopbtn.Style = DrakeUI.Framework.UIStyle.Custom;
            this.stopbtn.Symbol = 61453;
            this.stopbtn.TabIndex = 4;
            this.stopbtn.Text = "Stop";
            this.stopbtn.Click += new System.EventHandler(this.DrakeUIButtonIcon2_Click);
            // 
            // drakeUIButtonIcon3
            // 
            this.drakeUIButtonIcon3.Cursor = System.Windows.Forms.Cursors.Hand;
            this.drakeUIButtonIcon3.Dock = System.Windows.Forms.DockStyle.Top;
            this.drakeUIButtonIcon3.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(45)))));
            this.drakeUIButtonIcon3.FillHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(45)))));
            this.drakeUIButtonIcon3.FillPressColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(45)))));
            this.drakeUIButtonIcon3.FillSelectedColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(45)))));
            this.drakeUIButtonIcon3.Font = new System.Drawing.Font("Roboto", 12F);
            this.drakeUIButtonIcon3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(136)))), ((int)(((byte)(229)))));
            this.drakeUIButtonIcon3.Location = new System.Drawing.Point(0, 70);
            this.drakeUIButtonIcon3.Name = "drakeUIButtonIcon3";
            this.drakeUIButtonIcon3.Radius = 20;
            this.drakeUIButtonIcon3.RectColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(45)))));
            this.drakeUIButtonIcon3.RectDisableColor = System.Drawing.Color.Black;
            this.drakeUIButtonIcon3.RectHoverColor = System.Drawing.Color.White;
            this.drakeUIButtonIcon3.RectPressColor = System.Drawing.Color.White;
            this.drakeUIButtonIcon3.RectSelectedColor = System.Drawing.Color.White;
            this.drakeUIButtonIcon3.Size = new System.Drawing.Size(468, 35);
            this.drakeUIButtonIcon3.Style = DrakeUI.Framework.UIStyle.Custom;
            this.drakeUIButtonIcon3.Symbol = 61766;
            this.drakeUIButtonIcon3.TabIndex = 5;
            this.drakeUIButtonIcon3.Text = "Hide";
            this.drakeUIButtonIcon3.Click += new System.EventHandler(this.DrakeUIButtonIcon3_Click);
            // 
            // notifyIcon1
            // 
            this.notifyIcon1.Icon = ((System.Drawing.Icon)(resources.GetObject("notifyIcon1.Icon")));
            this.notifyIcon1.Text = "ClipSaver";
            this.notifyIcon1.Visible = true;
            this.notifyIcon1.MouseClick += new System.Windows.Forms.MouseEventHandler(this.NotifyIcon1_MouseClick);
            this.notifyIcon1.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.NotifyIcon1_MouseDoubleClick);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AllowUserToResizeColumns = false;
            this.dataGridView1.AllowUserToResizeRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(45)))));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView1.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dataGridView1.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(45)))));
            this.dataGridView1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dataGridView1.ClipboardCopyMode = System.Windows.Forms.DataGridViewClipboardCopyMode.EnableWithoutHeaderText;
            this.dataGridView1.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(45)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI Semibold", 12F);
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(136)))), ((int)(((byte)(229)))));
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.txt,
            this.Dat,
            this.Program});
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(45)))));
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI Semibold", 12F);
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView1.DefaultCellStyle = dataGridViewCellStyle3;
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView1.EnableHeadersVisualStyles = false;
            this.dataGridView1.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(136)))), ((int)(((byte)(229)))));
            this.dataGridView1.Location = new System.Drawing.Point(0, 0);
            this.dataGridView1.MultiSelect = false;
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowHeadersVisible = false;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView1.RowsDefaultCellStyle = dataGridViewCellStyle4;
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(468, 380);
            this.dataGridView1.TabIndex = 6;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DataGridView1_CellClick);
            // 
            // txt
            // 
            this.txt.HeaderText = "Texts";
            this.txt.Name = "txt";
            this.txt.ReadOnly = true;
            // 
            // Dat
            // 
            this.Dat.HeaderText = "time";
            this.Dat.Name = "Dat";
            this.Dat.ReadOnly = true;
            // 
            // Program
            // 
            this.Program.HeaderText = "Program";
            this.Program.Name = "Program";
            this.Program.ReadOnly = true;
            // 
            // ctxminu
            // 
            this.ctxminu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(207)))), ((int)(((byte)(216)))), ((int)(((byte)(220)))));
            this.ctxminu.Font = new System.Drawing.Font("Roboto", 9F);
            this.ctxminu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.openToolStripMenuItem,
            this.enableToolStripMenuItem,
            this.disableToolStripMenuItem,
            this.exitToolStripMenuItem});
            this.ctxminu.Name = "ctxminu";
            this.ctxminu.ShowImageMargin = false;
            this.ctxminu.Size = new System.Drawing.Size(90, 92);
            this.ctxminu.Style = DrakeUI.Framework.UIStyle.Black;
            this.ctxminu.StyleCustomMode = true;
            // 
            // openToolStripMenuItem
            // 
            this.openToolStripMenuItem.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(45)))));
            this.openToolStripMenuItem.Font = new System.Drawing.Font("Roboto", 9F);
            this.openToolStripMenuItem.ForeColor = System.Drawing.Color.White;
            this.openToolStripMenuItem.Name = "openToolStripMenuItem";
            this.openToolStripMenuItem.Size = new System.Drawing.Size(89, 22);
            this.openToolStripMenuItem.Text = "Open";
            this.openToolStripMenuItem.Click += new System.EventHandler(this.OpenToolStripMenuItem_Click);
            // 
            // enableToolStripMenuItem
            // 
            this.enableToolStripMenuItem.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(45)))));
            this.enableToolStripMenuItem.Font = new System.Drawing.Font("Roboto", 9F);
            this.enableToolStripMenuItem.ForeColor = System.Drawing.Color.White;
            this.enableToolStripMenuItem.Name = "enableToolStripMenuItem";
            this.enableToolStripMenuItem.Size = new System.Drawing.Size(89, 22);
            this.enableToolStripMenuItem.Text = "Enable";
            this.enableToolStripMenuItem.Click += new System.EventHandler(this.EnableToolStripMenuItem_Click);
            // 
            // disableToolStripMenuItem
            // 
            this.disableToolStripMenuItem.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(45)))));
            this.disableToolStripMenuItem.Font = new System.Drawing.Font("Roboto", 9F);
            this.disableToolStripMenuItem.ForeColor = System.Drawing.Color.White;
            this.disableToolStripMenuItem.Name = "disableToolStripMenuItem";
            this.disableToolStripMenuItem.Size = new System.Drawing.Size(89, 22);
            this.disableToolStripMenuItem.Text = "Disable";
            this.disableToolStripMenuItem.Click += new System.EventHandler(this.DisableToolStripMenuItem_Click);
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(45)))));
            this.exitToolStripMenuItem.Font = new System.Drawing.Font("Roboto", 9F);
            this.exitToolStripMenuItem.ForeColor = System.Drawing.Color.White;
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(89, 22);
            this.exitToolStripMenuItem.Text = "Exit";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.ExitToolStripMenuItem_Click);
            // 
            // checkstartup
            // 
            this.checkstartup.CheckBoxColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(136)))), ((int)(((byte)(229)))));
            this.checkstartup.Cursor = System.Windows.Forms.Cursors.Hand;
            this.checkstartup.Font = new System.Drawing.Font("Roboto", 12F);
            this.checkstartup.ForeColor = System.Drawing.Color.White;
            this.checkstartup.Location = new System.Drawing.Point(27, 37);
            this.checkstartup.Name = "checkstartup";
            this.checkstartup.Padding = new System.Windows.Forms.Padding(22, 0, 0, 0);
            this.checkstartup.Size = new System.Drawing.Size(206, 29);
            this.checkstartup.Style = DrakeUI.Framework.UIStyle.Custom;
            this.checkstartup.TabIndex = 8;
            this.checkstartup.Text = "Add To Windows Startup";
            this.checkstartup.ValueChanged += new DrakeUI.Framework.DrakeUICheckBox.OnValueChanged(this.Checkstartup_ValueChanged);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.dataGridView1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(468, 380);
            this.panel1.TabIndex = 9;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.drakeUIButtonIcon3);
            this.panel2.Controls.Add(this.stopbtn);
            this.panel2.Controls.Add(this.startbtn);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(468, 114);
            this.panel2.TabIndex = 10;
            // 
            // drakeUITabControl1
            // 
            this.drakeUITabControl1.Controls.Add(this.tabPage1);
            this.drakeUITabControl1.Controls.Add(this.tabPage2);
            this.drakeUITabControl1.Controls.Add(this.tabPage3);
            this.drakeUITabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.drakeUITabControl1.DrawMode = System.Windows.Forms.TabDrawMode.OwnerDrawFixed;
            this.drakeUITabControl1.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(45)))));
            this.drakeUITabControl1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.drakeUITabControl1.ItemSize = new System.Drawing.Size(155, 40);
            this.drakeUITabControl1.Location = new System.Drawing.Point(0, 0);
            this.drakeUITabControl1.MenuStyle = DrakeUI.Framework.UIMenuStyle.Custom;
            this.drakeUITabControl1.Name = "drakeUITabControl1";
            this.drakeUITabControl1.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.drakeUITabControl1.SelectedIndex = 0;
            this.drakeUITabControl1.Size = new System.Drawing.Size(468, 420);
            this.drakeUITabControl1.SizeMode = System.Windows.Forms.TabSizeMode.Fixed;
            this.drakeUITabControl1.Style = DrakeUI.Framework.UIStyle.Custom;
            this.drakeUITabControl1.StyleCustomMode = true;
            this.drakeUITabControl1.TabBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(56)))), ((int)(((byte)(56)))), ((int)(((byte)(56)))));
            this.drakeUITabControl1.TabIndex = 7;
            this.drakeUITabControl1.TabSelectedColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(136)))), ((int)(((byte)(229)))));
            this.drakeUITabControl1.TabSelectedForeColor = System.Drawing.Color.White;
            this.drakeUITabControl1.TabSelectedHighColor = System.Drawing.Color.White;
            this.drakeUITabControl1.TabUnSelectedForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(136)))), ((int)(((byte)(229)))));
            // 
            // tabPage1
            // 
            this.tabPage1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(45)))));
            this.tabPage1.Controls.Add(this.pictureBox1);
            this.tabPage1.Controls.Add(this.panel2);
            this.tabPage1.Controls.Add(this.stats);
            this.tabPage1.Font = new System.Drawing.Font("Segoe UI Semibold", 12F);
            this.tabPage1.Location = new System.Drawing.Point(0, 40);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Size = new System.Drawing.Size(468, 380);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Home";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pictureBox1.Image = global::ClipSaver.Properties.Resources.mylogo;
            this.pictureBox1.Location = new System.Drawing.Point(0, 114);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(468, 243);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 11;
            this.pictureBox1.TabStop = false;
            // 
            // stats
            // 
            this.stats.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.stats.Font = new System.Drawing.Font("Segoe UI Semibold", 12F);
            this.stats.ForeColor = System.Drawing.Color.Red;
            this.stats.Location = new System.Drawing.Point(0, 357);
            this.stats.Name = "stats";
            this.stats.Size = new System.Drawing.Size(468, 23);
            this.stats.TabIndex = 12;
            this.stats.Text = "ClipSaver is not running";
            this.stats.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // tabPage2
            // 
            this.tabPage2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(45)))));
            this.tabPage2.Controls.Add(this.panel1);
            this.tabPage2.Font = new System.Drawing.Font("Segoe UI Semibold", 12F);
            this.tabPage2.Location = new System.Drawing.Point(0, 40);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Size = new System.Drawing.Size(468, 380);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Clips";
            // 
            // tabPage3
            // 
            this.tabPage3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(45)))));
            this.tabPage3.Controls.Add(this.drakeUISymbolLabel5);
            this.tabPage3.Controls.Add(this.checkhotkey);
            this.tabPage3.Controls.Add(this.drakeUISymbolLabel4);
            this.tabPage3.Controls.Add(this.CheckClose);
            this.tabPage3.Controls.Add(this.drakeUISymbolLabel3);
            this.tabPage3.Controls.Add(this.drakeUISymbolLabel2);
            this.tabPage3.Controls.Add(this.CheclDoublecate);
            this.tabPage3.Controls.Add(this.drakeUIButtonIcon1);
            this.tabPage3.Controls.Add(this.drakeUISymbolLabel1);
            this.tabPage3.Controls.Add(this.CheckWindow);
            this.tabPage3.Controls.Add(this.checkstartup);
            this.tabPage3.Font = new System.Drawing.Font("Segoe UI Semibold", 12F);
            this.tabPage3.Location = new System.Drawing.Point(0, 40);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Size = new System.Drawing.Size(468, 380);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "Options";
            // 
            // drakeUISymbolLabel5
            // 
            this.drakeUISymbolLabel5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.drakeUISymbolLabel5.ForeColor = System.Drawing.Color.White;
            this.drakeUISymbolLabel5.IsCircle = true;
            this.drakeUISymbolLabel5.Location = new System.Drawing.Point(278, 265);
            this.drakeUISymbolLabel5.Name = "drakeUISymbolLabel5";
            this.drakeUISymbolLabel5.Padding = new System.Windows.Forms.Padding(28, 0, 0, 0);
            this.drakeUISymbolLabel5.Size = new System.Drawing.Size(33, 35);
            this.drakeUISymbolLabel5.Style = DrakeUI.Framework.UIStyle.Custom;
            this.drakeUISymbolLabel5.StyleCustomMode = true;
            this.drakeUISymbolLabel5.Symbol = 61529;
            this.drakeUISymbolLabel5.SymbolColor = System.Drawing.SystemColors.ActiveCaption;
            this.drakeUISymbolLabel5.TabIndex = 18;
            this.drakeUIToolTip1.SetToolTip(this.drakeUISymbolLabel5, "Open small window\r\non top right to for\r\nfast text copy");
            // 
            // checkhotkey
            // 
            this.checkhotkey.CheckBoxColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(136)))), ((int)(((byte)(229)))));
            this.checkhotkey.Cursor = System.Windows.Forms.Cursors.Hand;
            this.checkhotkey.Font = new System.Drawing.Font("Roboto", 12F);
            this.checkhotkey.ForeColor = System.Drawing.Color.White;
            this.checkhotkey.Location = new System.Drawing.Point(27, 271);
            this.checkhotkey.Name = "checkhotkey";
            this.checkhotkey.Padding = new System.Windows.Forms.Padding(22, 0, 0, 0);
            this.checkhotkey.Size = new System.Drawing.Size(245, 29);
            this.checkhotkey.Style = DrakeUI.Framework.UIStyle.Custom;
            this.checkhotkey.TabIndex = 17;
            this.checkhotkey.Text = "Use HotKeys (Alt + Shift + S)";
            this.checkhotkey.ValueChanged += new DrakeUI.Framework.DrakeUICheckBox.OnValueChanged(this.Checkhotkey_ValueChanged);
            // 
            // drakeUISymbolLabel4
            // 
            this.drakeUISymbolLabel4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.drakeUISymbolLabel4.ForeColor = System.Drawing.Color.White;
            this.drakeUISymbolLabel4.IsCircle = true;
            this.drakeUISymbolLabel4.Location = new System.Drawing.Point(403, 207);
            this.drakeUISymbolLabel4.Name = "drakeUISymbolLabel4";
            this.drakeUISymbolLabel4.Padding = new System.Windows.Forms.Padding(28, 0, 0, 0);
            this.drakeUISymbolLabel4.Size = new System.Drawing.Size(33, 35);
            this.drakeUISymbolLabel4.Style = DrakeUI.Framework.UIStyle.Custom;
            this.drakeUISymbolLabel4.StyleCustomMode = true;
            this.drakeUISymbolLabel4.Symbol = 61529;
            this.drakeUISymbolLabel4.SymbolColor = System.Drawing.SystemColors.ActiveCaption;
            this.drakeUISymbolLabel4.TabIndex = 16;
            this.drakeUIToolTip1.SetToolTip(this.drakeUISymbolLabel4, "minimize ClipSaver to bottom right icons");
            // 
            // CheckClose
            // 
            this.CheckClose.CheckBoxColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(136)))), ((int)(((byte)(229)))));
            this.CheckClose.Cursor = System.Windows.Forms.Cursors.Hand;
            this.CheckClose.Font = new System.Drawing.Font("Roboto", 12F);
            this.CheckClose.ForeColor = System.Drawing.Color.White;
            this.CheckClose.Location = new System.Drawing.Point(27, 213);
            this.CheckClose.Name = "CheckClose";
            this.CheckClose.Padding = new System.Windows.Forms.Padding(22, 0, 0, 0);
            this.CheckClose.Size = new System.Drawing.Size(370, 29);
            this.CheckClose.Style = DrakeUI.Framework.UIStyle.Custom;
            this.CheckClose.TabIndex = 15;
            this.CheckClose.Text = "Send program to windows system tray on close";
            this.CheckClose.ValueChanged += new DrakeUI.Framework.DrakeUICheckBox.OnValueChanged(this.CheckClose_ValueChanged);
            // 
            // drakeUISymbolLabel3
            // 
            this.drakeUISymbolLabel3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.drakeUISymbolLabel3.ForeColor = System.Drawing.Color.White;
            this.drakeUISymbolLabel3.IsCircle = true;
            this.drakeUISymbolLabel3.Location = new System.Drawing.Point(239, 31);
            this.drakeUISymbolLabel3.Name = "drakeUISymbolLabel3";
            this.drakeUISymbolLabel3.Padding = new System.Windows.Forms.Padding(28, 0, 0, 0);
            this.drakeUISymbolLabel3.Size = new System.Drawing.Size(33, 35);
            this.drakeUISymbolLabel3.Style = DrakeUI.Framework.UIStyle.Custom;
            this.drakeUISymbolLabel3.StyleCustomMode = true;
            this.drakeUISymbolLabel3.Symbol = 61529;
            this.drakeUISymbolLabel3.SymbolColor = System.Drawing.SystemColors.ActiveCaption;
            this.drakeUISymbolLabel3.TabIndex = 14;
            this.drakeUIToolTip1.SetToolTip(this.drakeUISymbolLabel3, "Run ClipSaver When Windows Start");
            // 
            // drakeUISymbolLabel2
            // 
            this.drakeUISymbolLabel2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.drakeUISymbolLabel2.ForeColor = System.Drawing.Color.White;
            this.drakeUISymbolLabel2.IsCircle = true;
            this.drakeUISymbolLabel2.Location = new System.Drawing.Point(189, 150);
            this.drakeUISymbolLabel2.Name = "drakeUISymbolLabel2";
            this.drakeUISymbolLabel2.Padding = new System.Windows.Forms.Padding(28, 0, 0, 0);
            this.drakeUISymbolLabel2.Size = new System.Drawing.Size(33, 35);
            this.drakeUISymbolLabel2.Style = DrakeUI.Framework.UIStyle.Custom;
            this.drakeUISymbolLabel2.StyleCustomMode = true;
            this.drakeUISymbolLabel2.Symbol = 61529;
            this.drakeUISymbolLabel2.SymbolColor = System.Drawing.SystemColors.ActiveCaption;
            this.drakeUISymbolLabel2.TabIndex = 13;
            this.drakeUIToolTip1.SetToolTip(this.drakeUISymbolLabel2, "Don\'t Copy same text Twice");
            // 
            // CheclDoublecate
            // 
            this.CheclDoublecate.CheckBoxColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(136)))), ((int)(((byte)(229)))));
            this.CheclDoublecate.Cursor = System.Windows.Forms.Cursors.Hand;
            this.CheclDoublecate.Font = new System.Drawing.Font("Roboto", 12F);
            this.CheclDoublecate.ForeColor = System.Drawing.Color.White;
            this.CheclDoublecate.Location = new System.Drawing.Point(27, 156);
            this.CheclDoublecate.Name = "CheclDoublecate";
            this.CheclDoublecate.Padding = new System.Windows.Forms.Padding(22, 0, 0, 0);
            this.CheclDoublecate.Size = new System.Drawing.Size(156, 29);
            this.CheclDoublecate.Style = DrakeUI.Framework.UIStyle.Custom;
            this.CheclDoublecate.TabIndex = 12;
            this.CheclDoublecate.Text = "prevent duplicate";
            this.CheclDoublecate.ValueChanged += new DrakeUI.Framework.DrakeUICheckBox.OnValueChanged(this.CheclDoublecate_ValueChanged);
            // 
            // drakeUIButtonIcon1
            // 
            this.drakeUIButtonIcon1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.drakeUIButtonIcon1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.drakeUIButtonIcon1.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(45)))));
            this.drakeUIButtonIcon1.FillHoverColor = System.Drawing.Color.Black;
            this.drakeUIButtonIcon1.FillPressColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(45)))));
            this.drakeUIButtonIcon1.FillSelectedColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(45)))));
            this.drakeUIButtonIcon1.Font = new System.Drawing.Font("Roboto", 12F);
            this.drakeUIButtonIcon1.ForeColor = System.Drawing.Color.Red;
            this.drakeUIButtonIcon1.Location = new System.Drawing.Point(0, 345);
            this.drakeUIButtonIcon1.Name = "drakeUIButtonIcon1";
            this.drakeUIButtonIcon1.Radius = 20;
            this.drakeUIButtonIcon1.RectColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(45)))));
            this.drakeUIButtonIcon1.RectDisableColor = System.Drawing.Color.Black;
            this.drakeUIButtonIcon1.RectHoverColor = System.Drawing.Color.White;
            this.drakeUIButtonIcon1.RectPressColor = System.Drawing.Color.Lime;
            this.drakeUIButtonIcon1.RectSelectedColor = System.Drawing.Color.Lime;
            this.drakeUIButtonIcon1.Size = new System.Drawing.Size(468, 35);
            this.drakeUIButtonIcon1.Style = DrakeUI.Framework.UIStyle.Custom;
            this.drakeUIButtonIcon1.Symbol = 61944;
            this.drakeUIButtonIcon1.TabIndex = 11;
            this.drakeUIButtonIcon1.Text = "Clear All Clips";
            this.drakeUIButtonIcon1.Click += new System.EventHandler(this.DrakeUIButtonIcon1_Click_1);
            // 
            // drakeUISymbolLabel1
            // 
            this.drakeUISymbolLabel1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.drakeUISymbolLabel1.ForeColor = System.Drawing.Color.White;
            this.drakeUISymbolLabel1.IsCircle = true;
            this.drakeUISymbolLabel1.Location = new System.Drawing.Point(209, 89);
            this.drakeUISymbolLabel1.Name = "drakeUISymbolLabel1";
            this.drakeUISymbolLabel1.Padding = new System.Windows.Forms.Padding(28, 0, 0, 0);
            this.drakeUISymbolLabel1.Size = new System.Drawing.Size(33, 35);
            this.drakeUISymbolLabel1.Style = DrakeUI.Framework.UIStyle.Custom;
            this.drakeUISymbolLabel1.StyleCustomMode = true;
            this.drakeUISymbolLabel1.Symbol = 61529;
            this.drakeUISymbolLabel1.SymbolColor = System.Drawing.SystemColors.ActiveCaption;
            this.drakeUISymbolLabel1.TabIndex = 10;
            this.drakeUIToolTip1.SetToolTip(this.drakeUISymbolLabel1, "Save The Program Name where the text get Copied");
            // 
            // CheckWindow
            // 
            this.CheckWindow.CheckBoxColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(136)))), ((int)(((byte)(229)))));
            this.CheckWindow.Cursor = System.Windows.Forms.Cursors.Hand;
            this.CheckWindow.Font = new System.Drawing.Font("Roboto", 12F);
            this.CheckWindow.ForeColor = System.Drawing.Color.White;
            this.CheckWindow.Location = new System.Drawing.Point(27, 95);
            this.CheckWindow.Name = "CheckWindow";
            this.CheckWindow.Padding = new System.Windows.Forms.Padding(22, 0, 0, 0);
            this.CheckWindow.Size = new System.Drawing.Size(176, 29);
            this.CheckWindow.Style = DrakeUI.Framework.UIStyle.Custom;
            this.CheckWindow.TabIndex = 9;
            this.CheckWindow.Text = "Save Program Name";
            this.CheckWindow.ValueChanged += new DrakeUI.Framework.DrakeUICheckBox.OnValueChanged(this.CheckWindow_ValueChanged);
            // 
            // drakeUIToolTip1
            // 
            this.drakeUIToolTip1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(54)))), ((int)(((byte)(54)))));
            this.drakeUIToolTip1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(239)))), ((int)(((byte)(239)))));
            this.drakeUIToolTip1.OwnerDraw = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(45)))));
            this.ClientSize = new System.Drawing.Size(468, 420);
            this.Controls.Add(this.drakeUITabControl1);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.SizableToolWindow;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MinimumSize = new System.Drawing.Size(484, 459);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ClipSaver";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            this.Load += new System.EventHandler(this.Form1_Load);
            this.Resize += new System.EventHandler(this.Form1_Resize);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ctxminu.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.drakeUITabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.tabPage2.ResumeLayout(false);
            this.tabPage3.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private DrakeUI.Framework.DrakeUIButtonIcon startbtn;
        private DrakeUI.Framework.DrakeUIButtonIcon stopbtn;
        private DrakeUI.Framework.DrakeUIButtonIcon drakeUIButtonIcon3;
        private System.Windows.Forms.NotifyIcon notifyIcon1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private DrakeUI.Framework.DrakeUIContextMenuStrip ctxminu;
        private System.Windows.Forms.ToolStripMenuItem openToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem enableToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem disableToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private DrakeUI.Framework.DrakeUICheckBox checkstartup;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label stats;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.TabPage tabPage3;
        private DrakeUI.Framework.DrakeUISymbolLabel drakeUISymbolLabel1;
        private DrakeUI.Framework.DrakeUIToolTip drakeUIToolTip1;
        private DrakeUI.Framework.DrakeUICheckBox CheckWindow;
        private System.Windows.Forms.DataGridViewTextBoxColumn txt;
        private System.Windows.Forms.DataGridViewTextBoxColumn Dat;
        private System.Windows.Forms.DataGridViewTextBoxColumn Program;
        public DrakeUI.Framework.DrakeUITabControl drakeUITabControl1;
        private DrakeUI.Framework.DrakeUIButtonIcon drakeUIButtonIcon1;
        private DrakeUI.Framework.DrakeUISymbolLabel drakeUISymbolLabel3;
        private DrakeUI.Framework.DrakeUISymbolLabel drakeUISymbolLabel2;
        private DrakeUI.Framework.DrakeUICheckBox CheclDoublecate;
        private DrakeUI.Framework.DrakeUISymbolLabel drakeUISymbolLabel4;
        private DrakeUI.Framework.DrakeUICheckBox CheckClose;
        private DrakeUI.Framework.DrakeUICheckBox checkhotkey;
        private DrakeUI.Framework.DrakeUISymbolLabel drakeUISymbolLabel5;
    }
}

