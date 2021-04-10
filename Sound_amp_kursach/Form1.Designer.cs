namespace Sound_amp_kursach
{
    partial class Form1
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.volume_bar = new System.Windows.Forms.TrackBar();
            this.Play_button = new System.Windows.Forms.Button();
            this.Pause_button = new System.Windows.Forms.Button();
            this.Stop_button = new System.Windows.Forms.Button();
            this.btnOpen = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.volume_bar)).BeginInit();
            this.SuspendLayout();
            // 
            // volume_bar
            // 
            this.volume_bar.BackColor = System.Drawing.SystemColors.Control;
            this.volume_bar.Location = new System.Drawing.Point(12, 45);
            this.volume_bar.Name = "volume_bar";
            this.volume_bar.Orientation = System.Windows.Forms.Orientation.Vertical;
            this.volume_bar.Size = new System.Drawing.Size(45, 367);
            this.volume_bar.TabIndex = 0;
            this.volume_bar.ValueChanged += new System.EventHandler(this.Volume_bar_ValueChanged);
            // 
            // Play_button
            // 
            this.Play_button.Location = new System.Drawing.Point(194, 124);
            this.Play_button.Name = "Play_button";
            this.Play_button.Size = new System.Drawing.Size(75, 71);
            this.Play_button.TabIndex = 2;
            this.Play_button.Text = "Play";
            this.Play_button.UseVisualStyleBackColor = true;
            this.Play_button.Click += new System.EventHandler(this.Play_button_Click);
            // 
            // Pause_button
            // 
            this.Pause_button.Location = new System.Drawing.Point(343, 124);
            this.Pause_button.Name = "Pause_button";
            this.Pause_button.Size = new System.Drawing.Size(75, 71);
            this.Pause_button.TabIndex = 2;
            this.Pause_button.Text = "Pause";
            this.Pause_button.UseVisualStyleBackColor = true;
            this.Pause_button.Click += new System.EventHandler(this.Pause_button_Click);
            // 
            // Stop_button
            // 
            this.Stop_button.Location = new System.Drawing.Point(497, 124);
            this.Stop_button.Name = "Stop_button";
            this.Stop_button.Size = new System.Drawing.Size(75, 71);
            this.Stop_button.TabIndex = 2;
            this.Stop_button.Text = "Stop";
            this.Stop_button.UseVisualStyleBackColor = true;
            this.Stop_button.Click += new System.EventHandler(this.Stop_button_Click);
            // 
            // btnOpen
            // 
            this.btnOpen.Location = new System.Drawing.Point(12, 12);
            this.btnOpen.Name = "btnOpen";
            this.btnOpen.Size = new System.Drawing.Size(75, 23);
            this.btnOpen.TabIndex = 3;
            this.btnOpen.Text = "Open";
            this.btnOpen.UseVisualStyleBackColor = true;
            this.btnOpen.Click += new System.EventHandler(this.BtnOpen_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnOpen);
            this.Controls.Add(this.Stop_button);
            this.Controls.Add(this.Pause_button);
            this.Controls.Add(this.Play_button);
            this.Controls.Add(this.volume_bar);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.volume_bar)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TrackBar volume_bar;
        private System.Windows.Forms.Button Play_button;
        private System.Windows.Forms.Button Pause_button;
        private System.Windows.Forms.Button Stop_button;
        private System.Windows.Forms.Button btnOpen;
    }
}

