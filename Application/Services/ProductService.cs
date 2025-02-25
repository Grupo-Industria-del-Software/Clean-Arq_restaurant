using Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Services
{
    public class ProductService
    {
        public ProductRecord CreateProduct(string name, decimal price, string category, int quantity)
        {
            var product = new Product(name, price, category);
            return new ProductRecord(product, quantity);
        }
    }
}
