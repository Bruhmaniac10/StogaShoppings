namespace StogaShopping;

public partial class DealsPage : ContentPage
{
	public DealsPage()
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
}
