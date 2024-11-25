using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CIS199E1F23
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void calcbutton_Click(object sender, EventArgs e)
        {
            double PriceInput;
            PriceInput = Double.Parse(uiTextbox.Text);

            if (PriceInput >= 5 && PriceInput <= 10)
                OutputLabel.Text = ("Basic Plan");
            else if (PriceInput >= 11 && PriceInput <= 20)
                OutputLabel.Text = ("Standard Plan");
            else if (PriceInput >= 21 && PriceInput <= 30)
                OutputLabel.Text = ("Premium Plan");
            else if (PriceInput >= 31 && PriceInput <= 45)
                OutputLabel.Text = ("Family Plan");
            else if (PriceInput >= 46 && PriceInput <= 60)
                OutputLabel.Text = ("Ultra Plan");
            else if (PriceInput >= 61 && PriceInput <= 75)
                OutputLabel.Text = ("VIP Membership");
        }
    }
}
