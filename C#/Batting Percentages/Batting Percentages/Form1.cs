using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Batting_Percentages
{
    public partial class Form1 : Form
    {
        public string[] names = { };
        //I couldn't figure out how to find the length of the array, so I decided to just add 1 to a counter whenever a name is added, see the buttonCalc_Click event below
        public int lengthOfNames = 0;
        public double[] averages = { };
        //same method for this array of the average of each player
        public int lengthOfAverages = 0;
        public Form1()
        {
            InitializeComponent();
            buttonCalc.Click += buttonCalc_Click;
            buttonClear.Click += buttonClear_Click;
            buttonNext.Click += buttonNext_Click;
            buttonExit.Click += buttonExit_Click;
        }

        private void buttonCalc_Click(object sender, EventArgs e)
        {
            double average;
            double sp;
            lengthOfNames++;
            names[lengthOfNames - 1] = textBoxPName.Text;
            //if I had more time I'd figure out why I kept getting an out-of-bounds error every time the next line of code ran
            lengthOfAverages++;
            //adding the calculated average for the player to the parallel list "averages"
            average = (Int32.Parse(textBoxSingles.Text) + Int32.Parse(textBoxDoubles.Text) + Int32.Parse(textBoxTriples.Text) + Int32.Parse(textBoxHomes.Text)) / Int32.Parse(textBoxTBatting.Text);
            averages[lengthOfAverages - 1] = average;

            sp = (Int32.Parse(textBoxSingles.Text) + 2 * Int32.Parse(textBoxDoubles.Text) + 3 * Int32.Parse(textBoxTriples.Text) + 4 * Int32.Parse(textBoxHomes.Text)) / Int32.Parse(textBoxTBatting.Text);

            //changing the labels
            labelBAve.Text = average.ToString();

        }

        private void buttonClear_Click(object sender, EventArgs e)
        {
            //emptying all the textboxes
            textBoxPName.Text = "";
            textBoxTCode.Text = "";
            textBoxTBatting.Text = "";
            textBoxSingles.Text = "";
            textBoxDoubles.Text = "";
            textBoxTriples.Text = "";
            textBoxHomes.Text = "";
        }

        private void buttonNext_Click (object sender, EventArgs e)
        {
            //getting the index of the highest average
            int index = Array.IndexOf(averages, averages.Max());
            //changing the "screen"
            tabControl1.SelectedTab = tabPage2;

            //showing the best player's name and average
            //since both name and average arrays are parallel, I can just use the same index to get the data I need from both arrays.
            labelBPName.Text = names[index].ToString();
            labelBPAve.Text = averages[index].ToString();
        }

        private void buttonExit_Click (object sender, EventArgs e)
        {
            //If I had more time I'd find a way to close the program for this event
        }
    }
}
