using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Computer_Programming_2012_Attempt
{
    public partial class Form1 : Form
    {
        //instantiate customer data for possible external use
        public string CName = "";
        public string CAddress = "";
        public string CPhone = "";
        //doPickup
        public bool doPickup = true;

        public Form1()
        {
            InitializeComponent();
            //navigation buttons
            buttonNext.Click += buttonNext_Click;
            buttonNext1.Click += buttonNext1_Click;
            buttonExit.Click += buttonExit_Click;
            //control buttons
            buttonClear.Click += buttonClear_Click;
            buttonCalculate.Click += buttonCalculate_Click;
            //customer data collection
            textBoxCName.Leave += textBoxCName_Leave;
            textBoxCAddress.Leave += textBoxCAddress_Leave;
            textBoxCPhone.Leave += textBoxCPhone_Leave;
            //doPickup
            checkBoxPickup.CheckedChanged += checkBoxPickup_CheckedChanged;
            checkBoxDelivery.CheckedChanged += checkBoxDelivery_CheckedChanged;
            //Location selection
            listBoxLocation.Leave += listBoxLocation_Leave;
        }

        private void tabPage1_Click(object sender, EventArgs e)
        {

        }

        private void screen2_Click(object sender, EventArgs e)
        {

        }



        private void buttonNext_Click(object sender, EventArgs e)
        {
            tabControl.SelectedTab = screen2;
        }

        private void buttonNext1_Click(object sender, EventArgs e)
        {
            tabControl.SelectedTab = screen3;
        }

        private void buttonExit_Click(object sender, EventArgs e)
        {
            //Form1.exit;
        }




        private void buttonClear_Click(object sender, EventArgs e)
        {
            //Clear selected foods
        }

        private void buttonCalculate_Click(object sender, EventArgs e)
        {
            //Calculate cost
        }


        
        private void textBoxCName_Leave(object sender, EventArgs e)
        {
            CName = textBoxCName.Text;
            labelCName.Text = CName;
        }

        private void textBoxCAddress_Leave(object sender, EventArgs e)
        {
            CAddress = textBoxCAddress.Text;
            labelCAddress.Text = CAddress;
        }

        private void textBoxCPhone_Leave(object sender, EventArgs e)
        {
            CPhone = textBoxCPhone.Text;
            labelCPhone.Text = CPhone;
        }



        private void checkBoxPickup_CheckedChanged(object sender, EventArgs e)
        {
            checkBoxDelivery.Checked = !checkBoxPickup.Checked;
            doPickup = checkBoxPickup.Checked;
            //labelWelcome.Text = doPickup.ToString();
        }

        private void checkBoxDelivery_CheckedChanged(object sender, EventArgs e)
        {
            checkBoxPickup.Checked = !checkBoxDelivery.Checked;
            doPickup = checkBoxPickup.Checked;
            //labelWelcome.Text = doPickup.ToString();
        }



        private void listBoxLocation_Leave(object sender, EventArgs e)
        {
            if (listBoxLocation.SelectedItem == "Kung Panda")
            {
                labelLName.Text = "Kung Panda";
                labelLAddress.Text = "123 abraham st.";
                labelLPhone.Text = "(805)-123-456";
            } else if (listBoxLocation.SelectedItem == "McNommie's")
            {
                labelLName.Text = "McNommie's";
                labelLAddress.Text = "456 bentley st.";
                labelLPhone.Text = "(805)-123-456";
            } else
            {
                labelLName.Text = "Renegade Tacos";
                labelLAddress.Text = "789 corporate st.";
                labelLPhone.Text = "(805)-123-456";
            }
        }
    }
}
