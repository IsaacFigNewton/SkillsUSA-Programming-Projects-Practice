namespace Hello_World
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
            this.components = new System.ComponentModel.Container();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.nameInput = new System.Windows.Forms.TextBox();
            this.addressInput = new System.Windows.Forms.TextBox();
            this.phoneInput = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.pickup = new System.Windows.Forms.CheckBox();
            this.delivery = new System.Windows.Forms.CheckBox();
            this.locationSelector = new System.Windows.Forms.ComboBox();
            this.nextButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
            // 
            // nameInput
            // 
            this.nameInput.Location = new System.Drawing.Point(275, 104);
            this.nameInput.Name = "nameInput";
            this.nameInput.Size = new System.Drawing.Size(100, 20);
            this.nameInput.TabIndex = 2;
            this.nameInput.Text = "Name";
            // 
            // addressInput
            // 
            this.addressInput.Location = new System.Drawing.Point(274, 134);
            this.addressInput.Name = "addressInput";
            this.addressInput.Size = new System.Drawing.Size(100, 20);
            this.addressInput.TabIndex = 3;
            this.addressInput.Text = "Address";
            // 
            // phoneInput
            // 
            this.phoneInput.Location = new System.Drawing.Point(276, 167);
            this.phoneInput.Name = "phoneInput";
            this.phoneInput.Size = new System.Drawing.Size(100, 20);
            this.phoneInput.TabIndex = 4;
            this.phoneInput.Text = "Phone";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(104, 104);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(123, 13);
            this.label1.TabIndex = 5;
            this.label1.Text = "Please Enter Your Name";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(104, 134);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(133, 13);
            this.label2.TabIndex = 6;
            this.label2.Text = "Please Enter Your Address";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(104, 167);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(166, 13);
            this.label3.TabIndex = 7;
            this.label3.Text = "Please Enter Your Phone Number";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(104, 31);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(219, 13);
            this.label4.TabIndex = 8;
            this.label4.Text = "Welcome to the Pizza.com Delivery Program!";
            // 
            // pickup
            // 
            this.pickup.AutoSize = true;
            this.pickup.Location = new System.Drawing.Point(107, 193);
            this.pickup.Name = "pickup";
            this.pickup.Size = new System.Drawing.Size(71, 17);
            this.pickup.TabIndex = 11;
            this.pickup.Text = "Pick up...";
            this.pickup.UseVisualStyleBackColor = true;
            // 
            // delivery
            // 
            this.delivery.AutoSize = true;
            this.delivery.Location = new System.Drawing.Point(185, 193);
            this.delivery.Name = "delivery";
            this.delivery.Size = new System.Drawing.Size(127, 17);
            this.delivery.TabIndex = 12;
            this.delivery.Text = "...or Delivery? ($5.00)";
            this.delivery.UseVisualStyleBackColor = true;
            // 
            // locationSelector
            // 
            this.locationSelector.FormattingEnabled = true;
            this.locationSelector.Items.AddRange(new object[] {
            "Pizza Yurt",
            "Space Pizza",
            "Guillermo\'s Pizza"});
            this.locationSelector.Location = new System.Drawing.Point(106, 216);
            this.locationSelector.Name = "locationSelector";
            this.locationSelector.Size = new System.Drawing.Size(121, 21);
            this.locationSelector.TabIndex = 14;
            this.locationSelector.Text = "Location";
            // 
            // nextButton
            // 
            this.nextButton.Location = new System.Drawing.Point(106, 369);
            this.nextButton.Name = "nextButton";
            this.nextButton.Size = new System.Drawing.Size(121, 26);
            this.nextButton.TabIndex = 15;
            this.nextButton.Text = "Next";
            this.nextButton.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.nextButton);
            this.Controls.Add(this.locationSelector);
            this.Controls.Add(this.delivery);
            this.Controls.Add(this.pickup);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.phoneInput);
            this.Controls.Add(this.addressInput);
            this.Controls.Add(this.nameInput);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.TextBox nameInput;
        private System.Windows.Forms.TextBox addressInput;
        private System.Windows.Forms.TextBox phoneInput;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.CheckBox pickup;
        private System.Windows.Forms.CheckBox delivery;
        private System.Windows.Forms.ComboBox locationSelector;
        private System.Windows.Forms.Button nextButton;
    }
}

