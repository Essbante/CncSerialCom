namespace CncSerialCom
{
    partial class MainForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.serialPort = new System.IO.Ports.SerialPort(this.components);
            this.menuStrip = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.connectToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.disconnectToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.optionsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.displaySettingsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aboutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStrip = new System.Windows.Forms.ToolStrip();
            this.btnGoHome = new System.Windows.Forms.ToolStripButton();
            this.btnSetHome = new System.Windows.Forms.ToolStripButton();
            this.statusStrip = new System.Windows.Forms.StatusStrip();
            this.lblConnected = new System.Windows.Forms.ToolStripStatusLabel();
            this.lblConnectedSts = new System.Windows.Forms.ToolStripStatusLabel();
            this.splitContainer = new System.Windows.Forms.SplitContainer();
            this.btnClear = new System.Windows.Forms.Button();
            this.textBox = new System.Windows.Forms.RichTextBox();
            this.splitContainer2 = new System.Windows.Forms.SplitContainer();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.rbUPM = new System.Windows.Forms.RadioButton();
            this.rbInverse = new System.Windows.Forms.RadioButton();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.rbYZ = new System.Windows.Forms.RadioButton();
            this.rbXZ = new System.Windows.Forms.RadioButton();
            this.rbXY = new System.Windows.Forms.RadioButton();
            this.gbDistance = new System.Windows.Forms.GroupBox();
            this.rbRelative = new System.Windows.Forms.RadioButton();
            this.rbAbsolute = new System.Windows.Forms.RadioButton();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.rbMM = new System.Windows.Forms.RadioButton();
            this.rbInch = new System.Windows.Forms.RadioButton();
            this.tabControl = new System.Windows.Forms.TabControl();
            this.tabGcode = new System.Windows.Forms.TabPage();
            this.gbBatch = new System.Windows.Forms.GroupBox();
            this.cbPause = new System.Windows.Forms.CheckBox();
            this.lblLinesSts = new System.Windows.Forms.Label();
            this.btnStopFile = new System.Windows.Forms.Button();
            this.btnSendFile = new System.Windows.Forms.Button();
            this.lblLines = new System.Windows.Forms.Label();
            this.pbProgress = new System.Windows.Forms.ProgressBar();
            this.btnOpenFile = new System.Windows.Forms.Button();
            this.txtFile = new System.Windows.Forms.TextBox();
            this.lblFile = new System.Windows.Forms.Label();
            this.gbCommand = new System.Windows.Forms.GroupBox();
            this.lblCommand = new System.Windows.Forms.Label();
            this.txtCommand = new System.Windows.Forms.TextBox();
            this.tabManual = new System.Windows.Forms.TabPage();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.lblHotkeys = new System.Windows.Forms.Label();
            this.tableLayoutPanel = new System.Windows.Forms.TableLayoutPanel();
            this.btnXsub = new System.Windows.Forms.Button();
            this.btnXadd = new System.Windows.Forms.Button();
            this.btnYsub = new System.Windows.Forms.Button();
            this.btnYadd = new System.Windows.Forms.Button();
            this.btnZadd = new System.Windows.Forms.Button();
            this.btnZsub = new System.Windows.Forms.Button();
            this.nudXY = new System.Windows.Forms.NumericUpDown();
            this.nudZ = new System.Windows.Forms.NumericUpDown();
            this.btnXsubYsub = new System.Windows.Forms.Button();
            this.btnXsubYadd = new System.Windows.Forms.Button();
            this.btnXaddYsub = new System.Windows.Forms.Button();
            this.btnXaddYAdd = new System.Windows.Forms.Button();
            this.rbLinear = new System.Windows.Forms.RadioButton();
            this.rbSeek = new System.Windows.Forms.RadioButton();
            this.openFileDialog = new System.Windows.Forms.OpenFileDialog();
            this.lblHotkeysSts = new System.Windows.Forms.Label();
            this.seekRateToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.txtSeekRate = new System.Windows.Forms.ToolStripTextBox();
            this.feedRateToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.txtFeedRate = new System.Windows.Forms.ToolStripTextBox();
            this.menuStrip.SuspendLayout();
            this.toolStrip.SuspendLayout();
            this.statusStrip.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer)).BeginInit();
            this.splitContainer.Panel1.SuspendLayout();
            this.splitContainer.Panel2.SuspendLayout();
            this.splitContainer.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer2)).BeginInit();
            this.splitContainer2.Panel1.SuspendLayout();
            this.splitContainer2.Panel2.SuspendLayout();
            this.splitContainer2.SuspendLayout();
            this.groupBox5.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.gbDistance.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.tabControl.SuspendLayout();
            this.tabGcode.SuspendLayout();
            this.gbBatch.SuspendLayout();
            this.gbCommand.SuspendLayout();
            this.tabManual.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.tableLayoutPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudXY)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudZ)).BeginInit();
            this.SuspendLayout();
            // 
            // serialPort
            // 
            this.serialPort.DiscardNull = true;
            this.serialPort.DtrEnable = true;
            this.serialPort.PortName = "COM8";
            this.serialPort.DataReceived += new System.IO.Ports.SerialDataReceivedEventHandler(this.serialPort_DataReceived);
            // 
            // menuStrip
            // 
            this.menuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.optionsToolStripMenuItem,
            this.aboutToolStripMenuItem});
            this.menuStrip.Location = new System.Drawing.Point(0, 0);
            this.menuStrip.Name = "menuStrip";
            this.menuStrip.Size = new System.Drawing.Size(732, 24);
            this.menuStrip.TabIndex = 0;
            this.menuStrip.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.connectToolStripMenuItem,
            this.disconnectToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // connectToolStripMenuItem
            // 
            this.connectToolStripMenuItem.Name = "connectToolStripMenuItem";
            this.connectToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.connectToolStripMenuItem.Text = "Connect";
            this.connectToolStripMenuItem.Click += new System.EventHandler(this.connectToolStripMenuItem_Click);
            // 
            // disconnectToolStripMenuItem
            // 
            this.disconnectToolStripMenuItem.Name = "disconnectToolStripMenuItem";
            this.disconnectToolStripMenuItem.Size = new System.Drawing.Size(133, 22);
            this.disconnectToolStripMenuItem.Text = "Disconnect";
            this.disconnectToolStripMenuItem.Click += new System.EventHandler(this.disconnectToolStripMenuItem_Click);
            // 
            // optionsToolStripMenuItem
            // 
            this.optionsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.displaySettingsToolStripMenuItem,
            this.seekRateToolStripMenuItem,
            this.feedRateToolStripMenuItem});
            this.optionsToolStripMenuItem.Name = "optionsToolStripMenuItem";
            this.optionsToolStripMenuItem.Size = new System.Drawing.Size(61, 20);
            this.optionsToolStripMenuItem.Text = "Options";
            // 
            // displaySettingsToolStripMenuItem
            // 
            this.displaySettingsToolStripMenuItem.Name = "displaySettingsToolStripMenuItem";
            this.displaySettingsToolStripMenuItem.Size = new System.Drawing.Size(156, 22);
            this.displaySettingsToolStripMenuItem.Text = "Display settings";
            this.displaySettingsToolStripMenuItem.Click += new System.EventHandler(this.displaySettingsToolStripMenuItem_Click);
            // 
            // aboutToolStripMenuItem
            // 
            this.aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
            this.aboutToolStripMenuItem.Size = new System.Drawing.Size(52, 20);
            this.aboutToolStripMenuItem.Text = "About";
            this.aboutToolStripMenuItem.Click += new System.EventHandler(this.aboutToolStripMenuItem_Click);
            // 
            // toolStrip
            // 
            this.toolStrip.Enabled = false;
            this.toolStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btnGoHome,
            this.btnSetHome});
            this.toolStrip.Location = new System.Drawing.Point(0, 24);
            this.toolStrip.Name = "toolStrip";
            this.toolStrip.Size = new System.Drawing.Size(732, 25);
            this.toolStrip.TabIndex = 3;
            this.toolStrip.Text = "toolStrip1";
            // 
            // btnGoHome
            // 
            this.btnGoHome.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.btnGoHome.Image = ((System.Drawing.Image)(resources.GetObject("btnGoHome.Image")));
            this.btnGoHome.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnGoHome.Name = "btnGoHome";
            this.btnGoHome.Size = new System.Drawing.Size(62, 22);
            this.btnGoHome.Text = "Go Home";
            this.btnGoHome.Click += new System.EventHandler(this.btnGoHome_Click);
            // 
            // btnSetHome
            // 
            this.btnSetHome.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.btnSetHome.Image = ((System.Drawing.Image)(resources.GetObject("btnSetHome.Image")));
            this.btnSetHome.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnSetHome.Name = "btnSetHome";
            this.btnSetHome.Size = new System.Drawing.Size(63, 22);
            this.btnSetHome.Text = "Set Home";
            this.btnSetHome.Click += new System.EventHandler(this.btnSetHome_Click);
            // 
            // statusStrip
            // 
            this.statusStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.lblConnected,
            this.lblConnectedSts});
            this.statusStrip.Location = new System.Drawing.Point(0, 528);
            this.statusStrip.Name = "statusStrip";
            this.statusStrip.Size = new System.Drawing.Size(732, 22);
            this.statusStrip.TabIndex = 4;
            this.statusStrip.Text = "statusStrip1";
            // 
            // lblConnected
            // 
            this.lblConnected.Name = "lblConnected";
            this.lblConnected.Size = new System.Drawing.Size(68, 17);
            this.lblConnected.Text = "Connected:";
            // 
            // lblConnectedSts
            // 
            this.lblConnectedSts.Name = "lblConnectedSts";
            this.lblConnectedSts.Size = new System.Drawing.Size(21, 17);
            this.lblConnectedSts.Text = "no";
            // 
            // splitContainer
            // 
            this.splitContainer.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.splitContainer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer.Enabled = false;
            this.splitContainer.FixedPanel = System.Windows.Forms.FixedPanel.Panel2;
            this.splitContainer.Location = new System.Drawing.Point(0, 49);
            this.splitContainer.Name = "splitContainer";
            // 
            // splitContainer.Panel1
            // 
            this.splitContainer.Panel1.Controls.Add(this.btnClear);
            this.splitContainer.Panel1.Controls.Add(this.textBox);
            // 
            // splitContainer.Panel2
            // 
            this.splitContainer.Panel2.Controls.Add(this.splitContainer2);
            this.splitContainer.Size = new System.Drawing.Size(732, 479);
            this.splitContainer.SplitterDistance = 433;
            this.splitContainer.TabIndex = 5;
            // 
            // btnClear
            // 
            this.btnClear.Location = new System.Drawing.Point(342, 440);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(75, 23);
            this.btnClear.TabIndex = 1;
            this.btnClear.Text = "Clear";
            this.btnClear.UseVisualStyleBackColor = true;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // textBox
            // 
            this.textBox.AutoWordSelection = true;
            this.textBox.DetectUrls = false;
            this.textBox.Location = new System.Drawing.Point(3, 0);
            this.textBox.Name = "textBox";
            this.textBox.ReadOnly = true;
            this.textBox.Size = new System.Drawing.Size(418, 434);
            this.textBox.TabIndex = 0;
            this.textBox.Text = "";
            // 
            // splitContainer2
            // 
            this.splitContainer2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.splitContainer2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer2.Location = new System.Drawing.Point(0, 0);
            this.splitContainer2.Name = "splitContainer2";
            this.splitContainer2.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitContainer2.Panel1
            // 
            this.splitContainer2.Panel1.Controls.Add(this.groupBox5);
            this.splitContainer2.Panel1.Controls.Add(this.groupBox4);
            this.splitContainer2.Panel1.Controls.Add(this.gbDistance);
            this.splitContainer2.Panel1.Controls.Add(this.groupBox2);
            // 
            // splitContainer2.Panel2
            // 
            this.splitContainer2.Panel2.Controls.Add(this.tabControl);
            this.splitContainer2.Size = new System.Drawing.Size(295, 479);
            this.splitContainer2.SplitterDistance = 237;
            this.splitContainer2.TabIndex = 1;
            // 
            // groupBox5
            // 
            this.groupBox5.Controls.Add(this.rbUPM);
            this.groupBox5.Controls.Add(this.rbInverse);
            this.groupBox5.Location = new System.Drawing.Point(5, 181);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(279, 45);
            this.groupBox5.TabIndex = 7;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "Feed rate mode";
            // 
            // rbUPM
            // 
            this.rbUPM.AutoSize = true;
            this.rbUPM.Checked = true;
            this.rbUPM.Location = new System.Drawing.Point(148, 19);
            this.rbUPM.Name = "rbUPM";
            this.rbUPM.Size = new System.Drawing.Size(115, 17);
            this.rbUPM.TabIndex = 1;
            this.rbUPM.TabStop = true;
            this.rbUPM.Text = "Units/Minute (G94)";
            this.rbUPM.UseVisualStyleBackColor = true;
            this.rbUPM.CheckedChanged += new System.EventHandler(this.rbUPM_CheckedChanged);
            // 
            // rbInverse
            // 
            this.rbInverse.AutoSize = true;
            this.rbInverse.Location = new System.Drawing.Point(7, 20);
            this.rbInverse.Name = "rbInverse";
            this.rbInverse.Size = new System.Drawing.Size(111, 17);
            this.rbInverse.TabIndex = 0;
            this.rbInverse.TabStop = true;
            this.rbInverse.Text = "Inverse time (G93)";
            this.rbInverse.UseVisualStyleBackColor = true;
            this.rbInverse.CheckedChanged += new System.EventHandler(this.rbInverse_CheckedChanged);
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.rbYZ);
            this.groupBox4.Controls.Add(this.rbXZ);
            this.groupBox4.Controls.Add(this.rbXY);
            this.groupBox4.Location = new System.Drawing.Point(5, 105);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(279, 70);
            this.groupBox4.TabIndex = 6;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Plane selection";
            // 
            // rbYZ
            // 
            this.rbYZ.AutoSize = true;
            this.rbYZ.Location = new System.Drawing.Point(7, 43);
            this.rbYZ.Name = "rbYZ";
            this.rbYZ.Size = new System.Drawing.Size(68, 17);
            this.rbYZ.TabIndex = 2;
            this.rbYZ.TabStop = true;
            this.rbYZ.Text = "YZ (G19)";
            this.rbYZ.UseVisualStyleBackColor = true;
            this.rbYZ.CheckedChanged += new System.EventHandler(this.rbYZ_CheckedChanged);
            // 
            // rbXZ
            // 
            this.rbXZ.AutoSize = true;
            this.rbXZ.Location = new System.Drawing.Point(148, 20);
            this.rbXZ.Name = "rbXZ";
            this.rbXZ.Size = new System.Drawing.Size(68, 17);
            this.rbXZ.TabIndex = 1;
            this.rbXZ.TabStop = true;
            this.rbXZ.Text = "XZ (G18)";
            this.rbXZ.UseVisualStyleBackColor = true;
            this.rbXZ.CheckedChanged += new System.EventHandler(this.rbXZ_CheckedChanged);
            // 
            // rbXY
            // 
            this.rbXY.AutoSize = true;
            this.rbXY.Checked = true;
            this.rbXY.Location = new System.Drawing.Point(7, 20);
            this.rbXY.Name = "rbXY";
            this.rbXY.Size = new System.Drawing.Size(68, 17);
            this.rbXY.TabIndex = 0;
            this.rbXY.TabStop = true;
            this.rbXY.Text = "XY (G17)";
            this.rbXY.UseVisualStyleBackColor = true;
            this.rbXY.CheckedChanged += new System.EventHandler(this.rbXY_CheckedChanged);
            // 
            // gbDistance
            // 
            this.gbDistance.Controls.Add(this.rbRelative);
            this.gbDistance.Controls.Add(this.rbAbsolute);
            this.gbDistance.Location = new System.Drawing.Point(5, 54);
            this.gbDistance.Name = "gbDistance";
            this.gbDistance.Size = new System.Drawing.Size(279, 45);
            this.gbDistance.TabIndex = 5;
            this.gbDistance.TabStop = false;
            this.gbDistance.Text = "Distance mode";
            // 
            // rbRelative
            // 
            this.rbRelative.AutoSize = true;
            this.rbRelative.Location = new System.Drawing.Point(148, 20);
            this.rbRelative.Name = "rbRelative";
            this.rbRelative.Size = new System.Drawing.Size(93, 17);
            this.rbRelative.TabIndex = 1;
            this.rbRelative.TabStop = true;
            this.rbRelative.Text = "Relative (G91)";
            this.rbRelative.UseVisualStyleBackColor = true;
            this.rbRelative.CheckedChanged += new System.EventHandler(this.rbRelative_CheckedChanged);
            // 
            // rbAbsolute
            // 
            this.rbAbsolute.AutoSize = true;
            this.rbAbsolute.Checked = true;
            this.rbAbsolute.Location = new System.Drawing.Point(7, 20);
            this.rbAbsolute.Name = "rbAbsolute";
            this.rbAbsolute.Size = new System.Drawing.Size(95, 17);
            this.rbAbsolute.TabIndex = 0;
            this.rbAbsolute.TabStop = true;
            this.rbAbsolute.Text = "Absolute (G90)";
            this.rbAbsolute.UseVisualStyleBackColor = true;
            this.rbAbsolute.CheckedChanged += new System.EventHandler(this.rbAbsolute_CheckedChanged);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.rbMM);
            this.groupBox2.Controls.Add(this.rbInch);
            this.groupBox2.Location = new System.Drawing.Point(5, 3);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(279, 45);
            this.groupBox2.TabIndex = 4;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Units";
            // 
            // rbMM
            // 
            this.rbMM.AutoSize = true;
            this.rbMM.Checked = true;
            this.rbMM.Location = new System.Drawing.Point(148, 19);
            this.rbMM.Name = "rbMM";
            this.rbMM.Size = new System.Drawing.Size(100, 17);
            this.rbMM.TabIndex = 1;
            this.rbMM.TabStop = true;
            this.rbMM.Text = "Milimeters (G21)";
            this.rbMM.UseVisualStyleBackColor = true;
            this.rbMM.CheckedChanged += new System.EventHandler(this.rbMM_CheckedChanged);
            // 
            // rbInch
            // 
            this.rbInch.AutoSize = true;
            this.rbInch.Location = new System.Drawing.Point(7, 20);
            this.rbInch.Name = "rbInch";
            this.rbInch.Size = new System.Drawing.Size(75, 17);
            this.rbInch.TabIndex = 0;
            this.rbInch.TabStop = true;
            this.rbInch.Text = "Inch (G20)";
            this.rbInch.UseVisualStyleBackColor = true;
            this.rbInch.CheckedChanged += new System.EventHandler(this.rbInch_CheckedChanged);
            // 
            // tabControl
            // 
            this.tabControl.Controls.Add(this.tabGcode);
            this.tabControl.Controls.Add(this.tabManual);
            this.tabControl.Location = new System.Drawing.Point(1, 1);
            this.tabControl.Name = "tabControl";
            this.tabControl.SelectedIndex = 0;
            this.tabControl.Size = new System.Drawing.Size(290, 236);
            this.tabControl.TabIndex = 0;
            this.tabControl.SelectedIndexChanged += new System.EventHandler(this.tabControl_SelectedIndexChanged);
            this.tabControl.Enter += new System.EventHandler(this.tabControl_Enter);
            this.tabControl.KeyDown += new System.Windows.Forms.KeyEventHandler(this.tabControl_KeyDown);
            this.tabControl.Leave += new System.EventHandler(this.tabControl_Leave);
            // 
            // tabGcode
            // 
            this.tabGcode.Controls.Add(this.gbBatch);
            this.tabGcode.Controls.Add(this.gbCommand);
            this.tabGcode.Location = new System.Drawing.Point(4, 22);
            this.tabGcode.Name = "tabGcode";
            this.tabGcode.Padding = new System.Windows.Forms.Padding(3);
            this.tabGcode.Size = new System.Drawing.Size(282, 210);
            this.tabGcode.TabIndex = 1;
            this.tabGcode.Text = "Gcode";
            this.tabGcode.UseVisualStyleBackColor = true;
            // 
            // gbBatch
            // 
            this.gbBatch.Controls.Add(this.cbPause);
            this.gbBatch.Controls.Add(this.lblLinesSts);
            this.gbBatch.Controls.Add(this.btnStopFile);
            this.gbBatch.Controls.Add(this.btnSendFile);
            this.gbBatch.Controls.Add(this.lblLines);
            this.gbBatch.Controls.Add(this.pbProgress);
            this.gbBatch.Controls.Add(this.btnOpenFile);
            this.gbBatch.Controls.Add(this.txtFile);
            this.gbBatch.Controls.Add(this.lblFile);
            this.gbBatch.Location = new System.Drawing.Point(4, 80);
            this.gbBatch.Name = "gbBatch";
            this.gbBatch.Size = new System.Drawing.Size(275, 126);
            this.gbBatch.TabIndex = 1;
            this.gbBatch.TabStop = false;
            this.gbBatch.Text = "Batch";
            // 
            // cbPause
            // 
            this.cbPause.Appearance = System.Windows.Forms.Appearance.Button;
            this.cbPause.AutoSize = true;
            this.cbPause.Location = new System.Drawing.Point(111, 45);
            this.cbPause.MinimumSize = new System.Drawing.Size(75, 23);
            this.cbPause.Name = "cbPause";
            this.cbPause.Size = new System.Drawing.Size(75, 23);
            this.cbPause.TabIndex = 14;
            this.cbPause.Text = "Pause";
            this.cbPause.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.cbPause.UseVisualStyleBackColor = true;
            this.cbPause.CheckedChanged += new System.EventHandler(this.cbPause_CheckedChanged);
            // 
            // lblLinesSts
            // 
            this.lblLinesSts.AutoSize = true;
            this.lblLinesSts.Location = new System.Drawing.Point(68, 100);
            this.lblLinesSts.Name = "lblLinesSts";
            this.lblLinesSts.Size = new System.Drawing.Size(24, 13);
            this.lblLinesSts.TabIndex = 13;
            this.lblLinesSts.Text = "0/0";
            // 
            // btnStopFile
            // 
            this.btnStopFile.Location = new System.Drawing.Point(191, 44);
            this.btnStopFile.Name = "btnStopFile";
            this.btnStopFile.Size = new System.Drawing.Size(75, 23);
            this.btnStopFile.TabIndex = 12;
            this.btnStopFile.Text = "Stop";
            this.btnStopFile.UseVisualStyleBackColor = true;
            this.btnStopFile.Click += new System.EventHandler(this.btnStopFile_Click);
            // 
            // btnSendFile
            // 
            this.btnSendFile.Location = new System.Drawing.Point(29, 45);
            this.btnSendFile.Name = "btnSendFile";
            this.btnSendFile.Size = new System.Drawing.Size(75, 23);
            this.btnSendFile.TabIndex = 10;
            this.btnSendFile.Text = "Send";
            this.btnSendFile.UseVisualStyleBackColor = true;
            this.btnSendFile.Click += new System.EventHandler(this.btnSendFile_Click);
            // 
            // lblLines
            // 
            this.lblLines.AutoSize = true;
            this.lblLines.Location = new System.Drawing.Point(26, 100);
            this.lblLines.Name = "lblLines";
            this.lblLines.Size = new System.Drawing.Size(35, 13);
            this.lblLines.TabIndex = 9;
            this.lblLines.Text = "Lines:";
            // 
            // pbProgress
            // 
            this.pbProgress.Location = new System.Drawing.Point(29, 74);
            this.pbProgress.Name = "pbProgress";
            this.pbProgress.Size = new System.Drawing.Size(237, 23);
            this.pbProgress.TabIndex = 8;
            // 
            // btnOpenFile
            // 
            this.btnOpenFile.Location = new System.Drawing.Point(191, 15);
            this.btnOpenFile.Name = "btnOpenFile";
            this.btnOpenFile.Size = new System.Drawing.Size(75, 23);
            this.btnOpenFile.TabIndex = 2;
            this.btnOpenFile.Text = "Open";
            this.btnOpenFile.UseVisualStyleBackColor = true;
            this.btnOpenFile.Click += new System.EventHandler(this.btnOpenFile_Click);
            // 
            // txtFile
            // 
            this.txtFile.Location = new System.Drawing.Point(29, 18);
            this.txtFile.Name = "txtFile";
            this.txtFile.ReadOnly = true;
            this.txtFile.Size = new System.Drawing.Size(156, 20);
            this.txtFile.TabIndex = 1;
            // 
            // lblFile
            // 
            this.lblFile.AutoSize = true;
            this.lblFile.Location = new System.Drawing.Point(7, 20);
            this.lblFile.Name = "lblFile";
            this.lblFile.Size = new System.Drawing.Size(23, 13);
            this.lblFile.TabIndex = 0;
            this.lblFile.Text = "File";
            // 
            // gbCommand
            // 
            this.gbCommand.Controls.Add(this.lblCommand);
            this.gbCommand.Controls.Add(this.txtCommand);
            this.gbCommand.Location = new System.Drawing.Point(4, 14);
            this.gbCommand.Name = "gbCommand";
            this.gbCommand.Size = new System.Drawing.Size(275, 52);
            this.gbCommand.TabIndex = 0;
            this.gbCommand.TabStop = false;
            this.gbCommand.Text = "Command";
            // 
            // lblCommand
            // 
            this.lblCommand.AutoSize = true;
            this.lblCommand.Location = new System.Drawing.Point(10, 20);
            this.lblCommand.Name = "lblCommand";
            this.lblCommand.Size = new System.Drawing.Size(13, 13);
            this.lblCommand.TabIndex = 2;
            this.lblCommand.Text = ">";
            // 
            // txtCommand
            // 
            this.txtCommand.Location = new System.Drawing.Point(29, 19);
            this.txtCommand.Name = "txtCommand";
            this.txtCommand.Size = new System.Drawing.Size(237, 20);
            this.txtCommand.TabIndex = 0;
            this.txtCommand.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtCommand_KeyDown);
            // 
            // tabManual
            // 
            this.tabManual.Controls.Add(this.groupBox1);
            this.tabManual.Location = new System.Drawing.Point(4, 22);
            this.tabManual.Name = "tabManual";
            this.tabManual.Padding = new System.Windows.Forms.Padding(3);
            this.tabManual.Size = new System.Drawing.Size(282, 210);
            this.tabManual.TabIndex = 0;
            this.tabManual.Text = "Manual";
            this.tabManual.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.lblHotkeysSts);
            this.groupBox1.Controls.Add(this.lblHotkeys);
            this.groupBox1.Controls.Add(this.tableLayoutPanel);
            this.groupBox1.Controls.Add(this.rbLinear);
            this.groupBox1.Controls.Add(this.rbSeek);
            this.groupBox1.Location = new System.Drawing.Point(3, 6);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(289, 207);
            this.groupBox1.TabIndex = 4;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Motion";
            // 
            // lblHotkeys
            // 
            this.lblHotkeys.AutoSize = true;
            this.lblHotkeys.Location = new System.Drawing.Point(4, 182);
            this.lblHotkeys.Name = "lblHotkeys";
            this.lblHotkeys.Size = new System.Drawing.Size(49, 13);
            this.lblHotkeys.TabIndex = 6;
            this.lblHotkeys.Text = "Hotkeys:";
            // 
            // tableLayoutPanel
            // 
            this.tableLayoutPanel.BackColor = System.Drawing.Color.LightGreen;
            this.tableLayoutPanel.ColumnCount = 4;
            this.tableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel.Controls.Add(this.btnXsub, 1, 0);
            this.tableLayoutPanel.Controls.Add(this.btnXadd, 1, 2);
            this.tableLayoutPanel.Controls.Add(this.btnYsub, 0, 1);
            this.tableLayoutPanel.Controls.Add(this.btnYadd, 2, 1);
            this.tableLayoutPanel.Controls.Add(this.btnZadd, 3, 0);
            this.tableLayoutPanel.Controls.Add(this.btnZsub, 3, 2);
            this.tableLayoutPanel.Controls.Add(this.nudXY, 1, 1);
            this.tableLayoutPanel.Controls.Add(this.nudZ, 3, 1);
            this.tableLayoutPanel.Controls.Add(this.btnXsubYsub, 0, 0);
            this.tableLayoutPanel.Controls.Add(this.btnXsubYadd, 2, 0);
            this.tableLayoutPanel.Controls.Add(this.btnXaddYsub, 0, 2);
            this.tableLayoutPanel.Controls.Add(this.btnXaddYAdd, 2, 2);
            this.tableLayoutPanel.Location = new System.Drawing.Point(6, 43);
            this.tableLayoutPanel.Name = "tableLayoutPanel";
            this.tableLayoutPanel.RowCount = 3;
            this.tableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel.Size = new System.Drawing.Size(276, 132);
            this.tableLayoutPanel.TabIndex = 5;
            // 
            // btnXsub
            // 
            this.btnXsub.Location = new System.Drawing.Point(72, 3);
            this.btnXsub.Name = "btnXsub";
            this.btnXsub.Size = new System.Drawing.Size(63, 23);
            this.btnXsub.TabIndex = 0;
            this.btnXsub.Text = "X- (W)";
            this.btnXsub.UseVisualStyleBackColor = true;
            this.btnXsub.Click += new System.EventHandler(this.btnXsub_Click);
            // 
            // btnXadd
            // 
            this.btnXadd.Location = new System.Drawing.Point(72, 91);
            this.btnXadd.Name = "btnXadd";
            this.btnXadd.Size = new System.Drawing.Size(63, 23);
            this.btnXadd.TabIndex = 1;
            this.btnXadd.Text = "X+ (X)";
            this.btnXadd.UseVisualStyleBackColor = true;
            this.btnXadd.Click += new System.EventHandler(this.btnXadd_Click);
            // 
            // btnYsub
            // 
            this.btnYsub.Location = new System.Drawing.Point(3, 47);
            this.btnYsub.Name = "btnYsub";
            this.btnYsub.Size = new System.Drawing.Size(63, 23);
            this.btnYsub.TabIndex = 2;
            this.btnYsub.Text = "Y- (A)";
            this.btnYsub.UseVisualStyleBackColor = true;
            this.btnYsub.Click += new System.EventHandler(this.btnYsub_Click);
            // 
            // btnYadd
            // 
            this.btnYadd.Location = new System.Drawing.Point(141, 47);
            this.btnYadd.Name = "btnYadd";
            this.btnYadd.Size = new System.Drawing.Size(63, 23);
            this.btnYadd.TabIndex = 3;
            this.btnYadd.Text = "Y+ (D)";
            this.btnYadd.UseVisualStyleBackColor = true;
            this.btnYadd.Click += new System.EventHandler(this.btnYadd_Click);
            // 
            // btnZadd
            // 
            this.btnZadd.Location = new System.Drawing.Point(210, 3);
            this.btnZadd.Name = "btnZadd";
            this.btnZadd.Size = new System.Drawing.Size(63, 23);
            this.btnZadd.TabIndex = 4;
            this.btnZadd.Text = "Z+ (R)";
            this.btnZadd.UseVisualStyleBackColor = true;
            this.btnZadd.Click += new System.EventHandler(this.btnZadd_Click);
            // 
            // btnZsub
            // 
            this.btnZsub.Location = new System.Drawing.Point(210, 91);
            this.btnZsub.Name = "btnZsub";
            this.btnZsub.Size = new System.Drawing.Size(63, 23);
            this.btnZsub.TabIndex = 5;
            this.btnZsub.Text = "Z- (F)";
            this.btnZsub.UseVisualStyleBackColor = true;
            this.btnZsub.Click += new System.EventHandler(this.btnZsub_Click);
            // 
            // nudXY
            // 
            this.nudXY.DecimalPlaces = 3;
            this.nudXY.Increment = new decimal(new int[] {
            5,
            0,
            0,
            65536});
            this.nudXY.Location = new System.Drawing.Point(72, 47);
            this.nudXY.Name = "nudXY";
            this.nudXY.Size = new System.Drawing.Size(63, 20);
            this.nudXY.TabIndex = 6;
            this.nudXY.Value = new decimal(new int[] {
            1,
            0,
            0,
            65536});
            // 
            // nudZ
            // 
            this.nudZ.DecimalPlaces = 3;
            this.nudZ.Increment = new decimal(new int[] {
            5,
            0,
            0,
            65536});
            this.nudZ.Location = new System.Drawing.Point(210, 47);
            this.nudZ.Name = "nudZ";
            this.nudZ.Size = new System.Drawing.Size(63, 20);
            this.nudZ.TabIndex = 7;
            this.nudZ.Value = new decimal(new int[] {
            1,
            0,
            0,
            65536});
            // 
            // btnXsubYsub
            // 
            this.btnXsubYsub.Location = new System.Drawing.Point(3, 3);
            this.btnXsubYsub.Name = "btnXsubYsub";
            this.btnXsubYsub.Size = new System.Drawing.Size(63, 23);
            this.btnXsubYsub.TabIndex = 8;
            this.btnXsubYsub.Text = "X-/Y- (Q)";
            this.btnXsubYsub.UseVisualStyleBackColor = true;
            this.btnXsubYsub.Click += new System.EventHandler(this.btnXsubYsub_Click);
            // 
            // btnXsubYadd
            // 
            this.btnXsubYadd.Location = new System.Drawing.Point(141, 3);
            this.btnXsubYadd.Name = "btnXsubYadd";
            this.btnXsubYadd.Size = new System.Drawing.Size(63, 23);
            this.btnXsubYadd.TabIndex = 9;
            this.btnXsubYadd.Text = "X-/Y+ (E)";
            this.btnXsubYadd.UseVisualStyleBackColor = true;
            this.btnXsubYadd.Click += new System.EventHandler(this.btnXsubYadd_Click);
            // 
            // btnXaddYsub
            // 
            this.btnXaddYsub.Location = new System.Drawing.Point(3, 91);
            this.btnXaddYsub.Name = "btnXaddYsub";
            this.btnXaddYsub.Size = new System.Drawing.Size(63, 23);
            this.btnXaddYsub.TabIndex = 10;
            this.btnXaddYsub.Text = "X+/Y- (Z)";
            this.btnXaddYsub.UseVisualStyleBackColor = true;
            this.btnXaddYsub.Click += new System.EventHandler(this.btnXaddYsub_Click);
            // 
            // btnXaddYAdd
            // 
            this.btnXaddYAdd.Location = new System.Drawing.Point(141, 91);
            this.btnXaddYAdd.Name = "btnXaddYAdd";
            this.btnXaddYAdd.Size = new System.Drawing.Size(63, 23);
            this.btnXaddYAdd.TabIndex = 11;
            this.btnXaddYAdd.Text = "X+/Y+ (C)";
            this.btnXaddYAdd.UseVisualStyleBackColor = true;
            this.btnXaddYAdd.Click += new System.EventHandler(this.btnXaddYAdd_Click);
            // 
            // rbLinear
            // 
            this.rbLinear.AutoSize = true;
            this.rbLinear.Location = new System.Drawing.Point(145, 19);
            this.rbLinear.Name = "rbLinear";
            this.rbLinear.Size = new System.Drawing.Size(77, 17);
            this.rbLinear.TabIndex = 1;
            this.rbLinear.Text = "Linear (G1)";
            this.rbLinear.UseVisualStyleBackColor = true;
            // 
            // rbSeek
            // 
            this.rbSeek.AutoSize = true;
            this.rbSeek.Checked = true;
            this.rbSeek.Location = new System.Drawing.Point(7, 20);
            this.rbSeek.Name = "rbSeek";
            this.rbSeek.Size = new System.Drawing.Size(73, 17);
            this.rbSeek.TabIndex = 0;
            this.rbSeek.TabStop = true;
            this.rbSeek.Text = "Seek (G0)";
            this.rbSeek.UseVisualStyleBackColor = true;
            // 
            // openFileDialog
            // 
            this.openFileDialog.FileOk += new System.ComponentModel.CancelEventHandler(this.openFileDialog_FileOk);
            // 
            // lblHotkeysSts
            // 
            this.lblHotkeysSts.AutoSize = true;
            this.lblHotkeysSts.Location = new System.Drawing.Point(59, 182);
            this.lblHotkeysSts.Name = "lblHotkeysSts";
            this.lblHotkeysSts.Size = new System.Drawing.Size(46, 13);
            this.lblHotkeysSts.TabIndex = 7;
            this.lblHotkeysSts.Text = "Enabled";
            // 
            // seekRateToolStripMenuItem
            // 
            this.seekRateToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.txtSeekRate});
            this.seekRateToolStripMenuItem.Name = "seekRateToolStripMenuItem";
            this.seekRateToolStripMenuItem.Size = new System.Drawing.Size(156, 22);
            this.seekRateToolStripMenuItem.Text = "Seek rate";
            // 
            // txtSeekRate
            // 
            this.txtSeekRate.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtSeekRate.MaxLength = 4;
            this.txtSeekRate.Name = "txtSeekRate";
            this.txtSeekRate.Size = new System.Drawing.Size(100, 23);
            this.txtSeekRate.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtSeekRate_KeyDown);
            // 
            // feedRateToolStripMenuItem
            // 
            this.feedRateToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.txtFeedRate});
            this.feedRateToolStripMenuItem.Name = "feedRateToolStripMenuItem";
            this.feedRateToolStripMenuItem.Size = new System.Drawing.Size(156, 22);
            this.feedRateToolStripMenuItem.Text = "Feed rate";
            // 
            // txtFeedRate
            // 
            this.txtFeedRate.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtFeedRate.MaxLength = 4;
            this.txtFeedRate.Name = "txtFeedRate";
            this.txtFeedRate.Size = new System.Drawing.Size(100, 23);
            this.txtFeedRate.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtFeedRate_KeyDown);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(732, 550);
            this.Controls.Add(this.splitContainer);
            this.Controls.Add(this.statusStrip);
            this.Controls.Add(this.toolStrip);
            this.Controls.Add(this.menuStrip);
            this.MinimumSize = new System.Drawing.Size(740, 570);
            this.Name = "MainForm";
            this.Text = "Cnc Serial Com";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.MainForm_FormClosed);
            this.menuStrip.ResumeLayout(false);
            this.menuStrip.PerformLayout();
            this.toolStrip.ResumeLayout(false);
            this.toolStrip.PerformLayout();
            this.statusStrip.ResumeLayout(false);
            this.statusStrip.PerformLayout();
            this.splitContainer.Panel1.ResumeLayout(false);
            this.splitContainer.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer)).EndInit();
            this.splitContainer.ResumeLayout(false);
            this.splitContainer2.Panel1.ResumeLayout(false);
            this.splitContainer2.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer2)).EndInit();
            this.splitContainer2.ResumeLayout(false);
            this.groupBox5.ResumeLayout(false);
            this.groupBox5.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.gbDistance.ResumeLayout(false);
            this.gbDistance.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.tabControl.ResumeLayout(false);
            this.tabGcode.ResumeLayout(false);
            this.gbBatch.ResumeLayout(false);
            this.gbBatch.PerformLayout();
            this.gbCommand.ResumeLayout(false);
            this.gbCommand.PerformLayout();
            this.tabManual.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.tableLayoutPanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.nudXY)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudZ)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.IO.Ports.SerialPort serialPort;
        private System.Windows.Forms.MenuStrip menuStrip;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem optionsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem aboutToolStripMenuItem;
        private System.Windows.Forms.ToolStrip toolStrip;
        private System.Windows.Forms.ToolStripButton btnGoHome;
        private System.Windows.Forms.ToolStripButton btnSetHome;
        private System.Windows.Forms.StatusStrip statusStrip;
        private System.Windows.Forms.SplitContainer splitContainer;
        private System.Windows.Forms.SplitContainer splitContainer2;
        private System.Windows.Forms.GroupBox groupBox5;
        private System.Windows.Forms.RadioButton rbUPM;
        private System.Windows.Forms.RadioButton rbInverse;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.RadioButton rbYZ;
        private System.Windows.Forms.RadioButton rbXZ;
        private System.Windows.Forms.RadioButton rbXY;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.RadioButton rbMM;
        private System.Windows.Forms.RadioButton rbInch;
        private System.Windows.Forms.RichTextBox textBox;
        private System.Windows.Forms.GroupBox gbDistance;
        private System.Windows.Forms.RadioButton rbRelative;
        private System.Windows.Forms.RadioButton rbAbsolute;
        private System.Windows.Forms.TabControl tabControl;
        private System.Windows.Forms.TabPage tabManual;
        private System.Windows.Forms.TabPage tabGcode;
        private System.Windows.Forms.ToolStripMenuItem connectToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem disconnectToolStripMenuItem;
        private System.Windows.Forms.ToolStripStatusLabel lblConnected;
        private System.Windows.Forms.ToolStripStatusLabel lblConnectedSts;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.ToolStripMenuItem displaySettingsToolStripMenuItem;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton rbLinear;
        private System.Windows.Forms.RadioButton rbSeek;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel;
        private System.Windows.Forms.Button btnXsub;
        private System.Windows.Forms.Button btnXadd;
        private System.Windows.Forms.Button btnYsub;
        private System.Windows.Forms.Button btnYadd;
        private System.Windows.Forms.Button btnZadd;
        private System.Windows.Forms.Button btnZsub;
        private System.Windows.Forms.NumericUpDown nudXY;
        private System.Windows.Forms.NumericUpDown nudZ;
        private System.Windows.Forms.Button btnXsubYsub;
        private System.Windows.Forms.Button btnXsubYadd;
        private System.Windows.Forms.Button btnXaddYsub;
        private System.Windows.Forms.Button btnXaddYAdd;
        private System.Windows.Forms.GroupBox gbBatch;
        private System.Windows.Forms.GroupBox gbCommand;
        private System.Windows.Forms.TextBox txtCommand;
        private System.Windows.Forms.Button btnOpenFile;
        private System.Windows.Forms.TextBox txtFile;
        private System.Windows.Forms.Label lblFile;
        private System.Windows.Forms.OpenFileDialog openFileDialog;
        private System.Windows.Forms.Label lblCommand;
        private System.Windows.Forms.Label lblHotkeys;
        private System.Windows.Forms.ProgressBar pbProgress;
        private System.Windows.Forms.Label lblLinesSts;
        private System.Windows.Forms.Button btnStopFile;
        private System.Windows.Forms.Button btnSendFile;
        private System.Windows.Forms.Label lblLines;
        private System.IO.StreamReader streamReader;
        private int fileLines;
        private int FileLines
        {
            get
            {
                return fileLines;
            }
            set
            {
                fileLines = value;
                lblLinesSts.Text = sentLines + "/" + fileLines;
            }
        }

        private int sentLines;
        private int SentLines
        {
            get
            {
                return sentLines;
            }
            set
            {
                sentLines = value;
                lblLinesSts.Text = sentLines + "/" + fileLines;                
            }
        }
        private string rxString;
        private bool sendingFile;
        private System.Windows.Forms.CheckBox cbPause;
        private System.Windows.Forms.Label lblHotkeysSts;
        private System.Windows.Forms.ToolStripMenuItem seekRateToolStripMenuItem;
        private System.Windows.Forms.ToolStripTextBox txtSeekRate;
        private System.Windows.Forms.ToolStripMenuItem feedRateToolStripMenuItem;
        private System.Windows.Forms.ToolStripTextBox txtFeedRate;


    }
}

