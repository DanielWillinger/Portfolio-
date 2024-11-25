//Grading ID: A1032
//Lab 4
//October 1st 2023
//Cis 199-50-4238
//This program will determine admisson based upon GPA and Admission test scores.
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics.Eventing.Reader;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;



namespace Lab4
{
    public partial class Form1 : Form
    {
        //Counter Variable for accpeted
        int AcceptedCounter = 0;
        //Counter Variable for Rejected
        int RejectedCounter = 0;

        public Form1()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void Rejectedlabel_Click(object sender, EventArgs e)
        {

        }

        private void CalculateAdmissionButton_Click(object sender, EventArgs e)
        {
            //Holds GPA user input
            double GPA;
            //Holds Admission Score user input
            int AdmissionScore;

            //Try Parse to get user input and to ask for valid input if one is not given
            if (double.TryParse(GPAUI.Text, out GPA)) {

            }
            else
            {
                MessageBox.Show("Enter Valid Double.");
            }
            //Try Parse to get user input and to ask for valid input if one is not given
            if (int.TryParse(AdmissionTestUI.Text, out AdmissionScore))
            {

            }
            else
            {
                MessageBox.Show("Enter Valid Integer.");
            }
            //Calculation for Admission and adding to counter
            if (GPA >= 3.0 && AdmissionScore >= 60 || AdmissionScore >= 80)
            {
                AcceptedCounter = AcceptedCounter + 1;
                AdmissionResult.Text = $"Accepted";
            }
            else
            {
                RejectedCounter = RejectedCounter + 1;
                AdmissionResult.Text = $"Rejected";
            }
            //Puts counter value in Text box
            AcceptedCounterTextBox.Text = $"{AcceptedCounter}";
            RejectedCounterTextBox.Text = $"{RejectedCounter}";
            


        }
    }
}
