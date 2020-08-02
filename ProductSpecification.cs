using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Controller
{
    class ProductSpecification
    {
        private double productPrice;
        private string description;
        private int productID;

        public double ProductPrice
        {
            get => this.productPrice;
            set => this.productPrice = value;
        }

        public string Description
        {
            get => this.description;
            set => this.description = value;
        }

        public int ProductID
        {
            get => this.productID;
            set => this.productID = value;
        }

        public ProductSpecification(double productPrice, string description, int productId)
        {
            this.ProductPrice = productPrice;
            this.Description = description;
            this.ProductID = productId;
        }

        public double GetProductPrice()
        {
            return this.ProductPrice;
        }

    }
}
