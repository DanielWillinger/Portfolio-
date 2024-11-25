using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Program4
{
    public class Product
    {
        string SupplierName;
        string ProductName;
        string ProductType;
        string supplierName { get; set; }
       string productName { get; set; }
        private int productID;
       public int ProductID { get { return productID; } 
         set 
         { 
         if (ProductID > 100000 && ProductID < 1000000) { }
         else
         {
             ProductID = 0;
         }

         }
     }

       string productType { get; set; }

        private double productPrice;
       public double ProductPrice
        { get { return productPrice; }
            set { 
                 if (ProductPrice < 0)
                {
                    ProductPrice = 0;
                }
            }
        }
        private int aisle;

       public int  Aisle { get { return aisle; } set 
            {

                if (Aisle < 1 && Aisle > 20)
                {
                    Aisle = 0;
                }
            } }
       bool InStockStatus;

        public Product(string SupplierName,
        string ProductName,
        int ProductID,
        string ProductType,
        double ProductPrice,
        int Aisle)
        {
            

            supplierName = SupplierName;
            productName = ProductName;
            productID = ProductID;
            productType = ProductType;
            aisle = Aisle;
            productPrice = ProductPrice;
        }

        public void InStock() { InStockStatus = true; }
        public void OutofStock() { InStockStatus = false; }

        public  override string ToString()
        {
            return String.Format($"Supplier's Name: {supplierName}\n" +
                $"Product Name: {productName}\n" +
                $"Product ID: {ProductID}\n" +
                $"Product Type: {productType}\n" +
                $"Product Price: {ProductPrice}\n" +
                $"Aisle: {Aisle}\n" +
                $"In Stock: {InStockStatus}\n");
        }

    }
}
