//A1032
//Cis 199 50 4238
//Lab 5 10/16/2023
//This program will add temps together and output their mean. 
using System;
using System.Collections.Generic;
using System.Diagnostics.Eventing.Reader;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter Temperature from -20 to 130 (999 to stop/Calculate)");
            //These set constants to use in my conditional statements
            const int Min_Temp = -20;
            const int Max_Temp = 130;
            //Holds User input and variables to be used in calculations
            double Temp;
            int loopCount = 0;
            double sumTemp = 0;
            double meanTemp = 0;
            //Holds true false for if conditional
            bool validTemp;

            string userTempI = Console.ReadLine();
            
            validTemp = double.TryParse(userTempI, out Temp) && Temp >= Min_Temp && Temp >= Max_Temp || Temp == 999;
            //Loop so program keeps going and ends when 999 is entered
                while (Temp != 999)
            {
                if (validTemp == true)
                {
                    loopCount++;
                    sumTemp = Temp + sumTemp;
                    meanTemp = sumTemp / loopCount;
                }
                else
                {
                    Console.WriteLine("InValid Temperatures are from -20 to 130. Please Reenter temperature");
                }
                //Gets additional user input
                Console.WriteLine("Enter Temperature from -20 to 130 (999 to stop)");
                userTempI = Console.ReadLine();
                validTemp = double.TryParse(userTempI, out Temp) && Temp > Min_Temp && Temp < Max_Temp || Temp == 999;
            }
                //Output lines
            Console.WriteLine($"You Entered {loopCount} valid Temperatures.");
            Console.WriteLine($"The mean temperature is {Math.Round(meanTemp,2)}");
            Console.ReadKey();

        }
    }
}
