//A1032
//CIS-199-50-4238
//11/12/2023
//Takes user input and creates a sqaure of stars based on it
//lab 7
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab7
{
    internal class Program
    {
       
        static void Main(string[] args)
        {   //Holds user input
            int numStars;

            Console.WriteLine("Enter the number of Stars: ");
            //if else for user input
            if (int.TryParse(Console.ReadLine(), out numStars) && numStars > 0 )
            {//calls method
                ShowSqaureOfStars(numStars);
            }

            else
                Console.WriteLine("Enter a number above 0 ");
                Console.ReadLine();
        }      
       
        //method to write the block of stars
        static void ShowSqaureOfStars(int numStars)
        {
            for (int i = 0; i < numStars; i++)
            {
                for (int x = 0; x < numStars; x++)
                {
                    Console.Write("*");
                }
                Console.WriteLine();
                
            }
            //keeps program open at end
            Console.ReadLine();
        }
        
    }
}
