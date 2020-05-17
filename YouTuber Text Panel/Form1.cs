//code by Eng-Mustafa Jawad © 2017 
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace YouTuber_Text_Panel
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            panel1.Visible = true ;
            pictureBox8.Visible = true;
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            label1.Text = textBox2.Text;
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {
            label2.Text = textBox3.Text;
        }

        private void label11_Click(object sender, EventArgs e)
        {
            panel1.Visible = false;
        }

      
        private void button1_Click(object sender, EventArgs e)
        {
            colorDialog1.ShowDialog();
            label1 .ForeColor   = colorDialog1.Color;
        }

        private void label11_Click_1(object sender, EventArgs e)
        {
            panel1.Visible = false;
            pictureBox8.Visible = false;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            colorDialog2.ShowDialog();
            label2 .ForeColor  = colorDialog2.Color;
            
        }

        
        private void pictureBox10_Click(object sender, EventArgs e)
        {
            Pa_about.Visible = false;
            Pa_them.Visible = true;
            Pa_general.Visible = false;
            Panel_general.Visible = false ;
            Panel_theme.Visible = true ;
            Panel_theme_tx.Visible = true ;
            Panel_share.Visible = false;
        }

        private void pictureBox9_Click(object sender, EventArgs e)
        {
            Pa_about.Visible = false;
            Pa_them.Visible = false ;
            Pa_general.Visible = true ;
            Panel_general.Visible = true;
            Panel_theme.Visible = false;
            Panel_theme_tx.Visible = false;
            Panel_share.Visible = false;
        }

        private void pictureBox11_Click(object sender, EventArgs e)
        {
            Pa_about.Visible = true ;
            Pa_them.Visible = false ;
            Pa_general.Visible = false;
            Panel_general.Visible = false ;
            Panel_theme.Visible = false;
            Panel_theme_tx.Visible = false;
            Panel_share.Visible = true ;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            colorDialog3.ShowDialog();
            this.BackColor = colorDialog3.Color;
            panel1.BackColor = Color.Gray;
            pictureBox14.BackColor = colorDialog3.Color;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            fontDialog2.ShowDialog();
            label1.Font = fontDialog2.Font;
        }

        private void button5_Click(object sender, EventArgs e)
        {
            fontDialog1.ShowDialog();
            textBox1.Font = fontDialog1.Font;
        }

        private void button6_Click(object sender, EventArgs e)
        {
            colorDialog4.ShowDialog();
            textBox1.ForeColor = colorDialog4.Color;
            pictureBox15.BackColor = colorDialog4.Color;
        }

        private void button7_Click(object sender, EventArgs e)
        {
            fontDialog3.ShowDialog();
            label2.Font = fontDialog3.Font;
        }

        private void textBox2_TextChanged_1(object sender, EventArgs e)
        {
            label1.Text = textBox2.Text;
        }

        private void textBox3_TextChanged_1(object sender, EventArgs e)
        {
            label2.Text = textBox3.Text;
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
             System.Diagnostics.Process.Start("https://www.youtube.com/channel/UCUVVQuZDggQ49cEYOtlto8A");
             notifyIcon1.Icon = this.Icon;
             notifyIcon1.BalloonTipIcon = ToolTipIcon.Info ;
             notifyIcon1.BalloonTipText = "Please Description our channel and share it with your friends ! ,  ";
             notifyIcon1.BalloonTipTitle = "Mental Software";
             notifyIcon1.ShowBalloonTip(20);

        }

        private void linkLabel2_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            System.Diagnostics.Process.Start("www.facebook.com/dev.mental20");
            notifyIcon1.Icon = this.Icon;
            notifyIcon1.BalloonTipIcon = ToolTipIcon.Info;
            notifyIcon1.BalloonTipText = "Please dont't forget like our page ! ";
            notifyIcon1.BalloonTipTitle = "Mental Software";
            notifyIcon1.ShowBalloonTip(20);
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            textBox1.Font = new Font("Consolas", 16);
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            string tx = textBox1 .Text ;
            tx = tx.Trim();
            int txN = tx.Length;
            label32 .Text  = (txN.ToString());
            if (label32 .Text == "100")
            {

                label32.ForeColor = Color.Green;

            } else 
                if (label32 .Text == "1000")
                {
                    label32.ForeColor = Color.OrangeRed;

                }
        }

        private void label34_Click(object sender, EventArgs e)
        {
            textBox1.RightToLeft = RightToLeft.Yes;
        }

        private void label33_Click(object sender, EventArgs e)
        {
            textBox1.RightToLeft = RightToLeft.No;
        }
        
    }
}
