namespace Program3
{
    partial class ContractCalculator
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
            this.providercomboBox = new System.Windows.Forms.ComboBox();
            this.TitleLabel = new System.Windows.Forms.Label();
            this.Providerlabel = new System.Windows.Forms.Label();
            this.businesscomboBox = new System.Windows.Forms.ComboBox();
            this.businesslabel = new System.Windows.Forms.Label();
            this.contractlabel = new System.Windows.Forms.Label();
            this.contracttextBox = new System.Windows.Forms.TextBox();
            this.calculatebutton = new System.Windows.Forms.Button();
            this.shippinglabel = new System.Windows.Forms.Label();
            this.initiallabel = new System.Windows.Forms.Label();
            this.discountlabel = new System.Windows.Forms.Label();
            this.lengthlabel = new System.Windows.Forms.Label();
            this.finallabel = new System.Windows.Forms.Label();
            this.shippingprovidertextBox = new System.Windows.Forms.TextBox();
            this.initialpricetextBox = new System.Windows.Forms.TextBox();
            this.discounttextBox = new System.Windows.Forms.TextBox();
            this.lengthtextBox = new System.Windows.Forms.TextBox();
            this.finalpricetextBox = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // providercomboBox
            // 
            this.providercomboBox.FormattingEnabled = true;
            this.providercomboBox.Items.AddRange(new object[] {
            "USPS",
            "DHL",
            "FedEx",
            "UPS"});
            this.providercomboBox.Location = new System.Drawing.Point(161, 57);
            this.providercomboBox.Name = "providercomboBox";
            this.providercomboBox.Size = new System.Drawing.Size(121, 21);
            this.providercomboBox.TabIndex = 0;
            // 
            // TitleLabel
            // 
            this.TitleLabel.AutoSize = true;
            this.TitleLabel.Location = new System.Drawing.Point(107, 9);
            this.TitleLabel.Name = "TitleLabel";
            this.TitleLabel.Size = new System.Drawing.Size(141, 13);
            this.TitleLabel.TabIndex = 1;
            this.TitleLabel.Text = "Shipping Contract Calculator";
            // 
            // Providerlabel
            // 
            this.Providerlabel.AutoSize = true;
            this.Providerlabel.Location = new System.Drawing.Point(63, 60);
            this.Providerlabel.Name = "Providerlabel";
            this.Providerlabel.Size = new System.Drawing.Size(49, 13);
            this.Providerlabel.TabIndex = 2;
            this.Providerlabel.Text = "Provider:";
            // 
            // businesscomboBox
            // 
            this.businesscomboBox.FormattingEnabled = true;
            this.businesscomboBox.Items.AddRange(new object[] {
            "John\'s Books",
            "Office Supplies",
            "J.B. Car Parts",
            "Gevalia Coffee",
            "Ceylon Tea",
            "My Footwear"});
            this.businesscomboBox.Location = new System.Drawing.Point(161, 102);
            this.businesscomboBox.Name = "businesscomboBox";
            this.businesscomboBox.Size = new System.Drawing.Size(121, 21);
            this.businesscomboBox.TabIndex = 3;
            // 
            // businesslabel
            // 
            this.businesslabel.AutoSize = true;
            this.businesslabel.Location = new System.Drawing.Point(63, 105);
            this.businesslabel.Name = "businesslabel";
            this.businesslabel.Size = new System.Drawing.Size(52, 13);
            this.businesslabel.TabIndex = 4;
            this.businesslabel.Text = "Business:";
            // 
            // contractlabel
            // 
            this.contractlabel.AutoSize = true;
            this.contractlabel.Location = new System.Drawing.Point(63, 150);
            this.contractlabel.Name = "contractlabel";
            this.contractlabel.Size = new System.Drawing.Size(86, 13);
            this.contractlabel.TabIndex = 5;
            this.contractlabel.Text = "Contract Length:";
            // 
            // contracttextBox
            // 
            this.contracttextBox.Location = new System.Drawing.Point(161, 147);
            this.contracttextBox.Name = "contracttextBox";
            this.contracttextBox.Size = new System.Drawing.Size(100, 20);
            this.contracttextBox.TabIndex = 6;
            // 
            // calculatebutton
            // 
            this.calculatebutton.Location = new System.Drawing.Point(99, 196);
            this.calculatebutton.Name = "calculatebutton";
            this.calculatebutton.Size = new System.Drawing.Size(75, 23);
            this.calculatebutton.TabIndex = 7;
            this.calculatebutton.Text = "Calculate";
            this.calculatebutton.UseVisualStyleBackColor = true;
            this.calculatebutton.Click += new System.EventHandler(this.calculatebutton_Click);
            // 
            // shippinglabel
            // 
            this.shippinglabel.AutoSize = true;
            this.shippinglabel.Location = new System.Drawing.Point(63, 257);
            this.shippinglabel.Name = "shippinglabel";
            this.shippinglabel.Size = new System.Drawing.Size(93, 13);
            this.shippinglabel.TabIndex = 8;
            this.shippinglabel.Text = "Shipping Provider:";
            // 
            // initiallabel
            // 
            this.initiallabel.AutoSize = true;
            this.initiallabel.Location = new System.Drawing.Point(63, 297);
            this.initiallabel.Name = "initiallabel";
            this.initiallabel.Size = new System.Drawing.Size(104, 13);
            this.initiallabel.TabIndex = 9;
            this.initiallabel.Text = "Initial Contract Price:";
            // 
            // discountlabel
            // 
            this.discountlabel.AutoSize = true;
            this.discountlabel.Location = new System.Drawing.Point(63, 334);
            this.discountlabel.Name = "discountlabel";
            this.discountlabel.Size = new System.Drawing.Size(99, 13);
            this.discountlabel.TabIndex = 10;
            this.discountlabel.Text = "Company Discount:";
            // 
            // lengthlabel
            // 
            this.lengthlabel.AutoSize = true;
            this.lengthlabel.Location = new System.Drawing.Point(63, 372);
            this.lengthlabel.Name = "lengthlabel";
            this.lengthlabel.Size = new System.Drawing.Size(88, 13);
            this.lengthlabel.TabIndex = 11;
            this.lengthlabel.Text = "Length Discount:";
            // 
            // finallabel
            // 
            this.finallabel.AutoSize = true;
            this.finallabel.Location = new System.Drawing.Point(63, 406);
            this.finallabel.Name = "finallabel";
            this.finallabel.Size = new System.Drawing.Size(59, 13);
            this.finallabel.TabIndex = 12;
            this.finallabel.Text = "Final Price:";
            // 
            // shippingprovidertextBox
            // 
            this.shippingprovidertextBox.Location = new System.Drawing.Point(182, 254);
            this.shippingprovidertextBox.Name = "shippingprovidertextBox";
            this.shippingprovidertextBox.Size = new System.Drawing.Size(100, 20);
            this.shippingprovidertextBox.TabIndex = 13;
            // 
            // initialpricetextBox
            // 
            this.initialpricetextBox.Location = new System.Drawing.Point(182, 294);
            this.initialpricetextBox.Name = "initialpricetextBox";
            this.initialpricetextBox.Size = new System.Drawing.Size(100, 20);
            this.initialpricetextBox.TabIndex = 14;
            // 
            // discounttextBox
            // 
            this.discounttextBox.Location = new System.Drawing.Point(182, 331);
            this.discounttextBox.Name = "discounttextBox";
            this.discounttextBox.Size = new System.Drawing.Size(100, 20);
            this.discounttextBox.TabIndex = 15;
            // 
            // lengthtextBox
            // 
            this.lengthtextBox.Location = new System.Drawing.Point(182, 369);
            this.lengthtextBox.Name = "lengthtextBox";
            this.lengthtextBox.Size = new System.Drawing.Size(100, 20);
            this.lengthtextBox.TabIndex = 16;
            // 
            // finalpricetextBox
            // 
            this.finalpricetextBox.Location = new System.Drawing.Point(182, 403);
            this.finalpricetextBox.Name = "finalpricetextBox";
            this.finalpricetextBox.Size = new System.Drawing.Size(100, 20);
            this.finalpricetextBox.TabIndex = 17;
            // 
            // ContractCalculator
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(361, 450);
            this.Controls.Add(this.finalpricetextBox);
            this.Controls.Add(this.lengthtextBox);
            this.Controls.Add(this.discounttextBox);
            this.Controls.Add(this.initialpricetextBox);
            this.Controls.Add(this.shippingprovidertextBox);
            this.Controls.Add(this.finallabel);
            this.Controls.Add(this.lengthlabel);
            this.Controls.Add(this.discountlabel);
            this.Controls.Add(this.initiallabel);
            this.Controls.Add(this.shippinglabel);
            this.Controls.Add(this.calculatebutton);
            this.Controls.Add(this.contracttextBox);
            this.Controls.Add(this.contractlabel);
            this.Controls.Add(this.businesslabel);
            this.Controls.Add(this.businesscomboBox);
            this.Controls.Add(this.Providerlabel);
            this.Controls.Add(this.TitleLabel);
            this.Controls.Add(this.providercomboBox);
            this.Name = "ContractCalculator";
            this.Text = "Contract Calculator";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox providercomboBox;
        private System.Windows.Forms.Label TitleLabel;
        private System.Windows.Forms.Label Providerlabel;
        private System.Windows.Forms.ComboBox businesscomboBox;
        private System.Windows.Forms.Label businesslabel;
        private System.Windows.Forms.Label contractlabel;
        private System.Windows.Forms.TextBox contracttextBox;
        private System.Windows.Forms.Button calculatebutton;
        private System.Windows.Forms.Label shippinglabel;
        private System.Windows.Forms.Label initiallabel;
        private System.Windows.Forms.Label discountlabel;
        private System.Windows.Forms.Label lengthlabel;
        private System.Windows.Forms.Label finallabel;
        private System.Windows.Forms.TextBox shippingprovidertextBox;
        private System.Windows.Forms.TextBox initialpricetextBox;
        private System.Windows.Forms.TextBox discounttextBox;
        private System.Windows.Forms.TextBox lengthtextBox;
        private System.Windows.Forms.TextBox finalpricetextBox;
    }
}

