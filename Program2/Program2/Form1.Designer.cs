namespace Program2
{
    partial class InsuranceForm
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
            this.titlelabel = new System.Windows.Forms.Label();
            this.CarInsurancelabel = new System.Windows.Forms.Label();
            this.Healthlabel = new System.Windows.Forms.Label();
            this.carvaluelabel = new System.Windows.Forms.Label();
            this.agelabel = new System.Windows.Forms.Label();
            this.AgetextBox = new System.Windows.Forms.TextBox();
            this.carvaluetextBox = new System.Windows.Forms.TextBox();
            this.healthcomboBox = new System.Windows.Forms.ComboBox();
            this.insurancecomboBox = new System.Windows.Forms.ComboBox();
            this.smokebuttonNo = new System.Windows.Forms.RadioButton();
            this.smokebuttonYes = new System.Windows.Forms.RadioButton();
            this.smokegroupBox = new System.Windows.Forms.GroupBox();
            this.Smokelabel = new System.Windows.Forms.Label();
            this.smokeyesradioButton = new System.Windows.Forms.RadioButton();
            this.smokenoradioButton = new System.Windows.Forms.RadioButton();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.accidentnoradioButton = new System.Windows.Forms.RadioButton();
            this.accidentyesradioButton = new System.Windows.Forms.RadioButton();
            this.accidentlabel = new System.Windows.Forms.Label();
            this.calculatepremiumbutton = new System.Windows.Forms.Button();
            this.totalcostlabel = new System.Windows.Forms.Label();
            this.Carcoveragelabel = new System.Windows.Forms.Label();
            this.healthcostlabel = new System.Windows.Forms.Label();
            this.totaltextBox = new System.Windows.Forms.TextBox();
            this.carcosttextBox = new System.Windows.Forms.TextBox();
            this.healthcosttextBox = new System.Windows.Forms.TextBox();
            this.smokegroupBox.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // titlelabel
            // 
            this.titlelabel.AutoSize = true;
            this.titlelabel.Location = new System.Drawing.Point(123, 21);
            this.titlelabel.Name = "titlelabel";
            this.titlelabel.Size = new System.Drawing.Size(176, 13);
            this.titlelabel.TabIndex = 0;
            this.titlelabel.Text = "Cardinal Insurance Policy Calculator";
            // 
            // CarInsurancelabel
            // 
            this.CarInsurancelabel.AutoSize = true;
            this.CarInsurancelabel.Location = new System.Drawing.Point(25, 153);
            this.CarInsurancelabel.Name = "CarInsurancelabel";
            this.CarInsurancelabel.Size = new System.Drawing.Size(125, 13);
            this.CarInsurancelabel.TabIndex = 1;
            this.CarInsurancelabel.Text = "Car Insurance Coverage:";
            // 
            // Healthlabel
            // 
            this.Healthlabel.AutoSize = true;
            this.Healthlabel.Location = new System.Drawing.Point(25, 125);
            this.Healthlabel.Name = "Healthlabel";
            this.Healthlabel.Size = new System.Drawing.Size(140, 13);
            this.Healthlabel.TabIndex = 2;
            this.Healthlabel.Text = "Health Insurance Coverage:";
            this.Healthlabel.Click += new System.EventHandler(this.label2_Click);
            // 
            // carvaluelabel
            // 
            this.carvaluelabel.AutoSize = true;
            this.carvaluelabel.Location = new System.Drawing.Point(25, 95);
            this.carvaluelabel.Name = "carvaluelabel";
            this.carvaluelabel.Size = new System.Drawing.Size(117, 13);
            this.carvaluelabel.TabIndex = 3;
            this.carvaluelabel.Text = "Estimated Value of Car:";
            // 
            // agelabel
            // 
            this.agelabel.AutoSize = true;
            this.agelabel.Location = new System.Drawing.Point(25, 64);
            this.agelabel.Name = "agelabel";
            this.agelabel.Size = new System.Drawing.Size(82, 13);
            this.agelabel.TabIndex = 4;
            this.agelabel.Text = "Enter Your Age:";
            // 
            // AgetextBox
            // 
            this.AgetextBox.Location = new System.Drawing.Point(304, 61);
            this.AgetextBox.Name = "AgetextBox";
            this.AgetextBox.Size = new System.Drawing.Size(100, 20);
            this.AgetextBox.TabIndex = 5;
            // 
            // carvaluetextBox
            // 
            this.carvaluetextBox.Location = new System.Drawing.Point(304, 92);
            this.carvaluetextBox.Name = "carvaluetextBox";
            this.carvaluetextBox.Size = new System.Drawing.Size(100, 20);
            this.carvaluetextBox.TabIndex = 6;
            // 
            // healthcomboBox
            // 
            this.healthcomboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.healthcomboBox.FormattingEnabled = true;
            this.healthcomboBox.Items.AddRange(new object[] {
            "Medical",
            "Dental",
            "Vision",
            "None"});
            this.healthcomboBox.Location = new System.Drawing.Point(283, 122);
            this.healthcomboBox.Name = "healthcomboBox";
            this.healthcomboBox.Size = new System.Drawing.Size(121, 21);
            this.healthcomboBox.TabIndex = 7;
            this.healthcomboBox.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // insurancecomboBox
            // 
            this.insurancecomboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.insurancecomboBox.FormattingEnabled = true;
            this.insurancecomboBox.Items.AddRange(new object[] {
            "Full",
            "Liability",
            "None"});
            this.insurancecomboBox.Location = new System.Drawing.Point(283, 149);
            this.insurancecomboBox.Name = "insurancecomboBox";
            this.insurancecomboBox.Size = new System.Drawing.Size(121, 21);
            this.insurancecomboBox.TabIndex = 8;
            // 
            // smokebuttonNo
            // 
            this.smokebuttonNo.AutoSize = true;
            this.smokebuttonNo.Location = new System.Drawing.Point(304, 234);
            this.smokebuttonNo.Name = "smokebuttonNo";
            this.smokebuttonNo.Size = new System.Drawing.Size(39, 17);
            this.smokebuttonNo.TabIndex = 9;
            this.smokebuttonNo.TabStop = true;
            this.smokebuttonNo.Text = "No";
            this.smokebuttonNo.UseVisualStyleBackColor = true;
            // 
            // smokebuttonYes
            // 
            this.smokebuttonYes.AutoSize = true;
            this.smokebuttonYes.Location = new System.Drawing.Point(304, 199);
            this.smokebuttonYes.Name = "smokebuttonYes";
            this.smokebuttonYes.Size = new System.Drawing.Size(43, 17);
            this.smokebuttonYes.TabIndex = 10;
            this.smokebuttonYes.TabStop = true;
            this.smokebuttonYes.Text = "Yes";
            this.smokebuttonYes.UseVisualStyleBackColor = true;
            // 
            // smokegroupBox
            // 
            this.smokegroupBox.Controls.Add(this.smokenoradioButton);
            this.smokegroupBox.Controls.Add(this.smokeyesradioButton);
            this.smokegroupBox.Controls.Add(this.Smokelabel);
            this.smokegroupBox.Location = new System.Drawing.Point(28, 199);
            this.smokegroupBox.Name = "smokegroupBox";
            this.smokegroupBox.Size = new System.Drawing.Size(376, 112);
            this.smokegroupBox.TabIndex = 12;
            this.smokegroupBox.TabStop = false;
            // 
            // Smokelabel
            // 
            this.Smokelabel.AutoSize = true;
            this.Smokelabel.Location = new System.Drawing.Point(3, 16);
            this.Smokelabel.Name = "Smokelabel";
            this.Smokelabel.Size = new System.Drawing.Size(85, 13);
            this.Smokelabel.TabIndex = 0;
            this.Smokelabel.Text = "Do You Smoke?";
            // 
            // smokeyesradioButton
            // 
            this.smokeyesradioButton.AutoSize = true;
            this.smokeyesradioButton.Location = new System.Drawing.Point(276, 14);
            this.smokeyesradioButton.Name = "smokeyesradioButton";
            this.smokeyesradioButton.Size = new System.Drawing.Size(43, 17);
            this.smokeyesradioButton.TabIndex = 1;
            this.smokeyesradioButton.TabStop = true;
            this.smokeyesradioButton.Text = "Yes";
            this.smokeyesradioButton.UseVisualStyleBackColor = true;
            // 
            // smokenoradioButton
            // 
            this.smokenoradioButton.AutoSize = true;
            this.smokenoradioButton.Location = new System.Drawing.Point(276, 75);
            this.smokenoradioButton.Name = "smokenoradioButton";
            this.smokenoradioButton.Size = new System.Drawing.Size(39, 17);
            this.smokenoradioButton.TabIndex = 2;
            this.smokenoradioButton.TabStop = true;
            this.smokenoradioButton.Text = "No";
            this.smokenoradioButton.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.accidentnoradioButton);
            this.groupBox1.Controls.Add(this.accidentyesradioButton);
            this.groupBox1.Controls.Add(this.accidentlabel);
            this.groupBox1.Location = new System.Drawing.Point(28, 317);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(376, 112);
            this.groupBox1.TabIndex = 13;
            this.groupBox1.TabStop = false;
            // 
            // accidentnoradioButton
            // 
            this.accidentnoradioButton.AutoSize = true;
            this.accidentnoradioButton.Location = new System.Drawing.Point(276, 75);
            this.accidentnoradioButton.Name = "accidentnoradioButton";
            this.accidentnoradioButton.Size = new System.Drawing.Size(39, 17);
            this.accidentnoradioButton.TabIndex = 2;
            this.accidentnoradioButton.TabStop = true;
            this.accidentnoradioButton.Text = "No";
            this.accidentnoradioButton.UseVisualStyleBackColor = true;
            // 
            // accidentyesradioButton
            // 
            this.accidentyesradioButton.AutoSize = true;
            this.accidentyesradioButton.Location = new System.Drawing.Point(276, 14);
            this.accidentyesradioButton.Name = "accidentyesradioButton";
            this.accidentyesradioButton.Size = new System.Drawing.Size(43, 17);
            this.accidentyesradioButton.TabIndex = 1;
            this.accidentyesradioButton.TabStop = true;
            this.accidentyesradioButton.Text = "Yes";
            this.accidentyesradioButton.UseVisualStyleBackColor = true;
            // 
            // accidentlabel
            // 
            this.accidentlabel.AutoSize = true;
            this.accidentlabel.Location = new System.Drawing.Point(3, 16);
            this.accidentlabel.Name = "accidentlabel";
            this.accidentlabel.Size = new System.Drawing.Size(152, 13);
            this.accidentlabel.TabIndex = 0;
            this.accidentlabel.Text = "Car Accident in the Past Year?";
            // 
            // calculatepremiumbutton
            // 
            this.calculatepremiumbutton.Location = new System.Drawing.Point(126, 452);
            this.calculatepremiumbutton.Name = "calculatepremiumbutton";
            this.calculatepremiumbutton.Size = new System.Drawing.Size(178, 23);
            this.calculatepremiumbutton.TabIndex = 14;
            this.calculatepremiumbutton.Text = "Calculate Policy Premiums";
            this.calculatepremiumbutton.UseVisualStyleBackColor = true;
            this.calculatepremiumbutton.Click += new System.EventHandler(this.calculatepremiumbutton_Click);
            // 
            // totalcostlabel
            // 
            this.totalcostlabel.AutoSize = true;
            this.totalcostlabel.Location = new System.Drawing.Point(31, 591);
            this.totalcostlabel.Name = "totalcostlabel";
            this.totalcostlabel.Size = new System.Drawing.Size(132, 13);
            this.totalcostlabel.TabIndex = 15;
            this.totalcostlabel.Text = "Total Policy Cost per Year:";
            // 
            // Carcoveragelabel
            // 
            this.Carcoveragelabel.AutoSize = true;
            this.Carcoveragelabel.Location = new System.Drawing.Point(31, 545);
            this.Carcoveragelabel.Name = "Carcoveragelabel";
            this.Carcoveragelabel.Size = new System.Drawing.Size(142, 13);
            this.Carcoveragelabel.TabIndex = 16;
            this.Carcoveragelabel.Text = "Car Coverage Cost per Year:";
            // 
            // healthcostlabel
            // 
            this.healthcostlabel.AutoSize = true;
            this.healthcostlabel.Location = new System.Drawing.Point(31, 500);
            this.healthcostlabel.Name = "healthcostlabel";
            this.healthcostlabel.Size = new System.Drawing.Size(157, 13);
            this.healthcostlabel.TabIndex = 17;
            this.healthcostlabel.Text = "Health Coverage Cost per Year:";
            // 
            // totaltextBox
            // 
            this.totaltextBox.Location = new System.Drawing.Point(247, 588);
            this.totaltextBox.Name = "totaltextBox";
            this.totaltextBox.Size = new System.Drawing.Size(100, 20);
            this.totaltextBox.TabIndex = 18;
            // 
            // carcosttextBox
            // 
            this.carcosttextBox.Location = new System.Drawing.Point(247, 542);
            this.carcosttextBox.Name = "carcosttextBox";
            this.carcosttextBox.Size = new System.Drawing.Size(100, 20);
            this.carcosttextBox.TabIndex = 19;
            // 
            // healthcosttextBox
            // 
            this.healthcosttextBox.Location = new System.Drawing.Point(247, 497);
            this.healthcosttextBox.Name = "healthcosttextBox";
            this.healthcosttextBox.Size = new System.Drawing.Size(100, 20);
            this.healthcosttextBox.TabIndex = 20;
            // 
            // InsuranceForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(425, 634);
            this.Controls.Add(this.healthcosttextBox);
            this.Controls.Add(this.carcosttextBox);
            this.Controls.Add(this.totaltextBox);
            this.Controls.Add(this.healthcostlabel);
            this.Controls.Add(this.Carcoveragelabel);
            this.Controls.Add(this.totalcostlabel);
            this.Controls.Add(this.calculatepremiumbutton);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.smokegroupBox);
            this.Controls.Add(this.smokebuttonYes);
            this.Controls.Add(this.smokebuttonNo);
            this.Controls.Add(this.insurancecomboBox);
            this.Controls.Add(this.healthcomboBox);
            this.Controls.Add(this.carvaluetextBox);
            this.Controls.Add(this.AgetextBox);
            this.Controls.Add(this.agelabel);
            this.Controls.Add(this.carvaluelabel);
            this.Controls.Add(this.Healthlabel);
            this.Controls.Add(this.CarInsurancelabel);
            this.Controls.Add(this.titlelabel);
            this.Name = "InsuranceForm";
            this.Text = "Program 2";
            this.smokegroupBox.ResumeLayout(false);
            this.smokegroupBox.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label titlelabel;
        private System.Windows.Forms.Label CarInsurancelabel;
        private System.Windows.Forms.Label Healthlabel;
        private System.Windows.Forms.Label carvaluelabel;
        private System.Windows.Forms.Label agelabel;
        private System.Windows.Forms.TextBox AgetextBox;
        private System.Windows.Forms.TextBox carvaluetextBox;
        private System.Windows.Forms.ComboBox healthcomboBox;
        private System.Windows.Forms.ComboBox insurancecomboBox;
        private System.Windows.Forms.RadioButton smokebuttonNo;
        private System.Windows.Forms.RadioButton smokebuttonYes;
        private System.Windows.Forms.GroupBox smokegroupBox;
        private System.Windows.Forms.RadioButton smokenoradioButton;
        private System.Windows.Forms.RadioButton smokeyesradioButton;
        private System.Windows.Forms.Label Smokelabel;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton accidentnoradioButton;
        private System.Windows.Forms.RadioButton accidentyesradioButton;
        private System.Windows.Forms.Label accidentlabel;
        private System.Windows.Forms.Button calculatepremiumbutton;
        private System.Windows.Forms.Label totalcostlabel;
        private System.Windows.Forms.Label Carcoveragelabel;
        private System.Windows.Forms.Label healthcostlabel;
        private System.Windows.Forms.TextBox totaltextBox;
        private System.Windows.Forms.TextBox carcosttextBox;
        private System.Windows.Forms.TextBox healthcosttextBox;
    }
}

