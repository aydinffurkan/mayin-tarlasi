using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Mayın_Tarlası
{
    public partial class Form1 : Form
    {
        DateTime zaman = new DateTime(0);
        public Form1()
        {
            InitializeComponent();
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            label5.AutoSize = true;
            label6.AutoSize = true;
            timer1.Stop();
            for(int i=0;i<400;i++)
            {
                Button btn = new Button();
                btn.Width = 16;
                btn.Height = 16;
                btn.Margin = new System.Windows.Forms.Padding(0);
                flowLayoutPanel1.Controls.Add(btn);
            }
        }
        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {

        }
        private void flowLayoutPanel1_ControlAdded(object sender, ControlEventArgs e)
        {

        }
        private void button1_Click(object sender, EventArgs e)
        {
            MessageBox.Show(textBox1.Text + " Kaydedildi");
        }

        private void label6_Click(object sender, EventArgs e)
        {
        }

        private void tableLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            MessageBox.Show("GELIŞTİRİCİ:FURKAN AYDIN\n .......\n Nasıl Oynanır?\n");

        }

        private void ortakbuton(object sender, EventArgs e)
        {

            
        }
        private void button6_Click(object sender, EventArgs e)
        {
            timer1.Start();

        }
        private void button_Click(object sender, EventArgs e)
        {

        }
        private void button4_Click(object sender, EventArgs e)
        {
            timer1.Start();

        }
        private void button5_Click(object sender, EventArgs e)
        {
            timer1.Start();

        }
        private void button7_Click(object sender, EventArgs e)
        {
            timer1.Start();
        }
        private void timertick(object sender, EventArgs e)
        {
            zaman = zaman.AddSeconds(1);
            label6.Text = zaman.ToLongTimeString();
        }
        private void flowLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }
    }
 
}
