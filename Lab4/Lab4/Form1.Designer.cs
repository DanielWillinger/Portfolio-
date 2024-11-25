namespace Lab4
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
            this.gpalabel = new System.Windows.Forms.Label();
            this.admissiontestlabel = new System.Windows.Forms.Label();
            this.CalculateAdmissionButton = new System.Windows.Forms.Button();
            this.GPAUI = new System.Windows.Forms.TextBox();
            this.AdmissionTestUI = new System.Windows.Forms.TextBox();
            this.AcceptedCounterTextBox = new System.Windows.Forms.TextBox();
            this.RejectedCounterTextBox = new System.Windows.Forms.TextBox();
            this.Rejectedlabel = new System.Windows.Forms.Label();
            this.AcceptedLabel = new System.Windows.Forms.Label();
            this.Decisionlabel = new System.Windows.Forms.Label();
            this.AdmissionResult = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // gpalabel
            // 
            this.gpalabel.AutoSize = true;
            this.gpalabel.Location = new System.Drawing.Point(39, 24);
            this.gpalabel.Name = "gpalabel";
            this.gpalabel.Size = new System.Drawing.Size(137, 13);
            this.gpalabel.TabIndex = 0;
            this.gpalabel.Text = "Enter Grade Point Average:";
            // 
            // admissiontestlabel
            // 
            this.admissiontestlabel.AutoSize = true;
            this.admissiontestlabel.Location = new System.Drawing.Point(39, 69);
            this.admissiontestlabel.Name = "admissiontestlabel";
            this.admissiontestlabel.Size = new System.Drawing.Size(140, 13);
            this.admissiontestlabel.TabIndex = 1;
            this.admissiontestlabel.Text = "Enter Admission Test Score:";
            // 
            // CalculateAdmissionButton
            // 
            this.CalculateAdmissionButton.Location = new System.Drawing.Point(234, 198);
            this.CalculateAdmissionButton.Name = "CalculateAdmissionButton";
            this.CalculateAdmissionButton.Size = new System.Drawing.Size(75, 23);
            this.CalculateAdmissionButton.TabIndex = 2;
            this.CalculateAdmissionButton.Text = "Admit?";
            this.CalculateAdmissionButton.UseVisualStyleBackColor = true;
            this.CalculateAdmissionButton.Click += new System.EventHandler(this.CalculateAdmissionButton_Click);
            // 
            // GPAUI
            // 
            this.GPAUI.Location = new System.Drawing.Point(209, 24);
            this.GPAUI.Name = "GPAUI";
            this.GPAUI.Size = new System.Drawing.Size(100, 20);
            this.GPAUI.TabIndex = 3;
            this.GPAUI.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // AdmissionTestUI
            // 
            this.AdmissionTestUI.Location = new System.Drawing.Point(209, 69);
            this.AdmissionTestUI.Name = "AdmissionTestUI";
            this.AdmissionTestUI.Size = new System.Drawing.Size(100, 20);
            this.AdmissionTestUI.TabIndex = 4;
            // 
            // AcceptedCounterTextBox
            // 
            this.AcceptedCounterTextBox.BackColor = System.Drawing.SystemColors.Window;
            this.AcceptedCounterTextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.AcceptedCounterTextBox.Location = new System.Drawing.Point(101, 163);
            this.AcceptedCounterTextBox.Name = "AcceptedCounterTextBox";
            this.AcceptedCounterTextBox.Size = new System.Drawing.Size(100, 20);
            this.AcceptedCounterTextBox.TabIndex = 5;
            // 
            // RejectedCounterTextBox
            // 
            this.RejectedCounterTextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.RejectedCounterTextBox.Location = new System.Drawing.Point(101, 201);
            this.RejectedCounterTextBox.Name = "RejectedCounterTextBox";
            this.RejectedCounterTextBox.Size = new System.Drawing.Size(100, 20);
            this.RejectedCounterTextBox.TabIndex = 6;
            // 
            // Rejectedlabel
            // 
            this.Rejectedlabel.AutoSize = true;
            this.Rejectedlabel.Location = new System.Drawing.Point(39, 201);
            this.Rejectedlabel.Name = "Rejectedlabel";
            this.Rejectedlabel.Size = new System.Drawing.Size(53, 13);
            this.Rejectedlabel.TabIndex = 7;
            this.Rejectedlabel.Text = "Rejected:";
            this.Rejectedlabel.Click += new System.EventHandler(this.Rejectedlabel_Click);
            // 
            // AcceptedLabel
            // 
            this.AcceptedLabel.AutoSize = true;
            this.AcceptedLabel.Location = new System.Drawing.Point(39, 163);
            this.AcceptedLabel.Name = "AcceptedLabel";
            this.AcceptedLabel.Size = new System.Drawing.Size(56, 13);
            this.AcceptedLabel.TabIndex = 8;
            this.AcceptedLabel.Text = "Accepted:";
            // 
            // Decisionlabel
            // 
            this.Decisionlabel.AutoSize = true;
            this.Decisionlabel.Location = new System.Drawing.Point(39, 123);
            this.Decisionlabel.Name = "Decisionlabel";
            this.Decisionlabel.Size = new System.Drawing.Size(101, 13);
            this.Decisionlabel.TabIndex = 9;
            this.Decisionlabel.Text = "Admission Decision:";
            // 
            // AdmissionResult
            // 
            this.AdmissionResult.Location = new System.Drawing.Point(175, 120);
            this.AdmissionResult.Name = "AdmissionResult";
            this.AdmissionResult.Size = new System.Drawing.Size(100, 20);
            this.AdmissionResult.TabIndex = 10;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(358, 239);
            this.Controls.Add(this.AdmissionResult);
            this.Controls.Add(this.Decisionlabel);
            this.Controls.Add(this.AcceptedLabel);
            this.Controls.Add(this.Rejectedlabel);
            this.Controls.Add(this.RejectedCounterTextBox);
            this.Controls.Add(this.AcceptedCounterTextBox);
            this.Controls.Add(this.AdmissionTestUI);
            this.Controls.Add(this.GPAUI);
            this.Controls.Add(this.CalculateAdmissionButton);
            this.Controls.Add(this.admissiontestlabel);
            this.Controls.Add(this.gpalabel);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label gpalabel;
        private System.Windows.Forms.Label admissiontestlabel;
        private System.Windows.Forms.Button CalculateAdmissionButton;
        private System.Windows.Forms.TextBox GPAUI;
        private System.Windows.Forms.TextBox AdmissionTestUI;
        private System.Windows.Forms.TextBox AcceptedCounterTextBox;
        private System.Windows.Forms.TextBox RejectedCounterTextBox;
        private System.Windows.Forms.Label Rejectedlabel;
        private System.Windows.Forms.Label AcceptedLabel;
        private System.Windows.Forms.Label Decisionlabel;
        private System.Windows.Forms.TextBox AdmissionResult;
    }
}

