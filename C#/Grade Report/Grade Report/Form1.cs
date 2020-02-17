using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Grade_Report
{
    public partial class Form1 : Form
    {
        //explained below
        //public String [] courses = {"Math", "English", "Gym", "History"};
        public Form1()
        {
            InitializeComponent();
            textBoxSName.Leave += textBoxSName_Leave;
            textBoxSNumber.Leave += texboxSNumber_Leave;
            textBoxCCode.Leave += textboxCCode_Leave;
            textBoxCGrade.Leave += textboxCGrade_Leave;
        }

        private void textBoxSName_Leave (object sender, EventArgs e)
        {
            labelSName.Text = textBoxSName.Text;
        }

        private void texboxSNumber_Leave (object sender, EventArgs e)
        {
            labelSNumber.Text = textBoxSNumber.Text;
        }

        private void textboxCCode_Leave(object sender, EventArgs e)
        {
            //I couldn't figure out what the bug was, so I used a different approach
            //if (Array.IndexOf(courses, textBoxCCode.Text) == -1)
            //    labelCName.Text = courses[Array.IndexOf(courses, textBoxCCode.Text)];
            //else
            //    labelCName.Text = "Please enter a valid course code";

            //code-to-class matching
            if (textBoxCCode.Text == "M")
                labelCName.Text = "Math";
            else if (textBoxCCode.Text == "E")
                labelCName.Text = "English";
            else if (textBoxCCode.Text == "G")
                labelCName.Text = "Gym";
            else if (textBoxCCode.Text == "H")
                labelCName.Text = "History";
            else
                labelCName.Text = "Please enter a valid course code.";
        }

        private void textboxCGrade_Leave(object sender, EventArgs e)
        {
            //testing to see what area the grade falls under
            if (Int64.Parse(textBoxCCode.Text) >= 90)
                labelCGrade.Text = "A";
            else if (Int64.Parse(textBoxCCode.Text) >= 80)
                labelCGrade.Text = "B";
            else if (Int64.Parse(textBoxCCode.Text) >= 70)
                labelCGrade.Text = "C";
            else if (Int64.Parse(textBoxCCode.Text) >=60)
                labelCGrade.Text = "D";
            else
                labelCGrade.Text = "F";

            //if I had more time I would've used Int32.TryParse() to catch any formatting exceptions
        }
    }

}
