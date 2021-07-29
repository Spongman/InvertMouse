﻿
namespace InvertMouse
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
            this.startStopBtn = new System.Windows.Forms.Button();
            this.stateLabel = new System.Windows.Forms.Label();
            this.cursorHiddenCB = new System.Windows.Forms.CheckBox();
            this.yAxisCB = new System.Windows.Forms.CheckBox();
            this.xAxisCB = new System.Windows.Forms.CheckBox();
            this.notifyIcon = new System.Windows.Forms.NotifyIcon(this.components);
            this.contextMenuStrip = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.restoreItem = new System.Windows.Forms.ToolStripMenuItem();
            this.closeItem = new System.Windows.Forms.ToolStripMenuItem();
            this.driverLabel = new System.Windows.Forms.Label();
            this.driverComboBox = new System.Windows.Forms.ComboBox();
            this.minimizeToTrayCB = new System.Windows.Forms.CheckBox();
            this.contextMenuStrip.SuspendLayout();
            this.SuspendLayout();
            // 
            // startStopBtn
            // 
            this.startStopBtn.Location = new System.Drawing.Point(13, 100);
            this.startStopBtn.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.startStopBtn.Name = "startStopBtn";
            this.startStopBtn.Size = new System.Drawing.Size(286, 57);
            this.startStopBtn.TabIndex = 2;
            this.startStopBtn.Text = "Start";
            this.startStopBtn.UseVisualStyleBackColor = true;
            this.startStopBtn.Click += new System.EventHandler(this.StartStopBtn_Click);
            // 
            // stateLabel
            // 
            this.stateLabel.Location = new System.Drawing.Point(12, 74);
            this.stateLabel.Name = "stateLabel";
            this.stateLabel.Size = new System.Drawing.Size(287, 21);
            this.stateLabel.TabIndex = 1;
            this.stateLabel.Text = "StateLabel";
            // 
            // cursorHiddenCB
            // 
            this.cursorHiddenCB.AutoSize = true;
            this.cursorHiddenCB.Checked = true;
            this.cursorHiddenCB.CheckState = System.Windows.Forms.CheckState.Checked;
            this.cursorHiddenCB.Location = new System.Drawing.Point(16, 172);
            this.cursorHiddenCB.Name = "cursorHiddenCB";
            this.cursorHiddenCB.Size = new System.Drawing.Size(185, 25);
            this.cursorHiddenCB.TabIndex = 3;
            this.cursorHiddenCB.Text = "When cursor is hidden";
            this.cursorHiddenCB.UseVisualStyleBackColor = true;
            this.cursorHiddenCB.CheckedChanged += new System.EventHandler(this.OptionsChanged);
            // 
            // yAxisCB
            // 
            this.yAxisCB.AutoSize = true;
            this.yAxisCB.Checked = true;
            this.yAxisCB.CheckState = System.Windows.Forms.CheckState.Checked;
            this.yAxisCB.Location = new System.Drawing.Point(16, 203);
            this.yAxisCB.Name = "yAxisCB";
            this.yAxisCB.Size = new System.Drawing.Size(70, 25);
            this.yAxisCB.TabIndex = 4;
            this.yAxisCB.Text = "Y Axis";
            this.yAxisCB.UseVisualStyleBackColor = true;
            this.yAxisCB.CheckedChanged += new System.EventHandler(this.OptionsChanged);
            // 
            // xAxisCB
            // 
            this.xAxisCB.AutoSize = true;
            this.xAxisCB.Location = new System.Drawing.Point(16, 234);
            this.xAxisCB.Name = "xAxisCB";
            this.xAxisCB.Size = new System.Drawing.Size(70, 25);
            this.xAxisCB.TabIndex = 5;
            this.xAxisCB.Text = "X Axis";
            this.xAxisCB.UseVisualStyleBackColor = true;
            this.xAxisCB.CheckedChanged += new System.EventHandler(this.OptionsChanged);
            // 
            // notifyIcon
            // 
            this.notifyIcon.ContextMenuStrip = this.contextMenuStrip;
            this.notifyIcon.Text = "InvertMouse";
            this.notifyIcon.MouseDown += new System.Windows.Forms.MouseEventHandler(this.notifyIcon_MouseDown);
            // 
            // contextMenuStrip
            // 
            this.contextMenuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.restoreItem,
            this.closeItem});
            this.contextMenuStrip.Name = "contextMenuStrip";
            this.contextMenuStrip.Size = new System.Drawing.Size(114, 48);
            this.contextMenuStrip.ItemClicked += new System.Windows.Forms.ToolStripItemClickedEventHandler(this.contextMenuStrip_ItemClicked);
            // 
            // restoreItem
            // 
            this.restoreItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.restoreItem.Name = "restoreItem";
            this.restoreItem.Size = new System.Drawing.Size(113, 22);
            this.restoreItem.Text = "Restore";
            // 
            // closeItem
            // 
            this.closeItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.closeItem.Name = "closeItem";
            this.closeItem.Size = new System.Drawing.Size(113, 22);
            this.closeItem.Text = "Close";
            // 
            // driverLabel
            // 
            this.driverLabel.Location = new System.Drawing.Point(12, 9);
            this.driverLabel.Name = "driverLabel";
            this.driverLabel.Size = new System.Drawing.Size(287, 21);
            this.driverLabel.TabIndex = 5;
            this.driverLabel.Text = "Driver";
            // 
            // driverComboBox
            // 
            this.driverComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.driverComboBox.FormattingEnabled = true;
            this.driverComboBox.Items.AddRange(new object[] {
            "Interception",
            "RawAccel"});
            this.driverComboBox.Location = new System.Drawing.Point(16, 33);
            this.driverComboBox.Name = "driverComboBox";
            this.driverComboBox.Size = new System.Drawing.Size(283, 29);
            this.driverComboBox.TabIndex = 1;
            this.driverComboBox.SelectedIndexChanged += new System.EventHandler(this.driverComboBox_SelectedIndexChanged);
            // 
            // minimizeToTrayCB
            // 
            this.minimizeToTrayCB.AutoSize = true;
            this.minimizeToTrayCB.Location = new System.Drawing.Point(16, 265);
            this.minimizeToTrayCB.Name = "minimizeToTrayCB";
            this.minimizeToTrayCB.Size = new System.Drawing.Size(142, 25);
            this.minimizeToTrayCB.TabIndex = 6;
            this.minimizeToTrayCB.Text = "Minimize to tray";
            this.minimizeToTrayCB.UseVisualStyleBackColor = true;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(311, 300);
            this.Controls.Add(this.minimizeToTrayCB);
            this.Controls.Add(this.driverComboBox);
            this.Controls.Add(this.driverLabel);
            this.Controls.Add(this.xAxisCB);
            this.Controls.Add(this.yAxisCB);
            this.Controls.Add(this.cursorHiddenCB);
            this.Controls.Add(this.stateLabel);
            this.Controls.Add(this.startStopBtn);
            this.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.MaximizeBox = false;
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "InvertMouse";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.MainForm_FormClosing);
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.Resize += new System.EventHandler(this.MainForm_Resize);
            this.contextMenuStrip.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button startStopBtn;
        private System.Windows.Forms.Label stateLabel;
        private System.Windows.Forms.CheckBox cursorHiddenCB;
        private System.Windows.Forms.CheckBox yAxisCB;
        private System.Windows.Forms.CheckBox xAxisCB;
        private System.Windows.Forms.NotifyIcon notifyIcon;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip;
        private System.Windows.Forms.ToolStripMenuItem restoreItem;
        private System.Windows.Forms.ToolStripMenuItem closeItem;
        private System.Windows.Forms.Label driverLabel;
        private System.Windows.Forms.ComboBox driverComboBox;
        private System.Windows.Forms.CheckBox minimizeToTrayCB;
    }
}

