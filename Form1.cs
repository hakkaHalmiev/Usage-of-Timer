using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Usage_of_Timer
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        int sayac = 0;
        int saat = 0;
        int dakika = 0;
        int saniye = 0;

        private void button1_Click(object sender, EventArgs e)
        {
            timer1.Start();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            
            
                sayac++;
                label1.Text = sayac.ToString();

            if (sayac >= 100)
                {
                    timer1.Stop();
                    MessageBox.Show("Süre doldu");
            }



        }

        private void timer2_Tick(object sender, EventArgs e)
        {
            saniye++;
            if (saniye == 60)
            {
                saniye = 0;
                dakika++;
            }
            if (dakika == 60)
            {
                dakika = 0;
                saat++;
            }

            label2.Text = saat.ToString();
            label3.Text = dakika.ToString();
            label4.Text = saniye.ToString();

            
           

        }
    }
}
