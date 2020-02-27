using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Fast_Food_Ordering_Program_Attempt_2
{
    public partial class Form1 : Form
    {
        public string CName;
        public string CAddress;
        public string CPhone;
        //saved in case you want to know that I started with saving the selected restaurant but decided it was easier and simpler the other way
        //public string RName;
        //public string RAddress;
        //public string RPhone;
        public bool doDelivery;
        public double cost;
        public int numOrders;

        public Form1()
        {
            InitializeComponent();

            buttonNext1.Click += buttonNext1_Click;
            checkBoxPickup.CheckedChanged += checkBoxPickup_CheckedChanged;
            checkBoxDelivery.CheckedChanged += checkBoxDelivery_CheckedChanged;
            buttonClear.Click += buttonClear_Click;
            buttonCalc.Click += buttonCalc_Click;
            buttonExit.Click += buttonExit_Click;
        }

        //screen 1
            private void buttonNext1_Click(object sender, EventArgs e)
            {
                //setting up the variables for later use
                CName = textBoxCName.Text;
                CAddress = textBoxCAddress.Text;
                CPhone = textBoxCPhone.Text;
                labelRName.Text = listBox1.SelectedItem.ToString();
                labelRAddress.Text = "123 DnE st.";
                labelRPhone.Text = "555-123-4567";

            tabControl1.SelectedTab = tabPage2;
            }

            private void checkBoxPickup_CheckedChanged(object sender, EventArgs e)
            {
                //swap checked states and record checked state
                doDelivery = checkBoxDelivery.Checked;
                checkBoxDelivery.Checked = !checkBoxPickup.Checked;
            }

            private void checkBoxDelivery_CheckedChanged(object sender, EventArgs e)
            {
                //swap checked states and record checked state
                doDelivery = checkBoxDelivery.Checked;
                checkBoxPickup.Checked = !checkBoxDelivery.Checked;
            }

        //screen 2
        private void buttonClear_Click(object sender, EventArgs e)
        {
            //if I'd had more time I'd've figured out how to get the maximum index of the checkedListBoxes

            //for (int i; i < checkedListBoxMains.MaxIndex; i++)
            //    checkedListBoxMains.SetItemChecked(i, false);

            //for (int i; i < checkedListBoxSides.MaxIndex; i++)
            //    checkedListBoxSides.SetItemChecked(i, false);

            //for (int i; i < checkedListBoxDrinks.MaxIndex; i++)
            //    checkedListBoxDrinks.SetItemChecked(i, false);
        }

        private void buttonCalc_Click(object sender, EventArgs e)
        {
            //I'd add together the # orders * the individual order cost and the cost of delivery or lack thereof
        }

        private void buttonExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

    }
}
