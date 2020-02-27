using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Currency_Conversion_Program
{
    public partial class Form1 : Form
    {
        public double USD;
        public Form1()
        {
            InitializeComponent();
            buttonCalc.Click += buttonCalc_Click;
            buttonClear.Click += buttonClear_Click;
            buttonExit.Click += buttonExit_Click;

        }

        private void buttonCalc_Click(object sender, EventArgs e)
        {

            //setting the USD variable to the inputted number of US dollars 
            USD = Convert.ToDouble(textBoxUSD.Text);

            //Setting all the labels to their respective values
            labelPounds.Text = (USD * 0.64).ToString();
            labelFrancs.Text = (USD * 6.70426).ToString();
            labelLires.Text = (USD * 1793.62).ToString();
            labelGDM.Text = (USD * 1.811).ToString();
            labelPesetas.Text = (USD * 154.076).ToString();
        }

        private void buttonClear_Click(object sender, EventArgs e)
        {
            textBoxUSD.Text = "";
            labelPounds.Text = "";
            labelFrancs.Text = "";
            labelLires.Text = "";
            labelGDM.Text = "";
            labelPesetas.Text = "";
        }

        private void buttonExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
