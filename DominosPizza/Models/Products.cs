using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace DominosPizza.Models
{
    public class Products
    {
<<<<<<< 2a16dddde79a62e068ac43d43e6fcad2b3d1f3d9
        public int ProductId { get; set; }
        public string ProductName { get; set; }
        public double ProductWeight { get; set; }
        public double ProductPrice { get; set; }
        public double ProductQuantity { get; set; }

        public ICollection<Ingredients> IngredientsId { get; set; }
=======
        public int ProductsId { get; set; } 
        public string ProductName { get; set; }
        public int ProductPrice { get; set; }
        public string ProductDescription { get; set; }
        public string ProductRecipe { get; set; }
        public string ImageLink { get; set; }


>>>>>>> В процессе доделывания интерфейса реализовалась минимально работающая версия приложения.
    }
}