using System.Collections.ObjectModel;

namespace StogaShopping;

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
        /*        users.Add(new User()
                {
                    UserId = 1,
                    Username = "LilyJiang",
                    Password = "NewJeansLover",
                    PaymentInfo = 0101010101,
                    Address = "Korea",
                    ProfilePhoto = "amongus.png"
                });*/

        users.Add(new User() { UserId = 2, Username = "JaneDoe", Password = "SecurePass456", PaymentInfo = 1234567890, Address = "Canada", ProfilePhoto = "profile.jpg" });

        users.Add(new User() { UserId = 3, Username = "AlexSmith", Password = "BlueSky789", PaymentInfo = 987654321, Address = "Australia", ProfilePhoto = "sunset.jpg" });

        users.Add(new User() { UserId = 4, Username = "ChrisTaylor", Password = "GreenForest123", PaymentInfo = 5555555555, Address = "USA", ProfilePhoto = "woods.png" });

        users.Add(new User() { UserId = 5, Username = "EllaJohnson", Password = "PurpleRain789", PaymentInfo = 8888888888, Address = "UK", ProfilePhoto = "raindrops.jpg" });
        
        users.Add(new User() { UserId = 6, Username = "MaxWilliams", Password = "YellowSun123", PaymentInfo = 3333333333, Address = "Canada", ProfilePhoto = "sunnyday.png" }); 
        
        users.Add(new User() { UserId = 7, Username = "SophieClark", Password = "RedRose456", PaymentInfo = 4444444444, Address = "France", ProfilePhoto = "rosepetals.jpg" });

        users.Add(new User() { UserId = 8, Username = "DanielMiller", Password = "BrownBear789", PaymentInfo = 6666666666, Address = "Germany", ProfilePhoto = "forestwalk.jpg" });
        
        users.Add(new User() { UserId = 9, Username = "OliviaWhite", Password = "SilverMoon123", PaymentInfo = 9999999999, Address = "Italy", ProfilePhoto = "moonlight.png" });
        
        users.Add(new User() { UserId = 10, Username = "MasonAnderson", Password = "GoldenKey456", PaymentInfo = 7777777777, Address = "Spain", ProfilePhoto = "keyhole.jpg" });

        users.Add(new User() { UserId = 11, Username = "AvaTaylor", Password = "PinkFlower789", PaymentInfo = 2222222222, Address = "Japan", ProfilePhoto = "cherryblossom.jpg" }); 
        
        users.Add(new User() { UserId = 12, Username = "WilliamJones", Password = "CrimsonSky123", PaymentInfo = 5555555555, Address = "Australia", ProfilePhoto = "skyscraper.jpg" }); 
        
        users.Add(new User() { UserId = 13, Username = "EthanSmith", Password = "OceanBlue456", PaymentInfo = 8888888888, Address = "Brazil", ProfilePhoto = "oceanwave.png" });

        users.Add(new User() { UserId = 14, Username = "EmmaWilson", Password = "VioletSunset789", PaymentInfo = 3333333333, Address = "South Africa", ProfilePhoto = "sunsetview.jpg" }); 
        
        users.Add(new User() { UserId = 15, Username = "JamesBrown", Password = "EmeraldForest123", PaymentInfo = 6666666666, Address = "New Zealand", ProfilePhoto = "enchantedforest.png" }); 
        
        users.Add(new User() { UserId = 16, Username = "GraceMurphy", Password = "AmberFields456", PaymentInfo = 1111111111, Address = "Mexico", ProfilePhoto = "amberfields.jpg" });

        users.Add(new User() { UserId = 17, Username = "LiamCooper", Password = "SilverLake789", PaymentInfo = 7777777777, Address = "Canada", ProfilePhoto = "silverlake.jpg" }); 
        
        users.Add(new User() { UserId = 18, Username = "AriaLee", Password = "GoldenSands123", PaymentInfo = 4444444444, Address = "Maldives", ProfilePhoto = "goldensands.png" });
        
        users.Add(new User() { UserId = 19, Username = "LoganSmith", Password = "RubySky456", PaymentInfo = 2222222222, Address = "Norway", ProfilePhoto = "rubysky.jpg" });
        
        users.Add(new User() { UserId = 20, Username = "IsabellaBrown", Password = "DiamondPeak789", PaymentInfo = 9999999999, Address = "Switzerland", ProfilePhoto = "diamondpeak.png" });

        users.Add(new User() { UserId = 21, Username = "LiamMiller", Password = "CopperSunset789", PaymentInfo = 2222222222, Address = "Norway", ProfilePhoto = "coppersunset.jpg" }); 
        
        users.Add(new User() { UserId = 22, Username = "ChloeDavis", Password = "PlatinumRiver123", PaymentInfo = 8888888888, Address = "Netherlands", ProfilePhoto = "platinumriver.png" });
        
        users.Add(new User() { UserId = 23, Username = "NoahHill", Password = "DiamondValley456", PaymentInfo = 6666666666, Address = "Sweden", ProfilePhoto = "diamondvalley.jpg" });
        
        users.Add(new User() { UserId = 24, Username = "MiaWright", Password = "RubyGarden789", PaymentInfo = 1111111111, Address = "Denmark", ProfilePhoto = "rubygarden.png" });
        
        users.Add(new User() { UserId = 25, Username = "ElijahWhite", Password = "SapphireOcean123", PaymentInfo = 4444444444, Address = "Finland", ProfilePhoto = "sapphireocean.jpg" });

        users.Add(new User() { UserId = 26, Username = "AvaJohnson", Password = "EmeraldForest789", PaymentInfo = 9999999999, Address = "Poland", ProfilePhoto = "emeraldforest.png" }); 
        
        users.Add(new User() { UserId = 27, Username = "OliverTaylor", Password = "AmethystHaven123", PaymentInfo = 3333333333, Address = "Czech Republic", ProfilePhoto = "amethysthaven.jpg" }); 
        
        users.Add(new User() { UserId = 28, Username = "HarperBrown", Password = "TopazDream456", PaymentInfo = 7777777777, Address = "Austria", ProfilePhoto = "topazdream.jpg" }); 
        
        users.Add(new User() { UserId = 29, Username = "EthanWilson", Password = "MoonstoneMeadow789", PaymentInfo = 5555555555, Address = "Hungary", ProfilePhoto = "moonstonemeadow.png" }); 
        
        users.Add(new User() { UserId = 30, Username = "AmeliaSmith", Password = "PearlHarbor123", PaymentInfo = 8888888888, Address = "Slovakia", ProfilePhoto = "pearlharbor.jpg" });

        users.Add(new User() { UserId = 31, Username = "LiamHill", Password = "OpalSky789", PaymentInfo = 1111111111, Address = "Belgium", ProfilePhoto = "opalsky.png" }); 
        
        users.Add(new User() { UserId = 32, Username = "EmmaMurphy", Password = "JadeGrove123", PaymentInfo = 4444444444, Address = "Romania", ProfilePhoto = "jadegrove.jpg" });
        
        users.Add(new User() { UserId = 33, Username = "LucasAnderson", Password = "CoralReef456", PaymentInfo = 9999999999, Address = "Bulgaria", ProfilePhoto = "coralreef.png" }); 
        
        users.Add(new User() { UserId = 34, Username = "MiaMartin", Password = "SunflowerField789", PaymentInfo = 3333333333, Address = "Iceland", ProfilePhoto = "sunflowerfield.jpg" }); 
        
        users.Add(new User() { UserId = 35, Username = "NoahJones", Password = "RainbowCascade123", PaymentInfo = 7777777777, Address = "Luxembourg", ProfilePhoto = "rainbowcascade.png" });

        users.Add(new User() { UserId = 36, Username = "OliviaBrown", Password = "SilverBreeze789", PaymentInfo = 5555555555, Address = "Estonia", ProfilePhoto = "silverbreeze.png" }); 
        
        users.Add(new User() { UserId = 37, Username = "WilliamWilson", Password = "GoldenMeadow123", PaymentInfo = 8888888888, Address = "Latvia", ProfilePhoto = "goldenmeadow.jpg" }); 
        
        users.Add(new User() { UserId = 38, Username = "AvaWhite", Password = "RubyHorizon456", PaymentInfo = 6666666666, Address = "Lithuania", ProfilePhoto = "rubyhorizon.png" });
        
        users.Add(new User() { UserId = 39, Username = "LiamMartin", Password = "EmeraldGrove789", PaymentInfo = 2222222222, Address = "Slovenia", ProfilePhoto = "emeraldgrove.jpg" });
        
        users.Add(new User() { UserId = 40, Username = "EmmaJones", Password = "SapphireCascade123", PaymentInfo = 4444444444, Address = "Cyprus", ProfilePhoto = "sapphirecascade.png" });

        users.Add(new User() { UserId = 41, Username = "EthanAnderson", Password = "DiamondSky789", PaymentInfo = 1111111111, Address = "Malta", ProfilePhoto = "diamondsky.png" }); 
        
        users.Add(new User() { UserId = 42, Username = "OliviaTaylor", Password = "AmberHarbor123", PaymentInfo = 5555555555, Address = "Monaco", ProfilePhoto = "amberharbor.jpg" }); 
        
        users.Add(new User() { UserId = 43, Username = "NoahClark", Password = "TopazMeadow456", PaymentInfo = 7777777777, Address = "San Marino", ProfilePhoto = "topazmeadow.png" });
        
        users.Add(new User() { UserId = 44, Username = "AvaHill", Password = "OpalValley789", PaymentInfo = 9999999999, Address = "Andorra", ProfilePhoto = "opalvalley.jpg" });
        
        users.Add(new User() { UserId = 45, Username = "LiamBrown", Password = "CoralCove123", PaymentInfo = 3333333333, Address = "Liechtenstein", ProfilePhoto = "coralcove.png" });

        users.Add(new User() { UserId = 46, Username = "EmmaJohnson", Password = "RubyGrove789", PaymentInfo = 8888888888, Address = "Ivory Coast", ProfilePhoto = "rubygrove.jpg" }); 
        
        users.Add(new User() { UserId = 47, Username = "OliverClark", Password = "EmeraldMeadow123", PaymentInfo = 6666666666, Address = "Seychelles", ProfilePhoto = "emeraldmeadow.png" }); 
        
        users.Add(new User() { UserId = 48, Username = "SophiaWhite", Password = "GoldenSunset456", PaymentInfo = 2222222222, Address = "Fiji", ProfilePhoto = "goldensunset.jpg" }); 
        
        users.Add(new User() { UserId = 49, Username = "LucasBrown", Password = "AmethystHarbor789", PaymentInfo = 4444444444, Address = "Vanuatu", ProfilePhoto = "amethystharbor.png" });
        
        users.Add(new User() { UserId = 50, Username = "IsabellaMartin", Password = "SapphireHorizon123", PaymentInfo = 1111111111, Address = "Tonga", ProfilePhoto = "sapphirehorizon.jpg" });

        foreach (User user in await database.GetUsersAsync())
            await database.DeleteUserAsync(user);

        foreach (User user in users)
            await database.SaveUserAsync(user);
    }

    public async void AddUser(User user)
    {
        users.Add(user);
        await database.SaveUserAsync(user);
    }

}
