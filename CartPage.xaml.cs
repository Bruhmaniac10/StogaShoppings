namespace StogaShopping;

public partial class CartPage : ContentPage
    {
        private Cart cart = new Cart();

    public CartPage()
    {
        InitializeComponent();
        BindingContext = Cart.Instance;
            if (cart != null)
                cartListView.ItemsSource = cart.CartItems;
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
            if (Application.Current.MainPage.Navigation.NavigationStack.FirstOrDefault(p => p is CartPage) == null)
            {
                await Navigation.PushAsync(new CartPage());
            }
        }


    private async void AccountClicked(System.Object sender, EventArgs e)
        {
            await Navigation.PushAsync(new AccountPage());
        }

        private async void HelpClicked(System.Object sender, EventArgs e)
        {
            await Navigation.PushAsync(new HelpPage());
        }
    }
