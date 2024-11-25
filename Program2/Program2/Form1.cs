// A1032
// Cis 199 50 4238
// 10/21/2023
//This program will calculate health and car insurance costs based on a variety of inputs from a user.
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

namespace Program2
{
    public partial class InsuranceForm : Form
    {
        

        public InsuranceForm()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void calculatepremiumbutton_Click(object sender, EventArgs e)
        {
            //Constants set for calcualtions
            const int MONTH = 12;
            const double HEALTH_MED = 160.00;
            const double HEALTH_DEN = 20.00;
            const double HEALTH_VIS = 30.00;
            const double CAR_FUL = 110.00;
            const double CAR_LIA = 50.00;
            const double SMOKE_PRE = 70.00;
            const double AGE_PRE = 25.00;
            const double CARVALUE_RATEDISCOUNT = 0.12;
            const double ACCIDENT_PRE = 0.20;

            // Variables to do calculations, to hold placeholder 0 values, store user input and to hold results.
            int Age;
            int CarValue;
            double healthCoverageRate;
            double carCoverageRate = 0;
            bool MedicalCoverage;
            double totalHealthCost = 0;
            double total;

            
            // Gets user input for age
            if (int.TryParse(AgetextBox.Text, out Age) && Age >= 16 && Age < 120) { }
            else
            {
                MessageBox.Show("You must be at least 16 Years old.");
            }
            // Gets user input for car value
            if (int.TryParse(carvaluetextBox.Text, out CarValue) && CarValue >= 0) { }
            else
            {
                MessageBox.Show("Invalid Car Value Entered.");
            }
            //Sets values for health coverage based on user input
            if (healthcomboBox.SelectedIndex >= 0)
            {
                if (healthcomboBox.Text == "Medical")
                {
                    healthCoverageRate = HEALTH_MED;
                    MedicalCoverage = true;
                }
                else if (healthcomboBox.Text == "Dental")
                {
                    healthCoverageRate = HEALTH_DEN;
                    MedicalCoverage = false;
                }
                else if (healthcomboBox.Text == "Vision")
                {
                    healthCoverageRate = HEALTH_VIS;
                    MedicalCoverage = false;
                }
                else
                {
                    healthCoverageRate = 0;
                    MedicalCoverage = false;
                }
                //Calculates cost of smoking only for users that have full medical coverage
                if (MedicalCoverage == true && smokeyesradioButton.Checked)
                {
                    totalHealthCost = healthCoverageRate + SMOKE_PRE;
                }
                else
                {
                    totalHealthCost = healthCoverageRate;
                }
            }
            else
            {
                MessageBox.Show("Please enter Preferred Health Coverage.");
            }
            // Sets and calculates car coverage rate based on coverage choice, age, and accident history. 
            if (insurancecomboBox.SelectedIndex >= 0)
            {
                if (insurancecomboBox.Text == "Full")
                {
                    carCoverageRate = CAR_FUL;

                    if(Age < 21)
                    {
                        carCoverageRate = carCoverageRate + AGE_PRE;
                    }
                    if (CarValue < 15000)
                    {
                        carCoverageRate = carCoverageRate - (carCoverageRate * CARVALUE_RATEDISCOUNT);
                    }
                    if (accidentyesradioButton.Checked)
                    {
                        carCoverageRate = carCoverageRate + (carCoverageRate * ACCIDENT_PRE);
                    }
                }

                else if (insurancecomboBox.Text == "Liability")
                {
                    carCoverageRate = CAR_LIA;

                    if (Age < 21)
                    {
                        carCoverageRate = carCoverageRate + AGE_PRE;
                    }
                    if (CarValue < 15000)
                    {
                        carCoverageRate = carCoverageRate - (carCoverageRate * CARVALUE_RATEDISCOUNT);
                    }
                    if (accidentyesradioButton.Checked)
                    {
                        carCoverageRate = carCoverageRate + (carCoverageRate * ACCIDENT_PRE);
                    }
                }
            }
            // Sets insurance cost to 0 if no coverage is wanted
                else if (insurancecomboBox.Text == "None")
                {
                    carCoverageRate = 0;
                }

               
            
            else
            {
                MessageBox.Show("Please enter Preferred Car Insurance Coverage.");
            }
            // Final total calculation
            total = (totalHealthCost * MONTH) + (carCoverageRate * MONTH);
            //Output to textboxes in currency format.
            healthcosttextBox.Text = (totalHealthCost * MONTH).ToString("C2");
            carcosttextBox.Text = (carCoverageRate * MONTH).ToString("C2");
            totaltextBox.Text = total.ToString("C2");
        }
        
    }
}
