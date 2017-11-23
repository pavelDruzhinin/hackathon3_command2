using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace DominosPizza.Models
{
    public class Products
    {
        public int ProductsId { get; set; } 
        public string ProductName { get; set; }
        public int ProductPrice { get; set; }
        public string ProductDescription { get; set; }
        public string ProductRecipe { get; set; }
        public string ImageLink { get; set; }


    }
}