using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Robot_Studio
{
    public partial class Form8 : Form
    {
        public Form8()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string Com = textBox1.Text;
            int baudRate = Convert.ToInt32(textBox2.Text);
            serialPort1.PortName = Com;
            serialPort1.BaudRate = baudRate;
            serialPort1.Open();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            serialPort1.Write(textBox3.Text.ToString());
        }
    }
}
