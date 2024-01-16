using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StogaShopping
{
    public class Product
    {
        
        public int ProductId {  get; set; }

        public string Name { get; set; }

        public string Seller { get; set; }

        public double Stars { get; set; }

        public string Review { get; set; }

        public string Description { get; set; }

        public int Price {  get; set; }

        public bool Availability { get; set; }

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
}
