namespace Robot_Studio
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.button1 = new System.Windows.Forms.Button();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.settingsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.allowEuToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.assemblyToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.assemblyToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.machineToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.machineToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.postDataAndGetResponseFromServerToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.serialSoftwareConnectionToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.hardwareOutputToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.sendDataToSerialPortToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.variablesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.memoryFreeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.percentToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.textBox6 = new System.Windows.Forms.TextBox();
            this.textBox7 = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.button6 = new System.Windows.Forms.Button();
            this.textBox8 = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.button4 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.textBox5 = new System.Windows.Forms.TextBox();
            this.button7 = new System.Windows.Forms.Button();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.button8 = new System.Windows.Forms.Button();
            this.textBox9 = new System.Windows.Forms.TextBox();
            this.textBox10 = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.textBox11 = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.textBox12 = new System.Windows.Forms.TextBox();
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.button10 = new System.Windows.Forms.Button();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button1.Location = new System.Drawing.Point(38, 27);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(172, 23);
            this.button1.TabIndex = 0;
            this.button1.Text = "Generate Memory Data";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.settingsToolStripMenuItem,
            this.variablesToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(510, 24);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // settingsToolStripMenuItem
            // 
            this.settingsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.allowEuToolStripMenuItem,
            this.postDataAndGetResponseFromServerToolStripMenuItem,
            this.serialSoftwareConnectionToolStripMenuItem});
            this.settingsToolStripMenuItem.Name = "settingsToolStripMenuItem";
            this.settingsToolStripMenuItem.Size = new System.Drawing.Size(61, 20);
            this.settingsToolStripMenuItem.Text = "Settings";
            // 
            // allowEuToolStripMenuItem
            // 
            this.allowEuToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.assemblyToolStripMenuItem,
            this.machineToolStripMenuItem});
            this.allowEuToolStripMenuItem.Name = "allowEuToolStripMenuItem";
            this.allowEuToolStripMenuItem.Size = new System.Drawing.Size(289, 22);
            this.allowEuToolStripMenuItem.Text = "Remove Enumerator";
            // 
            // assemblyToolStripMenuItem
            // 
            this.assemblyToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.assemblyToolStripMenuItem1});
            this.assemblyToolStripMenuItem.Name = "assemblyToolStripMenuItem";
            this.assemblyToolStripMenuItem.Size = new System.Drawing.Size(125, 22);
            this.assemblyToolStripMenuItem.Text = "Assembly";
            // 
            // assemblyToolStripMenuItem1
            // 
            this.assemblyToolStripMenuItem1.Name = "assemblyToolStripMenuItem1";
            this.assemblyToolStripMenuItem1.Size = new System.Drawing.Size(125, 22);
            this.assemblyToolStripMenuItem1.Text = "Assembly";
            this.assemblyToolStripMenuItem1.Click += new System.EventHandler(this.assemblyToolStripMenuItem1_Click);
            // 
            // machineToolStripMenuItem
            // 
            this.machineToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.machineToolStripMenuItem1});
            this.machineToolStripMenuItem.Name = "machineToolStripMenuItem";
            this.machineToolStripMenuItem.Size = new System.Drawing.Size(125, 22);
            this.machineToolStripMenuItem.Text = "Machine";
            // 
            // machineToolStripMenuItem1
            // 
            this.machineToolStripMenuItem1.Name = "machineToolStripMenuItem1";
            this.machineToolStripMenuItem1.Size = new System.Drawing.Size(120, 22);
            this.machineToolStripMenuItem1.Text = "Machine";
            this.machineToolStripMenuItem1.Click += new System.EventHandler(this.machineToolStripMenuItem1_Click);
            // 
            // postDataAndGetResponseFromServerToolStripMenuItem
            // 
            this.postDataAndGetResponseFromServerToolStripMenuItem.Name = "postDataAndGetResponseFromServerToolStripMenuItem";
            this.postDataAndGetResponseFromServerToolStripMenuItem.Size = new System.Drawing.Size(289, 22);
            this.postDataAndGetResponseFromServerToolStripMenuItem.Text = "Post Data And Get Response From Server";
            this.postDataAndGetResponseFromServerToolStripMenuItem.Click += new System.EventHandler(this.postDataAndGetResponseFromServerToolStripMenuItem_Click);
            // 
            // serialSoftwareConnectionToolStripMenuItem
            // 
            this.serialSoftwareConnectionToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.hardwareOutputToolStripMenuItem,
            this.sendDataToSerialPortToolStripMenuItem});
            this.serialSoftwareConnectionToolStripMenuItem.Name = "serialSoftwareConnectionToolStripMenuItem";
            this.serialSoftwareConnectionToolStripMenuItem.Size = new System.Drawing.Size(289, 22);
            this.serialSoftwareConnectionToolStripMenuItem.Text = "Serial Software Connection";
            // 
            // hardwareOutputToolStripMenuItem
            // 
            this.hardwareOutputToolStripMenuItem.Name = "hardwareOutputToolStripMenuItem";
            this.hardwareOutputToolStripMenuItem.Size = new System.Drawing.Size(200, 22);
            this.hardwareOutputToolStripMenuItem.Text = "Hardware Output";
            this.hardwareOutputToolStripMenuItem.Click += new System.EventHandler(this.hardwareOutputToolStripMenuItem_Click);
            // 
            // sendDataToSerialPortToolStripMenuItem
            // 
            this.sendDataToSerialPortToolStripMenuItem.Name = "sendDataToSerialPortToolStripMenuItem";
            this.sendDataToSerialPortToolStripMenuItem.Size = new System.Drawing.Size(200, 22);
            this.sendDataToSerialPortToolStripMenuItem.Text = "Send Data To Serial Port";
            this.sendDataToSerialPortToolStripMenuItem.Click += new System.EventHandler(this.sendDataToSerialPortToolStripMenuItem_Click);
            // 
            // variablesToolStripMenuItem
            // 
            this.variablesToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.memoryFreeToolStripMenuItem});
            this.variablesToolStripMenuItem.Name = "variablesToolStripMenuItem";
            this.variablesToolStripMenuItem.Size = new System.Drawing.Size(66, 20);
            this.variablesToolStripMenuItem.Text = "Variables";
            // 
            // memoryFreeToolStripMenuItem
            // 
            this.memoryFreeToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.percentToolStripMenuItem});
            this.memoryFreeToolStripMenuItem.Name = "memoryFreeToolStripMenuItem";
            this.memoryFreeToolStripMenuItem.Size = new System.Drawing.Size(144, 22);
            this.memoryFreeToolStripMenuItem.Text = "Memory Free";
            // 
            // percentToolStripMenuItem
            // 
            this.percentToolStripMenuItem.Name = "percentToolStripMenuItem";
            this.percentToolStripMenuItem.Size = new System.Drawing.Size(117, 22);
            this.percentToolStripMenuItem.Text = "Percent ";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(72, 56);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(178, 20);
            this.textBox1.TabIndex = 2;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(72, 82);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(178, 20);
            this.textBox2.TabIndex = 3;
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(72, 108);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(178, 20);
            this.textBox3.TabIndex = 4;
            // 
            // textBox4
            // 
            this.textBox4.Location = new System.Drawing.Point(72, 134);
            this.textBox4.Name = "textBox4";
            this.textBox4.Size = new System.Drawing.Size(178, 20);
            this.textBox4.TabIndex = 5;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(21, 59);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(28, 13);
            this.label1.TabIndex = 6;
            this.label1.Text = "Free";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(13, 85);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(53, 13);
            this.label2.TabIndex = 7;
            this.label2.Text = "Occupied";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(21, 137);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(34, 13);
            this.label3.TabIndex = 8;
            this.label3.Text = "Total ";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 111);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(50, 13);
            this.label4.TabIndex = 9;
            this.label4.Text = "Available";
            // 
            // button2
            // 
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button2.Location = new System.Drawing.Point(15, 160);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(122, 23);
            this.button2.TabIndex = 10;
            this.button2.Text = "Flush Memory";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click_1);
            // 
            // button3
            // 
            this.button3.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button3.Location = new System.Drawing.Point(143, 160);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(122, 23);
            this.button3.TabIndex = 11;
            this.button3.Text = "Refresh";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click_1);
            // 
            // textBox6
            // 
            this.textBox6.Location = new System.Drawing.Point(324, 59);
            this.textBox6.Name = "textBox6";
            this.textBox6.Size = new System.Drawing.Size(159, 20);
            this.textBox6.TabIndex = 18;
            // 
            // textBox7
            // 
            this.textBox7.Location = new System.Drawing.Point(324, 84);
            this.textBox7.Name = "textBox7";
            this.textBox7.Size = new System.Drawing.Size(159, 20);
            this.textBox7.TabIndex = 19;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(283, 62);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(29, 13);
            this.label6.TabIndex = 20;
            this.label6.Text = "CPU";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(283, 87);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(31, 13);
            this.label7.TabIndex = 21;
            this.label7.Text = "RAM";
            // 
            // button6
            // 
            this.button6.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button6.Location = new System.Drawing.Point(286, 27);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(201, 23);
            this.button6.TabIndex = 22;
            this.button6.Text = "Generate CPU And RAM Data";
            this.button6.UseVisualStyleBackColor = true;
            this.button6.Click += new System.EventHandler(this.button6_Click);
            // 
            // textBox8
            // 
            this.textBox8.Location = new System.Drawing.Point(324, 107);
            this.textBox8.Name = "textBox8";
            this.textBox8.Size = new System.Drawing.Size(159, 20);
            this.textBox8.TabIndex = 23;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(283, 110);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(22, 13);
            this.label8.TabIndex = 24;
            this.label8.Text = "OP";
            // 
            // button4
            // 
            this.button4.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button4.Location = new System.Drawing.Point(324, 133);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(154, 23);
            this.button4.TabIndex = 25;
            this.button4.Text = "Get Console Process";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click_1);
            // 
            // button5
            // 
            this.button5.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button5.Location = new System.Drawing.Point(15, 189);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(250, 34);
            this.button5.TabIndex = 26;
            this.button5.Text = "Get Drive Plugged In";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.button5_Click_1);
            // 
            // textBox5
            // 
            this.textBox5.Location = new System.Drawing.Point(15, 230);
            this.textBox5.Name = "textBox5";
            this.textBox5.Size = new System.Drawing.Size(250, 20);
            this.textBox5.TabIndex = 27;
            // 
            // button7
            // 
            this.button7.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button7.Location = new System.Drawing.Point(15, 256);
            this.button7.Name = "button7";
            this.button7.Size = new System.Drawing.Size(250, 23);
            this.button7.TabIndex = 28;
            this.button7.Text = "Get Access To Specific CPU Of Processor";
            this.button7.UseVisualStyleBackColor = true;
            this.button7.Click += new System.EventHandler(this.button7_Click);
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Interval = 1;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // button8
            // 
            this.button8.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button8.Location = new System.Drawing.Point(283, 162);
            this.button8.Name = "button8";
            this.button8.Size = new System.Drawing.Size(195, 23);
            this.button8.TabIndex = 29;
            this.button8.Text = "Get System Processor Name";
            this.button8.UseVisualStyleBackColor = true;
            this.button8.Click += new System.EventHandler(this.button8_Click);
            // 
            // textBox9
            // 
            this.textBox9.Location = new System.Drawing.Point(15, 286);
            this.textBox9.Name = "textBox9";
            this.textBox9.Size = new System.Drawing.Size(250, 20);
            this.textBox9.TabIndex = 30;
            // 
            // textBox10
            // 
            this.textBox10.Location = new System.Drawing.Point(283, 189);
            this.textBox10.Name = "textBox10";
            this.textBox10.Size = new System.Drawing.Size(195, 20);
            this.textBox10.TabIndex = 31;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(283, 212);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(141, 13);
            this.label5.TabIndex = 32;
            this.label5.Text = "Retreived Usage Of Memory";
            // 
            // textBox11
            // 
            this.textBox11.Location = new System.Drawing.Point(286, 228);
            this.textBox11.Name = "textBox11";
            this.textBox11.Size = new System.Drawing.Size(168, 20);
            this.textBox11.TabIndex = 33;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(284, 256);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(186, 13);
            this.label9.TabIndex = 34;
            this.label9.Text = "Get Retreived Store From Isolated File";
            // 
            // textBox12
            // 
            this.textBox12.Location = new System.Drawing.Point(286, 273);
            this.textBox12.Name = "textBox12";
            this.textBox12.Size = new System.Drawing.Size(168, 20);
            this.textBox12.TabIndex = 35;
            // 
            // richTextBox1
            // 
            this.richTextBox1.Location = new System.Drawing.Point(15, 329);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.Size = new System.Drawing.Size(182, 122);
            this.richTextBox1.TabIndex = 37;
            this.richTextBox1.Text = "";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(15, 310);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(59, 13);
            this.label10.TabIndex = 38;
            this.label10.Text = "Drive Info :";
            // 
            // button10
            // 
            this.button10.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button10.Location = new System.Drawing.Point(286, 299);
            this.button10.Name = "button10";
            this.button10.Size = new System.Drawing.Size(168, 23);
            this.button10.TabIndex = 39;
            this.button10.Text = "Launch Debugger";
            this.button10.UseVisualStyleBackColor = true;
            this.button10.Click += new System.EventHandler(this.button10_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ClientSize = new System.Drawing.Size(510, 463);
            this.Controls.Add(this.button10);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.richTextBox1);
            this.Controls.Add(this.textBox12);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.textBox11);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.textBox10);
            this.Controls.Add(this.textBox9);
            this.Controls.Add(this.button8);
            this.Controls.Add(this.button7);
            this.Controls.Add(this.textBox5);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.textBox8);
            this.Controls.Add(this.button6);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.textBox7);
            this.Controls.Add(this.textBox6);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBox4);
            this.Controls.Add(this.textBox3);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "Form1";
            this.KeyUp += new System.Windows.Forms.KeyEventHandler(this.Form1_KeyUp);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem settingsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem variablesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem memoryFreeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem percentToolStripMenuItem;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.TextBox textBox4;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.TextBox textBox6;
        private System.Windows.Forms.TextBox textBox7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.TextBox textBox8;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.TextBox textBox5;
        private System.Windows.Forms.Button button7;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Button button8;
        private System.Windows.Forms.TextBox textBox9;
        private System.Windows.Forms.TextBox textBox10;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox textBox11;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox textBox12;
        private System.Windows.Forms.ToolStripMenuItem allowEuToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem assemblyToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem assemblyToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem machineToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem machineToolStripMenuItem1;
        private System.Windows.Forms.RichTextBox richTextBox1;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Button button10;
        private System.Windows.Forms.ToolStripMenuItem postDataAndGetResponseFromServerToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem serialSoftwareConnectionToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem hardwareOutputToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem sendDataToSerialPortToolStripMenuItem;
    }
}

