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

namespace SMTV_SaveUtil_GUI
{
    public partial class Form1 : Form
    {
        public string file_dir;
        public Form1()
        {
            InitializeComponent();
        }

        private void openFileToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OpenFileDialog opf = new OpenFileDialog();

            

            if (opf.ShowDialog() == DialogResult.OK)
            {
                file_dir = opf.FileName.ToString();
                textBox1.Text = opf.FileName.ToString();
                button1.Enabled = true;
                button2.Enabled = true;
                selectOutputToolStripMenuItem.Enabled = true;
            }

           
        }

        private void button1_Click(object sender, EventArgs e)
        {

            //Process pro = new Process();
            //pro.StartInfo.FileName = "cmd.exe";
            //pro.StartInfo.CreateNoWindow = true;
            //pro.StartInfo.RedirectStandardInput = true;
            //pro.StartInfo.RedirectStandardOutput = true;
            //pro.StartInfo.UseShellExecute = false;
            //pro.Start();
            //pro.StandardInput.WriteLine("smtv.saveutil.exe -i " + textBox1.Text);
            //pro.StandardInput.Flush();
            //pro.StandardInput.Close();
            //pro.WaitForExit();
            //Console.WriteLine(pro.StandardOutput.ReadToEnd());


            try
            {
                string strCmdText;
                strCmdText = "/C " + Environment.CurrentDirectory + "\\req\\smtv.saveutil.exe -i " + textBox1.Text;
                string test = "/C smtv.saveutil.exe -i " + textBox1.Text;

                Process.Start("cmd.exe", test);

                MessageBox.Show("Task Finished. Please check output file", "Success");
            }
            catch
            {
                MessageBox.Show("Error. Check your Input Path value", "Error");
            }
           
            
        }

        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                string test = "/C smtv.saveutil.exe -i " + textBox1.Text + " -o " + textBox2.Text;

                Process.Start("cmd.exe", test);

                MessageBox.Show("Task Finished. Please check output file", "Success");
            }
            catch
            {
                MessageBox.Show("Error. Check your Input Path value", "Error");
            }
            
        }

        private void selectOutputToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SaveFileDialog sfd = new SaveFileDialog();

            if (sfd.ShowDialog() == DialogResult.OK)
            {
                textBox2.Text = sfd.FileName.ToString();
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            button1.Enabled = false;
            button2.Enabled = false;
            selectOutputToolStripMenuItem.Enabled = false;

        }
    }
}
