using System;
using System.Collections.ObjectModel;
using System.Linq;

namespace StogaShopping
{
    public class ShoppingPage
    {
        public ObservableCollection<Product> Products { get; set; }

        public ShoppingPage()
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
		private void FilterButton_Clicked(object sender, EventArgs e)
		{
    // Retrieve user inputs from entry fields
    int minPrice = int.TryParse(minPriceEntry.Text, out int minPriceResult) ? minPriceResult : 0;
    int maxPrice = int.TryParse(maxPriceEntry.Text, out int maxPriceResult) ? maxPriceResult : int.MaxValue;
    string seller = sellerEntry.Text;
    string descriptionKeywords = descriptionEntry.Text;
    string features = featuresEntry.Text;

    // Apply filters to the view model
    ((ProductsViewModel)BindingContext).ApplyFilters(minPrice, maxPrice, seller, descriptionKeywords, features);
}
public void ApplyFilters(int minPrice, int maxPrice, string seller, string descriptionKeywords, string features)
{
    var filteredProducts = originalProducts
        .Where(p =>
            p.Price >= minPrice &&
            p.Price <= maxPrice &&
            (string.IsNullOrEmpty(seller) || p.Seller.Contains(seller, StringComparison.OrdinalIgnoreCase)) &&
            (string.IsNullOrEmpty(descriptionKeywords) || p.Description.Contains(descriptionKeywords, StringComparison.OrdinalIgnoreCase)) &&
            (string.IsNullOrEmpty(features) || p.Features.Contains(features, StringComparison.OrdinalIgnoreCase))
        )
        .ToList();

    Products.Clear();
    foreach (var product in filteredProducts)
    {
        Products.Add(product);
    }
}

    }
}
