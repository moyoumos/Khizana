namespace C2.Flash
{
	partial class frmMain
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
            this.cbPorts = new System.Windows.Forms.ComboBox();
            this.btnStartStop = new System.Windows.Forms.Button();
            this.btnC2Target = new System.Windows.Forms.Button();
            this.groupC2 = new System.Windows.Forms.GroupBox();
            this.label5 = new System.Windows.Forms.Label();
            this.infos = new System.Windows.Forms.TextBox();
            this.cbAutoErase = new System.Windows.Forms.CheckBox();
            this.btnWriteFlashPartial = new System.Windows.Forms.Button();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.btnDeviceErase04 = new System.Windows.Forms.Button();
            this.btnDeviceErase = new System.Windows.Forms.Button();
            this.EndAddr = new System.Windows.Forms.TextBox();
            this.StartAddr = new System.Windows.Forms.TextBox();
            this.FileName = new System.Windows.Forms.TextBox();
            this.btnHalt = new System.Windows.Forms.Button();
            this.btnGo = new System.Windows.Forms.Button();
            this.btnReadFlash = new System.Windows.Forms.Button();
            this.btnWriteFlash = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.cbDevices = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.UniqueID = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.Revision = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.DeviceID = new System.Windows.Forms.TextBox();
            this.statusStrip = new System.Windows.Forms.StatusStrip();
            this.status = new System.Windows.Forms.ToolStripStatusLabel();
            this.progress = new System.Windows.Forms.ToolStripProgressBar();
            this.openFileDialog = new System.Windows.Forms.OpenFileDialog();
            this.saveFileDialog = new System.Windows.Forms.SaveFileDialog();
            this.groupC2.SuspendLayout();
            this.statusStrip.SuspendLayout();
            this.SuspendLayout();
            // 
            // cbPorts
            // 
            this.cbPorts.FormattingEnabled = true;
            this.cbPorts.Location = new System.Drawing.Point(4, 12);
            this.cbPorts.Name = "cbPorts";
            this.cbPorts.Size = new System.Drawing.Size(144, 21);
            this.cbPorts.TabIndex = 0;
            // 
            // btnStartStop
            // 
            this.btnStartStop.Location = new System.Drawing.Point(154, 10);
            this.btnStartStop.Name = "btnStartStop";
            this.btnStartStop.Size = new System.Drawing.Size(100, 23);
            this.btnStartStop.TabIndex = 1;
            this.btnStartStop.Text = "Connect";
            this.btnStartStop.UseVisualStyleBackColor = true;
            this.btnStartStop.Click += new System.EventHandler(this.btnStartStop_Click);
            // 
            // btnC2Target
            // 
            this.btnC2Target.Location = new System.Drawing.Point(16, 184);
            this.btnC2Target.Name = "btnC2Target";
            this.btnC2Target.Size = new System.Drawing.Size(100, 23);
            this.btnC2Target.TabIndex = 4;
            this.btnC2Target.Text = "C2 Check";
            this.btnC2Target.UseVisualStyleBackColor = true;
            this.btnC2Target.Click += new System.EventHandler(this.btnC2Target_Click);
            // 
            // groupC2
            // 
            this.groupC2.Controls.Add(this.label5);
            this.groupC2.Controls.Add(this.infos);
            this.groupC2.Controls.Add(this.cbAutoErase);
            this.groupC2.Controls.Add(this.btnWriteFlashPartial);
            this.groupC2.Controls.Add(this.label8);
            this.groupC2.Controls.Add(this.label7);
            this.groupC2.Controls.Add(this.btnDeviceErase04);
            this.groupC2.Controls.Add(this.btnDeviceErase);
            this.groupC2.Controls.Add(this.EndAddr);
            this.groupC2.Controls.Add(this.StartAddr);
            this.groupC2.Controls.Add(this.FileName);
            this.groupC2.Controls.Add(this.btnHalt);
            this.groupC2.Controls.Add(this.btnGo);
            this.groupC2.Controls.Add(this.btnReadFlash);
            this.groupC2.Controls.Add(this.btnWriteFlash);
            this.groupC2.Controls.Add(this.label4);
            this.groupC2.Controls.Add(this.cbDevices);
            this.groupC2.Controls.Add(this.label3);
            this.groupC2.Controls.Add(this.UniqueID);
            this.groupC2.Controls.Add(this.label2);
            this.groupC2.Controls.Add(this.Revision);
            this.groupC2.Controls.Add(this.label1);
            this.groupC2.Controls.Add(this.DeviceID);
            this.groupC2.Controls.Add(this.btnC2Target);
            this.groupC2.Enabled = false;
            this.groupC2.ForeColor = System.Drawing.SystemColors.ControlText;
            this.groupC2.Location = new System.Drawing.Point(12, 39);
            this.groupC2.Name = "groupC2";
            this.groupC2.Size = new System.Drawing.Size(551, 212);
            this.groupC2.TabIndex = 5;
            this.groupC2.TabStop = false;
            this.groupC2.Text = "C2 TARGET";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(180, 129);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(45, 13);
            this.label5.TabIndex = 42;
            this.label5.Text = "FPadrss";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // infos
            // 
            this.infos.Location = new System.Drawing.Point(231, 122);
            this.infos.Name = "infos";
            this.infos.Size = new System.Drawing.Size(160, 20);
            this.infos.TabIndex = 41;
            // 
            // cbAutoErase
            // 
            this.cbAutoErase.AutoSize = true;
            this.cbAutoErase.Checked = true;
            this.cbAutoErase.CheckState = System.Windows.Forms.CheckState.Checked;
            this.cbAutoErase.Location = new System.Drawing.Point(304, 19);
            this.cbAutoErase.Name = "cbAutoErase";
            this.cbAutoErase.Size = new System.Drawing.Size(111, 17);
            this.cbAutoErase.TabIndex = 40;
            this.cbAutoErase.Text = "Auto Erase Pages";
            this.cbAutoErase.UseVisualStyleBackColor = true;
            // 
            // btnWriteFlashPartial
            // 
            this.btnWriteFlashPartial.Location = new System.Drawing.Point(43, 15);
            this.btnWriteFlashPartial.Name = "btnWriteFlashPartial";
            this.btnWriteFlashPartial.Size = new System.Drawing.Size(100, 23);
            this.btnWriteFlashPartial.TabIndex = 38;
            this.btnWriteFlashPartial.Text = "Write Flash ...";
            this.btnWriteFlashPartial.UseVisualStyleBackColor = true;
            this.btnWriteFlashPartial.Click += new System.EventHandler(this.btnWriteFlashPartial_Click);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(180, 103);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(45, 13);
            this.label8.TabIndex = 37;
            this.label8.Text = "Address";
            this.label8.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(14, 45);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(23, 13);
            this.label7.TabIndex = 36;
            this.label7.Text = "File";
            this.label7.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // btnDeviceErase04
            // 
            this.btnDeviceErase04.Location = new System.Drawing.Point(445, 105);
            this.btnDeviceErase04.Name = "btnDeviceErase04";
            this.btnDeviceErase04.Size = new System.Drawing.Size(100, 23);
            this.btnDeviceErase04.TabIndex = 35;
            this.btnDeviceErase04.Text = "Device Erase (04)";
            this.btnDeviceErase04.UseVisualStyleBackColor = true;
            this.btnDeviceErase04.Click += new System.EventHandler(this.btnDeviceErase04_Click);
            // 
            // btnDeviceErase
            // 
            this.btnDeviceErase.Location = new System.Drawing.Point(445, 61);
            this.btnDeviceErase.Name = "btnDeviceErase";
            this.btnDeviceErase.Size = new System.Drawing.Size(100, 23);
            this.btnDeviceErase.TabIndex = 24;
            this.btnDeviceErase.Text = "Device Erase (03)";
            this.btnDeviceErase.UseVisualStyleBackColor = true;
            this.btnDeviceErase.Click += new System.EventHandler(this.btnDeviceErase_Click);
            // 
            // EndAddr
            // 
            this.EndAddr.Location = new System.Drawing.Point(314, 100);
            this.EndAddr.Name = "EndAddr";
            this.EndAddr.Size = new System.Drawing.Size(77, 20);
            this.EndAddr.TabIndex = 23;
            this.EndAddr.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // StartAddr
            // 
            this.StartAddr.Location = new System.Drawing.Point(231, 100);
            this.StartAddr.Name = "StartAddr";
            this.StartAddr.Size = new System.Drawing.Size(77, 20);
            this.StartAddr.TabIndex = 22;
            this.StartAddr.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // FileName
            // 
            this.FileName.AcceptsTab = true;
            this.FileName.Location = new System.Drawing.Point(43, 42);
            this.FileName.Name = "FileName";
            this.FileName.Size = new System.Drawing.Size(372, 20);
            this.FileName.TabIndex = 20;
            // 
            // btnHalt
            // 
            this.btnHalt.Location = new System.Drawing.Point(294, 183);
            this.btnHalt.Name = "btnHalt";
            this.btnHalt.Size = new System.Drawing.Size(75, 23);
            this.btnHalt.TabIndex = 19;
            this.btnHalt.Text = "Halt";
            this.btnHalt.UseVisualStyleBackColor = true;
            this.btnHalt.Click += new System.EventHandler(this.btnHalt_Click);
            // 
            // btnGo
            // 
            this.btnGo.Location = new System.Drawing.Point(183, 183);
            this.btnGo.Name = "btnGo";
            this.btnGo.Size = new System.Drawing.Size(75, 23);
            this.btnGo.TabIndex = 18;
            this.btnGo.Text = "GO";
            this.btnGo.UseVisualStyleBackColor = true;
            this.btnGo.Click += new System.EventHandler(this.btnGo_Click);
            // 
            // btnReadFlash
            // 
            this.btnReadFlash.Location = new System.Drawing.Point(445, 19);
            this.btnReadFlash.Name = "btnReadFlash";
            this.btnReadFlash.Size = new System.Drawing.Size(100, 23);
            this.btnReadFlash.TabIndex = 14;
            this.btnReadFlash.Text = "Read Flash";
            this.btnReadFlash.UseVisualStyleBackColor = true;
            this.btnReadFlash.Click += new System.EventHandler(this.btnReadFlash_Click);
            // 
            // btnWriteFlash
            // 
            this.btnWriteFlash.Location = new System.Drawing.Point(149, 15);
            this.btnWriteFlash.Name = "btnWriteFlash";
            this.btnWriteFlash.Size = new System.Drawing.Size(100, 23);
            this.btnWriteFlash.TabIndex = 13;
            this.btnWriteFlash.Text = "Write Flash";
            this.btnWriteFlash.UseVisualStyleBackColor = true;
            this.btnWriteFlash.Click += new System.EventHandler(this.btnWriteFlash_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(13, 71);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(41, 13);
            this.label4.TabIndex = 12;
            this.label4.Text = "Device";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // cbDevices
            // 
            this.cbDevices.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.cbDevices.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cbDevices.FormattingEnabled = true;
            this.cbDevices.Location = new System.Drawing.Point(67, 68);
            this.cbDevices.Name = "cbDevices";
            this.cbDevices.Size = new System.Drawing.Size(302, 21);
            this.cbDevices.TabIndex = 11;
            this.cbDevices.SelectedIndexChanged += new System.EventHandler(this.cbDevices_SelectedIndexChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 158);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(55, 13);
            this.label3.TabIndex = 10;
            this.label3.Text = "Unique ID";
            // 
            // UniqueID
            // 
            this.UniqueID.Enabled = false;
            this.UniqueID.Location = new System.Drawing.Point(67, 158);
            this.UniqueID.Name = "UniqueID";
            this.UniqueID.Size = new System.Drawing.Size(36, 20);
            this.UniqueID.TabIndex = 9;
            this.UniqueID.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 132);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(48, 13);
            this.label2.TabIndex = 8;
            this.label2.Text = "Revision";
            // 
            // Revision
            // 
            this.Revision.Enabled = false;
            this.Revision.Location = new System.Drawing.Point(67, 129);
            this.Revision.Name = "Revision";
            this.Revision.Size = new System.Drawing.Size(36, 20);
            this.Revision.TabIndex = 7;
            this.Revision.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 105);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(55, 13);
            this.label1.TabIndex = 6;
            this.label1.Text = "Device ID";
            // 
            // DeviceID
            // 
            this.DeviceID.Enabled = false;
            this.DeviceID.Location = new System.Drawing.Point(67, 102);
            this.DeviceID.Name = "DeviceID";
            this.DeviceID.Size = new System.Drawing.Size(36, 20);
            this.DeviceID.TabIndex = 5;
            this.DeviceID.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // statusStrip
            // 
            this.statusStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.status,
            this.progress});
            this.statusStrip.Location = new System.Drawing.Point(0, 254);
            this.statusStrip.Name = "statusStrip";
            this.statusStrip.Size = new System.Drawing.Size(575, 22);
            this.statusStrip.TabIndex = 6;
            this.statusStrip.Text = "statusStrip1";
            // 
            // status
            // 
            this.status.Name = "status";
            this.status.Size = new System.Drawing.Size(458, 17);
            this.status.Spring = true;
            this.status.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // progress
            // 
            this.progress.Name = "progress";
            this.progress.Size = new System.Drawing.Size(100, 16);
            // 
            // openFileDialog
            // 
            this.openFileDialog.Filter = "Flash files|*.hex;*.bin|All files|*.*";
            this.openFileDialog.Title = "Select file to open";
            // 
            // saveFileDialog
            // 
            this.saveFileDialog.Filter = "Binary files|*.bin";
            this.saveFileDialog.Title = "Select file to save";
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(575, 276);
            this.Controls.Add(this.statusStrip);
            this.Controls.Add(this.groupC2);
            this.Controls.Add(this.btnStartStop);
            this.Controls.Add(this.cbPorts);
            this.Name = "frmMain";
            this.Text = "C2.Flash";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.frmMain_FormClosed);
            this.Load += new System.EventHandler(this.frmMain_Load);
            this.groupC2.ResumeLayout(false);
            this.groupC2.PerformLayout();
            this.statusStrip.ResumeLayout(false);
            this.statusStrip.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.ComboBox cbPorts;
		private System.Windows.Forms.Button btnStartStop;
		private System.Windows.Forms.Button btnC2Target;
		private System.Windows.Forms.GroupBox groupC2;
		private System.Windows.Forms.TextBox DeviceID;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.StatusStrip statusStrip;
		private System.Windows.Forms.ToolStripStatusLabel status;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.TextBox Revision;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.TextBox UniqueID;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.ComboBox cbDevices;
		private System.Windows.Forms.Button btnReadFlash;
		private System.Windows.Forms.Button btnWriteFlash;
		private System.Windows.Forms.TextBox EndAddr;
		private System.Windows.Forms.TextBox StartAddr;
		private System.Windows.Forms.Button btnHalt;
		private System.Windows.Forms.Button btnGo;
		private System.Windows.Forms.ToolStripProgressBar progress;
		private System.Windows.Forms.Button btnDeviceErase;
		private System.Windows.Forms.Button btnDeviceErase04;
		private System.Windows.Forms.Label label8;
		private System.Windows.Forms.Label label7;
		private System.Windows.Forms.TextBox FileName;
		private System.Windows.Forms.OpenFileDialog openFileDialog;
		private System.Windows.Forms.SaveFileDialog saveFileDialog;
		private System.Windows.Forms.Button btnWriteFlashPartial;
		private System.Windows.Forms.CheckBox cbAutoErase;
        private System.Windows.Forms.TextBox infos;
        private System.Windows.Forms.Label label5;
    }
}

