namespace SMTV_SaveUtil_GUI
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.selectOutputeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.selectOutputToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.additionalOptionsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.setDLCStatusToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.stopPlayMusicToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(36, 63);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(384, 20);
            this.textBox1.TabIndex = 0;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(36, 139);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(384, 20);
            this.textBox2.TabIndex = 1;
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.selectOutputeToolStripMenuItem,
            this.selectOutputToolStripMenuItem,
            this.additionalOptionsToolStripMenuItem,
            this.stopPlayMusicToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(443, 24);
            this.menuStrip1.TabIndex = 2;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // selectOutputeToolStripMenuItem
            // 
            this.selectOutputeToolStripMenuItem.Name = "selectOutputeToolStripMenuItem";
            this.selectOutputeToolStripMenuItem.Size = new System.Drawing.Size(69, 20);
            this.selectOutputeToolStripMenuItem.Text = "Open File";
            this.selectOutputeToolStripMenuItem.Click += new System.EventHandler(this.openFileToolStripMenuItem_Click);
            // 
            // selectOutputToolStripMenuItem
            // 
            this.selectOutputToolStripMenuItem.Name = "selectOutputToolStripMenuItem";
            this.selectOutputToolStripMenuItem.Size = new System.Drawing.Size(91, 20);
            this.selectOutputToolStripMenuItem.Text = "Select Output";
            this.selectOutputToolStripMenuItem.Click += new System.EventHandler(this.selectOutputToolStripMenuItem_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(27, 229);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(152, 23);
            this.button1.TabIndex = 3;
            this.button1.Text = "Start Encoding/Decoding";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(244, 229);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(152, 23);
            this.button2.TabIndex = 4;
            this.button2.Text = "Manual Encoding";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(33, 36);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(55, 13);
            this.label1.TabIndex = 5;
            this.label1.Text = "Input path";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(33, 108);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(63, 13);
            this.label2.TabIndex = 6;
            this.label2.Text = "Output path";
            // 
            // additionalOptionsToolStripMenuItem
            // 
            this.additionalOptionsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.setDLCStatusToolStripMenuItem});
            this.additionalOptionsToolStripMenuItem.Name = "additionalOptionsToolStripMenuItem";
            this.additionalOptionsToolStripMenuItem.Size = new System.Drawing.Size(119, 20);
            this.additionalOptionsToolStripMenuItem.Text = "Additional Options";
            // 
            // setDLCStatusToolStripMenuItem
            // 
            this.setDLCStatusToolStripMenuItem.Name = "setDLCStatusToolStripMenuItem";
            this.setDLCStatusToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.setDLCStatusToolStripMenuItem.Text = "Set DLC status";
            this.setDLCStatusToolStripMenuItem.Click += new System.EventHandler(this.setDLCStatusToolStripMenuItem_Click);
            // 
            // stopPlayMusicToolStripMenuItem
            // 
            this.stopPlayMusicToolStripMenuItem.Name = "stopPlayMusicToolStripMenuItem";
            this.stopPlayMusicToolStripMenuItem.Size = new System.Drawing.Size(105, 20);
            this.stopPlayMusicToolStripMenuItem.Text = "Stop/Play Music";
            this.stopPlayMusicToolStripMenuItem.Click += new System.EventHandler(this.stopPlayMusicToolStripMenuItem_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(443, 292);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.menuStrip1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "SMTV SaveUtil";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem selectOutputeToolStripMenuItem;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.ToolStripMenuItem selectOutputToolStripMenuItem;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ToolStripMenuItem additionalOptionsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem setDLCStatusToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem stopPlayMusicToolStripMenuItem;
    }
}

