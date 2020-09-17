using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Robot_Studio
{
    public partial class Form5 : Form
    {
        public Form5()
        {
            InitializeComponent();
            try
            {
                DriveInfo[] myDrives = DriveInfo.GetDrives();
                StringBuilder sb = new StringBuilder();
                foreach (DriveInfo drive in myDrives)
                {
                    sb.AppendLine("Drive:" + drive.Name);
                    sb.AppendLine("Drive Type:" + drive.DriveType);

                    if (drive.IsReady == true)
                    {
                        sb.AppendLine("Vol Label:" + drive.VolumeLabel);
                        sb.AppendLine("File System: " + drive.DriveFormat);
                    }
                }
                richTextBox1.Text = (sb.ToString());
            }
            catch (Exception)
            {
                throw;
            }
            
        }
    }
}
