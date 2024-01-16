namespace StogaShopping
{
    public partial class ProductDetailPage : ContentPage
    {
        private Product selectedProduct;

        Label productNameLabel, productPriceLabel;

        public ProductDetailPage(Product product)
        {
            InitializeComponent();

            productNameLabel = new Label();
            productPriceLabel = new Label();
            Content = new StackLayout
            {
                Margin = new Thickness(20),
                Children = {
                    new Label { Text = "Product Details", FontSize = 20, FontAttributes = FontAttributes.Bold, Margin = new Thickness(0, 0, 0, 10) },
                    productNameLabel,
                    productPriceLabel
                }
            };

            selectedProduct = product;
            DisplayProductDetails();
            AddSampleProducts();
        }

        private void DisplayProductDetails()
        {
            productNameLabel.Text = $"Name: {selectedProduct.Name}";
            productPriceLabel.Text = $"Price: {selectedProduct.Price:C}";
            // Add more UI elements and details as needed
        }

       private void AddSampleProductsWithPricesAndBrands()
        {
            var products = new List<Product>
            {
                new Product { Name = "Smartphone", Brand = "Samsung", Price = 299.99 },
                new Product { Name = "Laptop", Brand = "Dell", Price = 799.99 },
                new Product { Name = "Headphones", Brand = "Sony", Price = 149.99 },
                new Product { Name = "Desk Chair", Brand = "IKEA", Price = 89.99 },
                new Product { Name = "Backpack", Brand = "Nike", Price = 39.99 },
                new Product { Name = "Coffee Maker", Brand = "Keurig", Price = 79.99 },
                new Product { Name = "Fitness Tracker", Brand = "Fitbit", Price = 129.99 },
                new Product { Name = "Bluetooth Speaker", Brand = "JBL", Price = 59.99 },
                new Product { Name = "Wireless Mouse", Brand = "Logitech", Price = 24.99 },
                new Product { Name = "External Hard Drive", Brand = "Western Digital", Price = 99.99 }
            };

            foreach (var product in products)
            {
                _ = productDatabase.SaveProductAsync(product);
            }
        }
    }
}
