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
    public partial class Form7 : Form
    {
        public Compiler COM = new Compiler();
        public Form1 f1 = new Form1();
        public Form7()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string Data = richTextBox2.Text.ToString();
            if (f1.Binary)
            {
                richTextBox1.Text = COM.StringToBinary(Data);
            }
            if (f1.Decimal)
            {
                richTextBox1.Text = COM.Data_Decimal(Data).ToString();
            }
            if (f1.Hex)
            {
                richTextBox1.Text = COM.Data_Hex_Asc(Data);
            }
            Refresh();
        }
    }
}
