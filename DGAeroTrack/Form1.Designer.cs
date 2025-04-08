namespace DGAeroTrack
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
            this.yxPanel = new System.Windows.Forms.Panel();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.openToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.connectionToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.refreshDevicesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.panel2 = new System.Windows.Forms.Panel();
            this.XLbl = new System.Windows.Forms.Label();
            this.YLbl = new System.Windows.Forms.Label();
            this.ZLbl = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.zxPanel = new System.Windows.Forms.Panel();
            this.zyPanel = new System.Windows.Forms.Panel();
            this.StartPlot = new System.Windows.Forms.Button();
            this.StopPlot = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.SerialConnectBtn = new System.Windows.Forms.Button();
            this.BaudRateCmb = new System.Windows.Forms.ComboBox();
            this.reateLbl = new System.Windows.Forms.Label();
            this.SerialPortCmb = new System.Windows.Forms.ComboBox();
            this.portLbl = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.msgLbl = new System.Windows.Forms.Label();
            this.menuStrip1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel1.SuspendLayout();
            this.panel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // yxPanel
            // 
            this.yxPanel.Location = new System.Drawing.Point(12, 70);
            this.yxPanel.Name = "yxPanel";
            this.yxPanel.Size = new System.Drawing.Size(300, 300);
            this.yxPanel.TabIndex = 0;
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.connectionToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(784, 24);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.openToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // openToolStripMenuItem
            // 
            this.openToolStripMenuItem.Name = "openToolStripMenuItem";
            this.openToolStripMenuItem.Size = new System.Drawing.Size(103, 22);
            this.openToolStripMenuItem.Text = "Open";
            this.openToolStripMenuItem.Click += new System.EventHandler(this.openToolStripMenuItem_Click);
            // 
            // connectionToolStripMenuItem
            // 
            this.connectionToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.refreshDevicesToolStripMenuItem});
            this.connectionToolStripMenuItem.Name = "connectionToolStripMenuItem";
            this.connectionToolStripMenuItem.Size = new System.Drawing.Size(81, 20);
            this.connectionToolStripMenuItem.Text = "Connection";
            // 
            // refreshDevicesToolStripMenuItem
            // 
            this.refreshDevicesToolStripMenuItem.Name = "refreshDevicesToolStripMenuItem";
            this.refreshDevicesToolStripMenuItem.Size = new System.Drawing.Size(156, 22);
            this.refreshDevicesToolStripMenuItem.Text = "Refresh Devices";
            this.refreshDevicesToolStripMenuItem.Click += new System.EventHandler(this.refreshDevicesToolStripMenuItem_Click);
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel2.Controls.Add(this.XLbl);
            this.panel2.Controls.Add(this.YLbl);
            this.panel2.Controls.Add(this.ZLbl);
            this.panel2.Controls.Add(this.label7);
            this.panel2.Controls.Add(this.label5);
            this.panel2.Controls.Add(this.label4);
            this.panel2.Location = new System.Drawing.Point(130, 682);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(346, 30);
            this.panel2.TabIndex = 7;
            // 
            // XLbl
            // 
            this.XLbl.AutoSize = true;
            this.XLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.XLbl.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.XLbl.Location = new System.Drawing.Point(37, 5);
            this.XLbl.Name = "XLbl";
            this.XLbl.Size = new System.Drawing.Size(24, 13);
            this.XLbl.TabIndex = 15;
            this.XLbl.Text = "0 m";
            // 
            // YLbl
            // 
            this.YLbl.AutoSize = true;
            this.YLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.YLbl.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.YLbl.Location = new System.Drawing.Point(146, 5);
            this.YLbl.Name = "YLbl";
            this.YLbl.Size = new System.Drawing.Size(24, 13);
            this.YLbl.TabIndex = 14;
            this.YLbl.Text = "0 m";
            // 
            // ZLbl
            // 
            this.ZLbl.AutoSize = true;
            this.ZLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ZLbl.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ZLbl.Location = new System.Drawing.Point(264, 5);
            this.ZLbl.Name = "ZLbl";
            this.ZLbl.Size = new System.Drawing.Size(24, 13);
            this.ZLbl.TabIndex = 13;
            this.ZLbl.Text = "0 m";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label7.Location = new System.Drawing.Point(229, 5);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(20, 13);
            this.label7.TabIndex = 12;
            this.label7.Text = "z=";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label5.Location = new System.Drawing.Point(115, 5);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(22, 13);
            this.label5.TabIndex = 11;
            this.label5.Text = "Y=";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label4.Location = new System.Drawing.Point(9, 5);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(22, 13);
            this.label4.TabIndex = 10;
            this.label4.Text = "X=";
            // 
            // zxPanel
            // 
            this.zxPanel.Location = new System.Drawing.Point(12, 376);
            this.zxPanel.Name = "zxPanel";
            this.zxPanel.Size = new System.Drawing.Size(300, 300);
            this.zxPanel.TabIndex = 1;
            // 
            // zyPanel
            // 
            this.zyPanel.Location = new System.Drawing.Point(318, 376);
            this.zyPanel.Name = "zyPanel";
            this.zyPanel.Size = new System.Drawing.Size(300, 300);
            this.zyPanel.TabIndex = 8;
            // 
            // StartPlot
            // 
            this.StartPlot.Location = new System.Drawing.Point(202, 98);
            this.StartPlot.Name = "StartPlot";
            this.StartPlot.Size = new System.Drawing.Size(75, 23);
            this.StartPlot.TabIndex = 9;
            this.StartPlot.Text = "Start Plot";
            this.StartPlot.UseVisualStyleBackColor = true;
            this.StartPlot.Click += new System.EventHandler(this.StartPlot_Click);
            // 
            // StopPlot
            // 
            this.StopPlot.Location = new System.Drawing.Point(202, 127);
            this.StopPlot.Name = "StopPlot";
            this.StopPlot.Size = new System.Drawing.Size(75, 23);
            this.StopPlot.TabIndex = 10;
            this.StopPlot.Text = "Stop";
            this.StopPlot.UseVisualStyleBackColor = true;
            this.StopPlot.Click += new System.EventHandler(this.StopPlot_Click);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.SerialConnectBtn);
            this.panel1.Controls.Add(this.BaudRateCmb);
            this.panel1.Controls.Add(this.reateLbl);
            this.panel1.Controls.Add(this.SerialPortCmb);
            this.panel1.Controls.Add(this.portLbl);
            this.panel1.Location = new System.Drawing.Point(318, 70);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(300, 133);
            this.panel1.TabIndex = 11;
            // 
            // SerialConnectBtn
            // 
            this.SerialConnectBtn.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.SerialConnectBtn.Location = new System.Drawing.Point(202, 88);
            this.SerialConnectBtn.Name = "SerialConnectBtn";
            this.SerialConnectBtn.Size = new System.Drawing.Size(75, 23);
            this.SerialConnectBtn.TabIndex = 10;
            this.SerialConnectBtn.Text = "Connect";
            this.SerialConnectBtn.UseVisualStyleBackColor = true;
            this.SerialConnectBtn.Click += new System.EventHandler(this.SerialConnectBtn_Click);
            // 
            // BaudRateCmb
            // 
            this.BaudRateCmb.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.BaudRateCmb.FormattingEnabled = true;
            this.BaudRateCmb.Location = new System.Drawing.Point(59, 88);
            this.BaudRateCmb.Name = "BaudRateCmb";
            this.BaudRateCmb.Size = new System.Drawing.Size(119, 21);
            this.BaudRateCmb.TabIndex = 9;
            // 
            // reateLbl
            // 
            this.reateLbl.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.reateLbl.AutoSize = true;
            this.reateLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.reateLbl.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.reateLbl.Location = new System.Drawing.Point(11, 91);
            this.reateLbl.Name = "reateLbl";
            this.reateLbl.Size = new System.Drawing.Size(42, 13);
            this.reateLbl.TabIndex = 8;
            this.reateLbl.Text = "Rate: ";
            this.reateLbl.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // SerialPortCmb
            // 
            this.SerialPortCmb.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.SerialPortCmb.FormattingEnabled = true;
            this.SerialPortCmb.Location = new System.Drawing.Point(59, 61);
            this.SerialPortCmb.Name = "SerialPortCmb";
            this.SerialPortCmb.Size = new System.Drawing.Size(119, 21);
            this.SerialPortCmb.TabIndex = 7;
            // 
            // portLbl
            // 
            this.portLbl.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.portLbl.AutoSize = true;
            this.portLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.portLbl.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.portLbl.Location = new System.Drawing.Point(11, 64);
            this.portLbl.Name = "portLbl";
            this.portLbl.Size = new System.Drawing.Size(34, 13);
            this.portLbl.TabIndex = 6;
            this.portLbl.Text = "Port:";
            this.portLbl.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.StartPlot);
            this.panel3.Controls.Add(this.StopPlot);
            this.panel3.Location = new System.Drawing.Point(318, 209);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(300, 161);
            this.panel3.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label1.Location = new System.Drawing.Point(129, 715);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(88, 13);
            this.label1.TabIndex = 12;
            this.label1.Text = "Last message:";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // msgLbl
            // 
            this.msgLbl.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.msgLbl.AutoSize = true;
            this.msgLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.msgLbl.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.msgLbl.Location = new System.Drawing.Point(219, 715);
            this.msgLbl.Name = "msgLbl";
            this.msgLbl.Size = new System.Drawing.Size(0, 13);
            this.msgLbl.TabIndex = 13;
            this.msgLbl.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(784, 761);
            this.Controls.Add(this.msgLbl);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.zyPanel);
            this.Controls.Add(this.zxPanel);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.yxPanel);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "Form1";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel yxPanel;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem connectionToolStripMenuItem;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label XLbl;
        private System.Windows.Forms.Label YLbl;
        private System.Windows.Forms.Label ZLbl;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Panel zxPanel;
        private System.Windows.Forms.Panel zyPanel;
        private System.Windows.Forms.ToolStripMenuItem openToolStripMenuItem;
        private System.Windows.Forms.Button StartPlot;
        private System.Windows.Forms.Button StopPlot;
        private System.Windows.Forms.ToolStripMenuItem refreshDevicesToolStripMenuItem;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button SerialConnectBtn;
        private System.Windows.Forms.ComboBox BaudRateCmb;
        private System.Windows.Forms.Label reateLbl;
        private System.Windows.Forms.ComboBox SerialPortCmb;
        private System.Windows.Forms.Label portLbl;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label msgLbl;
    }
}

