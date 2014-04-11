using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using StoryBuilder.Management;

namespace StoryBuilder
{
    public partial class Form1 : Form
    {
        MainProcess mainProcess = new MainProcess();

        public static Form1 _Form1;

        public Form1()
        {
            InitializeComponent();

            _Form1 = this;
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        /*****************************************************
         * Added code to programmatically change form values *
         *****************************************************/
        public string SetText
        {
            get { return textBox1.Text; }
            set { textBox1.Text = value; }
        }
    }
}
