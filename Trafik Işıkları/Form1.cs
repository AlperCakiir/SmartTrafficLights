using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Trafik_Işıkları
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        int sure = 0, kırmızı = 10, sarı = 5, yesil = 10;

        private void timer3_Tick(object sender, EventArgs e)
        {
            sure++;
            if (sure > 0 && sure <= 10)
            {
                btnKırmızı.Text = " ";
                btnKırmızı.BackColor = Color.Transparent;
                btnSarı.Text = " ";
                btnSarı.BackColor = Color.Transparent;
                btnYesil.Text = (--yesil).ToString();
                btnYesil.BackColor = Color.Green;
            }
            else
            {
                sure = 0;
                yesil = 10;
                timer1.Start();
                timer3.Stop();
              
            }
        }

        private void timer2_Tick(object sender, EventArgs e)
        {
            sure++;
            if (sure > 0 && sure <= 5)
            {
                btnKırmızı.Text = " ";
                btnKırmızı.BackColor = Color.Transparent;
                btnSarı.Text = (--sarı).ToString();
                btnSarı.BackColor = Color.Yellow;
                btnYesil.Text = " ";
                btnYesil.BackColor = Color.Transparent;
            }
            else
            {
                sure = 0;
                sarı = 5;
                timer3.Start();
                timer2.Stop();
             
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            timer1.Start();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            sure++;
            if (sure > 0 && sure <= 10)
            {
                btnKırmızı.Text = (--kırmızı).ToString();
                btnKırmızı.BackColor = Color.Red;
                btnSarı.Text = " ";
                btnSarı.BackColor = Color.Transparent;
                btnYesil.Text = " ";
                btnYesil.BackColor = Color.Transparent;
            }
            else
            {
                sure = 0;
                kırmızı = 10;
                timer2.Start();
                timer1.Stop();
                
            }
        }
    }
}
