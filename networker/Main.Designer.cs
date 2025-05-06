namespace networker
{
    partial class Main
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Main));
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.stripStatus = new System.Windows.Forms.ToolStripStatusLabel();
            this.statusScan = new System.Windows.Forms.ToolStripProgressBar();
            this.mc_label = new System.Windows.Forms.ToolStripStatusLabel();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saveToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.allDevicesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.selectedDevicesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.allDevicesPortToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.selectedDevicePortsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exportToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.allToHtmlToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.allToCsvToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.allToXmlToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.allToJsonToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem4 = new System.Windows.Forms.ToolStripSeparator();
            this.quitCTRLQToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.networkInfoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem3 = new System.Windows.Forms.ToolStripSeparator();
            this.aboutNetworkerToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aboutMaccaComputerToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.bgWorker = new System.ComponentModel.BackgroundWorker();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.stripSTART = new System.Windows.Forms.ToolStripButton();
            this.stripSTOP = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.stripRESCAN = new System.Windows.Forms.ToolStripButton();
            this.panel1 = new System.Windows.Forms.Panel();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.statusStrip1.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.toolStrip1.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // statusStrip1
            // 
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.stripStatus,
            this.statusScan,
            this.mc_label});
            this.statusStrip1.Location = new System.Drawing.Point(0, 428);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(914, 22);
            this.statusStrip1.TabIndex = 0;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // stripStatus
            // 
            this.stripStatus.BorderSides = ((System.Windows.Forms.ToolStripStatusLabelBorderSides)((((System.Windows.Forms.ToolStripStatusLabelBorderSides.Left | System.Windows.Forms.ToolStripStatusLabelBorderSides.Top) 
            | System.Windows.Forms.ToolStripStatusLabelBorderSides.Right) 
            | System.Windows.Forms.ToolStripStatusLabelBorderSides.Bottom)));
            this.stripStatus.BorderStyle = System.Windows.Forms.Border3DStyle.Sunken;
            this.stripStatus.Font = new System.Drawing.Font("MS Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.stripStatus.Name = "stripStatus";
            this.stripStatus.Size = new System.Drawing.Size(63, 17);
            this.stripStatus.Text = "STATO_APP";
            // 
            // statusScan
            // 
            this.statusScan.Name = "statusScan";
            this.statusScan.Size = new System.Drawing.Size(100, 16);
            // 
            // mc_label
            // 
            this.mc_label.BorderSides = ((System.Windows.Forms.ToolStripStatusLabelBorderSides)((((System.Windows.Forms.ToolStripStatusLabelBorderSides.Left | System.Windows.Forms.ToolStripStatusLabelBorderSides.Top) 
            | System.Windows.Forms.ToolStripStatusLabelBorderSides.Right) 
            | System.Windows.Forms.ToolStripStatusLabelBorderSides.Bottom)));
            this.mc_label.BorderStyle = System.Windows.Forms.Border3DStyle.Sunken;
            this.mc_label.Font = new System.Drawing.Font("MS Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.mc_label.Name = "mc_label";
            this.mc_label.Size = new System.Drawing.Size(237, 17);
            this.mc_label.Text = "more software at www.maccacomputer.com";
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.toolStripMenuItem1});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(914, 24);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.saveToolStripMenuItem,
            this.exportToolStripMenuItem,
            this.toolStripMenuItem4,
            this.quitCTRLQToolStripMenuItem});
            this.fileToolStripMenuItem.Font = new System.Drawing.Font("MS Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(41, 20);
            this.fileToolStripMenuItem.Text = "file";
            // 
            // saveToolStripMenuItem
            // 
            this.saveToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.allDevicesToolStripMenuItem,
            this.selectedDevicesToolStripMenuItem,
            this.allDevicesPortToolStripMenuItem,
            this.selectedDevicePortsToolStripMenuItem});
            this.saveToolStripMenuItem.Name = "saveToolStripMenuItem";
            this.saveToolStripMenuItem.Size = new System.Drawing.Size(148, 22);
            this.saveToolStripMenuItem.Text = "save";
            // 
            // allDevicesToolStripMenuItem
            // 
            this.allDevicesToolStripMenuItem.Name = "allDevicesToolStripMenuItem";
            this.allDevicesToolStripMenuItem.Size = new System.Drawing.Size(208, 22);
            this.allDevicesToolStripMenuItem.Text = "all devices";
            // 
            // selectedDevicesToolStripMenuItem
            // 
            this.selectedDevicesToolStripMenuItem.Name = "selectedDevicesToolStripMenuItem";
            this.selectedDevicesToolStripMenuItem.Size = new System.Drawing.Size(208, 22);
            this.selectedDevicesToolStripMenuItem.Text = "selected device";
            // 
            // allDevicesPortToolStripMenuItem
            // 
            this.allDevicesPortToolStripMenuItem.Name = "allDevicesPortToolStripMenuItem";
            this.allDevicesPortToolStripMenuItem.Size = new System.Drawing.Size(208, 22);
            this.allDevicesPortToolStripMenuItem.Text = "all devices + ports";
            // 
            // selectedDevicePortsToolStripMenuItem
            // 
            this.selectedDevicePortsToolStripMenuItem.Name = "selectedDevicePortsToolStripMenuItem";
            this.selectedDevicePortsToolStripMenuItem.Size = new System.Drawing.Size(208, 22);
            this.selectedDevicePortsToolStripMenuItem.Text = "selected device + ports";
            // 
            // exportToolStripMenuItem
            // 
            this.exportToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.allToHtmlToolStripMenuItem,
            this.allToCsvToolStripMenuItem,
            this.allToXmlToolStripMenuItem,
            this.allToJsonToolStripMenuItem});
            this.exportToolStripMenuItem.Name = "exportToolStripMenuItem";
            this.exportToolStripMenuItem.Size = new System.Drawing.Size(148, 22);
            this.exportToolStripMenuItem.Text = "export";
            // 
            // allToHtmlToolStripMenuItem
            // 
            this.allToHtmlToolStripMenuItem.Name = "allToHtmlToolStripMenuItem";
            this.allToHtmlToolStripMenuItem.Size = new System.Drawing.Size(136, 22);
            this.allToHtmlToolStripMenuItem.Text = "all to html";
            // 
            // allToCsvToolStripMenuItem
            // 
            this.allToCsvToolStripMenuItem.Name = "allToCsvToolStripMenuItem";
            this.allToCsvToolStripMenuItem.Size = new System.Drawing.Size(136, 22);
            this.allToCsvToolStripMenuItem.Text = "all to csv";
            // 
            // allToXmlToolStripMenuItem
            // 
            this.allToXmlToolStripMenuItem.Name = "allToXmlToolStripMenuItem";
            this.allToXmlToolStripMenuItem.Size = new System.Drawing.Size(136, 22);
            this.allToXmlToolStripMenuItem.Text = "all to xml";
            // 
            // allToJsonToolStripMenuItem
            // 
            this.allToJsonToolStripMenuItem.Name = "allToJsonToolStripMenuItem";
            this.allToJsonToolStripMenuItem.Size = new System.Drawing.Size(136, 22);
            this.allToJsonToolStripMenuItem.Text = "all to json";
            // 
            // toolStripMenuItem4
            // 
            this.toolStripMenuItem4.Name = "toolStripMenuItem4";
            this.toolStripMenuItem4.Size = new System.Drawing.Size(145, 6);
            // 
            // quitCTRLQToolStripMenuItem
            // 
            this.quitCTRLQToolStripMenuItem.Name = "quitCTRLQToolStripMenuItem";
            this.quitCTRLQToolStripMenuItem.Size = new System.Drawing.Size(148, 22);
            this.quitCTRLQToolStripMenuItem.Text = "quit (CTRL+Q)";
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.networkInfoToolStripMenuItem,
            this.toolStripMenuItem3,
            this.aboutNetworkerToolStripMenuItem,
            this.aboutMaccaComputerToolStripMenuItem});
            this.toolStripMenuItem1.Font = new System.Drawing.Font("MS Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(23, 20);
            this.toolStripMenuItem1.Text = "?";
            // 
            // networkInfoToolStripMenuItem
            // 
            this.networkInfoToolStripMenuItem.Name = "networkInfoToolStripMenuItem";
            this.networkInfoToolStripMenuItem.Size = new System.Drawing.Size(190, 22);
            this.networkInfoToolStripMenuItem.Text = "network info";
            // 
            // toolStripMenuItem3
            // 
            this.toolStripMenuItem3.Name = "toolStripMenuItem3";
            this.toolStripMenuItem3.Size = new System.Drawing.Size(187, 6);
            // 
            // aboutNetworkerToolStripMenuItem
            // 
            this.aboutNetworkerToolStripMenuItem.Name = "aboutNetworkerToolStripMenuItem";
            this.aboutNetworkerToolStripMenuItem.Size = new System.Drawing.Size(190, 22);
            this.aboutNetworkerToolStripMenuItem.Text = "about networker";
            // 
            // aboutMaccaComputerToolStripMenuItem
            // 
            this.aboutMaccaComputerToolStripMenuItem.Name = "aboutMaccaComputerToolStripMenuItem";
            this.aboutMaccaComputerToolStripMenuItem.Size = new System.Drawing.Size(190, 22);
            this.aboutMaccaComputerToolStripMenuItem.Text = "about macca computer";
            // 
            // toolStrip1
            // 
            this.toolStrip1.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden;
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.stripSTART,
            this.stripSTOP,
            this.toolStripSeparator1,
            this.stripRESCAN});
            this.toolStrip1.Location = new System.Drawing.Point(0, 24);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(914, 25);
            this.toolStrip1.TabIndex = 2;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // stripSTART
            // 
            this.stripSTART.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.stripSTART.Image = ((System.Drawing.Image)(resources.GetObject("stripSTART.Image")));
            this.stripSTART.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.stripSTART.Name = "stripSTART";
            this.stripSTART.Size = new System.Drawing.Size(23, 22);
            this.stripSTART.Text = "start scan";
            // 
            // stripSTOP
            // 
            this.stripSTOP.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.stripSTOP.Image = ((System.Drawing.Image)(resources.GetObject("stripSTOP.Image")));
            this.stripSTOP.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.stripSTOP.Name = "stripSTOP";
            this.stripSTOP.Size = new System.Drawing.Size(23, 22);
            this.stripSTOP.Text = "stop scan";
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(6, 25);
            // 
            // stripRESCAN
            // 
            this.stripRESCAN.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.stripRESCAN.Image = ((System.Drawing.Image)(resources.GetObject("stripRESCAN.Image")));
            this.stripRESCAN.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.stripRESCAN.Name = "stripRESCAN";
            this.stripRESCAN.Size = new System.Drawing.Size(23, 22);
            this.stripRESCAN.Text = "rescan item";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.dataGridView1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 49);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(914, 379);
            this.panel1.TabIndex = 3;
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView1.Location = new System.Drawing.Point(0, 0);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowTemplate.Height = 25;
            this.dataGridView1.Size = new System.Drawing.Size(914, 379);
            this.dataGridView1.TabIndex = 0;
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(914, 450);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.toolStrip1);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.menuStrip1);
            this.Font = new System.Drawing.Font("MS Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Main";
            this.Text = "macca computer - networker discover";
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private StatusStrip statusStrip1;
        private MenuStrip menuStrip1;
        private ToolStripMenuItem fileToolStripMenuItem;
        private ToolStripMenuItem saveToolStripMenuItem;
        private ToolStripMenuItem allDevicesToolStripMenuItem;
        private ToolStripMenuItem selectedDevicesToolStripMenuItem;
        private ToolStripMenuItem allDevicesPortToolStripMenuItem;
        private ToolStripMenuItem selectedDevicePortsToolStripMenuItem;
        private ToolStripMenuItem toolStripMenuItem1;
        private ToolStripMenuItem networkInfoToolStripMenuItem;
        private ToolStripSeparator toolStripMenuItem3;
        private ToolStripMenuItem aboutNetworkerToolStripMenuItem;
        private ToolStripMenuItem aboutMaccaComputerToolStripMenuItem;
        private ToolStripStatusLabel stripStatus;
        private ToolStripProgressBar statusScan;
        private ToolStripStatusLabel mc_label;
        private ToolStripMenuItem exportToolStripMenuItem;
        private ToolStripMenuItem allToHtmlToolStripMenuItem;
        private ToolStripMenuItem allToCsvToolStripMenuItem;
        private ToolStripMenuItem allToXmlToolStripMenuItem;
        private ToolStripMenuItem allToJsonToolStripMenuItem;
        private ToolStripSeparator toolStripMenuItem4;
        private ToolStripMenuItem quitCTRLQToolStripMenuItem;
        private System.ComponentModel.BackgroundWorker bgWorker;
        private ToolStrip toolStrip1;
        private ToolStripButton stripSTART;
        private ToolStripButton stripSTOP;
        private ToolStripSeparator toolStripSeparator1;
        private ToolStripButton stripRESCAN;
        private Panel panel1;
        private DataGridView dataGridView1;
    }
}