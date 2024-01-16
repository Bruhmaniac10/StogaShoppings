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

        private void AddSampleProducts()
        {
            for (int i = 1; i <= 20; i++)
            {
                var newProduct = new Product
                {
                    Name = $"Sample Product {i}",
                    Price = 10.00 + i // You can adjust the pricing logic as needed
                };

                _ = productDatabase.SaveProductAsync(newProduct);
            }
        }
    }
}
