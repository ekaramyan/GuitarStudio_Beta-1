namespace Sound_amp_kursach
{
    partial class LivePlay_Form
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
            this.Play_btn = new System.Windows.Forms.Button();
            this.Stop_btn = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.back_btn = new System.Windows.Forms.Button();
            this.Reverb_btn = new System.Windows.Forms.Button();
            this.Distortion_btn = new System.Windows.Forms.Button();
            this.Chorus_btn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // Play_btn
            // 
            this.Play_btn.Location = new System.Drawing.Point(176, 155);
            this.Play_btn.Name = "Play_btn";
            this.Play_btn.Size = new System.Drawing.Size(107, 100);
            this.Play_btn.TabIndex = 0;
            this.Play_btn.Text = "Play Clean";
            this.Play_btn.UseVisualStyleBackColor = true;
            this.Play_btn.Click += new System.EventHandler(this.Play_btn_Click);
            // 
            // Stop_btn
            // 
            this.Stop_btn.Location = new System.Drawing.Point(463, 155);
            this.Stop_btn.Name = "Stop_btn";
            this.Stop_btn.Size = new System.Drawing.Size(108, 101);
            this.Stop_btn.TabIndex = 4;
            this.Stop_btn.Text = "Stop";
            this.Stop_btn.UseVisualStyleBackColor = true;
            this.Stop_btn.Click += new System.EventHandler(this.Stop_btn_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 383);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(62, 13);
            this.label1.TabIndex = 5;
            this.label1.Text = "Effects Bar:";
            // 
            // back_btn
            // 
            this.back_btn.Location = new System.Drawing.Point(12, 12);
            this.back_btn.Name = "back_btn";
            this.back_btn.Size = new System.Drawing.Size(46, 25);
            this.back_btn.TabIndex = 6;
            this.back_btn.Text = "Back";
            this.back_btn.UseVisualStyleBackColor = true;
            this.back_btn.Click += new System.EventHandler(this.Back_btn_Click);
            // 
            // Reverb_btn
            // 
            this.Reverb_btn.Location = new System.Drawing.Point(152, 378);
            this.Reverb_btn.Name = "Reverb_btn";
            this.Reverb_btn.Size = new System.Drawing.Size(75, 23);
            this.Reverb_btn.TabIndex = 7;
            this.Reverb_btn.Text = "Reverb";
            this.Reverb_btn.UseVisualStyleBackColor = true;
            this.Reverb_btn.Click += new System.EventHandler(this.Reverb_btn_Click);
            // 
            // Distortion_btn
            // 
            this.Distortion_btn.Location = new System.Drawing.Point(367, 378);
            this.Distortion_btn.Name = "Distortion_btn";
            this.Distortion_btn.Size = new System.Drawing.Size(75, 23);
            this.Distortion_btn.TabIndex = 7;
            this.Distortion_btn.Text = "Distortion";
            this.Distortion_btn.UseVisualStyleBackColor = true;
            this.Distortion_btn.Click += new System.EventHandler(this.Distortion_btn_Click);
            // 
            // Chorus_btn
            // 
            this.Chorus_btn.Location = new System.Drawing.Point(587, 378);
            this.Chorus_btn.Name = "Chorus_btn";
            this.Chorus_btn.Size = new System.Drawing.Size(75, 23);
            this.Chorus_btn.TabIndex = 7;
            this.Chorus_btn.Text = "Chorus";
            this.Chorus_btn.UseVisualStyleBackColor = true;
            this.Chorus_btn.Click += new System.EventHandler(this.Chorus_btn_Click);
            // 
            // LivePlay_Form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.Chorus_btn);
            this.Controls.Add(this.Distortion_btn);
            this.Controls.Add(this.Reverb_btn);
            this.Controls.Add(this.back_btn);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Stop_btn);
            this.Controls.Add(this.Play_btn);
            this.Name = "LivePlay_Form";
            this.Text = "LivePlay_Form";
            this.Load += new System.EventHandler(this.LivePlay_Form_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button Play_btn;
        private System.Windows.Forms.Button Stop_btn;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button back_btn;
        private System.Windows.Forms.Button Reverb_btn;
        private System.Windows.Forms.Button Distortion_btn;
        private System.Windows.Forms.Button Chorus_btn;
    }
}