using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.AccessControl;
using System.Text;
using System.Threading.Tasks;

namespace Bike
{
    public class Bike
    {

        //#1 - Put needed backing fields here. Remember: Some properties may be
        // auto-implemenetd so only create backing fields for ones needed
        private int bikeID;
        private double bikePrice;


        public string BikeName
        {get; set;
            // #2 - Put your code here to get/set accessors. May be auto-implemented.
        }
        public string BikeRenter
        {get;set;
            // #3 - Put your code here to get/set accessors. May be auto-implemented.
        }
        public string BikeType
        {get;set;
            // #4 - Put your code here to get/set accessors. May be auto-implemented.
        }
        public Bike (string bike, string renter, string type)
        {
            BikeName = bike;
            BikeRenter = renter;
            BikeType = type;
        }
        public int BikeID
        {get { return bikeID; } set { if(bikeID < 99999 && bikeID > 1) { } else { bikeID = 00000; }; }
            // #5 - Put your code here to get/set accessors. Set must validate.
            

        }
        public double BikePrice
        { get { return bikePrice; } set { if(bikePrice > 0) { } else { bikePrice = 0.00; }; }
            // #6 - Put your code here to get/set accessors. Set must validate.
            

        }

        public Bike(string bikeName, int bikeID, double bikePrice, string bikeRenter, string bikeType)
        {
            // #7 - Put your code here for constructor. Be sure your parameters get validated through properties
            BikeName = bikeName;
            BikeID = bikeID;
            BikePrice = bikePrice;
            BikeType = bikeType;
            BikeRenter = bikeRenter;
            
        }
        private bool isElectric;

        public void IsNotElectricBike()
        {   // #8 - Put your code here to determine if the bike is not electric
            isElectric = false;
        }
        public void IsElectricBike()
        {   // #9 Put your code here to determine if the bike is electric
            isElectric = true;
        }
        public bool IsElectric()
        {
            // #10 - Put your code here to determine if the bike is electric or not
            if (isElectric) return true;
            else return false;
        }
        public override string ToString()
        {
            // #11 - Put your code here to return a string that
            // displays the properties using string interpolation
            return String.Format($"Bike Name: {BikeName}\n" +
                                 $"Bike ID: {BikeID}\n" +
                                 $"Bike Price: {BikePrice:C}\n" +
                                 $"Bike Renter: {BikeRenter}\n" +
                                 $"Electric Bike?: {isElectric}");
            
        }
    }
}
