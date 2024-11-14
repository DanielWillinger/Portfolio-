//A1032
//11/11/2023
//Cis 199-50-4238
// This program will be used to caluclate contract prices for shipping
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

namespace Program3
{
    public partial class ContractCalculator : Form
    {
        public ContractCalculator()
        {
            InitializeComponent();
        }

        private void calculatebutton_Click(object sender, EventArgs e)
        {   //holds length of contract and savings based on length
            int lengthUI, savings = 0;
            //holds final total, discount as a decimal, and contract price based on businesses
            double discount = 0, contractPrice = 0, total = 0;
            // Bools to make sure program doesn't run without required information
            bool providerSelected = false, businessSelected = false, validContractLength = false;


            // Arrays provided for the calculations
            string[] shippingProviderLookup = { "USPS", "DHL", "FedEx", "UPS" };
            double[] discountLookup = { 0.22, 0.18, 0.19, 0.20 };
            string[] businessLookup = { "John's Books", "Office Supplies", "J.B. Car Parts", "Gevalia Coffee", "Ceylon Tea", "My Footwear" };
            int[] contractPriceLookup = { 50000, 85000, 60000, 75000, 95000, 55000 };
            string[] contractLengthLookup = { "0", "1", "2", "3", "4", "5", "6", "7", "8", "9", "10" };
            int[] savingLookup = { 0, 0, 10000, 10000, 10000, 20000, 20000, 20000, 30000, 30000, 30000 };
            //Sets bool true and message box if none is selected
            if (providercomboBox.SelectedIndex >= 0) { providerSelected = true; }
            else MessageBox.Show("Please Select A Provider.");
            //Sets bool true and message box if none is selected
            if (businesscomboBox.SelectedIndex >= 0) { businessSelected = true; }
            else MessageBox.Show("Please Select A Business.");
            //Sets bool true and message box if none or invalid number is entered.
            if (int.TryParse(contracttextBox.Text, out lengthUI) && lengthUI >= 0 && lengthUI <= 10) { validContractLength = true; }
            else MessageBox.Show("Please enter a Contract Length between 0 and 10.");
            //If statement to test if all required information is provided before program runs
            if (providerSelected == true && businessSelected == true && validContractLength == true)
            {   //Searching the array and setting result to textbox while setting discount to a double
                for (int i = 0; i < shippingProviderLookup.Length; i++)
                {
                    if (providercomboBox.Text == shippingProviderLookup[i])
                    {
                        shippingprovidertextBox.Text = shippingProviderLookup[i];

                        discount = discountLookup[i];
                    }
                }
                //Searching array and setting text box to contract price
                for (int i = 0; i < businessLookup.Length; i++)
                {
                    if (businesscomboBox.Text == businessLookup[i])
                    {
                        initialpricetextBox.Text = contractPriceLookup[i].ToString("C2");
                        //holds contract price for later calculations
                        contractPrice = contractPriceLookup[i];
                    }
                }
                //Searching array  and setting savings to a text box
                for (int i = 0; i < contractLengthLookup.Length; i++)
                {
                    if (contracttextBox.Text == contractLengthLookup[i])
                    {
                        lengthtextBox.Text = savingLookup[i].ToString("C2");
                        //set to savings to be used in later calculations
                        savings = savingLookup[i];
                    }
                }
            }
            //Final calculations/formating/textbox filling
            double companyDiscount = discount * contractPrice;
            discounttextBox.Text = companyDiscount.ToString("C2");
            total = (contractPrice - (contractPrice * discount)) - savings;
            finalpricetextBox.Text = total.ToString("C2");
        }
    }
}
