namespace Planet_Packing
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.tabControl = new System.Windows.Forms.TabControl();
            this.Intro = new System.Windows.Forms.TabPage();
            this.label1 = new System.Windows.Forms.Label();
            this.buttonStart = new System.Windows.Forms.Button();
            this.DestSelect = new System.Windows.Forms.TabPage();
            this.buttonTitan = new System.Windows.Forms.Button();
            this.buttonEuropa = new System.Windows.Forms.Button();
            this.buttonMars = new System.Windows.Forms.Button();
            this.DestinationTitle = new System.Windows.Forms.Label();
            this.buttonGotoIntro = new System.Windows.Forms.Button();
            this.PurchaseSupplies = new System.Windows.Forms.TabPage();
            this.labelFood = new System.Windows.Forms.Label();
            this.labelWater = new System.Windows.Forms.Label();
            this.labelAir = new System.Windows.Forms.Label();
            this.labelHappiness = new System.Windows.Forms.Label();
            this.labelMaintenance = new System.Windows.Forms.Label();
            this.labelEnergy = new System.Windows.Forms.Label();
            this.labelSpace = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.buttonAddItem = new System.Windows.Forms.Button();
            this.GotoIntro = new System.Windows.Forms.Button();
            this.checkedListBoxProperties = new System.Windows.Forms.CheckedListBox();
            this.label8 = new System.Windows.Forms.Label();
            this.textBoxSupply = new System.Windows.Forms.TextBox();
            this.checkedListBoxMisc = new System.Windows.Forms.CheckedListBox();
            this.label7 = new System.Windows.Forms.Label();
            this.checkedListBoxFarming = new System.Windows.Forms.CheckedListBox();
            this.label6 = new System.Windows.Forms.Label();
            this.checkedListBoxConstruction = new System.Windows.Forms.CheckedListBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.labelFunds = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.checkedListBoxBasics = new System.Windows.Forms.CheckedListBox();
            this.listBoxOtherSupplies = new System.Windows.Forms.ListBox();
            this.tabControl.SuspendLayout();
            this.Intro.SuspendLayout();
            this.DestSelect.SuspendLayout();
            this.PurchaseSupplies.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl
            // 
            this.tabControl.Controls.Add(this.Intro);
            this.tabControl.Controls.Add(this.DestSelect);
            this.tabControl.Controls.Add(this.PurchaseSupplies);
            this.tabControl.Location = new System.Drawing.Point(-15, -37);
            this.tabControl.Name = "tabControl";
            this.tabControl.SelectedIndex = 0;
            this.tabControl.Size = new System.Drawing.Size(1013, 806);
            this.tabControl.TabIndex = 0;
            // 
            // Intro
            // 
            this.Intro.Controls.Add(this.label1);
            this.Intro.Controls.Add(this.buttonStart);
            this.Intro.ImeMode = System.Windows.Forms.ImeMode.Off;
            this.Intro.Location = new System.Drawing.Point(4, 22);
            this.Intro.Name = "Intro";
            this.Intro.Padding = new System.Windows.Forms.Padding(3);
            this.Intro.Size = new System.Drawing.Size(1005, 780);
            this.Intro.TabIndex = 0;
            this.Intro.Text = "tabPage1";
            this.Intro.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Rockwell", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(23, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(960, 643);
            this.label1.TabIndex = 2;
            this.label1.Text = resources.GetString("label1.Text");
            // 
            // buttonStart
            // 
            this.buttonStart.Font = new System.Drawing.Font("Rockwell", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonStart.Location = new System.Drawing.Point(420, 703);
            this.buttonStart.Name = "buttonStart";
            this.buttonStart.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.buttonStart.Size = new System.Drawing.Size(191, 54);
            this.buttonStart.TabIndex = 1;
            this.buttonStart.Text = "Start";
            this.buttonStart.UseVisualStyleBackColor = true;
            // 
            // DestSelect
            // 
            this.DestSelect.Controls.Add(this.buttonTitan);
            this.DestSelect.Controls.Add(this.buttonEuropa);
            this.DestSelect.Controls.Add(this.buttonMars);
            this.DestSelect.Controls.Add(this.DestinationTitle);
            this.DestSelect.Controls.Add(this.buttonGotoIntro);
            this.DestSelect.Location = new System.Drawing.Point(4, 22);
            this.DestSelect.Name = "DestSelect";
            this.DestSelect.Padding = new System.Windows.Forms.Padding(3);
            this.DestSelect.Size = new System.Drawing.Size(1005, 780);
            this.DestSelect.TabIndex = 1;
            this.DestSelect.Text = "tabPage2";
            this.DestSelect.UseVisualStyleBackColor = true;
            // 
            // buttonTitan
            // 
            this.buttonTitan.Font = new System.Drawing.Font("Magneto", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonTitan.Location = new System.Drawing.Point(356, 408);
            this.buttonTitan.Name = "buttonTitan";
            this.buttonTitan.Size = new System.Drawing.Size(325, 125);
            this.buttonTitan.TabIndex = 8;
            this.buttonTitan.Text = "Titan\r\nCost: $400,000";
            this.buttonTitan.UseVisualStyleBackColor = true;
            // 
            // buttonEuropa
            // 
            this.buttonEuropa.Font = new System.Drawing.Font("Script MT Bold", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonEuropa.Location = new System.Drawing.Point(369, 251);
            this.buttonEuropa.Name = "buttonEuropa";
            this.buttonEuropa.Size = new System.Drawing.Size(300, 125);
            this.buttonEuropa.TabIndex = 6;
            this.buttonEuropa.Text = "Europa\r\nCost: $300,000";
            this.buttonEuropa.UseVisualStyleBackColor = true;
            // 
            // buttonMars
            // 
            this.buttonMars.Font = new System.Drawing.Font("Papyrus", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonMars.Location = new System.Drawing.Point(369, 102);
            this.buttonMars.Name = "buttonMars";
            this.buttonMars.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.buttonMars.Size = new System.Drawing.Size(300, 125);
            this.buttonMars.TabIndex = 5;
            this.buttonMars.Text = "Mars\r\nCost: $200,000";
            this.buttonMars.UseVisualStyleBackColor = true;
            this.buttonMars.Click += new System.EventHandler(this.buttonMars_Click);
            // 
            // DestinationTitle
            // 
            this.DestinationTitle.AutoSize = true;
            this.DestinationTitle.Font = new System.Drawing.Font("Rockwell", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DestinationTitle.Location = new System.Drawing.Point(233, 24);
            this.DestinationTitle.Name = "DestinationTitle";
            this.DestinationTitle.Size = new System.Drawing.Size(573, 54);
            this.DestinationTitle.TabIndex = 4;
            this.DestinationTitle.Text = "Choose Your Destination";
            // 
            // buttonGotoIntro
            // 
            this.buttonGotoIntro.Font = new System.Drawing.Font("Rockwell", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonGotoIntro.Location = new System.Drawing.Point(426, 690);
            this.buttonGotoIntro.Name = "buttonGotoIntro";
            this.buttonGotoIntro.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.buttonGotoIntro.Size = new System.Drawing.Size(191, 54);
            this.buttonGotoIntro.TabIndex = 3;
            this.buttonGotoIntro.Text = "Back to Introduction";
            this.buttonGotoIntro.UseVisualStyleBackColor = true;
            this.buttonGotoIntro.Click += new System.EventHandler(this.GotoIntro_Click);
            // 
            // PurchaseSupplies
            // 
            this.PurchaseSupplies.Controls.Add(this.listBoxOtherSupplies);
            this.PurchaseSupplies.Controls.Add(this.labelFood);
            this.PurchaseSupplies.Controls.Add(this.labelWater);
            this.PurchaseSupplies.Controls.Add(this.labelAir);
            this.PurchaseSupplies.Controls.Add(this.labelHappiness);
            this.PurchaseSupplies.Controls.Add(this.labelMaintenance);
            this.PurchaseSupplies.Controls.Add(this.labelEnergy);
            this.PurchaseSupplies.Controls.Add(this.labelSpace);
            this.PurchaseSupplies.Controls.Add(this.label15);
            this.PurchaseSupplies.Controls.Add(this.label14);
            this.PurchaseSupplies.Controls.Add(this.label13);
            this.PurchaseSupplies.Controls.Add(this.label12);
            this.PurchaseSupplies.Controls.Add(this.label11);
            this.PurchaseSupplies.Controls.Add(this.label10);
            this.PurchaseSupplies.Controls.Add(this.label9);
            this.PurchaseSupplies.Controls.Add(this.buttonAddItem);
            this.PurchaseSupplies.Controls.Add(this.GotoIntro);
            this.PurchaseSupplies.Controls.Add(this.checkedListBoxProperties);
            this.PurchaseSupplies.Controls.Add(this.label8);
            this.PurchaseSupplies.Controls.Add(this.textBoxSupply);
            this.PurchaseSupplies.Controls.Add(this.checkedListBoxMisc);
            this.PurchaseSupplies.Controls.Add(this.label7);
            this.PurchaseSupplies.Controls.Add(this.checkedListBoxFarming);
            this.PurchaseSupplies.Controls.Add(this.label6);
            this.PurchaseSupplies.Controls.Add(this.checkedListBoxConstruction);
            this.PurchaseSupplies.Controls.Add(this.label5);
            this.PurchaseSupplies.Controls.Add(this.label4);
            this.PurchaseSupplies.Controls.Add(this.labelFunds);
            this.PurchaseSupplies.Controls.Add(this.label3);
            this.PurchaseSupplies.Controls.Add(this.label2);
            this.PurchaseSupplies.Controls.Add(this.checkedListBoxBasics);
            this.PurchaseSupplies.Location = new System.Drawing.Point(4, 22);
            this.PurchaseSupplies.Name = "PurchaseSupplies";
            this.PurchaseSupplies.Size = new System.Drawing.Size(1005, 780);
            this.PurchaseSupplies.TabIndex = 2;
            this.PurchaseSupplies.Text = "tabPage1";
            this.PurchaseSupplies.UseVisualStyleBackColor = true;
            // 
            // labelFood
            // 
            this.labelFood.AutoSize = true;
            this.labelFood.Font = new System.Drawing.Font("Rockwell", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelFood.Location = new System.Drawing.Point(175, 79);
            this.labelFood.Name = "labelFood";
            this.labelFood.Size = new System.Drawing.Size(86, 19);
            this.labelFood.TabIndex = 29;
            this.labelFood.Text = "Food Here";
            // 
            // labelWater
            // 
            this.labelWater.AutoSize = true;
            this.labelWater.Font = new System.Drawing.Font("Rockwell", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelWater.Location = new System.Drawing.Point(184, 60);
            this.labelWater.Name = "labelWater";
            this.labelWater.Size = new System.Drawing.Size(95, 19);
            this.labelWater.TabIndex = 28;
            this.labelWater.Text = "Water Here";
            // 
            // labelAir
            // 
            this.labelAir.AutoSize = true;
            this.labelAir.Font = new System.Drawing.Font("Rockwell", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelAir.Location = new System.Drawing.Point(160, 41);
            this.labelAir.Name = "labelAir";
            this.labelAir.Size = new System.Drawing.Size(71, 19);
            this.labelAir.TabIndex = 27;
            this.labelAir.Text = "Air Here";
            // 
            // labelHappiness
            // 
            this.labelHappiness.AutoSize = true;
            this.labelHappiness.Font = new System.Drawing.Font("Rockwell", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelHappiness.Location = new System.Drawing.Point(834, 79);
            this.labelHappiness.Name = "labelHappiness";
            this.labelHappiness.Size = new System.Drawing.Size(125, 19);
            this.labelHappiness.TabIndex = 26;
            this.labelHappiness.Text = "Happiness Here";
            // 
            // labelMaintenance
            // 
            this.labelMaintenance.AutoSize = true;
            this.labelMaintenance.Font = new System.Drawing.Font("Rockwell", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelMaintenance.Location = new System.Drawing.Point(887, 60);
            this.labelMaintenance.Name = "labelMaintenance";
            this.labelMaintenance.Size = new System.Drawing.Size(143, 19);
            this.labelMaintenance.TabIndex = 25;
            this.labelMaintenance.Text = "Maintenance Here";
            // 
            // labelEnergy
            // 
            this.labelEnergy.AutoSize = true;
            this.labelEnergy.Font = new System.Drawing.Font("Rockwell", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelEnergy.Location = new System.Drawing.Point(876, 38);
            this.labelEnergy.Name = "labelEnergy";
            this.labelEnergy.Size = new System.Drawing.Size(103, 19);
            this.labelEnergy.TabIndex = 24;
            this.labelEnergy.Text = "Energy Here";
            // 
            // labelSpace
            // 
            this.labelSpace.AutoSize = true;
            this.labelSpace.Font = new System.Drawing.Font("Rockwell", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelSpace.Location = new System.Drawing.Point(548, 79);
            this.labelSpace.Name = "labelSpace";
            this.labelSpace.Size = new System.Drawing.Size(94, 19);
            this.labelSpace.TabIndex = 23;
            this.labelSpace.Text = "Space Here";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("Rockwell", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label15.Location = new System.Drawing.Point(383, 79);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(161, 19);
            this.label15.TabIndex = 22;
            this.label15.Text = "Space in Base (m^3):";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Rockwell", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.Location = new System.Drawing.Point(738, 41);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(132, 19);
            this.label14.TabIndex = 21;
            this.label14.Text = "Energy (kW/hr):";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Rockwell", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.Location = new System.Drawing.Point(738, 60);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(143, 19);
            this.label13.TabIndex = 20;
            this.label13.Text = "Maintenance (kg):";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Rockwell", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(738, 79);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(90, 19);
            this.label12.TabIndex = 19;
            this.label12.Text = "Happiness:";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Rockwell", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(67, 79);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(102, 19);
            this.label11.TabIndex = 18;
            this.label11.Text = "Food (days):";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Rockwell", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(67, 60);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(111, 19);
            this.label10.TabIndex = 17;
            this.label10.Text = "Water (days):";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Rockwell", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(67, 41);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(87, 19);
            this.label9.TabIndex = 16;
            this.label9.Text = "Air (days):";
            // 
            // buttonAddItem
            // 
            this.buttonAddItem.AutoEllipsis = true;
            this.buttonAddItem.Font = new System.Drawing.Font("Rockwell", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonAddItem.Location = new System.Drawing.Point(552, 374);
            this.buttonAddItem.Name = "buttonAddItem";
            this.buttonAddItem.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.buttonAddItem.Size = new System.Drawing.Size(187, 54);
            this.buttonAddItem.TabIndex = 15;
            this.buttonAddItem.Text = "Add to Cart";
            this.buttonAddItem.UseVisualStyleBackColor = true;
            // 
            // GotoIntro
            // 
            this.GotoIntro.Font = new System.Drawing.Font("Rockwell", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.GotoIntro.Location = new System.Drawing.Point(420, 703);
            this.GotoIntro.Name = "GotoIntro";
            this.GotoIntro.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.GotoIntro.Size = new System.Drawing.Size(191, 54);
            this.GotoIntro.TabIndex = 14;
            this.GotoIntro.Text = "Back to Introduction";
            this.GotoIntro.UseVisualStyleBackColor = true;
            // 
            // checkedListBoxProperties
            // 
            this.checkedListBoxProperties.FormattingEnabled = true;
            this.checkedListBoxProperties.Items.AddRange(new object[] {
            "$10\t\t10kW/hr Energy",
            "$10\t\tConsumables",
            "$10\t\tFarming",
            "$10\t\tConstruction"});
            this.checkedListBoxProperties.Location = new System.Drawing.Point(742, 342);
            this.checkedListBoxProperties.Name = "checkedListBoxProperties";
            this.checkedListBoxProperties.Size = new System.Drawing.Size(200, 94);
            this.checkedListBoxProperties.TabIndex = 13;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Rockwell", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(550, 303);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(296, 36);
            this.label8.TabIndex = 12;
            this.label8.Text = "Additional Supplies";
            // 
            // textBoxSupply
            // 
            this.textBoxSupply.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxSupply.Location = new System.Drawing.Point(552, 342);
            this.textBoxSupply.Name = "textBoxSupply";
            this.textBoxSupply.Size = new System.Drawing.Size(187, 26);
            this.textBoxSupply.TabIndex = 11;
            this.textBoxSupply.Text = "Enter Supply Name Here";
            // 
            // checkedListBoxMisc
            // 
            this.checkedListBoxMisc.CheckOnClick = true;
            this.checkedListBoxMisc.FormattingEnabled = true;
            this.checkedListBoxMisc.Items.AddRange(new object[] {
            "$10,000\t\tGiant Solid Oxide Electrolysis Machine (Generates O2 + CO + H2)",
            "$10,000\t\t10 Resource-Gathering Robots",
            "$5,000\t\t5 Resource-Gathering Robots",
            "$1,000\t\t1 Resource-Gathering Robot",
            "$10,000\t\t10 Resource-Transporting Robots",
            "$5,000\t\t5 Resource-Transporting Robots",
            "$1,000\t\t1 Resource-Transporting Robot",
            "$5,000\t\tAlgae-Based Organic Polymer Synthesizer",
            "$1,000\t\tPlenty of Polymer",
            "$100\t\tEnough Polymer",
            "$10,000\t\tSpice Melange",
            "$50\t\tRecreational Supplies"});
            this.checkedListBoxMisc.Location = new System.Drawing.Point(556, 146);
            this.checkedListBoxMisc.Name = "checkedListBoxMisc";
            this.checkedListBoxMisc.Size = new System.Drawing.Size(415, 154);
            this.checkedListBoxMisc.TabIndex = 10;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Rockwell", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(550, 107);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(221, 36);
            this.label7.TabIndex = 9;
            this.label7.Text = "Miscellaneous";
            // 
            // checkedListBoxFarming
            // 
            this.checkedListBoxFarming.FormattingEnabled = true;
            this.checkedListBoxFarming.Items.AddRange(new object[] {
            "$10,000\t\tGreat Bioreactor",
            "$1,000\t\tDecent Bioreactor",
            "$100\t\tBasic Bioreactor",
            "$100\t\tChickens",
            "$100\t\tFish",
            "$25\t\tBamboo, Fertilizing/Processing GM Algae, Fungi,",
            "$20\t\tVarious seeds"});
            this.checkedListBoxFarming.Location = new System.Drawing.Point(71, 538);
            this.checkedListBoxFarming.Name = "checkedListBoxFarming";
            this.checkedListBoxFarming.Size = new System.Drawing.Size(393, 154);
            this.checkedListBoxFarming.TabIndex = 8;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Rockwell", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(65, 499);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(137, 36);
            this.label6.TabIndex = 7;
            this.label6.Text = "Farming";
            // 
            // checkedListBoxConstruction
            // 
            this.checkedListBoxConstruction.FormattingEnabled = true;
            this.checkedListBoxConstruction.Items.AddRange(new object[] {
            "$75,000\t\tGreat Construction, Maintenance, and Excavation Equipment",
            "$50,000\t\tDecent Construction, Maintenance, and Excavation Equipment",
            "$2,500\t\tBasic Construction, Maintenance, and Excavation Equipment",
            "$50,000\t\t50,000 kW/hr Atomic Battery and Transformer",
            "$10,000\t\t10,000 kW/hr Atomic Battery and Transformer",
            "$1,000\t\t1,000 kW/hr Atomic Battery and Transformer",
            "$10,000\t\tEnough spare parts for another base",
            "$1,000\t\tRegular amount of spare parts",
            "$100\t\tSome spare parts",
            "$5,000\t\tPlenty of Heating and Insulation",
            "$1,000\t\tGood Heating and Insulation",
            "$500\t\tBasic Heating and Insulation",
            "$100\t\tIndustrial-Grade 3-D Printer"});
            this.checkedListBoxConstruction.Location = new System.Drawing.Point(71, 342);
            this.checkedListBoxConstruction.Name = "checkedListBoxConstruction";
            this.checkedListBoxConstruction.Size = new System.Drawing.Size(393, 154);
            this.checkedListBoxConstruction.TabIndex = 6;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Rockwell", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(65, 303);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(202, 36);
            this.label5.TabIndex = 5;
            this.label5.Text = "Construction";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Rockwell", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(65, 107);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(479, 36);
            this.label4.TabIndex = 4;
            this.label4.Text = "Basics (Assuming 1:1 kg:$ ratio)";
            // 
            // labelFunds
            // 
            this.labelFunds.AutoSize = true;
            this.labelFunds.Font = new System.Drawing.Font("Rockwell", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelFunds.Location = new System.Drawing.Point(511, 60);
            this.labelFunds.Name = "labelFunds";
            this.labelFunds.Size = new System.Drawing.Size(93, 19);
            this.labelFunds.TabIndex = 3;
            this.labelFunds.Text = "Funds Here";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Rockwell", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(416, 60);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(89, 19);
            this.label3.TabIndex = 2;
            this.label3.Text = "Money ($):";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Rockwell", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(374, 24);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(281, 36);
            this.label2.TabIndex = 1;
            this.label2.Text = "Purchase Supplies";
            // 
            // checkedListBoxBasics
            // 
            this.checkedListBoxBasics.CheckOnClick = true;
            this.checkedListBoxBasics.FormattingEnabled = true;
            this.checkedListBoxBasics.Items.AddRange(new object[] {
            "$100,000\tEVA Suit",
            "$5,900\t\tAirlock",
            "$1,000\t\t1000kW/hr Atomic battery and transformer",
            "$1,000\t\tSolid Oxide Electrolysis Machine (Generates O2 + CO + H2)",
            "$100\t\tBasic Maintenance Supplies",
            "$100\t\t1 month of food and water",
            "$100\t\tSome Heating and Insulation",
            "$25\t\tExtremely basic excavation tools (Pick, shovel, etc.)",
            "$20\t\tMicrowave",
            "$20\t\tEdible GM Algae, potatoes, and composting bacteria",
            "$1\t\tPhone Stuff"});
            this.checkedListBoxBasics.Location = new System.Drawing.Point(71, 146);
            this.checkedListBoxBasics.Name = "checkedListBoxBasics";
            this.checkedListBoxBasics.Size = new System.Drawing.Size(401, 154);
            this.checkedListBoxBasics.TabIndex = 0;
            // 
            // listBoxOtherSupplies
            // 
            this.listBoxOtherSupplies.FormattingEnabled = true;
            this.listBoxOtherSupplies.Location = new System.Drawing.Point(552, 435);
            this.listBoxOtherSupplies.Name = "listBoxOtherSupplies";
            this.listBoxOtherSupplies.Size = new System.Drawing.Size(419, 251);
            this.listBoxOtherSupplies.TabIndex = 30;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(984, 754);
            this.Controls.Add(this.tabControl);
            this.Name = "Form1";
            this.Text = "Form1";
            this.tabControl.ResumeLayout(false);
            this.Intro.ResumeLayout(false);
            this.DestSelect.ResumeLayout(false);
            this.DestSelect.PerformLayout();
            this.PurchaseSupplies.ResumeLayout(false);
            this.PurchaseSupplies.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl;
        private System.Windows.Forms.TabPage Intro;
        private System.Windows.Forms.Button buttonStart;
        private System.Windows.Forms.TabPage DestSelect;
        private System.Windows.Forms.TabPage PurchaseSupplies;
        private System.Windows.Forms.Button buttonGotoIntro;
        private System.Windows.Forms.Button buttonMars;
        private System.Windows.Forms.Label DestinationTitle;
        private System.Windows.Forms.Button buttonTitan;
        private System.Windows.Forms.Button buttonEuropa;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label labelFunds;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.CheckedListBox checkedListBoxBasics;
        private System.Windows.Forms.CheckedListBox checkedListBoxMisc;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.CheckedListBox checkedListBoxFarming;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.CheckedListBox checkedListBoxConstruction;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.CheckedListBox checkedListBoxProperties;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox textBoxSupply;
        private System.Windows.Forms.Button buttonAddItem;
        private System.Windows.Forms.Button GotoIntro;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label labelFood;
        private System.Windows.Forms.Label labelWater;
        private System.Windows.Forms.Label labelAir;
        private System.Windows.Forms.Label labelHappiness;
        private System.Windows.Forms.Label labelMaintenance;
        private System.Windows.Forms.Label labelEnergy;
        private System.Windows.Forms.Label labelSpace;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.ListBox listBoxOtherSupplies;
    }
}

