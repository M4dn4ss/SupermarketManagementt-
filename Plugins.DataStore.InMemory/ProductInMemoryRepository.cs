using CoreBusiness;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UseCases.DataStorePluginInterfaces;

namespace Plugins.DataStore.InMemory
{
    public class ProductInMemoryRepository : IProductRepository
    {
        private List<Product> products;

        public ProductInMemoryRepository()
        {
            // Init with default values
            products = new List<Product>()
            {
                new Product {ProductId = 1, CategoryId = 1, Name = "Iced Tea",Quantity = 100, Price = 1.99},
                new Product {ProductId = 2, CategoryId = 1, Name = "Canada Dry",Quantity = 200, Price = 1.99},
                new Product {ProductId = 3, CategoryId = 2, Name = "Whole Wheat Bread",Quantity = 300, Price = 1.50},
                new Product {ProductId = 3, CategoryId = 2, Name = "White Bread",Quantity = 300, Price = 1.50},
            };
        }

        public void AddProduct(Product product)
        {
            if (products.Any(x => x.Name.Equals(category.Name, StringComparison.OrdinalIgnoreCase))) return;

            if (products != null && products.Count > 0)
            {
                var maxId = products.Max(x => x.CategoryId);
                category.CategoryId = maxId + 1;
            }
            else
            {
                category.CategoryId = 1;
            }

            categories.Add(category);
        }

        public IEnumerable<Product> GetProducts()
        {
            return products;
        }
    }
}
