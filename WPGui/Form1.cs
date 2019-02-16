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

namespace WPGui
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btnStart_Click(object sender, EventArgs e)
        {
            ProcessStartInfo startInfo = new ProcessStartInfo() {
                FileName = "/bin/bash",
                Arguments = "sudo apt-get update",
                UseShellExecute = false,
                RedirectStandardOutput = true,
                CreateNoWindow = true
            };
            Process proc = new Process() { StartInfo = startInfo, };
            proc.Start();

            while (!proc.StandardOutput.EndOfStream)
            {
                string line = proc.StandardOutput.ReadLine();
                txtView.AppendText(System.Environment.NewLine + line);
            }
            /*string URL = txtURL.Text;
            txtRuby.Text = "Ruby";
            txtWP.Text = "WPScan";
            txtOther.Text = "Other";
            TabControl.SelectedIndex = 1;*/
        }
    }
}
