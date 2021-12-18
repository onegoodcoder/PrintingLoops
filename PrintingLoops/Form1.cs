using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PrintingLoops
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            richTextBox1.Text = "";//clears the rich text box
            //print 1, 2, 3, 4, 5
            //values begin at 1, values increase by 1, last value is 5
            //int is the data type like -10,0,50, not 1.353
            int i = 1;//list begins at 1, so type int i=1
            //i will assukme the values: 1 2 3 4 5
            //i<=5 because a loop runs, i=1, i=2, i=3, i=4, i=5
            //when i = 6, 6<=5, so the loop is skipped
            while (i <= 5)
            {
                richTextBox1.Text += $"i={i}\n";
                i++;//this is needed to grlow the value of i on each cycle of the loop

            }
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            richTextBox1.Text = "";//clears the rich text box
            //list values 5  4 3 2 1
            //lst stats at 5, goes down by 1, endfs on 1
            int i = 5;//because the list stats at 5, set the value of i to 5
            //list i=5 i=4 i=3 i=2 i=1, each of the previos makes the loop run
            //i=0, 0>=1 fails, so loop code do9es not run again
            while(i>=1)
            {
                richTextBox1.Text += $"i={i}\n";
                i--;//this has the effect of decreasing the value of i on each cycle of the loop
            }
        }
    }
}
