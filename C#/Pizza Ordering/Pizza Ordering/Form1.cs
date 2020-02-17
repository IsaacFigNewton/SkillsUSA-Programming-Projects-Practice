using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Pizza_Ordering
{
    public partial class Form1 : Form
    {
        public double cost = 0.0;
        public Form1()
        {
            InitializeComponent();
            textBoxCName.Leave += textBoxCName_Leave;
            checkBox1.Click += checkBox1_Click;
            checkBox2.Click += checkBox2_Click;

            //control buttons
            buttonCalc.Click += buttonCalc_Click;
            buttonClear.Click += buttonClear_Click;
            buttonNext.Click += buttonNext_Click;
            buttonExit.Click += buttonExit_Click;

            //option selection event stuff for pizza 1
            //size
            checkBoxL.Click += checkBoxL_Click;
            checkBoxM.Click += checkBoxM_Click;
            checkBoxS.Click += checkBoxS_Click;
            //# toppings
            numericUpDown1.Leave += numericUpDown_Leave;
            //shape
            checkBoxRound.Click += checkBoxRound_Click;
            checkBoxSquare.Click += checkBoxSquare_Click;
            //crust
            checkBoxThicc.Click += checkBoxThicc_Click;
            checkBoxThin.Click += checkBoxThin_Click;

            //option selection event stuff for pizza 2
            //size
            checkBoxL2.Click += checkBoxL2_Click;
            checkBoxM2.Click += checkBoxM2_Click;
            checkBoxS2.Click += checkBoxS2_Click;
            //# toppings
            numericUpDown2.Leave += numericUpDown2_Leave;
            //shape
            checkBoxRound2.Click += checkBoxRound2_Click;
            checkBoxSquare2.Click += checkBoxSquare2_Click;
            //crust
            checkBox2Thicc.Click += checkBox2Thicc_Click;
            checkBoxThin2.Click += checkBoxThin2_Click;
        }

        private void textBoxCName_Leave (object sender, EventArgs e)
        {
            labelCName.Text = textBoxCName.Text;
        }
        private void checkBox1_Click(object sender, EventArgs e)
        {
            //there can only be 1
            checkBox2.Checked = !checkBox1.Checked;

            //hide all stuff for the second pizza shown on the next "screen"
            label15.Visible = false;
            label16.Visible = false;
            label17.Visible = false;
            label18.Visible = false;
            labelP2Cost.Visible = false;
            labelP2TCost.Visible = false;
            labelP2S.Visible = false;
            labelP2C.Visible = false;
        }
        private void checkBox2_Click(object sender, EventArgs e)
        {
            //there can only be 1
            checkBox1.Checked = !checkBox2.Checked;

            //show all stuff for the second pizza shown on the next "screen"
            label15.Visible = true;
            label16.Visible = true;
            label17.Visible = true;
            label18.Visible = true;
            labelP2Cost.Visible = true;
            labelP2TCost.Visible = true;
            labelP2S.Visible = true;
            labelP2C.Visible = true;
        }

        //control buttons
        private void buttonCalc_Click(object sender, EventArgs e)
        {

        }
        private void buttonClear_Click(object sender, EventArgs e)
        {
            //if I'd had more time, I'd make it so you could clear all the checkboxes
        }
        private void buttonNext_Click(object sender, EventArgs e)
        {

        }
        private void buttonExit_Click(object sender, EventArgs e)
        {

        }



        //option selection event stuff for pizza 1
        //size
        private void checkBoxL_Click(object sender, EventArgs e)
        {
            //there can only be 1
            checkBoxM.Checked = !checkBoxL.Checked;
            checkBoxS.Checked = !checkBoxL.Checked;
        }
        private void checkBoxM_Click(object sender, EventArgs e)
        {
            //there can only be 1
            checkBoxL.Checked = !checkBoxM.Checked;
            checkBoxS.Checked = !checkBoxM.Checked;
        }
        private void checkBoxS_Click(object sender, EventArgs e)
        {
            //there can only be 1
            checkBoxL.Checked = !checkBoxS.Checked;
            checkBoxM.Checked = !checkBoxS.Checked;
        }
        //# toppings
        private void numericUpDown_Leave(object sender, EventArgs e)
        {
            labelP1TCost.Text = ((numericUpDown1.Value).ToInt() * 1.25).ToString();
            //if I had more time I'd've figured out how to fix the type conversion error here
        }
        //shape
        private void checkBoxRound_Click(object sender, EventArgs e)
        {

        }
        private void checkBoxSquare_Click(object sender, EventArgs e)
        {

        }
        //crust
        private void checkBoxThicc_Click(object sender, EventArgs e)
        {

        }
        private void checkBoxThin_Click(object sender, EventArgs e)
        {

        }
        //if I'd had more time I'd've finished writing code for these other events and copied it for the second pizza
    }
}
