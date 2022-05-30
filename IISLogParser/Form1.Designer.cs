namespace IISLogParser
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.miniToolStrip = new System.Windows.Forms.MenuStrip();
            this.MenuBar = new System.Windows.Forms.ToolStripMenuItem();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.ChkServerFocus = new System.Windows.Forms.CheckBox();
            this.ChkTimeEnd = new System.Windows.Forms.CheckBox();
            this.ChkTimeStart = new System.Windows.Forms.CheckBox();
            this.BtnApplyTimeFilter = new System.Windows.Forms.Button();
            this.TimeEnd = new System.Windows.Forms.DateTimePicker();
            this.TimeStart = new System.Windows.Forms.DateTimePicker();
            this.FileBox = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.SearchBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.MainGrid = new System.Windows.Forms.DataGridView();
            this.Date = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Time = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ServerIpAddress = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ClientMethod = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ClientUriStem = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ClientUriQuery = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ServerPort = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ClientUserName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ClientIp = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ServerUserAgent = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ClientReferer = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ScStatus = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ScSubStatus = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ScWin32Status = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TimeTaken = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.XForwardedFor = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.MainGrid)).BeginInit();
            this.tableLayoutPanel1.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // miniToolStrip
            // 
            this.miniToolStrip.AccessibleName = "New item selection";
            this.miniToolStrip.AccessibleRole = System.Windows.Forms.AccessibleRole.ComboBox;
            this.miniToolStrip.AutoSize = false;
            this.miniToolStrip.Dock = System.Windows.Forms.DockStyle.None;
            this.miniToolStrip.Location = new System.Drawing.Point(80, 2);
            this.miniToolStrip.Name = "miniToolStrip";
            this.miniToolStrip.Size = new System.Drawing.Size(82, 24);
            this.miniToolStrip.TabIndex = 12;
            // 
            // MenuBar
            // 
            this.MenuBar.Name = "MenuBar";
            this.MenuBar.Size = new System.Drawing.Size(74, 20);
            this.MenuBar.Text = "Exclusions";
            this.MenuBar.Click += new System.EventHandler(this.MenuBar_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.ChkServerFocus);
            this.groupBox1.Controls.Add(this.ChkTimeEnd);
            this.groupBox1.Controls.Add(this.ChkTimeStart);
            this.groupBox1.Controls.Add(this.BtnApplyTimeFilter);
            this.groupBox1.Controls.Add(this.TimeEnd);
            this.groupBox1.Controls.Add(this.TimeStart);
            this.groupBox1.Controls.Add(this.FileBox);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.SearchBox);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupBox1.Location = new System.Drawing.Point(3, 4);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.groupBox1.Size = new System.Drawing.Size(1628, 82);
            this.groupBox1.TabIndex = 10;
            this.groupBox1.TabStop = false;
            // 
            // ChkServerFocus
            // 
            this.ChkServerFocus.AutoSize = true;
            this.ChkServerFocus.Checked = true;
            this.ChkServerFocus.CheckState = System.Windows.Forms.CheckState.Checked;
            this.ChkServerFocus.Location = new System.Drawing.Point(248, 20);
            this.ChkServerFocus.Name = "ChkServerFocus";
            this.ChkServerFocus.Size = new System.Drawing.Size(154, 22);
            this.ChkServerFocus.TabIndex = 12;
            this.ChkServerFocus.Text = "Server request focus";
            this.ChkServerFocus.UseVisualStyleBackColor = true;
            // 
            // ChkTimeEnd
            // 
            this.ChkTimeEnd.AutoSize = true;
            this.ChkTimeEnd.Location = new System.Drawing.Point(895, 14);
            this.ChkTimeEnd.Name = "ChkTimeEnd";
            this.ChkTimeEnd.Size = new System.Drawing.Size(84, 22);
            this.ChkTimeEnd.TabIndex = 11;
            this.ChkTimeEnd.Text = "Time End";
            this.ChkTimeEnd.UseVisualStyleBackColor = true;
            // 
            // ChkTimeStart
            // 
            this.ChkTimeStart.AutoSize = true;
            this.ChkTimeStart.Location = new System.Drawing.Point(765, 14);
            this.ChkTimeStart.Name = "ChkTimeStart";
            this.ChkTimeStart.Size = new System.Drawing.Size(90, 22);
            this.ChkTimeStart.TabIndex = 11;
            this.ChkTimeStart.Text = "Time Start";
            this.ChkTimeStart.UseVisualStyleBackColor = true;
            // 
            // BtnApplyTimeFilter
            // 
            this.BtnApplyTimeFilter.Location = new System.Drawing.Point(1015, 42);
            this.BtnApplyTimeFilter.Name = "BtnApplyTimeFilter";
            this.BtnApplyTimeFilter.Size = new System.Drawing.Size(88, 26);
            this.BtnApplyTimeFilter.TabIndex = 10;
            this.BtnApplyTimeFilter.Text = "Apply";
            this.BtnApplyTimeFilter.UseVisualStyleBackColor = true;
            this.BtnApplyTimeFilter.Click += new System.EventHandler(this.BtnApplyTimeFilter_Click_1);
            // 
            // TimeEnd
            // 
            this.TimeEnd.Format = System.Windows.Forms.DateTimePickerFormat.Time;
            this.TimeEnd.Location = new System.Drawing.Point(895, 42);
            this.TimeEnd.Name = "TimeEnd";
            this.TimeEnd.ShowUpDown = true;
            this.TimeEnd.Size = new System.Drawing.Size(114, 26);
            this.TimeEnd.TabIndex = 8;
            // 
            // TimeStart
            // 
            this.TimeStart.Format = System.Windows.Forms.DateTimePickerFormat.Time;
            this.TimeStart.Location = new System.Drawing.Point(765, 42);
            this.TimeStart.Name = "TimeStart";
            this.TimeStart.ShowUpDown = true;
            this.TimeStart.Size = new System.Drawing.Size(114, 26);
            this.TimeStart.TabIndex = 9;
            // 
            // FileBox
            // 
            this.FileBox.AllowDrop = true;
            this.FileBox.Location = new System.Drawing.Point(9, 43);
            this.FileBox.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.FileBox.Name = "FileBox";
            this.FileBox.PlaceholderText = "Press Enter to load the file";
            this.FileBox.Size = new System.Drawing.Size(393, 26);
            this.FileBox.TabIndex = 1;
            this.FileBox.DragDrop += new System.Windows.Forms.DragEventHandler(this.FileBox_DragDrop);
            this.FileBox.DragOver += new System.Windows.Forms.DragEventHandler(this.FileBox_DragOver);
            this.FileBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.FileBox_KeyPress);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(9, 21);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(97, 18);
            this.label2.TabIndex = 2;
            this.label2.Text = "Drop file here:";
            // 
            // SearchBox
            // 
            this.SearchBox.Location = new System.Drawing.Point(408, 43);
            this.SearchBox.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.SearchBox.Name = "SearchBox";
            this.SearchBox.PlaceholderText = "Press Enter to search";
            this.SearchBox.Size = new System.Drawing.Size(331, 26);
            this.SearchBox.TabIndex = 1;
            this.SearchBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.SearchBox_KeyPress);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(408, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(49, 18);
            this.label1.TabIndex = 0;
            this.label1.Text = "Search";
            // 
            // MainGrid
            // 
            this.MainGrid.AllowUserToAddRows = false;
            this.MainGrid.AllowUserToDeleteRows = false;
            this.MainGrid.BackgroundColor = System.Drawing.SystemColors.ControlLight;
            this.MainGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.MainGrid.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Date,
            this.Time,
            this.ServerIpAddress,
            this.ClientMethod,
            this.ClientUriStem,
            this.ClientUriQuery,
            this.ServerPort,
            this.ClientUserName,
            this.ClientIp,
            this.ServerUserAgent,
            this.ClientReferer,
            this.ScStatus,
            this.ScSubStatus,
            this.ScWin32Status,
            this.TimeTaken,
            this.XForwardedFor});
            this.MainGrid.Dock = System.Windows.Forms.DockStyle.Fill;
            this.MainGrid.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.MainGrid.Location = new System.Drawing.Point(3, 94);
            this.MainGrid.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.MainGrid.Name = "MainGrid";
            this.MainGrid.ReadOnly = true;
            this.MainGrid.RowHeadersWidth = 25;
            this.MainGrid.RowTemplate.Height = 25;
            this.MainGrid.ShowCellErrors = false;
            this.MainGrid.Size = new System.Drawing.Size(1628, 724);
            this.MainGrid.TabIndex = 11;
            // 
            // Date
            // 
            this.Date.DataPropertyName = "Date";
            dataGridViewCellStyle1.Format = "d";
            dataGridViewCellStyle1.NullValue = null;
            this.Date.DefaultCellStyle = dataGridViewCellStyle1;
            this.Date.HeaderText = "Date";
            this.Date.Name = "Date";
            this.Date.ReadOnly = true;
            // 
            // Time
            // 
            this.Time.DataPropertyName = "Time";
            dataGridViewCellStyle2.Format = "T";
            dataGridViewCellStyle2.NullValue = null;
            this.Time.DefaultCellStyle = dataGridViewCellStyle2;
            this.Time.HeaderText = "Time";
            this.Time.Name = "Time";
            this.Time.ReadOnly = true;
            // 
            // ServerIpAddress
            // 
            this.ServerIpAddress.DataPropertyName = "ServerIpAddress";
            this.ServerIpAddress.HeaderText = "Server Ip";
            this.ServerIpAddress.Name = "ServerIpAddress";
            this.ServerIpAddress.ReadOnly = true;
            // 
            // ClientMethod
            // 
            this.ClientMethod.DataPropertyName = "ClientMethod";
            this.ClientMethod.HeaderText = "Client Method";
            this.ClientMethod.Name = "ClientMethod";
            this.ClientMethod.ReadOnly = true;
            // 
            // ClientUriStem
            // 
            this.ClientUriStem.DataPropertyName = "ClientUriStem";
            this.ClientUriStem.HeaderText = "Uri";
            this.ClientUriStem.Name = "ClientUriStem";
            this.ClientUriStem.ReadOnly = true;
            // 
            // ClientUriQuery
            // 
            this.ClientUriQuery.DataPropertyName = "ClientUriQuery";
            this.ClientUriQuery.HeaderText = "Query String";
            this.ClientUriQuery.Name = "ClientUriQuery";
            this.ClientUriQuery.ReadOnly = true;
            // 
            // ServerPort
            // 
            this.ServerPort.DataPropertyName = "ServerPort";
            this.ServerPort.HeaderText = "Port";
            this.ServerPort.Name = "ServerPort";
            this.ServerPort.ReadOnly = true;
            // 
            // ClientUserName
            // 
            this.ClientUserName.DataPropertyName = "ClientUserName";
            this.ClientUserName.HeaderText = "User Name";
            this.ClientUserName.Name = "ClientUserName";
            this.ClientUserName.ReadOnly = true;
            // 
            // ClientIp
            // 
            this.ClientIp.DataPropertyName = "ClientIp";
            this.ClientIp.HeaderText = "Ip Address";
            this.ClientIp.Name = "ClientIp";
            this.ClientIp.ReadOnly = true;
            // 
            // ServerUserAgent
            // 
            this.ServerUserAgent.DataPropertyName = "ServerUserAgent";
            this.ServerUserAgent.HeaderText = "User Agent";
            this.ServerUserAgent.Name = "ServerUserAgent";
            this.ServerUserAgent.ReadOnly = true;
            // 
            // ClientReferer
            // 
            this.ClientReferer.DataPropertyName = "ClientReferer";
            this.ClientReferer.HeaderText = "Referer";
            this.ClientReferer.Name = "ClientReferer";
            this.ClientReferer.ReadOnly = true;
            // 
            // ScStatus
            // 
            this.ScStatus.DataPropertyName = "ScStatus";
            this.ScStatus.HeaderText = "Status";
            this.ScStatus.Name = "ScStatus";
            this.ScStatus.ReadOnly = true;
            // 
            // ScSubStatus
            // 
            this.ScSubStatus.DataPropertyName = "ScSubStatus";
            this.ScSubStatus.HeaderText = "Sub Status";
            this.ScSubStatus.Name = "ScSubStatus";
            this.ScSubStatus.ReadOnly = true;
            // 
            // ScWin32Status
            // 
            this.ScWin32Status.DataPropertyName = "ScWin32Status";
            this.ScWin32Status.HeaderText = "Win32 Status";
            this.ScWin32Status.Name = "ScWin32Status";
            this.ScWin32Status.ReadOnly = true;
            // 
            // TimeTaken
            // 
            this.TimeTaken.DataPropertyName = "TimeTaken";
            this.TimeTaken.HeaderText = "Time Taken";
            this.TimeTaken.Name = "TimeTaken";
            this.TimeTaken.ReadOnly = true;
            // 
            // XForwardedFor
            // 
            this.XForwardedFor.DataPropertyName = "XForwardedFor";
            this.XForwardedFor.HeaderText = "XForwardedFor";
            this.XForwardedFor.Name = "XForwardedFor";
            this.XForwardedFor.ReadOnly = true;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Controls.Add(this.MainGrid, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.groupBox1, 0, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 3;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 90F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.Size = new System.Drawing.Size(1634, 822);
            this.tableLayoutPanel1.TabIndex = 10;
            // 
            // menuStrip1
            // 
            this.menuStrip1.Dock = System.Windows.Forms.DockStyle.None;
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.MenuBar});
            this.menuStrip1.Location = new System.Drawing.Point(0, 798);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(82, 24);
            this.menuStrip1.TabIndex = 12;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1634, 822);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.MainMenuStrip = this.miniToolStrip;
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "Form1";
            this.Text = "IIS Log Viewer";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.MainGrid)).EndInit();
            this.tableLayoutPanel1.ResumeLayout(false);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private MenuStrip miniToolStrip;
        private ToolStripMenuItem MenuBar;
        private GroupBox groupBox1;
        private CheckBox ChkTimeEnd;
        private CheckBox ChkTimeStart;
        private Button BtnApplyTimeFilter;
        private DateTimePicker TimeEnd;
        private DateTimePicker TimeStart;
        private TextBox FileBox;
        private Label label2;
        private TextBox SearchBox;
        private Label label1;
        private DataGridView MainGrid;
        private TableLayoutPanel tableLayoutPanel1;
        private MenuStrip menuStrip1;
        private CheckBox ChkServerFocus;
        private DataGridViewTextBoxColumn Date;
        private DataGridViewTextBoxColumn Time;
        private DataGridViewTextBoxColumn ServerIpAddress;
        private DataGridViewTextBoxColumn ClientMethod;
        private DataGridViewTextBoxColumn ClientUriStem;
        private DataGridViewTextBoxColumn ClientUriQuery;
        private DataGridViewTextBoxColumn ServerPort;
        private DataGridViewTextBoxColumn ClientUserName;
        private DataGridViewTextBoxColumn ClientIp;
        private DataGridViewTextBoxColumn ServerUserAgent;
        private DataGridViewTextBoxColumn ClientReferer;
        private DataGridViewTextBoxColumn ScStatus;
        private DataGridViewTextBoxColumn ScSubStatus;
        private DataGridViewTextBoxColumn ScWin32Status;
        private DataGridViewTextBoxColumn TimeTaken;
        private DataGridViewTextBoxColumn XForwardedFor;
    }
}