using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Diagnostics;




namespace WindowsFormsApp1
{
    public partial class GDiskPart_JSantos_v1 : Form
    {

        public GDiskPart_JSantos_v1()
        {
            InitializeComponent();
            this.Text = "GDiskPart_JSantos_v1.1";
            button2.Enabled = false;
            button3.Enabled = false;
            button4.Enabled = false;
            button5.Enabled = false;
            button6.Enabled = false;
            checkBox1.Enabled = false;
            checkBox2.Enabled = false;
            checkBox3.Enabled = false;
            checkBox4.Enabled = false;
            checkBox5.Enabled = false;

        }

        private void button1_Click(object sender, EventArgs e)
        {

            Process diskpart = new Process();
            diskpart.StartInfo.UseShellExecute = false;
            diskpart.StartInfo.CreateNoWindow = true;
            diskpart.StartInfo.RedirectStandardOutput = true;
            diskpart.StartInfo.FileName = @"C:\Windows\System32\diskpart.exe";   // executable to run
            diskpart.StartInfo.RedirectStandardInput = true;                     // Redirects the input commands
            diskpart.Start();                                                    // Starts the process
            diskpart.StandardInput.WriteLine("List Disk");
            diskpart.StandardInput.WriteLine("exit");

            string s = diskpart.StandardOutput.ReadToEnd();
            textBox1.Text = s;
            textBox1.SelectionStart = textBox1.Text.Length;
            textBox1.ScrollToCaret();

            if (textBox1.Text.Contains("Disco 1"))
            {
                button2.Enabled = true;
                checkBox1.Enabled = true;
            }
            else
            {
                button2.Enabled = false;
                checkBox1.Enabled = false;
            }

            if (textBox1.Text.Contains("Disco 2"))
            {
                button3.Enabled = true;
                checkBox2.Enabled = true;
            }
            else
            {
                button3.Enabled = false;
                checkBox2.Enabled = false;
            }
            if (textBox1.Text.Contains("Disco 3"))
            {
                button4.Enabled = true;
                checkBox3.Enabled = true;
            }
            else
            {
                button4.Enabled = false;
                checkBox3.Enabled = false;
            }
            if (textBox1.Text.Contains("Disco 4"))
            {
                button5.Enabled = true;
                checkBox4.Enabled = true;
            }
            else
            {
                button5.Enabled = false;
                checkBox4.Enabled = false;
            }
            if (textBox1.Text.Contains("Disco 5"))
            {
                button6.Enabled = true;
                checkBox5.Enabled = true;
            }
            else
            {
                button6.Enabled = false;
                checkBox5.Enabled = false;
            }
        }


        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (checkBox1.Checked == true)
            {
                Process jClean1 = new Process();
                jClean1.StartInfo.UseShellExecute = false;
                jClean1.StartInfo.CreateNoWindow = true;
                jClean1.StartInfo.RedirectStandardOutput = true;
                jClean1.StartInfo.FileName = @"C:\Windows\System32\diskpart.exe";   // executable to run
                jClean1.StartInfo.RedirectStandardInput = true;                     // Redirects the input commands
                jClean1.Start();                                                    // Starts the process
                jClean1.StandardInput.WriteLine("sel Disk 1");
                jClean1.StandardInput.WriteLine("clean");
                jClean1.StandardInput.WriteLine("exit");

                string s = jClean1.StandardOutput.ReadToEnd();
                textBox1.Text = s;
                textBox1.SelectionStart = textBox1.Text.Length;
                textBox1.ScrollToCaret();
            }
            else
            {
                Process Clean1 = new Process();
                Clean1.StartInfo.UseShellExecute = false;
                Clean1.StartInfo.CreateNoWindow = true;
                Clean1.StartInfo.RedirectStandardOutput = true;
                Clean1.StartInfo.FileName = @"C:\Windows\System32\diskpart.exe";   // executable to run
                Clean1.StartInfo.RedirectStandardInput = true;                     // Redirects the input commands
                Clean1.Start();                                                    // Starts the process
                Clean1.StandardInput.WriteLine("sel Disk 1");
                Clean1.StandardInput.WriteLine("clean");
                Clean1.StandardInput.WriteLine("Create partition primary");
                Clean1.StandardInput.WriteLine("format quick fs=NTFS");
                Clean1.StandardInput.WriteLine("assign");
                Clean1.StandardInput.WriteLine("exit");

                string s = Clean1.StandardOutput.ReadToEnd();
                textBox1.Text = s;
                textBox1.SelectionStart = textBox1.Text.Length;
                textBox1.ScrollToCaret();
            }

        }

        private void filesToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (checkBox2.Checked == true)
            {
                Process jClean2 = new Process();
                jClean2.StartInfo.UseShellExecute = false;
                jClean2.StartInfo.CreateNoWindow = true;
                jClean2.StartInfo.RedirectStandardOutput = true;
                jClean2.StartInfo.FileName = @"C:\Windows\System32\diskpart.exe";   // executable to run
                jClean2.StartInfo.RedirectStandardInput = true;                     // Redirects the input commands
                jClean2.Start();                                                    // Starts the process
                jClean2.StandardInput.WriteLine("sel Disk 2");
                jClean2.StandardInput.WriteLine("clean");
                jClean2.StandardInput.WriteLine("exit");

                string s = jClean2.StandardOutput.ReadToEnd();
                textBox1.Text = s;
                textBox1.SelectionStart = textBox1.Text.Length;
                textBox1.ScrollToCaret();
            }
            else
            {
                Process Clean2 = new Process();
                Clean2.StartInfo.UseShellExecute = false;
                Clean2.StartInfo.CreateNoWindow = true;
                Clean2.StartInfo.RedirectStandardOutput = true;
                Clean2.StartInfo.FileName = @"C:\Windows\System32\diskpart.exe";   // executable to run
                Clean2.StartInfo.RedirectStandardInput = true;                     // Redirects the input commands
                Clean2.Start();                                                    // Starts the process
                Clean2.StandardInput.WriteLine("sel Disk 2");
                Clean2.StandardInput.WriteLine("clean");
                Clean2.StandardInput.WriteLine("Create partition primary");
                Clean2.StandardInput.WriteLine("format quick fs=NTFS");
                Clean2.StandardInput.WriteLine("assign");
                Clean2.StandardInput.WriteLine("exit");

                string s = Clean2.StandardOutput.ReadToEnd();
                textBox1.Text = s;
                textBox1.SelectionStart = textBox1.Text.Length;
                textBox1.ScrollToCaret();
            }

        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (checkBox3.Checked == true)
            {
                Process jClean3 = new Process();
                jClean3.StartInfo.UseShellExecute = false;
                jClean3.StartInfo.CreateNoWindow = true;
                jClean3.StartInfo.RedirectStandardOutput = true;
                jClean3.StartInfo.FileName = @"C:\Windows\System32\diskpart.exe";   // executable to run
                jClean3.StartInfo.RedirectStandardInput = true;                     // Redirects the input commands
                jClean3.Start();                                                    // Starts the process
                jClean3.StandardInput.WriteLine("sel Disk 3");
                jClean3.StandardInput.WriteLine("clean");
                jClean3.StandardInput.WriteLine("exit");

                string s = jClean3.StandardOutput.ReadToEnd();
                textBox1.Text = s;
                textBox1.SelectionStart = textBox1.Text.Length;
                textBox1.ScrollToCaret();
            }
            else
            {
                Process Clean3 = new Process();
                Clean3.StartInfo.UseShellExecute = false;
                Clean3.StartInfo.CreateNoWindow = true;
                Clean3.StartInfo.RedirectStandardOutput = true;
                Clean3.StartInfo.FileName = @"C:\Windows\System32\diskpart.exe";   // executable to run
                Clean3.StartInfo.RedirectStandardInput = true;                     // Redirects the input commands
                Clean3.Start();                                                    // Starts the process
                Clean3.StandardInput.WriteLine("sel Disk 3");
                Clean3.StandardInput.WriteLine("clean");
                Clean3.StandardInput.WriteLine("Create partition primary");
                Clean3.StandardInput.WriteLine("format quick fs=NTFS");
                Clean3.StandardInput.WriteLine("assign");
                Clean3.StandardInput.WriteLine("exit");

                string s = Clean3.StandardOutput.ReadToEnd();
                textBox1.Text = s;
                textBox1.SelectionStart = textBox1.Text.Length;
                textBox1.ScrollToCaret();
            }

        }

        private void button5_Click(object sender, EventArgs e)
        {
            if (checkBox4.Checked == true)
            {
                Process jClean4 = new Process();
                jClean4.StartInfo.UseShellExecute = false;
                jClean4.StartInfo.CreateNoWindow = true;
                jClean4.StartInfo.RedirectStandardOutput = true;
                jClean4.StartInfo.FileName = @"C:\Windows\System32\diskpart.exe";   // executable to run
                jClean4.StartInfo.RedirectStandardInput = true;                     // Redirects the input commands
                jClean4.Start();                                                    // Starts the process
                jClean4.StandardInput.WriteLine("sel Disk 4");
                jClean4.StandardInput.WriteLine("clean");
                jClean4.StandardInput.WriteLine("exit");

                string s = jClean4.StandardOutput.ReadToEnd();
                textBox1.Text = s;
                textBox1.SelectionStart = textBox1.Text.Length;
                textBox1.ScrollToCaret();
            }

            else
            {
                Process Clean4 = new Process();
                Clean4.StartInfo.UseShellExecute = false;
                Clean4.StartInfo.CreateNoWindow = true;
                Clean4.StartInfo.RedirectStandardOutput = true;
                Clean4.StartInfo.FileName = @"C:\Windows\System32\diskpart.exe";   // executable to run
                Clean4.StartInfo.RedirectStandardInput = true;                     // Redirects the input commands
                Clean4.Start();                                                    // Starts the process
                Clean4.StandardInput.WriteLine("sel Disk 4");
                Clean4.StandardInput.WriteLine("clean");
                Clean4.StandardInput.WriteLine("Create partition primary");
                Clean4.StandardInput.WriteLine("format quick fs=NTFS");
                Clean4.StandardInput.WriteLine("assign");
                Clean4.StandardInput.WriteLine("exit");

                string s = Clean4.StandardOutput.ReadToEnd();
                textBox1.Text = s;
                textBox1.SelectionStart = textBox1.Text.Length;
                textBox1.ScrollToCaret();
            }


        }
        

        private void button6_Click(object sender, EventArgs e)
        {
            if (checkBox5.Checked == true)
            {
                Process jClean5 = new Process();
                jClean5.StartInfo.UseShellExecute = false;
                jClean5.StartInfo.CreateNoWindow = true;
                jClean5.StartInfo.RedirectStandardOutput = true;
                jClean5.StartInfo.FileName = @"C:\Windows\System32\diskpart.exe";   // executable to run
                jClean5.StartInfo.RedirectStandardInput = true;                     // Redirects the input commands
                jClean5.Start();                                                    // Starts the process
                jClean5.StandardInput.WriteLine("sel Disk 5");
                jClean5.StandardInput.WriteLine("clean");
                jClean5.StandardInput.WriteLine("exit");

                string s = jClean5.StandardOutput.ReadToEnd();
                textBox1.Text = s;
                textBox1.SelectionStart = textBox1.Text.Length;
                textBox1.ScrollToCaret();
            }

            else
            {
                Process Clean5 = new Process();
                Clean5.StartInfo.UseShellExecute = false;
                Clean5.StartInfo.CreateNoWindow = true;
                Clean5.StartInfo.RedirectStandardOutput = true;
                Clean5.StartInfo.FileName = @"C:\Windows\System32\diskpart.exe";   // executable to run
                Clean5.StartInfo.RedirectStandardInput = true;                     // Redirects the input commands
                Clean5.Start();                                                    // Starts the process
                Clean5.StandardInput.WriteLine("sel Disk 5");
                Clean5.StandardInput.WriteLine("clean");
                Clean5.StandardInput.WriteLine("Create partition primary");
                Clean5.StandardInput.WriteLine("format quick fs=NTFS");
                Clean5.StandardInput.WriteLine("assign");
                Clean5.StandardInput.WriteLine("exit");

                string s = Clean5.StandardOutput.ReadToEnd();
                textBox1.Text = s;
                textBox1.SelectionStart = textBox1.Text.Length;
                textBox1.ScrollToCaret();
            }
        }

        private void checkBox5_CheckedChanged(object sender, EventArgs e)
        {

        }
        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void checkBox2_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }
    }

}
        