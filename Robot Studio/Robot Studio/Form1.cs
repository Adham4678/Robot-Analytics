using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Management;
using System.Runtime.InteropServices;
using System.IO;
using System.Windows.Forms.DataVisualization.Charting.ChartTypes;
using System.Diagnostics;
using System.Net;
using Microsoft.Win32;
using System.IO.IsolatedStorage;
using System.Threading;

namespace Robot_Studio
{
    public partial class Form1 : Form
    {
        public CreateFileOrFolder CFF = new CreateFileOrFolder();
        [DllImport("kernel32.dll", CharSet = CharSet.Auto)]
        public static extern int GetDriveType(string lpRootPathName);
        public Uri uri;
        public MemoryManagement MemoryFoo = new MemoryManagement();
        public bool IsMemoryByte = false;
        public Form1()
        {
            Int64 phav = PerformanceInfo.GetPhysicalAvailableMemoryInMiB();
            Int64 tot = PerformanceInfo.GetTotalMemoryInMiB();
            decimal percentFree = ((decimal)phav / (decimal)tot) * 100;
            InitializeComponent();
            percentToolStripMenuItem.Text = percentFree.ToString() + " gb";
            cpuCounter = new PerformanceCounter("Processor", "% Processor Time", "_Total");
            ramCounter = new PerformanceCounter("Memory", "Available MBytes");
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
        const int WM_DEVICECHANGE = 0x0219; //see msdn site
        const int DBT_DEVICEARRIVAL = 0x8000;
        const int DBT_DEVICEREMOVALCOMPLETE = 0x8004;
        const int DBT_DEVTYPVOLUME = 0x00000002;  
        protected override void WndProc(ref Message m)
        {
            if (m.Msg == WM_DEVICECHANGE)
            {
                try
                {
                    DEV_BROADCAST_VOLUME vol = (DEV_BROADCAST_VOLUME)Marshal.PtrToStructure(m.LParam, typeof(DEV_BROADCAST_VOLUME));
                }
                catch (NullReferenceException ex)
                {
                    return;
                }
                DEV_BROADCAST_VOLUME vol1 = (DEV_BROADCAST_VOLUME)Marshal.PtrToStructure(m.LParam, typeof(DEV_BROADCAST_VOLUME));
                if ((m.WParam.ToInt32() == DBT_DEVICEARRIVAL) && (vol1.dbcv_devicetype == DBT_DEVTYPVOLUME))
                {
                    MessageBox.Show("Usb Put In");
                    Form5 f5 = new Form5(); 
                    f5.Show();
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
                if ((m.WParam.ToInt32() == DBT_DEVICEREMOVALCOMPLETE) && (vol1.dbcv_devicetype == DBT_DEVTYPVOLUME))
                {
                    MessageBox.Show("Usb Out");
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
            base.WndProc(ref m);
        }

        [StructLayout(LayoutKind.Sequential)] //Same layout in mem
        public struct DEV_BROADCAST_VOLUME
        {
            public int dbcv_size;
            public int dbcv_devicetype;
            public int dbcv_reserved;
            public int dbcv_unitmask;
        }

        private static char DriveMaskToLetter(int mask)
        {
            char letter;
            string drives = "ABCDEFGHIJKLMNOPQRSTUVWXYZ"; //1 = A, 2 = B, 3 = C
            int cnt = 0;
            int pom = mask / 2;
            while (pom != 0)    // while there is any bit set in the mask shift it right        
            {
                pom = pom / 2;
                cnt++;
            }
            if (cnt < drives.Length)
                letter = drives[cnt];
            else
                letter = '?';
            return letter;
        }
        public bool GetIsDisk()
        {
            return true;
        }
        public string getCurrentCpuUsage()
        {
            return cpuCounter.NextValue() + "%";
        }

        public string getAvailableRAM()
        {
            return ramCounter.NextValue() + "MB";
        }
        public void FlushMemory()
        {
            MemoryFoo.FlushMemory();
        }
        private void button1_Click(object sender, EventArgs e)
        {
            if (!IsMemoryByte)
            {
                Int64 phav = PerformanceInfo.GetPhysicalAvailableMemoryInMiB();
                Int64 tot = PerformanceInfo.GetTotalMemoryInMiB();
                decimal percentFree = ((decimal)phav / (decimal)tot) * 100;
                decimal percentOccupied = 100 - percentFree;
                textBox3.Text = ("Available Physical Memory (MiB) " + phav.ToString());
                textBox4.Text = ("Total Memory (MiB) " + tot.ToString());
                textBox1.Text = ("Free (%) " + percentFree.ToString());
                textBox2.Text = ("Occupied (%) " + percentOccupied.ToString());
            }
            else
            {
                Int64 phav = PerformanceInfo.GetPhysicalAvailableMemoryInMiB();
                Int64 tot = PerformanceInfo.GetTotalMemoryInMiB();
                decimal percentFree = ((decimal)phav / (decimal)tot) * 100;
                decimal percentOccupied = 100 - percentFree;
                textBox3.Text = ("Available Physical Memory (MiB) " + Convert.ToByte(phav));
                textBox4.Text = ("Total Memory (MiB) " + Convert.ToByte(tot));
                textBox1.Text = ("Free (%) " + Convert.ToByte(percentFree));
                textBox2.Text = ("Occupied (%) " + Convert.ToByte(percentOccupied));
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Int64 phav = PerformanceInfo.GetPhysicalAvailableMemoryInMiB();
            Int64 tot = PerformanceInfo.GetTotalMemoryInMiB();
            decimal percentFree = ((decimal)phav / (decimal)tot) * 100;
            decimal percentOccupied = 100 - percentFree;
            textBox3.Text = ("Available Physical Memory (MiB) " + Convert.ToByte(phav).ToString());
            textBox4.Text = ("Total Memory (MiB) " + Convert.ToByte(tot).ToString());
            textBox1.Text = ("Free (%) " + Convert.ToByte(percentFree).ToString());
            textBox2.Text = ("Occupied (%) " + Convert.ToByte(percentOccupied).ToString());
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Int64 phav = PerformanceInfo.GetPhysicalAvailableMemoryInMiB();
            Int64 tot = PerformanceInfo.GetTotalMemoryInMiB();
            decimal percentFree = ((decimal)phav / (decimal)tot) * 100;
            decimal percentOccupied = 100 - percentFree;
            textBox3.Text = ("Available Physical Memory (MiB) " + Convert.ToSByte(phav));
            textBox4.Text = ("Total Memory (MiB) " + Convert.ToSByte(tot));
            textBox1.Text = ("Free (%) " + Convert.ToSByte(percentFree));
            textBox2.Text = ("Occupied (%) " + Convert.ToSByte(percentOccupied));
        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            Int64 phav = PerformanceInfo.GetPhysicalAvailableMemoryInMiB();
            Int64 tot = PerformanceInfo.GetTotalMemoryInMiB();
            decimal percentFree = ((decimal)phav / (decimal)tot) * 100;
            decimal percentOccupied = 100 - percentFree;
            textBox3.Text = ("Available Physical Memory (MiB) " + phav.ToString());
            textBox4.Text = ("Total Memory (MiB) " + tot.ToString());
            textBox1.Text = ("Free (%) " + percentFree.ToString());
            textBox2.Text = ("Occupied (%) " + percentOccupied.ToString());
            FlushMemory();
            percentToolStripMenuItem.Text = percentFree.ToString() + " gb";
        }

        private void button3_Click_1(object sender, EventArgs e)
        {
            Update();
            Refresh();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            //using (OpenFileDialog ofd = new OpenFileDialog())
            //{
            //    if (ofd.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            //    {
            //        uri = new Uri(ofd.FileName);
            //        //textBox5.Text = uri.ToString(); 
            //    }
            //}
        }

        private void button4_Click(object sender, EventArgs e)
        {
            //webBrowser1.Url = uri;
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            //webBrowser1.Dock = DockStyle.Fill;
            //this.Bounds = Screen.PrimaryScreen.Bounds;
            //linkLabel1.Visible = false;
            try
            {
                //System.Diagnostics.Process.Start(textBox5.Text);
            }
            catch (NullReferenceException)
            {
                MessageBox.Show("Something Went Wrong;\n System Uri == null;");
            }
            catch (ArgumentNullException)
            {
                MessageBox.Show("Something Went Wrong;\n System Uri == null;");
            }
        }


        private void Form1_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Back)
            {
                this.WindowState = FormWindowState.Normal;
            }
        }

        private void button6_Click(object sender, EventArgs e)
        {
            textBox6.Text = getCurrentCpuUsage();
            textBox7.Text = getAvailableRAM();
            string OPSystemVersion = Environment.OSVersion.ToString();
            textBox8.Text = OPSystemVersion;
        }
        PerformanceCounter cpuCounter;
        PerformanceCounter ramCounter;

        private void button4_Click_1(object sender, EventArgs e)
        {
            Form3 f3 = new Form3();
            f3.Show();
        }

        private void button5_Click_1(object sender, EventArgs e)
        {
            //var drives = DriveInfo.GetDrives().Where(drive => drive.IsReady && drive.DriveType == DriveType.Removable);
            //bool IsDrive = Convert.ToBoolean(drives);
            //textBox5.Text = drives.ToString();
            foreach (string s in Environment.GetLogicalDrives())
                textBox5.Text = (string.Format("Drive {0} is a {1}.",
                s, Enum.GetName(typeof(DriveType), GetDriveType(s))));
        }
        public void AccessCamera()
        {
            string sourceURL = "http://webcam.mmhk.cz/axis-cgi/jpg/image.cgi";
            byte[] buffer = new byte[100000];
            int read, total = 0;
            // create HTTP request
            HttpWebRequest req = (HttpWebRequest)WebRequest.Create(sourceURL);
            // get response
            WebResponse resp = req.GetResponse();
            // get response stream
            Stream stream = resp.GetResponseStream();
            // read data from stream
            while ((read = stream.Read(buffer, total, 1000)) != 0)
            {
                total += read; 
            }
            // get bitmap
            Bitmap bmp = (Bitmap)Bitmap.FromStream(new MemoryStream(buffer, 0, total));
        }
        public void Processer()
        {

        }
        private void button7_Click(object sender, EventArgs e)
        {
            RegistryKey registrykeyHKLM = Registry.LocalMachine;
            string keyPath = @"HARDWARE\DESCRIPTION\System\CentralProcessor\0";
            RegistryKey registrykeyCPU = registrykeyHKLM.OpenSubKey(keyPath, false);
            string MHz = registrykeyCPU.GetValue("~MHz").ToString();
            string ProcessorNameString = (string)registrykeyCPU.GetValue("ProcessorNameString");
            registrykeyCPU.Close();
            registrykeyHKLM.Close();
            textBox9.Text = MHz.ToString() + " % Ghz";
        }
        public void CPUFrequency()
        {
            RegistryKey registrykeyHKLM = Registry.LocalMachine;
            string keyPath = @"HARDWARE\DESCRIPTION\System\CentralProcessor\0";
            RegistryKey registrykeyCPU = registrykeyHKLM.OpenSubKey(keyPath, false);
            string MHz = registrykeyCPU.GetValue("~MHz").ToString();
            string ProcessorNameString = (string)registrykeyCPU.GetValue("ProcessorNameString");
            registrykeyCPU.Close();
            registrykeyHKLM.Close();
            MessageBox.Show(MHz + " Mhz for " + ProcessorNameString);
        }
        public string GetPathFromIsolatedStoragePath()
        {
            return IsolatedStorageFile.GetMachineStoreForDomain().AssemblyIdentity.ToString();             
        }
        private void timer1_Tick(object sender, EventArgs e)
        {
            textBox12.Text = GetPathFromIsolatedStoragePath();
            textBox6.Text = getCurrentCpuUsage();
            textBox7.Text = getAvailableRAM();
            string OPSystemVersion = Environment.OSVersion.ToString();
            textBox8.Text = OPSystemVersion;
            Int64 phav = PerformanceInfo.GetPhysicalAvailableMemoryInMiB();
            Int64 tot = PerformanceInfo.GetTotalMemoryInMiB();
            decimal percentFree = ((decimal)phav / (decimal)tot) * 100;
            decimal percentOccupied = 100 - percentFree;
            textBox3.Text = ("Available Physical Memory (MiB) " + phav.ToString());
            textBox4.Text = ("Total Memory (MiB) " + tot.ToString());
            textBox1.Text = ("Free (%) " + percentFree.ToString());
            textBox2.Text = ("Occupied (%) " + percentOccupied.ToString());
            FlushMemory();
            percentToolStripMenuItem.Text = percentFree.ToString() + " gb";
            long workingSet = System.Diagnostics.Process.GetCurrentProcess().WorkingSet64;
            textBox11.Text = workingSet.ToString();
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
           // assemblyToolStripMenuItem1.Text = IsolatedStorageFile.GetEnumerator(IsolatedStorageScope.Assembly).ToString();
        }
        private static void IncreaseMemory(long limity)
        {
            var limit = limity;

            var list = new List<byte[]>();
            try
            {
                while (true)
                {
                    list.Add(new byte[limit]); // Change the size here.
                    Thread.Sleep(1000); // Change the wait time here.
                }
            }

            catch (Exception ex)
            {
                // do nothing
            }
        }

        private void button8_Click(object sender, EventArgs e)
        {
            RegistryKey registrykeyHKLM = Registry.LocalMachine;
            string keyPath = @"HARDWARE\DESCRIPTION\System\CentralProcessor\0";
            RegistryKey registrykeyCPU = registrykeyHKLM.OpenSubKey(keyPath, false);
            string MHz = registrykeyCPU.GetValue("~MHz").ToString();
            string ProcessorNameString = (string)registrykeyCPU.GetValue("ProcessorNameString");
            registrykeyCPU.Close();
            registrykeyHKLM.Close();
            textBox10.Text = ProcessorNameString;
        }

        private void assemblyToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            try
            {
                IsolatedStorageFile.Remove(IsolatedStorageScope.Assembly);
                MessageBox.Show(NewMethod());
            }
            catch (ArgumentException exe)
            {
                MessageBox.Show("Oops Something Went Wrong");
            }
        }

        private static string NewMethod()
        {
            return "Removed Isolated Storage File Assembly Scope";
        }

        private void machineToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            try
            {
                IsolatedStorageFile.Remove(IsolatedStorageScope.Machine);
                MessageBox.Show("Removed Isolated Storage File Machine Scope");
            }
            catch (IsolatedStorageException exe)
            {
                MessageBox.Show("Oops Something Went Wrong");
            }
        }

        private void button9_Click(object sender, EventArgs e)
        {

        }

        private void button10_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Debugger.Launch();
        }

        private void button11_Click(object sender, EventArgs e)
        {
            Programer p = new Programer();
           // p.MainFunc(textBox13.Text);
        }

        private void button9_Click_1(object sender, EventArgs e)
        {
           // MessageBox.Show("Please Restart This App To Continue. There Was A Problem", "System Errors", MessageBoxButtons.YesNo);
            //IncreaseMemory(long.Parse(textBox13.Text));
        }

        private void button11_Click_1(object sender, EventArgs e)
        {
          //  MemoryLeak.IsItDead();
        }

        private void checkAnyInternetSignalsIncomingFromUnityToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Process UnityP = new Process();
            string path = "https://unity3d.com/";
            UnityP.StartInfo.FileName = path;
            UnityP.Start();
        }

        private void postDataAndGetResponseFromServerToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form6 f6 = new Form6();
            f6.ShowDialog();
        }
        public bool Hex = false;
        public bool Binary = false;
        public bool Decimal = false;
        private void ConvertToCompilerLanguage(object sender, EventArgs e)
        {
            ToolStripItem TSI = (ToolStripItem)sender;
            switch (TSI.Text)
            {
                case "Hexadecimal":
                    Hex = true;
                    Decimal = false;
                    Binary = false;
                    break;
                case "Decimal":
                    Hex = false;
                    Decimal = true;
                    Binary = false;
                    break;
                case "Binary":
                    Hex = false;
                    Decimal = false;
                    Binary = true;
                    break;
            }
            Form7 f7 = new Form7();
            f7.Show();
        }

        private void sendDataToSerialPortToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form8 f8 = new Form8();
            f8.ShowDialog();
        }

        private void hardwareOutputToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SerialComm sc = new SerialComm();
            sc.Show();
        }
    }
  //  public class MemoryLeak
  //  {
       // public static WeakReference Reference { get; private set; }

       // public static void CheckObject(object ObjToCheck)
        //{
         //   MemoryLeak.Reference = new WeakReference(ObjToCheck);
       // }

       // public static void IsItDead()
       // {
         //   GC.Collect();
         //   GC.WaitForPendingFinalizers();
        //    if (MemoryLeak.Reference.IsAlive || MemoryLeak.Reference.IsAlive == null)
         //       MessageBox.Show("Memory Leak On");
        //    else
        //        MessageBox.Show("Memory Leak Off");
       // }
    ///}  
    public class CreateFileOrFolder
    {
        public void MainFunction()
        {
            // Specify a name for your top-level folder.
            string folderName = @"c:\Top-Level Folder";

            // To create a string that specifies the path to a subfolder under your 
            // top-level folder, add a name for the subfolder to folderName.
            string pathString = System.IO.Path.Combine(folderName, "SubFolder");
            // You can write out the path name directly instead of using the Combine
            // method. Combine just makes the process easier.
            string pathString2 = @"c:\Top-Level Folder\SubFolder2";

            // You can extend the depth of your path if you want to.
            //pathString = System.IO.Path.Combine(pathString, "SubSubFolder");

            // Create the subfolder. You can verify in File Explorer that you have this
            // structure in the C: drive.
            //    Local Disk (C:)
            //        Top-Level Folder
            //            SubFolder
            System.IO.Directory.CreateDirectory(pathString);

            // Create a file name for the file you want to create. 
            string fileName = System.IO.Path.GetRandomFileName();

            // This example uses a random string for the name, but you also can specify
            // a particular name.
            //string fileName = "MyNewFile.txt";

            // Use Combine again to add the file name to the path.
            pathString = System.IO.Path.Combine(pathString, fileName);

            // Verify the path that you have constructed.
            MessageBox.Show("Path to my file: {0}\n", pathString);

            // Check that the file doesn't already exist. If it doesn't exist, create
            // the file and write integers 0 - 99 to it.
            // DANGER: System.IO.File.Create will overwrite the file if it already exists.
            // This could happen even with random file names, although it is unlikely.
            if (!System.IO.File.Exists(pathString))
            {
                using (System.IO.FileStream fs = System.IO.File.Create(pathString))
                {
                    for (byte i = 0; i < 100; i++)
                    {
                        fs.WriteByte(i);
                    }
                }
            }
            else
            {
                MessageBox.Show("File \"{0}\" already exists.", fileName);
                return;
            }

            // Read and display the data from your file.
            try
            {
                byte[] readBuffer = System.IO.File.ReadAllBytes(pathString);
                foreach (byte b in readBuffer)
                {
                    MessageBox.Show(b + " ");
                }
            }
            catch (System.IO.IOException e)
            {
                MessageBox.Show(e.Message);
            }

            // Keep the console window open in debug mode.
            //System.Console.WriteLine("Press any key to exit.");
            //System.Console.ReadKey();
        }
        // Sample output:

        // Path to my file: c:\Top-Level Folder\SubFolder\ttxvauxe.vv0
        
        //0 1 2 3 4 5 6 7 8 9 10 11 12 13 14 15 16 17 18 19 20 21 22 23 24 25 26 27 28 29
        //30 31 32 33 34 35 36 37 38 39 40 41 42 43 44 45 46 47 48 49 50 51 52 53 54 55 56
        // 57 58 59 60 61 62 63 64 65 66 67 68 69 70 71 72 73 74 75 76 77 78 79 80 81 82 83
        // 84 85 86 87 88 89 90 91 92 93 94 95 96 97 98 99
    }
    class Programer
    {
        // REQUIRED CONSTS
        const int PROCESS_QUERY_INFORMATION = 0x0400;
        const int MEM_COMMIT = 0x00001000;
        const int PAGE_READWRITE = 0x04;
        const int PROCESS_WM_READ = 0x0010;

        // REQUIRED METHODS
        [DllImport("kernel32.dll")]
        public static extern IntPtr OpenProcess(int dwDesiredAccess, bool bInheritHandle, int dwProcessId);

        [DllImport("kernel32.dll")]
        public static extern bool ReadProcessMemory(int hProcess, int lpBaseAddress, byte[] lpBuffer, int dwSize, ref int lpNumberOfBytesRead);

        [DllImport("kernel32.dll")]
        static extern void GetSystemInfo(out SYSTEM_INFO lpSystemInfo);

        [DllImport("kernel32.dll", SetLastError = true)]
        static extern int VirtualQueryEx(IntPtr hProcess, IntPtr lpAddress, out MEMORY_BASIC_INFORMATION lpBuffer, uint dwLength);

        // REQUIRED STRUCTS
        public struct MEMORY_BASIC_INFORMATION
        {
            public int BaseAddress;
            public int AllocationBase;
            public int AllocationProtect;
            public int RegionSize;
            public int State;
            public int Protect;
            public int lType;
        }

        public struct SYSTEM_INFO
        {
            public ushort processorArchitecture;
            ushort reserved;
            public uint pageSize;
            public IntPtr minimumApplicationAddress;
            public IntPtr maximumApplicationAddress;
            public IntPtr activeProcessorMask;
            public uint numberOfProcessors;
            public uint processorType;
            public uint allocationGranularity;
            public ushort processorLevel;
            public ushort processorRevision;
        }
        public Programer()
        {

        }
        // finally...
        public void MainFunc(string AppName)
        {
            // getting minimum & maximum address
            SYSTEM_INFO sys_info = new SYSTEM_INFO();
            GetSystemInfo(out sys_info);

            IntPtr proc_min_address = sys_info.minimumApplicationAddress;
            IntPtr proc_max_address = sys_info.maximumApplicationAddress;

            // saving the values as long ints so I won't have to do a lot of casts later
            long proc_min_address_l = (long)proc_min_address;
            long proc_max_address_l = (long)proc_max_address;

            // notepad better be runnin'
            Process process = Process.GetProcessesByName(AppName)[0];

            // opening the process with desired access level
            IntPtr processHandle = OpenProcess(PROCESS_QUERY_INFORMATION | PROCESS_WM_READ, false, process.Id);

            StreamWriter sw = new StreamWriter("dump.txt");

            // this will store any information we get from VirtualQueryEx()
            MEMORY_BASIC_INFORMATION mem_basic_info = new MEMORY_BASIC_INFORMATION();

            int bytesRead = 0;  // number of bytes read with ReadProcessMemory

            while (proc_min_address_l < proc_max_address_l)
            {
                // 28 = sizeof(MEMORY_BASIC_INFORMATION)
                VirtualQueryEx(processHandle, proc_min_address, out mem_basic_info, 28);

                // if this memory chunk is accessible
                if (mem_basic_info.Protect == PAGE_READWRITE && mem_basic_info.State == MEM_COMMIT)
                {
                    byte[] buffer = new byte[mem_basic_info.RegionSize];

                    // read everything in the buffer above
                    ReadProcessMemory((int)processHandle, mem_basic_info.BaseAddress, buffer, mem_basic_info.RegionSize, ref bytesRead);

                    // then output this in the file
                    for (int i = 0; i < mem_basic_info.RegionSize; i++)
                        sw.WriteLine("0x{0} : {1}", (mem_basic_info.BaseAddress + i).ToString("X"), (char)buffer[i]);
                }

                // move to the next memory chunk
               proc_min_address_l += mem_basic_info.RegionSize;
                proc_min_address = new IntPtr(proc_min_address_l);
            }
            sw.Close(); 
            
               
                MemoryStream mem = new MemoryStream();
                // then later you should be able to get your string.
                // this is in c# but I am certain you can do something of the sort in C++
                String result = System.Text.Encoding.UTF8.GetString(mem.ToArray(), 0, (int)mem.Length);
                Form1 f1 = new Form1();
             //   f1.textBox14.Text = result.ToString() + "%";
        }
    }
    public static class PerformanceInfo
    {
        [DllImport("psapi.dll", SetLastError = true)]
        [return: MarshalAs(UnmanagedType.Bool)]
        public static extern bool GetPerformanceInfo([Out] out PerformanceInformation PerformanceInformation, [In] int Size);

        [StructLayout(LayoutKind.Sequential)]
        public struct PerformanceInformation
        {
            public int Size;
            public IntPtr CommitTotal;
            public IntPtr CommitLimit;
            public IntPtr CommitPeak;
            public IntPtr PhysicalTotal;
            public IntPtr PhysicalAvailable;
            public IntPtr SystemCache;
            public IntPtr KernelTotal;
            public IntPtr KernelPaged;
            public IntPtr KernelNonPaged;
            public IntPtr PageSize;
            public int HandlesCount;
            public int ProcessCount; 
            public int ThreadCount;
        }

        public static Int64 GetPhysicalAvailableMemoryInMiB()
        {
            PerformanceInformation pi = new PerformanceInformation();
            if (GetPerformanceInfo(out pi, Marshal.SizeOf(pi)))
            {
                return Convert.ToInt64((pi.PhysicalAvailable.ToInt64() * pi.PageSize.ToInt64() / 1048576));
            }
            else
            {
                return -1;
            }
        }

        public static Int64 GetTotalMemoryInMiB()
        {
            PerformanceInformation pi = new PerformanceInformation();
            if (GetPerformanceInfo(out pi, Marshal.SizeOf(pi)))
            {
                return Convert.ToInt64((pi.PhysicalTotal.ToInt64() * pi.PageSize.ToInt64() / 1048576));
            }
            else
            {
                return -1;
            }

        }
    }
    public class MemoryManagement
    {
        [DllImportAttribute("kernel32.dll", EntryPoint = "SetProcessWorkingSetSize", ExactSpelling = true, CharSet = CharSet.Ansi, SetLastError = true)]
        private static extern int SetProcessWorkingSetSize(IntPtr process, int minimumWorkingSetSize, int maximumWorkingSetSize);

        public void FlushMemory()
        {
            GC.Collect();
            GC.WaitForPendingFinalizers();
            SetProcessWorkingSetSize(System.Diagnostics.Process.GetCurrentProcess().Handle, -1, -1);
        }
    }
    public enum DriveType : int
    {
        Unknown = 0,
        NoRoot = 1,
        Removable = 2,
        Localdisk = 3,
        Network = 4,
        CD = 5,
        RAMDrive = 6,
        CDRom
    }
}



