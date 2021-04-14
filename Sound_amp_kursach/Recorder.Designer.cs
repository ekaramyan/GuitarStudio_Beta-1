namespace Sound_amp_kursach
{
    partial class Recorder
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
            this.btnStart = new System.Windows.Forms.Button();
            this.btnStop = new System.Windows.Forms.Button();
            this.btnRefreshDevices = new System.Windows.Forms.Button();
            this.deviceList = new System.Windows.Forms.ListView();
            this.columnName = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnChannels = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.back_btn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnStart
            // 
            this.btnStart.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnStart.Enabled = false;
            this.btnStart.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnStart.Location = new System.Drawing.Point(688, 27);
            this.btnStart.Name = "btnStart";
            this.btnStart.Size = new System.Drawing.Size(100, 23);
            this.btnStart.TabIndex = 1;
            this.btnStart.Text = "Start recording";
            this.btnStart.UseVisualStyleBackColor = true;
            this.btnStart.Click += new System.EventHandler(this.BtnStart_Click);
            // 
            // btnStop
            // 
            this.btnStop.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnStop.Enabled = false;
            this.btnStop.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnStop.Location = new System.Drawing.Point(688, 56);
            this.btnStop.Name = "btnStop";
            this.btnStop.Size = new System.Drawing.Size(100, 23);
            this.btnStop.TabIndex = 2;
            this.btnStop.Text = "Stop recording";
            this.btnStop.UseVisualStyleBackColor = true;
            this.btnStop.Click += new System.EventHandler(this.btnStop_Click);
            // 
            // btnRefreshDevices
            // 
            this.btnRefreshDevices.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnRefreshDevices.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRefreshDevices.Location = new System.Drawing.Point(688, 415);
            this.btnRefreshDevices.Name = "btnRefreshDevices";
            this.btnRefreshDevices.Size = new System.Drawing.Size(100, 23);
            this.btnRefreshDevices.TabIndex = 3;
            this.btnRefreshDevices.Text = "Refresh devices";
            this.btnRefreshDevices.UseVisualStyleBackColor = true;
            this.btnRefreshDevices.Click += new System.EventHandler(this.btnRefreshDevices_Click);
            // 
            // deviceList
            // 
            this.deviceList.BackColor = System.Drawing.Color.LightGray;
            this.deviceList.BackgroundImage = global::Sound_amp_kursach.Properties.Resources.Recorder_back;
            this.deviceList.BackgroundImageTiled = true;
            this.deviceList.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.deviceList.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnName,
            this.columnChannels});
            this.deviceList.Dock = System.Windows.Forms.DockStyle.Fill;
            this.deviceList.Font = new System.Drawing.Font("Tahoma", 8.25F);
            this.deviceList.FullRowSelect = true;
            this.deviceList.HideSelection = false;
            this.deviceList.Location = new System.Drawing.Point(0, 0);
            this.deviceList.MultiSelect = false;
            this.deviceList.Name = "deviceList";
            this.deviceList.Size = new System.Drawing.Size(800, 450);
            this.deviceList.TabIndex = 4;
            this.deviceList.UseCompatibleStateImageBehavior = false;
            this.deviceList.View = System.Windows.Forms.View.Details;
            this.deviceList.SelectedIndexChanged += new System.EventHandler(this.deviceList_SelectedIndexChanged);
            // 
            // columnName
            // 
            this.columnName.Text = "Name";
            this.columnName.Width = 250;
            // 
            // columnChannels
            // 
            this.columnChannels.Text = "Channels";
            // 
            // back_btn
            // 
            this.back_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.back_btn.Location = new System.Drawing.Point(12, 415);
            this.back_btn.Name = "back_btn";
            this.back_btn.Size = new System.Drawing.Size(46, 23);
            this.back_btn.TabIndex = 10;
            this.back_btn.Text = "Back";
            this.back_btn.UseVisualStyleBackColor = true;
            this.back_btn.Click += new System.EventHandler(this.Back_btn_Click);
            // 
            // Recorder
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.back_btn);
            this.Controls.Add(this.btnRefreshDevices);
            this.Controls.Add(this.btnStop);
            this.Controls.Add(this.btnStart);
            this.Controls.Add(this.deviceList);
            this.Name = "Recorder";
            this.Text = "Recorder";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnStart;
        private System.Windows.Forms.Button btnStop;
        private System.Windows.Forms.Button btnRefreshDevices;
        private System.Windows.Forms.ListView deviceList;
        private System.Windows.Forms.ColumnHeader columnName;
        private System.Windows.Forms.ColumnHeader columnChannels;
        private System.Windows.Forms.Button back_btn;
    }
}