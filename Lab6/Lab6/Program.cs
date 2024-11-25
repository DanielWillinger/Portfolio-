//A1032
//10/29/2023
//This program uses a series of for loops to make 4 patterns
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Lab6
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Constant to set a max of 10 rows
            const int MAX_ROW = 10;

            Console.WriteLine("Pattern A");
            for (int row = 1; row <= MAX_ROW; ++row) 
            {
                for (int star = 1; star <= row; ++star) 
                Console.Write("*");
                Console.WriteLine();
            }
            Console.WriteLine("Pattern B");
            for (int row = 20; row >= MAX_ROW; --row)
            {
                for (int star = 10; star <= row; ++star)
                    Console.Write("*");
                Console.WriteLine();
            }
            Console.WriteLine("Pattern C");
            for (int row = 1; row <= MAX_ROW; ++row)
            {
                for (int spaces = 2; spaces <= row; ++spaces)
                    Console.Write(" ");
                for (int star = 10; star >= row; --star) 
                    Console.Write("*");
                    Console.WriteLine();
            }
            Console.WriteLine("Pattern D");
            for (int row = 1; row <= MAX_ROW; ++row)
            {
                for (int spaces = 9; spaces >= row; --spaces)
                    Console.Write(" ");
                for (int star = 1; star <= row; ++star)
                    Console.Write("*");
                Console.WriteLine();
            }

            Console.ReadKey();
        }
        
    }
    
     
}
