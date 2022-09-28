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

namespace ProcessDemo
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                var my_notepad_process = new Process();
                my_notepad_process.StartInfo.FileName = @"notepad.exe";
                my_notepad_process.StartInfo.Arguments = @"c:\temp-process-demo.txt";
                my_notepad_process.Start();
            }
            catch(Exception ex)
            {
                System.Windows.Forms.MessageBox.Show("ERROR!", ex.Message, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }
    }
}
