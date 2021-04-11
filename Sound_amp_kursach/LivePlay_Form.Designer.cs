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
            this.Reverb_checkbox = new System.Windows.Forms.CheckBox();
            this.Distortion_checkbox = new System.Windows.Forms.CheckBox();
            this.Chorus_checkbox = new System.Windows.Forms.CheckBox();
            this.Stop_btn = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // Play_btn
            // 
            this.Play_btn.Location = new System.Drawing.Point(176, 155);
            this.Play_btn.Name = "Play_btn";
            this.Play_btn.Size = new System.Drawing.Size(107, 100);
            this.Play_btn.TabIndex = 0;
            this.Play_btn.Text = "Play";
            this.Play_btn.UseVisualStyleBackColor = true;
            this.Play_btn.Click += new System.EventHandler(this.Play_btn_Click);
            // 
            // Reverb_checkbox
            // 
            this.Reverb_checkbox.AutoSize = true;
            this.Reverb_checkbox.Location = new System.Drawing.Point(176, 378);
            this.Reverb_checkbox.Name = "Reverb_checkbox";
            this.Reverb_checkbox.Size = new System.Drawing.Size(61, 17);
            this.Reverb_checkbox.TabIndex = 1;
            this.Reverb_checkbox.Text = "Reverb";
            this.Reverb_checkbox.UseVisualStyleBackColor = true;
            // 
            // Distortion_checkbox
            // 
            this.Distortion_checkbox.AutoSize = true;
            this.Distortion_checkbox.Location = new System.Drawing.Point(376, 378);
            this.Distortion_checkbox.Name = "Distortion_checkbox";
            this.Distortion_checkbox.Size = new System.Drawing.Size(70, 17);
            this.Distortion_checkbox.TabIndex = 2;
            this.Distortion_checkbox.Text = "Distortion";
            this.Distortion_checkbox.UseVisualStyleBackColor = true;
            // 
            // Chorus_checkbox
            // 
            this.Chorus_checkbox.AutoSize = true;
            this.Chorus_checkbox.Location = new System.Drawing.Point(582, 378);
            this.Chorus_checkbox.Name = "Chorus_checkbox";
            this.Chorus_checkbox.Size = new System.Drawing.Size(59, 17);
            this.Chorus_checkbox.TabIndex = 3;
            this.Chorus_checkbox.Text = "Chorus";
            this.Chorus_checkbox.UseVisualStyleBackColor = true;
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
            this.label1.Location = new System.Drawing.Point(13, 378);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(62, 13);
            this.label1.TabIndex = 5;
            this.label1.Text = "Effects Bar:";
            // 
            // LivePlay_Form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Stop_btn);
            this.Controls.Add(this.Chorus_checkbox);
            this.Controls.Add(this.Distortion_checkbox);
            this.Controls.Add(this.Reverb_checkbox);
            this.Controls.Add(this.Play_btn);
            this.Name = "LivePlay_Form";
            this.Text = "LivePlay_Form";
            this.Load += new System.EventHandler(this.LivePlay_Form_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button Play_btn;
        private System.Windows.Forms.CheckBox Reverb_checkbox;
        private System.Windows.Forms.CheckBox Distortion_checkbox;
        private System.Windows.Forms.CheckBox Chorus_checkbox;
        private System.Windows.Forms.Button Stop_btn;
        private System.Windows.Forms.Label label1;
    }
}