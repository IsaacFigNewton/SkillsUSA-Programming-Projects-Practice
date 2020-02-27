using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Payroll_Program
{
    public partial class Form1 : Form
    {
        double[] payrates = {10.00, 12.50, 15.00, 17.50, 20.00};
        double payRate;
        int hoursWorked;
        double overtime;
        double subtotal;
        public Form1()
        {
            InitializeComponent();
            //initialize the control events
            buttonCalc.Click += buttonCalc_Click;
            buttonClear.Click += buttonClear_Click;
            buttonExit.Click += buttonExit_Click;
        }

        private void buttonCalc_Click(object sender, EventArgs e)
        {
            payRate = payrates[Convert.ToInt32(textBoxPay.Text) - 1];
            hoursWorked = Convert.ToInt32(textBoxWorked.Text);
            //the if statement to text to see if and by how much the person worked overtime
            if (hoursWorked > 40)
                overtime = payRate * ((hoursWorked) - 40);
            else
                overtime = 0.00;
            //I wasn't sure where the tax and insurance got calculated but I assume it's here
            subtotal = payRate * hoursWorked;

            //setting the labels to their respective values (The $ signs were a stylistic choice)
            labelTax.Text = "$" + (subtotal * 0.1).ToString();
            labelInsurance.Text = "$" + (subtotal * 0.05).ToString();
            //yes, I know that this bit would be redundant if I just put it in the if statement before instead of using the variable, but I feel it helps make the code more easily understood and readable
            labelOvertime.Text = "$" + overtime.ToString();
            labelTotal.Text = "$" + (subtotal * 0.85).ToString();

        }

        private void buttonClear_Click (object sender, EventArgs e)
        {
            //reset input/output boxes
            textBoxName.Text = "employee name";
            textBoxSSN.Text = "";
            textBoxPay.Text = "";
            textBoxWorked.Text = "";
            textBoxShift.Text = "";

            //reset labels
            labelTax.Text = "";
            labelInsurance.Text = "";
            labelOvertime.Text = "";
            labelTotal.Text = "";
        }

        private void buttonExit_Click (object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
