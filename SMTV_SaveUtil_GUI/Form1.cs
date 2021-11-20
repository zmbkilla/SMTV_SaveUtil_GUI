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
using System.IO;
using System.Media;

namespace SMTV_SaveUtil_GUI
{
    public partial class Form1 : Form
    {
        public string file_dir;
        public string exe_dir;
        public bool dlcoff, dlcon;
        public bool musicp = true;
        public Stream strm = Properties.Resources._28_Evolution_Majin_Tensei_II_Spiral_Nemesis;
        public SoundPlayer sp;
        public OpenFileDialog opdexe = new OpenFileDialog();
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
                textBox1.Text = opf.FileName;
                button1.Enabled = true;
                button2.Enabled = true;
                selectOutputToolStripMenuItem.Enabled = true;
                additionalOptionsToolStripMenuItem.Enabled = true;
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
                string @addr = "/C smtv.saveutil.exe -i " + @""""+textBox1.Text+"\"";
                string strCmdText;
                strCmdText = "/C " + "@"+ Environment.CurrentDirectory + "\\req\\smtv.saveutil.exe -i " + textBox1.Text;


                if (exe_dir.Contains(opdexe.SafeFileName))
                {
                    

                    exe_dir = exe_dir.Replace(opdexe.SafeFileName.ToString(), "" );
                }


                string test = "/C " + @"""" +@"""" + opdexe.FileName.ToString() + @"""" + " -i " + @""""+textBox1.Text+"\"";


                if(dlcoff == true)
                {
                    decimal DLCS = 0;
                    byte[] bDLCS = BitConverter.GetBytes(Convert.ToInt32(DLCS));

                    string @adr = textBox1.Text;

                    BinaryWriter BWriter = new BinaryWriter(File.OpenWrite(adr));

                    BWriter.BaseStream.Position = 0x45d;
                    BWriter.Write(bDLCS);

                    BWriter.Close();
                    dlcoff = false;
                }

                if (dlcon == true)
                {
                    decimal DLCS = 255;
                    byte[] bDLCS = BitConverter.GetBytes(Convert.ToInt32(DLCS));

                    string @adr = textBox1.Text;
                    BinaryWriter BWriter = new BinaryWriter(File.OpenWrite(adr));

                    BWriter.BaseStream.Position = 0x45d;
                    BWriter.Write(bDLCS);

                    BWriter.Close();
                    dlcon = false;
                }

                Process.Start("cmd.exe", @test);

                MessageBox.Show("Task Finished. Please check output file", "Success");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error. Check your Input Path value", "Error");
            }
           
            
        }

        private void button2_Click(object sender, EventArgs e)
        {





            try
            {
                string test = @"/C "+ @""""+@""""+exe_dir+@""""+" -i " + @""""+textBox1.Text+"\"" + " -o " + @""""+textBox2.Text+"\"";


                if (dlcoff == true)
                {
                    decimal DLCS = 0;
                    byte[] bDLCS = BitConverter.GetBytes(Convert.ToInt32(DLCS));

                    string @adr = textBox1.Text;

                    BinaryWriter BWriter = new BinaryWriter(File.OpenWrite(adr));

                    BWriter.BaseStream.Position = 0x45d;
                    BWriter.Write(bDLCS);

                    BWriter.Close();
                    dlcoff = false;
                }

                if (dlcon == true)
                {
                    decimal DLCS = 255;
                    byte[] bDLCS = BitConverter.GetBytes(Convert.ToInt32(DLCS));

                    string @adr = textBox1.Text;
                    BinaryWriter BWriter = new BinaryWriter(File.OpenWrite(adr));

                    BWriter.BaseStream.Position = 0x45d;
                    BWriter.Write(bDLCS);

                    BWriter.Close();
                    dlcon = false;
                }


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
            sp = new SoundPlayer(strm);
            
            sp.PlayLooping();


            button1.Enabled = false;
            button2.Enabled = false;
            selectOutputToolStripMenuItem.Enabled = false;
            additionalOptionsToolStripMenuItem.Enabled = false;
            selectOutputeToolStripMenuItem.Enabled = false;

        }

        private void stopPlayMusicToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (musicp == true)
            {
                sp.Stop();
                musicp = false;
            } else if (musicp == false){
                sp.PlayLooping();
                musicp = true;
            }
        }

        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void selectSaveUtilEXEToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
            if (opdexe.ShowDialog() == DialogResult.OK)
            {
                exe_dir = opdexe.FileName;
                selectOutputeToolStripMenuItem.Enabled = true;
            }
        }

        private void setDLCStatusToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Do you want to set DLC status. YES = off, No = on (Input file must be Decrypted save)", "Confirmation", MessageBoxButtons.YesNoCancel);
            if (result == DialogResult.Yes)
            {
                dlcoff = true;
                
            }
            else if (result == DialogResult.No)
            {
                dlcon = true;
            }
            else
            {
                //...
            }
        }
    }
}
