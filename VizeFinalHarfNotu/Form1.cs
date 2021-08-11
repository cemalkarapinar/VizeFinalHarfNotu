using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace VizeFinalHarfNotu
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int vize =Convert.ToInt32(textBox1.Text);
            int final=Convert.ToInt32(textBox2.Text);
            int ortalama;
            ortalama = (vize * 40 / 100) + (final * 60 / 100);
            if(ortalama >= 88)
            {
                label5.Text = "AA";
                label6.Text = ortalama.ToString();
            }
            if (ortalama >= 81 & ortalama <=87)
            {
                label5.Text = "BA";
                label6.Text = ortalama.ToString();
            }
            if (ortalama >= 74 & ortalama <= 80)
            {
                label5.Text = "BB";
                label6.Text = ortalama.ToString();
            }
            if (ortalama >= 67 & ortalama <= 73)
            {
                label5.Text = "CB";
                label6.Text = ortalama.ToString();
            }
            if (ortalama >=60 & ortalama <= 66)
            {
                label5.Text = "CC";
                label6.Text = ortalama.ToString();
            }
            if (ortalama >= 53 & ortalama <= 59)
            {
                label5.Text = "DC";
                label6.Text = ortalama.ToString();
            }
            if (ortalama >= 46 & ortalama <= 52)
            {
                label5.Text = "DD";
                label6.Text = ortalama.ToString();
            }
            if (ortalama >= 39 & ortalama <= 45)
            {
                label5.Text = "FD";
                label6.Text = ortalama.ToString();
            }
            if (ortalama >= 0 & ortalama <= 38)
            {
                label5.Text = "FF";
                label6.Text = ortalama.ToString();
            }


        }
    }
}
