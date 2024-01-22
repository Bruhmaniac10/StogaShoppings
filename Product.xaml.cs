namespace StogaShopping
{
    public partial class Product : ContentPage
    {

        public int ProductId { get; set; }

        public string Name { get; set; }

        public string Seller { get; set; }

        public double Stars { get; set; }

        public string Review { get; set; }

        public string Description { get; set; }

        public int Price { get; set; }

        public bool Availability { get; set; }
        public Product()
        {
            InitializeComponent();
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
            //((Product)BindingContext).ApplyFilters(minPrice, maxPrice, seller, descriptionKeywords, features);
        }
        private void AddToCartButton_Clicked(object sender, EventArgs e)
        {
            
        }
    }
    
    
}