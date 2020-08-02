using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Controller
{
    class SalesLineItem
    {
        private int quantity;
        private ProductSpecification product;

        public int Quantity
        {
            get => this.quantity;
            set => this.quantity = value;
        }

        public ProductSpecification Product
        {
            get => this.product;
            set => this.product = value;
        }
        public SalesLineItem(int quantity, ProductSpecification product)
        {
            this.Quantity = quantity;
            this.Product = product;

        }

        public double GetSubTotal()
        {
            double subTotal = 0;
            subTotal = (this.Quantity) * (this.Product.GetProductPrice());
            return subTotal;
        }

    }
}
