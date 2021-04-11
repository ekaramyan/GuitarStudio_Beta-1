using System;
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
            Recorder Player_form = new Recorder();
            Player_form.ShowDialog();
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
            
        }
    }
}
