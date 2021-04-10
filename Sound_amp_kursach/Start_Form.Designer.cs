namespace Sound_amp_kursach
{
    partial class Start_Form
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
            this.rec_btn = new System.Windows.Forms.Button();
            this.Player_btn = new System.Windows.Forms.Button();
            this.Liveplay_btn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // rec_btn
            // 
            this.rec_btn.Location = new System.Drawing.Point(82, 154);
            this.rec_btn.Name = "rec_btn";
            this.rec_btn.Size = new System.Drawing.Size(122, 119);
            this.rec_btn.TabIndex = 0;
            this.rec_btn.Text = "Recorder";
            this.rec_btn.UseVisualStyleBackColor = true;
            this.rec_btn.Click += new System.EventHandler(this.Rec_btn_Click);
            // 
            // Player_btn
            // 
            this.Player_btn.Location = new System.Drawing.Point(315, 154);
            this.Player_btn.Name = "Player_btn";
            this.Player_btn.Size = new System.Drawing.Size(122, 119);
            this.Player_btn.TabIndex = 0;
            this.Player_btn.Text = "Player";
            this.Player_btn.UseVisualStyleBackColor = true;
            this.Player_btn.Click += new System.EventHandler(this.Player_btn_Click);
            // 
            // Liveplay_btn
            // 
            this.Liveplay_btn.Location = new System.Drawing.Point(571, 154);
            this.Liveplay_btn.Name = "Liveplay_btn";
            this.Liveplay_btn.Size = new System.Drawing.Size(122, 119);
            this.Liveplay_btn.TabIndex = 0;
            this.Liveplay_btn.Text = "Live";
            this.Liveplay_btn.UseVisualStyleBackColor = true;
            this.Liveplay_btn.Click += new System.EventHandler(this.Liveplay_btn_Click);
            // 
            // Start_Form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.Liveplay_btn);
            this.Controls.Add(this.Player_btn);
            this.Controls.Add(this.rec_btn);
            this.Name = "Start_Form";
            this.Text = "Start_Form";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button rec_btn;
        private System.Windows.Forms.Button Player_btn;
        private System.Windows.Forms.Button Liveplay_btn;
    }
}