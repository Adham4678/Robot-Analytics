using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace Robot_Studio
{
    public partial class Form2 : Form
    {
        public Uri uri1;
        Form1 f1 = new Form1();
        public Form2()
        {
            //Uri uri2 = new Uri(f1.textBox5.Text);
            InitializeComponent();
            this.Bounds = Screen.PrimaryScreen.Bounds;
            //webBrowser1.Url = uri2;
        }
    }
}
