using System;
using System.Collections.ObjectModel;
using System.Linq;

namespace StogaShopping
{
    public class ProductsViewModel
    {
        public ObservableCollection<Product> Products { get; set; }

        public ProductsViewModel()
        {
            // Initialize your Products collection with data from your database
            Products = new ObservableCollection<Product>
            {
                new Product { ProductId = 1, Name = "Product 1", Seller = "Seller A", Price = 50, Description = "Description 1", Availability = true },
                new Product { ProductId = 2, Name = "Product 2", Seller = "Seller B", Price = 30, Description = "Description 2", Availability = false },
            };

            // Shuffle the products randomly
            Random rand = new Random();
            Products = new ObservableCollection<Product>(Products.OrderBy(p => rand.Next()));
        }
    }
}
