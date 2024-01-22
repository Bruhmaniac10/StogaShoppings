namespace StogaShopping;

public partial class SellPage : ContentPage
{
    private ProductPage productPage;

    public SellPage()
    {
        InitializeComponent();
    }
    private async void ShoppingClicked(System.Object sender, EventArgs e)
    {
        await Navigation.PushAsync(new ShoppingPage());
    }

    private async void MusicClicked(System.Object sender, EventArgs e)
    {
        await Navigation.PushAsync(new MusicDisplay());
    }

    private async void DealsClicked(System.Object sender, EventArgs e)
    {
        await Navigation.PushAsync(new DealsPage());
    }

    private async void SellClicked(System.Object sender, EventArgs e)
    {
        await Navigation.PushAsync(new SellPage());
    }
    private async void CartClicked(System.Object sender, EventArgs e)
    {
        await Navigation.PushAsync(new CartPage());
    }

    private async void AccountClicked(System.Object sender, EventArgs e)
    {
        await Navigation.PushAsync(new AccountPage());
    }

    private async void HelpClicked(System.Object sender, EventArgs e)
    {
        await Navigation.PushAsync(new HelpPage());
    }

    private void OnProductAddClicked(System.Object sender, EventArgs e)
    {

        string productID = IDInfoEntry.Text;
        string productName = productNameEntry.Text;
        string sellerName = sellerNameEntry.Text;
        string priceText = priceEntry.Text;
        string starsText = starsEntry.Text;
        string review = reviewEntry.Text;
        string availabilityText = availibilityEntry.Text;
        string details = detailsEntry.Text;
        string features = featuresEntry.Text;
        string email = emailEntry.Text;
        string phoneNumber = phoneNumberEntry.Text;
        string paymentInfo = paymentInfoEntry.Text;


        if (int.TryParse(priceText, out int price) && int.TryParse(starsText, out int stars))
        {

            Product newProduct = new Product()
            {
                ProductId = !string.IsNullOrEmpty(productID) ? int.Parse(productID) : 0,
                Name = productName,
                Seller = sellerName,
                Price = price,
                Stars = stars,
                Review = review,
                Availability = !string.IsNullOrEmpty(availabilityText) ? bool.Parse(availabilityText) : false,

            };


            productPage.AddProduct(newProduct);


            Navigation.PopAsync();
        }
        else
        {

            DisplayAlert("Error", "Invalid price or stars. Please enter valid integers.", "True or False Only");
        }
    }

}

