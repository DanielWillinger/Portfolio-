// Grading ID: A1032
// Program 1
// Sept 28th 2023
// Cis 199-50-4238
// This Program Creates a GUI to calcualte Mural cost.

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Program_1
{
    public partial class Program1: Form
    {
        public Program1()
        {
            InitializeComponent();
        }
        // Event Handler for Calculation
        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void Output18_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void CalculateCost_Click(object sender, EventArgs e)

        {// These Variables will hold User Input
            double Width;
            double Length;
            int NumberOfColors;
            double PriceOfPaint;
            int Coats;
            int Illuminate;
            double Area;
            //This makes user input into a double or int
            Width = double.Parse(MuralWidthUI.Text);
            Length = double.Parse(MuralLengthUI.Text);
            NumberOfColors = int.Parse(MuralColorUI.Text);
            PriceOfPaint = double.Parse(MuralPriceOfPaintUI.Text);
            Coats = int.Parse(MuralCoatsUI.Text);
            Illuminate = int.Parse(MuralIlluminateUI.Text);
            //This area does the Calculations
            Area = Length * Width;
            double Labor = (Illuminate * 75.00) + (Area * 6.50);
            double Paint = (Area * PriceOfPaint * (1.1)) + (NumberOfColors * 8.50);
            double Coat = Coats * 10.00;
            double Total = Coat + Paint + Labor;

            TotalAreaOutput.Text = $"{Area:F2}";
            PaintingCostOutput.Text = $"{Paint:F2}";
            CoatCostOutput.Text = $"{Coat:F2}";
            LaborCostOutput.Text = $"{Labor:F2}";
            TotalCostOutput.Text = $"{Total:F2}";



        }
    }
}
