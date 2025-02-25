using Application.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Presentation
{
    public class Program
    {
        public void Main(String[] args)
        {
            ProductService productService = new ProductService();

            var product1 = productService.CreateProduct("Pizza", 12.99m, "Plato", 1);
            var product2 = productService.CreateProduct("Coca Cola", 1.99m, "Bebida", 2);
            var product3 = productService.CreateProduct("Pastel", 3.50m, "Postre", 1);



        }
    }
}
