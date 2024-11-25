using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace Program4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Product product1 = new Product("Lays","Dorito's", 798744, "Chip", 4.99, 8);
            Product product2 = new Product("Pepsi-Co", "Dr.Pepper", 789512, "Beverage", 1.00, 1);
            Product product3 = new Product("Coca-Cola", "Coke", 123456, "Beverage", 2.00, 19);
            Product product4 = new Product("Krispy Kreme", "Kreme Filled", 654987, "Doughnut", 7.00, 18);
            Product product5 = new Product("Kellogs", "Frosted Flakes", 654321, "Cereal", 6.00, 10);

            product4.InStock();
            product5.InStock();

            Product[] products = { product1, product2, product3, product4, product5 };

            WriteOut(products);
            
        }

        static void WriteOut(Product[] Products) 
        { 
            foreach (Product p in Products) 
            {
                Console.WriteLine(p.ToString());
            }

           Console.ReadLine();
        }
        
    }
}
