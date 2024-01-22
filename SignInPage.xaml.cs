namespace StogaShopping;

public partial class SignInPage : ContentPage
{
    public SignInPage()
    {
        InitializeComponent();
    }

    private async void OnSignInClicked(object sender, EventArgs e)
    {
        string username = usernameEntry.Text;
        string password = passwordEntry.Text;

        User matchedUser = await UserDatabase.GetUserAsync(username, password);

        if (matchedUser != null)
        {
            _ = Navigation.PopModalAsync();
            await Navigation.PushAsync(new AccountPage());
        }
        else
        {
            // No matching user found, show an error message
            DisplayAlert("Error", "Invalid username or password. Please try again.", "OK");
        }
    }


    private async void OnCreateAccountClicked(System.Object sender, EventArgs e)
    {
        _ = Navigation.PopModalAsync();
        await Navigation.PushAsync(new AccountPage());


    }
}