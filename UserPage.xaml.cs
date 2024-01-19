using System.Collections.ObjectModel;

namespace ShoppingDatabases;

public partial class UserPage : ContentPage
{

	UserDatabase database;
	private ObservableCollection<User> users;
	public UserPage()
	{
		InitializeComponent();
		database = new UserDatabase();
		users = new ObservableCollection<User>();
	}

    public async void InitialUserList()
    {
        users.Clear();
        users.Add(new User()
        {
            UserId = 1,
            Username = "LilyJiang",
            Password = "NewJeansLover",
            PaymentInfo = 0101010101,
            Address = "Korea",
            ProfilePhoto = "amongus.png"
        });

        foreach (User user in await database.GetUsersAsync())
            await database.DeleteUserAsync(user);

        foreach (User user in users)
            await database.SaveUserAsync(user);
    }
}