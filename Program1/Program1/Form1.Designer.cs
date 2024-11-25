namespace Program_1
{
    partial class Program1
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
            this.Widthlabel = new System.Windows.Forms.Label();
            this.Lengthlabel = new System.Windows.Forms.Label();
            this.Colorlabel = new System.Windows.Forms.Label();
            this.Paintlabel = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.Coatslabel = new System.Windows.Forms.Label();
            this.CalculateCost = new System.Windows.Forms.Button();
            this.TotalCostLabel = new System.Windows.Forms.Label();
            this.LaborCostLabel = new System.Windows.Forms.Label();
            this.CoatCostLabel = new System.Windows.Forms.Label();
            this.PaintCostlabel = new System.Windows.Forms.Label();
            this.totalarealabel = new System.Windows.Forms.Label();
            this.MuralWidthUI = new System.Windows.Forms.TextBox();
            this.MuralLengthUI = new System.Windows.Forms.TextBox();
            this.MuralColorUI = new System.Windows.Forms.TextBox();
            this.MuralPriceOfPaintUI = new System.Windows.Forms.TextBox();
            this.MuralCoatsUI = new System.Windows.Forms.TextBox();
            this.MuralIlluminateUI = new System.Windows.Forms.TextBox();
            this.TotalAreaOutput = new System.Windows.Forms.TextBox();
            this.PaintingCostOutput = new System.Windows.Forms.TextBox();
            this.CoatCostOutput = new System.Windows.Forms.TextBox();
            this.LaborCostOutput = new System.Windows.Forms.TextBox();
            this.TotalCostOutput = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // Widthlabel
            // 
            this.Widthlabel.AutoSize = true;
            this.Widthlabel.Location = new System.Drawing.Point(47, 37);
            this.Widthlabel.Name = "Widthlabel";
            this.Widthlabel.Size = new System.Drawing.Size(118, 13);
            this.Widthlabel.TabIndex = 0;
            this.Widthlabel.Text = "Enter The Width (In Ft):";
            // 
            // Lengthlabel
            // 
            this.Lengthlabel.AutoSize = true;
            this.Lengthlabel.Location = new System.Drawing.Point(47, 71);
            this.Lengthlabel.Name = "Lengthlabel";
            this.Lengthlabel.Size = new System.Drawing.Size(123, 13);
            this.Lengthlabel.TabIndex = 1;
            this.Lengthlabel.Text = "Enter The Length (In Ft):";
            // 
            // Colorlabel
            // 
            this.Colorlabel.AutoSize = true;
            this.Colorlabel.Location = new System.Drawing.Point(47, 104);
            this.Colorlabel.Name = "Colorlabel";
            this.Colorlabel.Size = new System.Drawing.Size(93, 13);
            this.Colorlabel.TabIndex = 2;
            this.Colorlabel.Text = "Number Of Colors:";
            this.Colorlabel.Click += new System.EventHandler(this.label3_Click);
            // 
            // Paintlabel
            // 
            this.Paintlabel.AutoSize = true;
            this.Paintlabel.Location = new System.Drawing.Point(47, 137);
            this.Paintlabel.Name = "Paintlabel";
            this.Paintlabel.Size = new System.Drawing.Size(72, 13);
            this.Paintlabel.TabIndex = 3;
            this.Paintlabel.Text = "Price Of Paint";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(47, 201);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(169, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "Illuminate Mural? (1 = Yes 0 = No):";
            // 
            // Coatslabel
            // 
            this.Coatslabel.AutoSize = true;
            this.Coatslabel.Location = new System.Drawing.Point(47, 170);
            this.Coatslabel.Name = "Coatslabel";
            this.Coatslabel.Size = new System.Drawing.Size(125, 13);
            this.Coatslabel.TabIndex = 5;
            this.Coatslabel.Text = "Number of Coats (1 or 2):";
            // 
            // CalculateCost
            // 
            this.CalculateCost.Location = new System.Drawing.Point(65, 255);
            this.CalculateCost.Name = "CalculateCost";
            this.CalculateCost.Size = new System.Drawing.Size(75, 23);
            this.CalculateCost.TabIndex = 6;
            this.CalculateCost.Text = "Calculate!";
            this.CalculateCost.UseVisualStyleBackColor = true;
            this.CalculateCost.Click += new System.EventHandler(this.CalculateCost_Click);
            // 
            // TotalCostLabel
            // 
            this.TotalCostLabel.AutoSize = true;
            this.TotalCostLabel.Location = new System.Drawing.Point(217, 367);
            this.TotalCostLabel.Name = "TotalCostLabel";
            this.TotalCostLabel.Size = new System.Drawing.Size(58, 13);
            this.TotalCostLabel.TabIndex = 7;
            this.TotalCostLabel.Text = "Total Cost:";
            // 
            // LaborCostLabel
            // 
            this.LaborCostLabel.AutoSize = true;
            this.LaborCostLabel.Location = new System.Drawing.Point(217, 341);
            this.LaborCostLabel.Name = "LaborCostLabel";
            this.LaborCostLabel.Size = new System.Drawing.Size(61, 13);
            this.LaborCostLabel.TabIndex = 8;
            this.LaborCostLabel.Text = "Labor Cost:";
            // 
            // CoatCostLabel
            // 
            this.CoatCostLabel.AutoSize = true;
            this.CoatCostLabel.Location = new System.Drawing.Point(217, 315);
            this.CoatCostLabel.Name = "CoatCostLabel";
            this.CoatCostLabel.Size = new System.Drawing.Size(61, 13);
            this.CoatCostLabel.TabIndex = 9;
            this.CoatCostLabel.Text = "Coats Cost:";
            // 
            // PaintCostlabel
            // 
            this.PaintCostlabel.AutoSize = true;
            this.PaintCostlabel.Location = new System.Drawing.Point(217, 286);
            this.PaintCostlabel.Name = "PaintCostlabel";
            this.PaintCostlabel.Size = new System.Drawing.Size(69, 13);
            this.PaintCostlabel.TabIndex = 10;
            this.PaintCostlabel.Text = "Painting Cost";
            // 
            // totalarealabel
            // 
            this.totalarealabel.AutoSize = true;
            this.totalarealabel.Location = new System.Drawing.Point(217, 255);
            this.totalarealabel.Name = "totalarealabel";
            this.totalarealabel.Size = new System.Drawing.Size(99, 13);
            this.totalarealabel.TabIndex = 11;
            this.totalarealabel.Text = "Total Area In Sq Ft:";
            // 
            // MuralWidthUI
            // 
            this.MuralWidthUI.Location = new System.Drawing.Point(245, 37);
            this.MuralWidthUI.Name = "MuralWidthUI";
            this.MuralWidthUI.Size = new System.Drawing.Size(100, 20);
            this.MuralWidthUI.TabIndex = 12;
            // 
            // MuralLengthUI
            // 
            this.MuralLengthUI.Location = new System.Drawing.Point(245, 71);
            this.MuralLengthUI.Name = "MuralLengthUI";
            this.MuralLengthUI.Size = new System.Drawing.Size(100, 20);
            this.MuralLengthUI.TabIndex = 13;
            // 
            // MuralColorUI
            // 
            this.MuralColorUI.Location = new System.Drawing.Point(245, 104);
            this.MuralColorUI.Name = "MuralColorUI";
            this.MuralColorUI.Size = new System.Drawing.Size(100, 20);
            this.MuralColorUI.TabIndex = 14;
            // 
            // MuralPriceOfPaintUI
            // 
            this.MuralPriceOfPaintUI.Location = new System.Drawing.Point(245, 137);
            this.MuralPriceOfPaintUI.Name = "MuralPriceOfPaintUI";
            this.MuralPriceOfPaintUI.Size = new System.Drawing.Size(100, 20);
            this.MuralPriceOfPaintUI.TabIndex = 15;
            // 
            // MuralCoatsUI
            // 
            this.MuralCoatsUI.Location = new System.Drawing.Point(245, 170);
            this.MuralCoatsUI.Name = "MuralCoatsUI";
            this.MuralCoatsUI.Size = new System.Drawing.Size(100, 20);
            this.MuralCoatsUI.TabIndex = 16;
            // 
            // MuralIlluminateUI
            // 
            this.MuralIlluminateUI.Location = new System.Drawing.Point(245, 201);
            this.MuralIlluminateUI.Name = "MuralIlluminateUI";
            this.MuralIlluminateUI.Size = new System.Drawing.Size(100, 20);
            this.MuralIlluminateUI.TabIndex = 17;
            // 
            // TotalAreaOutput
            // 
            this.TotalAreaOutput.Location = new System.Drawing.Point(350, 255);
            this.TotalAreaOutput.Name = "TotalAreaOutput";
            this.TotalAreaOutput.Size = new System.Drawing.Size(100, 20);
            this.TotalAreaOutput.TabIndex = 18;
            // 
            // PaintingCostOutput
            // 
            this.PaintingCostOutput.Location = new System.Drawing.Point(350, 286);
            this.PaintingCostOutput.Name = "PaintingCostOutput";
            this.PaintingCostOutput.Size = new System.Drawing.Size(100, 20);
            this.PaintingCostOutput.TabIndex = 19;
            // 
            // CoatCostOutput
            // 
            this.CoatCostOutput.Location = new System.Drawing.Point(350, 315);
            this.CoatCostOutput.Name = "CoatCostOutput";
            this.CoatCostOutput.Size = new System.Drawing.Size(100, 20);
            this.CoatCostOutput.TabIndex = 20;
            // 
            // LaborCostOutput
            // 
            this.LaborCostOutput.Location = new System.Drawing.Point(350, 341);
            this.LaborCostOutput.Name = "LaborCostOutput";
            this.LaborCostOutput.Size = new System.Drawing.Size(100, 20);
            this.LaborCostOutput.TabIndex = 21;
            // 
            // TotalCostOutput
            // 
            this.TotalCostOutput.Location = new System.Drawing.Point(350, 367);
            this.TotalCostOutput.Name = "TotalCostOutput";
            this.TotalCostOutput.Size = new System.Drawing.Size(100, 20);
            this.TotalCostOutput.TabIndex = 22;
            // 
            // Program1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.TotalCostOutput);
            this.Controls.Add(this.LaborCostOutput);
            this.Controls.Add(this.CoatCostOutput);
            this.Controls.Add(this.PaintingCostOutput);
            this.Controls.Add(this.TotalAreaOutput);
            this.Controls.Add(this.MuralIlluminateUI);
            this.Controls.Add(this.MuralCoatsUI);
            this.Controls.Add(this.MuralPriceOfPaintUI);
            this.Controls.Add(this.MuralColorUI);
            this.Controls.Add(this.MuralLengthUI);
            this.Controls.Add(this.MuralWidthUI);
            this.Controls.Add(this.totalarealabel);
            this.Controls.Add(this.PaintCostlabel);
            this.Controls.Add(this.CoatCostLabel);
            this.Controls.Add(this.LaborCostLabel);
            this.Controls.Add(this.TotalCostLabel);
            this.Controls.Add(this.CalculateCost);
            this.Controls.Add(this.Coatslabel);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Paintlabel);
            this.Controls.Add(this.Colorlabel);
            this.Controls.Add(this.Lengthlabel);
            this.Controls.Add(this.Widthlabel);
            this.Name = "Program1";
            this.Text = "Program 1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label Widthlabel;
        private System.Windows.Forms.Label Lengthlabel;
        private System.Windows.Forms.Label Colorlabel;
        private System.Windows.Forms.Label Paintlabel;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label Coatslabel;
        private System.Windows.Forms.Button CalculateCost;
        private System.Windows.Forms.Label TotalCostLabel;
        private System.Windows.Forms.Label LaborCostLabel;
        private System.Windows.Forms.Label CoatCostLabel;
        private System.Windows.Forms.Label PaintCostlabel;
        private System.Windows.Forms.Label totalarealabel;
        private System.Windows.Forms.TextBox MuralWidthUI;
        private System.Windows.Forms.TextBox MuralLengthUI;
        private System.Windows.Forms.TextBox MuralColorUI;
        private System.Windows.Forms.TextBox MuralPriceOfPaintUI;
        private System.Windows.Forms.TextBox MuralCoatsUI;
        private System.Windows.Forms.TextBox MuralIlluminateUI;
        private System.Windows.Forms.TextBox TotalAreaOutput;
        private System.Windows.Forms.TextBox PaintingCostOutput;
        private System.Windows.Forms.TextBox CoatCostOutput;
        private System.Windows.Forms.TextBox LaborCostOutput;
        private System.Windows.Forms.TextBox TotalCostOutput;
    }
}

