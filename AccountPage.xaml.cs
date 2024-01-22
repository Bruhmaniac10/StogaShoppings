using System.Data.Entity;

namespace StogaShopping;

public partial class AccountPage : ContentPage
{
	public AccountPage()
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
    private async void OnSignInClicked(System.Object sender, EventArgs e)
    {
        await Navigation.PushModalAsync(new SignInPage());
    }
    private async void OnCreateAccountClicked(object sender, EventArgs e)
    {
        string UserID = IDEntry.Text;
        string Username = usernameEntry.Text;
        string Password = passwordEntry.Text;
        string Email = emailEntry.Text;
        string PhoneNumber = phoneNumberEntry.Text;
        string HomeAddress = addressEntry.Text;
        string PaymentInformation = paymentInfoEntry.Text;
        string Photo = PhotoEntry.Text;

        User newUser = new User()
        {
            UserId = !string.IsNullOrEmpty(UserID) ? int.Parse(UserID) : 0,
            Username = Username,
            Password = Password,
            PaymentInfo = !string.IsNullOrEmpty(PaymentInformation) ? long.Parse(PaymentInformation) : 0,
            Address = HomeAddress,
            ProfilePhoto = Photo
        };

        UserPage userPage = new UserPage();
        userPage.AddUser(newUser);

        await Navigation.PopAsync();
    }

}
