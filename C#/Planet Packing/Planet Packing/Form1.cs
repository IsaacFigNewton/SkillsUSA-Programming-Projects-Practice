using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Planet_Packing
{
    public partial class Form1 : Form
    {
        //Resource variables
        public int money = 500000;
        public double air = 0;
        public double water = 0;
        public double food = 0;
        public double energy = 0;
        public double space = 0;
        public double maintenance = 0;
        public double happiness = 0;
        public int index = -1;

        //Subscribe to other elements' stuff
        public Form1()
        {
            InitializeComponent();
            buttonStart.Click += buttonStart_Click;
            buttonGotoIntro.Click += buttonGotoIntro_Click;
            buttonMars.Click += buttonMars_Click;
            buttonTitan.Click += buttonTitan_Click;
            buttonEuropa.Click += buttonEuropa_Click;

            checkedListBoxBasics.CheckOnClick = true;
            checkedListBoxConstruction.CheckOnClick = true;
            checkedListBoxFarming.CheckOnClick = true;
            checkedListBoxMisc.CheckOnClick = true;
            checkedListBoxBasics.ItemCheck += checkedListBoxBasics_ItemCheck;
            buttonAddItem.Click += buttonAddItem_Click;

            //Initialize some basic elements
            labelFunds.Text = money.ToString();
            labelSpace.Text = space.ToString();
            labelAir.Text = air.ToString();
            labelWater.Text = water.ToString();
            labelFood.Text = food.ToString();
            labelEnergy.Text = energy.ToString();
            labelMaintenance.Text = maintenance.ToString();
            labelHappiness.Text = happiness.ToString();
        }

        

        //Element event handlers
        private void buttonStart_Click(object sender, EventArgs e)
        {
            tabControl.SelectedTab = DestSelect;
            money = 500000;
        }

        private void buttonGotoIntro_Click(object sender, EventArgs e)
        {
            tabControl.SelectedTab = Intro;
        }

        private void GotoIntro_Click(object sender, EventArgs e)
        {
            tabControl.SelectedTab = Intro;
        }

        //Destination event handlers
        private void buttonMars_Click(object sender, EventArgs e)
        {
            tabControl.SelectedTab = PurchaseSupplies;
            money -= 100000;
            labelFunds.Text = money.ToString();
            labelSpace.Text = space.ToString();
            labelAir.Text = air.ToString();
            labelWater.Text = water.ToString();
            labelFood.Text = food.ToString();
            labelEnergy.Text = energy.ToString();
            labelMaintenance.Text = maintenance.ToString();
            labelHappiness.Text = happiness.ToString();
        }

        private void buttonEuropa_Click(object sender, EventArgs e)
        {
            tabControl.SelectedTab = PurchaseSupplies;
            money -= 300000;
            labelFunds.Text = money.ToString();
            labelSpace.Text = space.ToString();
            labelAir.Text = air.ToString();
            labelWater.Text = water.ToString();
            labelFood.Text = food.ToString();
            labelEnergy.Text = energy.ToString();
            labelMaintenance.Text = maintenance.ToString();
            labelHappiness.Text = happiness.ToString();
        }

        private void buttonTitan_Click(object sender, EventArgs e)
        {
            tabControl.SelectedTab = PurchaseSupplies;
            money -= 400000;
            labelFunds.Text = money.ToString();
            labelSpace.Text = space.ToString();
            labelAir.Text = air.ToString();
            labelWater.Text = water.ToString();
            labelFood.Text = food.ToString();
            labelEnergy.Text = energy.ToString();
            labelMaintenance.Text = maintenance.ToString();
            labelHappiness.Text = happiness.ToString();
        }

        private void buttonAddItem_Click(object sender, EventArgs e)
        {
            //Add item text in textBoxSupply to listBoxOtherSupplies and call updateResourcesCheck on checked items in checkedListBoxProperties
        }

        private void checkedListBoxBasics_ItemCheck(object sender, EventArgs e)
        {
            // get the NewValue
            bool isChecked = (e.NewValue == CheckState.Checked);

            // if checked
            if (isChecked)
            {
                //get index of checked box and set variable index to that
                index = checkedListBoxBasics.SelectedIndex;

                if (index == 0)
                {
                    //EVA Suit
                    updateResourcesCheck("checkedListBoxBasics", 100000, 0, 0, 0, 0, 0, 0, 0);
                }
                else if (index == 1)
                {
                    //Airlock
                    updateResourcesCheck("checkedListBoxBasics", 5900, 4.25, 0.5, 0, 0, 0, 0, 0);
                }
                else if (index == 2)
                {
                    //1000kW/hr Atomic Battery and Transformer
                    updateResourcesCheck("checkedListBoxBasics", 1000, 0, 0, 0, 0, 1000, 0, 0);
                }
                else if (index == 3)
                {
                    //Solid Oxide Electrolysis Machine
                    updateResourcesCheck("checkedListBoxBasics", 1000, 0, 30000, 0, 0, -300, 0, 0);
                }
                else if (index == 4)
                {
                    //Maintenance Supplies
                    updateResourcesCheck("checkedListBoxBasics", 100, 0, 0, 0, 0, 0, 100, 0);
                }
                else if (index == 5)
                {
                    //1 Month of Food and Water
                    updateResourcesCheck("checkedListBoxBasics", 100, 0, 0, 30, 30, 0, 0, 0);
                }
                else if (index == 6)
                {
                    //Heating and Insulation
                    updateResourcesCheck("checkedListBoxBasics", 100, 0, 0, 0, 0, -15, 0, 0);
                }
                else if (index == 7)
                {
                    //Basic Excavation Tools
                    updateResourcesCheck("checkedListBoxBasics", 25, 100, -100, -10, 100, 0, 0, 0);
                }
                else if (index == 8)
                {
                    //Microwave
                    //Maybe add multipliers as a feature later on?
                    updateResourcesCheck("checkedListBoxBasics", 20, 0.5, 0, 0, 0, 0.1, 0, 0);
                }
                else if (index == 9)
                {
                    //Basic Farming
                    updateResourcesCheck("checkedListBoxBasics", 20, 50, -10000, 100, -50, 0, 0, 0);
                }
                else if (index == 10)
                {
                    //Phone Stuff
                    updateResourcesCheck("checkedListBoxBasics", 1, 0, 0, 0, 0, 0.1, 0, 1000);
                }
            }
            else
            {
                if (index == 0)
                {
                    //EVA Suit
                    updateResourcesUncheck("checkedListBoxBasics", 100000, 0, 0, 0, 0, 0, 0, 0);
                }
                else if (index == 1)
                {
                    //Airlock
                    updateResourcesUncheck("checkedListBoxBasics", 5900, 4.25, 0.5, 0, 0, 0, 0, 0);
                }
                else if (index == 2)
                {
                    //1000kW/hr Atomic Battery and Transformer
                    updateResourcesUncheck("checkedListBoxBasics", 1000, 0, 0, 0, 0, 1000, 0, 0);
                }
                else if (index == 3)
                {
                    //Solid Oxide Electrolysis Machine
                    updateResourcesUncheck("checkedListBoxBasics", 1000, 0, 30000, 0, 0, -300, 0, 0);
                }
                else if (index == 4)
                {
                    //Maintenance Supplies
                    updateResourcesUncheck("checkedListBoxBasics", 100, 0, 0, 0, 0, 0, 100, 0);
                }
                else if (index == 5)
                {
                    //1 Month of Food and Water
                    updateResourcesUncheck("checkedListBoxBasics", 100, 0, 0, 30, 30, 0, 0, 0);
                }
                else if (index == 6)
                {
                    //Heating and Insulation
                    updateResourcesUncheck("checkedListBoxBasics", 100, 0, 0, 0, 0, -15, 0, 0);
                }
                else if (index == 7)
                {
                    //Basic Excavation Tools
                    updateResourcesUncheck("checkedListBoxBasics", 25, 100, -100, -10, 100, 0, 0, 0);
                }
                else if (index == 8)
                {
                    //Microwave
                    //Maybe add multipliers as a feature later on?
                    updateResourcesUncheck("checkedListBoxBasics", 20, 0.5, 0, 0, 0, 0.1, 0, 0);
                }
                else if (index == 9)
                {
                    //Basic Farming
                    updateResourcesUncheck("checkedListBoxBasics", 20, 50, -10000, 100, -50, 0, 0, 0);
                }
                else if (index == 10)
                {
                    //Phone Stuff
                    updateResourcesUncheck("checkedListBoxBasics", 1, 0, 0, 0, 0, 0.1, 0, 1000);
                }
            }
        }   
        
        //Methods
        public void updateResourcesCheck(String checkedListName, int cost, double spaceRate, double airRate, double waterRate, double foodRate, double energyRate, double maintenanceRate, int happinessRate)
        {
            //Check to see if the player can afford it
            if ((money < cost) || (space + spaceRate < 0) || (air + airRate < 0) || (water + waterRate < 0) || (food + foodRate < 0) || (energy + energyRate < 0) || (maintenance + maintenanceRate < 0) || (happiness + happinessRate < 0))
            {
                if (checkedListName == "checkedListBoxBasics")
                {
                    checkedListBoxBasics.SetItemCheckState(index, CheckState.Unchecked);
                }
                else if (checkedListName == "checkedListBoxConstruction")
                {
                    checkedListBoxConstruction.SetItemCheckState(index, CheckState.Unchecked);
                }
                else if (checkedListName == "checkedListBoxFarming")
                {
                    checkedListBoxFarming.SetItemCheckState(index, CheckState.Unchecked);
                }
                else if (checkedListName == "checkedListBoxMisc")
                {
                    checkedListBoxMisc.SetItemCheckState(index, CheckState.Unchecked);
                }
            }
            else
            {
                //implement input variables with other external variables
                money -= cost;
                space += spaceRate;
                air += airRate;
                water += waterRate;
                food += foodRate;
                energy += energyRate;
                maintenance += maintenanceRate;
                happiness += happinessRate;

                labelFunds.Text = money.ToString();
                labelSpace.Text = space.ToString();
                labelAir.Text = air.ToString();
                labelWater.Text = water.ToString();
                labelFood.Text = food.ToString();
                labelEnergy.Text = energy.ToString();
                labelMaintenance.Text = maintenance.ToString();
                labelHappiness.Text = happiness.ToString();
            }
        }

        public void updateResourcesUncheck(String checkedListName, int cost, double spaceRate, double airRate, double waterRate, double foodRate, double energyRate, double maintenanceRate, double happinessRate)
        {
            //Check to see if the player can afford it
            if ((space - spaceRate > 0) || (air - airRate > 0) || (water - waterRate > 0) || (food - foodRate > 0) || (energy - energyRate > 0) || (maintenance - maintenanceRate > 0) || (happiness - happinessRate > 0))
            {
                if (checkedListName == "checkedListBoxBasics")
                {
                    checkedListBoxBasics.SetItemCheckState(index, CheckState.Checked);
                }
                else if (checkedListName == "checkedListBoxConstruction")
                {
                    checkedListBoxConstruction.SetItemCheckState(index, CheckState.Checked);
                }
                else if (checkedListName == "checkedListBoxFarming")
                {
                    checkedListBoxFarming.SetItemCheckState(index, CheckState.Checked);
                }
                else if (checkedListName == "checkedListBoxMisc")
                {
                    checkedListBoxMisc.SetItemCheckState(index, CheckState.Checked);
                }
            }
            else
            {
                //implement input variables with other external variables
                money += cost;
                space -= spaceRate;
                air -= airRate;
                water -= waterRate;
                food -= foodRate;
                energy -= energyRate;
                maintenance -= maintenanceRate;
                happiness -= happinessRate;

                labelFunds.Text = money.ToString();
                labelSpace.Text = space.ToString();
                labelAir.Text = air.ToString();
                labelWater.Text = water.ToString();
                labelFood.Text = food.ToString();
                labelEnergy.Text = energy.ToString();
                labelMaintenance.Text = maintenance.ToString();
                labelHappiness.Text = happiness.ToString();
            }
        }
    }
}
