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
            this.rec_btn.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(98)))), ((int)(((byte)(98)))));
            this.rec_btn.FlatAppearance.BorderSize = 2;
            this.rec_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.rec_btn.Font = new System.Drawing.Font("Tahoma", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.rec_btn.ForeColor = System.Drawing.Color.White;
            this.rec_btn.Location = new System.Drawing.Point(77, 154);
            this.rec_btn.Name = "rec_btn";
            this.rec_btn.Size = new System.Drawing.Size(122, 119);
            this.rec_btn.TabIndex = 0;
            this.rec_btn.Text = "Recorder";
            this.rec_btn.UseMnemonic = false;
            this.rec_btn.UseVisualStyleBackColor = false;
            this.rec_btn.Click += new System.EventHandler(this.Rec_btn_Click);
            // 
            // Player_btn
            // 
            this.Player_btn.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(98)))), ((int)(((byte)(98)))));
            this.Player_btn.FlatAppearance.BorderSize = 2;
            this.Player_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Player_btn.Font = new System.Drawing.Font("Tahoma", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Player_btn.ForeColor = System.Drawing.Color.White;
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
            this.Liveplay_btn.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(98)))), ((int)(((byte)(98)))));
            this.Liveplay_btn.FlatAppearance.BorderSize = 2;
            this.Liveplay_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Liveplay_btn.Font = new System.Drawing.Font("Tahoma", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Liveplay_btn.ForeColor = System.Drawing.Color.White;
            this.Liveplay_btn.Location = new System.Drawing.Point(569, 154);
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
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.Liveplay_btn);
            this.Controls.Add(this.Player_btn);
            this.Controls.Add(this.rec_btn);
            this.ForeColor = System.Drawing.SystemColors.ControlText;
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