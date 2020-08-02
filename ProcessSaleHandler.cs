using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Controller
{
    class ProcessSaleHandler
    {
        //This is one of the controller we have designed for processing sale related operations. All these are the operations related to systems operations.
       
        public void MakeNewSale(List<SalesLineItem> salesLineItems)
        {
            Console.WriteLine("New Sale has been initiated");
            EnterItem(salesLineItems);
            Console.WriteLine("Sale is completed and Here is the receipt:");
            
        }

        public void EnterItem(List<SalesLineItem> salesLineItems)
        {
            Sale newSale = new Sale(salesLineItems); ;
            foreach (SalesLineItem item in salesLineItems)
            {
                if (salesLineItems.Contains(item))
                {
                    Console.WriteLine("Product id matched");
                    Console.WriteLine("Enter the product and process the sale!");
                    newSale = new Sale(salesLineItems);
                    Console.WriteLine("Products entry successful. Please process the payment for the sale.");

                }
                
            }
            MakePayment(newSale.getTotal());

        }

        public void MakePayment(double total)
        {
            Console.WriteLine("Making payment.");
            Console.WriteLine("Payment successful for the amount of: {0}",total);

        }

        
    }
}
