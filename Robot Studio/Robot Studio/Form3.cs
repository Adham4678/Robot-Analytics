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
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
            System.Text.StringBuilder sb = new System.Text.StringBuilder();
            var currentProcess = System.Diagnostics.Process.GetCurrentProcess();
            sb.AppendLine("Process information");
            sb.AppendLine("-------------------");
            sb.AppendLine("CPU time");
            sb.AppendLine(string.Format("\tTotal       {0}",
                currentProcess.TotalProcessorTime));
            sb.AppendLine(string.Format("\tUser        {0}",
                currentProcess.UserProcessorTime));
            sb.AppendLine(string.Format("\tPrivileged  {0}",
                currentProcess.PrivilegedProcessorTime));
            sb.AppendLine("Memory usage");
            sb.AppendLine(string.Format("\tCurrent     {0:N0} B", currentProcess.WorkingSet64));
            sb.AppendLine(string.Format("\tPeak        {0:N0} B", currentProcess.PeakWorkingSet64));
            sb.AppendLine(string.Format("Active threads      {0:N0}", currentProcess.Threads.Count));
            richTextBox1.Text = sb.ToString();
            //for (int i = 0; i <= sb.Length; i++)
            //{
            //    richTextBox1.Text += sb[i].ToString();
            //}
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            System.Text.StringBuilder sb = new System.Text.StringBuilder();

            var currentProcess = System.Diagnostics.Process.GetCurrentProcess();
            sb.AppendLine("Process information");
            sb.AppendLine("-------------------");
            sb.AppendLine("CPU time");
            sb.AppendLine(string.Format("\tTotal       {0}",
                currentProcess.TotalProcessorTime));
            sb.AppendLine(string.Format("\tUser        {0}",
                currentProcess.UserProcessorTime));
            sb.AppendLine(string.Format("\tPrivileged  {0}",
                currentProcess.PrivilegedProcessorTime));
            sb.AppendLine("Memory usage");
            sb.AppendLine(string.Format("\tCurrent     {0:N0} B", currentProcess.WorkingSet64));
            sb.AppendLine(string.Format("\tPeak        {0:N0} B", currentProcess.PeakWorkingSet64));
            sb.AppendLine(string.Format("Active threads      {0:N0}", currentProcess.Threads.Count));
            richTextBox1.Text = sb.ToString();
        }

    }
}
