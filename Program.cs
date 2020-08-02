using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Controller
{
    class Program
    {
        static void Main(string[] args)
        {
            ProductSpecification product1 = new ProductSpecification(4.99, "Milk", 48785);
            ProductSpecification product2 = new ProductSpecification(5.78, "Tomatoes", 523222);
            ProductSpecification product3 = new ProductSpecification(11.23, "Rice", 82474);
            ProductSpecification product4 = new ProductSpecification(5.89, "Yogurt", 33742);
            ProductSpecification product5 = new ProductSpecification(3.45, "eggs", 98088);

            SalesLineItem salesLineItem1 = new SalesLineItem(4, product2);
            SalesLineItem salesLineItem2 = new SalesLineItem(2, product3);
            SalesLineItem salesLineItem3 = new SalesLineItem(3, product4);
            SalesLineItem salesLineItem4 = new SalesLineItem(1, product5);
            SalesLineItem salesLineItem5 = new SalesLineItem(5, product1);

            List<SalesLineItem> newSale = new List<SalesLineItem>();
            newSale.Add(salesLineItem1);
            newSale.Add(salesLineItem2);
            newSale.Add(salesLineItem3);
            newSale.Add(salesLineItem4);
            newSale.Add(salesLineItem5);

            Sale sale1 = new Sale(newSale);
            ProcessSaleHandler processSale = new ProcessSaleHandler();
            processSale.MakeNewSale(newSale);

            Console.WriteLine("------ Receipt ---------------------------");
            Console.WriteLine("You have purchased the following items:");
            Console.WriteLine("------------------------------------------");
            Console.WriteLine("Product name\t\t\tQuantity");
            Console.WriteLine("------------------------------------------");
            Console.WriteLine("{0}\t\t\t{1}", salesLineItem1.Product.Description, salesLineItem1.Quantity);
            Console.WriteLine("{0}\t\t\t\t{1}", salesLineItem2.Product.Description, salesLineItem2.Quantity);
            Console.WriteLine("{0}\t\t\t\t{1}", salesLineItem3.Product.Description, salesLineItem3.Quantity);
            Console.WriteLine("{0}\t\t\t\t{1}", salesLineItem4.Product.Description, salesLineItem4.Quantity);
            Console.WriteLine("{0}\t\t\t\t{1}", salesLineItem5.Product.Description, salesLineItem5.Quantity);
            Console.WriteLine("------------------------------------------");
            Console.WriteLine("Grand total is : {0}", sale1.getTotal());


            Console.WriteLine();

            Console.ReadLine();

        }
    }
}
