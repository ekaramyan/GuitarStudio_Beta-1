﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Sound_amp_kursach
{
    public partial class Start_Form : Form
    {
        public Start_Form()
        {
            InitializeComponent();
        }

        private void Rec_btn_Click(object sender, EventArgs e)
        {
            Start_Form.ActiveForm.Hide();
            Recorder Recorder_form = new Recorder();
            Recorder_form.ShowDialog();
            Close();
        }

        private void Player_btn_Click(object sender, EventArgs e)
        {
            Start_Form.ActiveForm.Hide();
            Form1 Player_form = new Form1();
            Player_form.ShowDialog();
            Close();
        }

        private void Liveplay_btn_Click(object sender, EventArgs e)
        {
            Start_Form.ActiveForm.Hide();
            LivePlay_Form LivePlay_form = new LivePlay_Form();
            LivePlay_form.ShowDialog();
            Close();
        }
    }
}
