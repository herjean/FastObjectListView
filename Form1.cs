using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ListViewProject
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void uploadBtn_Click(object sender, EventArgs e)
        {
            DialogResult result = folderBrowserDialog1.ShowDialog();
            if(result == DialogResult.OK)
            {
                Stopwatch sw = new Stopwatch();
                sw.Start();
                this.fastObjectListView1.SetObjects(testClass.GET());
                string elapsedTime = sw.Elapsed.ToString();
                label1.Text = elapsedTime;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Stopwatch sw2 = new Stopwatch();
            sw2.Start();
            for (int i = 1; i < 10001; i++)
            {
                string item = "HELLO" + i.ToString();
                listView1.Items.Add(item);
            }
            string elapsedTime2 = sw2.Elapsed.ToString();
            label2.Text = elapsedTime2;
        }
    }
}
