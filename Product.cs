using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShoppingCart
{
    internal class Product
    {
        public int ProductId { get; set; }
        public string ProductModel { get; set; }
        public string ProductBrand { get; set; }
        public double ProductPrice { get; set; }
        public Product(int ProductId, string ProductModel,string ProductBrand,double ProductPrice)
        {
            this.ProductId = ProductId;
            this.ProductModel = ProductModel;
            this.ProductBrand = ProductBrand;
            this.ProductPrice = ProductPrice;
        }
        
    }
}
