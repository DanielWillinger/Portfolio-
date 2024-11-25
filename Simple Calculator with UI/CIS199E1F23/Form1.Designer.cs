namespace CIS199E1F23
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
            this.amountlabel = new System.Windows.Forms.Label();
            this.uiTextbox = new System.Windows.Forms.TextBox();
            this.calcbutton = new System.Windows.Forms.Button();
            this.affordlabel = new System.Windows.Forms.Label();
            this.OutputLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // amountlabel
            // 
            this.amountlabel.AutoSize = true;
            this.amountlabel.Location = new System.Drawing.Point(29, 44);
            this.amountlabel.Name = "amountlabel";
            this.amountlabel.Size = new System.Drawing.Size(46, 13);
            this.amountlabel.TabIndex = 0;
            this.amountlabel.Text = "Amount:";
            // 
            // uiTextbox
            // 
            this.uiTextbox.Location = new System.Drawing.Point(148, 44);
            this.uiTextbox.Name = "uiTextbox";
            this.uiTextbox.Size = new System.Drawing.Size(100, 20);
            this.uiTextbox.TabIndex = 1;
            // 
            // calcbutton
            // 
            this.calcbutton.Location = new System.Drawing.Point(148, 99);
            this.calcbutton.Name = "calcbutton";
            this.calcbutton.Size = new System.Drawing.Size(75, 23);
            this.calcbutton.TabIndex = 2;
            this.calcbutton.Text = "Calculate";
            this.calcbutton.UseVisualStyleBackColor = true;
            this.calcbutton.Click += new System.EventHandler(this.calcbutton_Click);
            // 
            // affordlabel
            // 
            this.affordlabel.AutoSize = true;
            this.affordlabel.Location = new System.Drawing.Point(29, 158);
            this.affordlabel.Name = "affordlabel";
            this.affordlabel.Size = new System.Drawing.Size(80, 13);
            this.affordlabel.TabIndex = 3;
            this.affordlabel.Text = "You can afford:";
            // 
            // OutputLabel
            // 
            this.OutputLabel.AutoSize = true;
            this.OutputLabel.Location = new System.Drawing.Point(145, 158);
            this.OutputLabel.Name = "OutputLabel";
            this.OutputLabel.Size = new System.Drawing.Size(0, 13);
            this.OutputLabel.TabIndex = 4;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.OutputLabel);
            this.Controls.Add(this.affordlabel);
            this.Controls.Add(this.calcbutton);
            this.Controls.Add(this.uiTextbox);
            this.Controls.Add(this.amountlabel);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label amountlabel;
        private System.Windows.Forms.TextBox uiTextbox;
        private System.Windows.Forms.Button calcbutton;
        private System.Windows.Forms.Label affordlabel;
        private System.Windows.Forms.Label OutputLabel;
    }
}

