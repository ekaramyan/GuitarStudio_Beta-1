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
            this.Liveplay_btn = new System.Windows.Forms.Button();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.Player_btn = new System.Windows.Forms.Button();
            this.rec_btn = new System.Windows.Forms.Button();
            this.tableLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // Liveplay_btn
            // 
            this.Liveplay_btn.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.Liveplay_btn.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(229)))), ((int)(((byte)(126)))), ((int)(((byte)(49)))));
            this.Liveplay_btn.FlatAppearance.BorderSize = 2;
            this.Liveplay_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Liveplay_btn.Font = new System.Drawing.Font("Tahoma", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Liveplay_btn.ForeColor = System.Drawing.Color.White;
            this.Liveplay_btn.Location = new System.Drawing.Point(541, 158);
            this.Liveplay_btn.Name = "Liveplay_btn";
            this.Liveplay_btn.Size = new System.Drawing.Size(249, 70);
            this.Liveplay_btn.TabIndex = 0;
            this.Liveplay_btn.Text = "Live";
            this.Liveplay_btn.UseVisualStyleBackColor = true;
            this.Liveplay_btn.Click += new System.EventHandler(this.Liveplay_btn_Click);
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tableLayoutPanel1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 52.58512F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 47.41488F));
            this.tableLayoutPanel1.Controls.Add(this.Player_btn, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.Liveplay_btn, 1, 2);
            this.tableLayoutPanel1.Controls.Add(this.rec_btn, 1, 1);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(-1, 1);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 4;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50.3268F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 49.6732F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 81F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 199F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(793, 434);
            this.tableLayoutPanel1.TabIndex = 1;
            // 
            // Player_btn
            // 
            this.Player_btn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.Player_btn.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(229)))), ((int)(((byte)(126)))), ((int)(((byte)(49)))));
            this.Player_btn.FlatAppearance.BorderSize = 2;
            this.Player_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Player_btn.Font = new System.Drawing.Font("Tahoma", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Player_btn.ForeColor = System.Drawing.Color.White;
            this.Player_btn.Location = new System.Drawing.Point(541, 3);
            this.Player_btn.Name = "Player_btn";
            this.Player_btn.Size = new System.Drawing.Size(249, 70);
            this.Player_btn.TabIndex = 0;
            this.Player_btn.Text = "Player";
            this.Player_btn.UseVisualStyleBackColor = true;
            this.Player_btn.Click += new System.EventHandler(this.Player_btn_Click);
            // 
            // rec_btn
            // 
            this.rec_btn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.rec_btn.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(229)))), ((int)(((byte)(126)))), ((int)(((byte)(49)))));
            this.rec_btn.FlatAppearance.BorderSize = 2;
            this.rec_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.rec_btn.Font = new System.Drawing.Font("Tahoma", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.rec_btn.ForeColor = System.Drawing.Color.White;
            this.rec_btn.Location = new System.Drawing.Point(541, 80);
            this.rec_btn.Name = "rec_btn";
            this.rec_btn.Size = new System.Drawing.Size(249, 70);
            this.rec_btn.TabIndex = 0;
            this.rec_btn.Text = "Recorder";
            this.rec_btn.UseMnemonic = false;
            this.rec_btn.UseVisualStyleBackColor = false;
            this.rec_btn.Click += new System.EventHandler(this.Rec_btn_Click);
            // 
            // Start_Form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(53)))), ((int)(((byte)(65)))));
            this.ClientSize = new System.Drawing.Size(789, 435);
            this.Controls.Add(this.tableLayoutPanel1);
            this.ForeColor = System.Drawing.SystemColors.ControlText;
            this.Name = "Start_Form";
            this.Text = "Start_Form";
            this.tableLayoutPanel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button Liveplay_btn;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Button rec_btn;
        private System.Windows.Forms.Button Player_btn;
    }
}