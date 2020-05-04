using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Lab01.Models
{
    public class ProductToCart
    {
        public int ProductPrice { get; set; }
        public int ProductQuantity { get; set; }
        public ProductModel ProductModel { get; set; }

        
    }
}
