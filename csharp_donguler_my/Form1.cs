using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace csharp_donguler_my
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int i;
            for(i = 0; i < 10; i++)
            {
                listBox1.Items.Add(i+". Sayı");
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            int i = 1;
            while(i < 10)
            {
                listBox2.Items.Add(i + ". Sayı");
                i++;
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            int i=1;
            do
            {
                listBox3.Items.Add(i + ". Sayı");
                i++;
            } while(i < 10);
        }

      
    }
}
