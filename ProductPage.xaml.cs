using System.Collections.ObjectModel;

namespace ShoppingDatabases;

public partial class ProductPage : ContentPage
{
    ProductDatabase database;

	private ObservableCollection<Product> products;
	public ProductPage()
	{
		InitializeComponent();
		database = new ProductDatabase();
		products = new ObservableCollection<Product>();
	}

    public async void InitialProductList()
    {
        products.Clear();
   /*     products.Add(new Product()
        {
            ProductId = 1,
            Name = "AmongUsMan",
            Seller = "Joe Zou",
            Stars = 5,
            Review = "Amazing",
            Description = "suspicious",
            Price = 500,
            Availability = true
        });*/
        products.Add(new Product() { ProductId = 1, Name = "GalaxyExplorer Drone", Seller = "Tech Innovations", Stars = 4, Review = "Captivating aerial views", Description = "Advanced drone for photography", Price = 600, Availability = true });

        products.Add(new Product() { ProductId = 2, Name = "CozyHome Blanket", Seller = "Comfort Haven", Stars = 5, Review = "Warm and snuggly", Description = "Soft and luxurious throw blanket", Price = 40, Availability = true });

        products.Add(new Product() { ProductId = 3, Name = "Gamer's Haven Chair", Seller = "Elite Comfort", Stars = 4, Review = "Perfect for long gaming sessions", Description = "Ergonomic gaming chair with RGB lights", Price = 250, Availability = true });

        products.Add(new Product() { ProductId = 4, Name = "FitMaster Pro Treadmill", Seller = "FitZone", Stars = 4, Review = "Efficient cardio workouts", Description = "High-performance treadmill for home use", Price = 800, Availability = true }); 
        
        products.Add(new Product() { ProductId = 6, Name = "AdventureReady Camping Tent", Seller = "Outdoor Gear Co.", Stars = 5, Review = "Sturdy and weather-resistant", Description = "Spacious tent for outdoor enthusiasts", Price = 120, Availability = true }); 
        
        products.Add(new Product() { ProductId = 7, Name = "TechSavvy Smartwatch", Seller = "Gadget Guru", Stars = 4, Review = "Stay connected on the go", Description = "Feature-rich smartwatch with health tracking", Price = 150, Availability = true });

        products.Add(new Product() { ProductId = 8, Name = "HomeSpa Relaxation Kit", Seller = "Wellness Haven", Stars = 5, Review = "Ultimate relaxation experience", Description = "Spa essentials for a home pampering session", Price = 100, Availability = true });
        
        products.Add(new Product() { ProductId = 9, Name = "PetPal Deluxe Cat Tree", Seller = "Pet Paradise", Stars = 4, Review = "Entertainment for feline friends", Description = "Multi-level cat tree with scratching posts", Price = 70, Availability = true }); 
        
        products.Add(new Product() { ProductId = 10, Name = "BookWorm Reading Lamp", Seller = "Literary Luminance", Stars = 5, Review = "Perfect for late-night reading", Description = "Adjustable LED lamp for avid readers", Price = 45, Availability = true });

        products.Add(new Product() { ProductId = 11, Name = "Chef'sChoice Knife Set", Seller = "Culinary Creations", Stars = 4, Review = "Precision cutting for chefs", Description = "High-quality knife set for kitchen enthusiasts", Price = 120, Availability = true });
        
        products.Add(new Product() { ProductId = 12, Name = "FitnessFusion Yoga Mat", Seller = "Mindful Moves", Stars = 5, Review = "Comfortable and non-slip", Description = "Premium yoga mat for home or studio use", Price = 35, Availability = true }); 
        
        products.Add(new Product() { ProductId = 13, Name = "GlowGarden Flower Seeds", Seller = "Green Thumb Supplies", Stars = 4, Review = "Colorful blooms for your garden", Description = "Assorted flower seeds for vibrant gardens", Price = 10, Availability = true });

        products.Add(new Product() { ProductId = 14, Name = "HomeFit Resistance Bands Set", Seller = "FitZone", Stars = 4, Review = "Versatile workout accessories", Description = "Set of resistance bands for home fitness", Price = 25, Availability = true }); 
        
        products.Add(new Product() { ProductId = 15, Name = "TechSculpt 3D Printer", Seller = "Innovation Hub", Stars = 5, Review = "Unleash your creativity", Description = "High-precision 3D printer for enthusiasts", Price = 400, Availability = true }); 
        
        products.Add(new Product() { ProductId = 16, Name = "PetEase Automatic Pet Feeder", Seller = "Pet Paradise", Stars = 4, Review = "Convenient feeding solution", Description = "Automated pet feeder for cats and dogs", Price = 60, Availability = true });

        products.Add(new Product() { ProductId = 17, Name = "AquaBliss Spa Showerhead", Seller = "Relaxation Haven", Stars = 5, Review = "Luxurious shower experience", Description = "High-pressure spa showerhead with multiple settings", Price = 50, Availability = true }); 
        
        products.Add(new Product() { ProductId = 18, Name = "SmartHome Security Camera", Seller = "SecureTech Solutions", Stars = 4, Review = "Enhanced home security", Description = "Wireless security camera with smart features", Price = 120, Availability = true }); 
        
        products.Add(new Product() { ProductId = 19, Name = "TravelMate Luggage Set", Seller = "Wanderlust Travel", Stars = 5, Review = "Durable and stylish", Description = "Three-piece luggage set for avid travelers", Price = 180, Availability = true });

        products.Add(new Product() { ProductId = 20, Name = "HomeBrew Craft Beer Kit", Seller = "Brewmaster Supplies", Stars = 4, Review = "Brew your own beer at home", Description = "Complete kit for crafting your favorite brews", Price = 70, Availability = true }); 
        
        products.Add(new Product() { ProductId = 21, Name = "CosmicSound Wireless Earbuds", Seller = "Audio Harmony", Stars = 5, Review = "Immersive audio experience", Description = "Wireless earbuds with noise-canceling technology", Price = 90, Availability = true }); 
        
        products.Add(new Product() { ProductId = 22, Name = "ArtisticTouch Paintbrush Set", Seller = "Creative Expressions", Stars = 4, Review = "Premium brushes for artists", Description = "Professional paintbrush set for various art styles", Price = 30, Availability = true });

        products.Add(new Product() { ProductId = 23, Name = "CulinaryMaster Knife Block Set", Seller = "Chef's Haven", Stars = 5, Review = "Essential knives for chefs", Description = "Complete knife block set for professional kitchens", Price = 150, Availability = true });
        
        products.Add(new Product() { ProductId = 24, Name = "SmartHome Thermostat", Seller = "Tech Innovations", Stars = 4, Review = "Efficient temperature control", Description = "Smart thermostat for energy savings", Price = 100, Availability = true }); 
        
        products.Add(new Product() { ProductId = 25, Name = "NatureExplorer Binoculars", Seller = "Outdoor Adventures", Stars = 5, Review = "Crystal-clear magnification", Description = "Binoculars for birdwatching and outdoor exploration", Price = 50, Availability = true });

        products.Add(new Product() { ProductId = 26, Name = "HomeGourmet Sous Vide Precision Cooker", Seller = "Culinary Creations", Stars = 4, Review = "Perfectly cooked meals every time", Description = "Sous vide precision cooker for home chefs", Price = 120, Availability = true }); 
        
        products.Add(new Product() { ProductId = 27, Name = "SmartLight LED Bulb Set", Seller = "EnergySaver Tech", Stars = 5, Review = "Customizable lighting solutions", Description = "Set of smart LED bulbs with color options", Price = 40, Availability = true }); 
        
        products.Add(new Product() { ProductId = 28, Name = "AdventureSeeker Backpack", Seller = "Outdoor Gear Co.", Stars = 4, Review = "Durable and spacious for adventures", Description = "Multi-compartment backpack for outdoor enthusiasts", Price = 60, Availability = true }); 
        
        products.Add(new Product() { ProductId = 29, Name = "HomeWorkout Resistance Bands Set", Seller = "FitZone", Stars = 4, Review = "Versatile workout accessories", Description = "Set of resistance bands for home fitness", Price = 25, Availability = true });
        
        products.Add(new Product() { ProductId = 30, Name = "TechInnovate Wireless Charging Pad", Seller = "Innovation Hub", Stars = 5, Review = "Convenient wireless charging", Description = "Fast-charging pad for smartphones and devices", Price = 30, Availability = true }); 
        
        products.Add(new Product() { ProductId = 31, Name = "NatureAdmirer Binoculars", Seller = "Wildlife Gear", Stars = 4, Review = "Explore wildlife with clarity", Description = "Binoculars for birdwatching and nature observation", Price = 40, Availability = true });

        products.Add(new Product() { ProductId = 32, Name = "HomeOffice Ergonomic Desk Chair", Seller = "Workspace Essentials", Stars = 5, Review = "Comfort for long work hours", Description = "Ergonomic chair for home office setups", Price = 120, Availability = true }); 
        
        products.Add(new Product() { ProductId = 33, Name = "AudioVibe Bluetooth Speaker", Seller = "Audio Harmony", Stars = 4, Review = "Immersive sound quality", Description = "Portable Bluetooth speaker for music lovers", Price = 50, Availability = true }); 
        
        products.Add(new Product() { ProductId = 34, Name = "GardenGlow Solar Lights Set", Seller = "Green Thumb Supplies", Stars = 5, Review = "Illuminate your garden at night", Description = "Set of solar-powered garden lights", Price = 20, Availability = true });

        products.Add(new Product() { ProductId = 35, Name = "HomeStudio Ring Light Kit", Seller = "Creative Expressions", Stars = 4, Review = "Perfect lighting for content creators", Description = "Ring light kit for photography and video recording", Price = 70, Availability = true }); 
        
        products.Add(new Product() { ProductId = 36, Name = "AdventurePro Camping Cookware Set", Seller = "Outdoor Gear Co.", Stars = 5, Review = "Compact and durable for outdoor cooking", Description = "Portable cookware set for camping and hiking", Price = 45, Availability = true }); 
        
        products.Add(new Product() { ProductId = 37, Name = "TechScribe Smart Pen", Seller = "Innovation Hub", Stars = 4, Review = "Digitize your notes seamlessly", Description = "Smart pen for digital note-taking and drawing", Price = 60, Availability = true });

        products.Add(new Product() { ProductId = 38, Name = "HomeChef Premium Knife Set", Seller = "Culinary Creations", Stars = 5, Review = "Precision cutting for culinary enthusiasts", Description = "Premium knife set for home chefs", Price = 90, Availability = true }); 
        
        products.Add(new Product() { ProductId = 39, Name = "EcoGlow Bamboo Utensil Set", Seller = "Green Living Co.", Stars = 4, Review = "Sustainable and stylish", Description = "Bamboo utensil set for eco-friendly kitchens", Price = 25, Availability = true }); 
        
        products.Add(new Product() { ProductId = 40, Name = "SmartHome Security Doorbell", Seller = "SecureTech Solutions", Stars = 5, Review = "Enhanced home security with video monitoring", Description = "Smart doorbell with HD camera and two-way audio", Price = 120, Availability = true });

        products.Add(new Product() { ProductId = 41, Name = "HomeBake Bread Maker", Seller = "Kitchen Innovations", Stars = 4, Review = "Freshly baked bread at home", Description = "Automatic bread maker for homemade bread", Price = 80, Availability = true }); 

        products.Add(new Product() { ProductId = 44, Name = "HomeFitness Yoga Mat", Seller = "FitZone", Stars = 5, Review = "Comfortable and non-slip", Description = "Premium yoga mat for home or studio use", Price = 35, Availability = true }); 
        
        products.Add(new Product() { ProductId = 45, Name = "ArtisticFlare Paint Set", Seller = "Creative Expressions", Stars = 4, Review = "Vibrant colors for artistic creations", Description = "Set of high-quality acrylic paints for artists", Price = 25, Availability = true });
        
        products.Add(new Product() { ProductId = 46, Name = "TravelTech Compact Charger", Seller = "Tech Innovations", Stars = 5, Review = "Charge your devices on the go", Description = "Compact and portable charger for smartphones and tablets", Price = 20, Availability = true });

        products.Add(new Product() { ProductId = 47, Name = "HomeHarbor Indoor Plants Set", Seller = "Green Thumb Supplies", Stars = 4, Review = "Bring nature indoors", Description = "Set of indoor plants for home decoration", Price = 30, Availability = true }); 
        
        products.Add(new Product() { ProductId = 48, Name = "AquaScape Aquarium Kit", Seller = "Aquatic Wonders", Stars = 5, Review = "Create a mesmerizing underwater world", Description = "Complete aquarium kit for fish enthusiasts", Price = 70, Availability = true }); 
        
        products.Add(new Product() { ProductId = 49, Name = "HomeOffice Standing Desk Converter", Seller = "Workspace Essentials", Stars = 4, Review = "Ergonomic solution for a flexible workspace", Description = "Adjustable standing desk converter for home offices", Price = 120, Availability = true });

        products.Add(new Product() { ProductId = 50, Name = "HomeHarmony Relaxation Pillow", Seller = "Wellness Haven", Stars = 5, Review = "Enhance your sleep and relaxation", Description = "Memory foam pillow for optimal comfort", Price = 40, Availability = true }); 
        
        products.Add(new Product() { ProductId = 51, Name = "PetWonder Catnip Toy Set", Seller = "Pet Paradise", Stars = 4, Review = "Entertainment for feline friends", Description = "Assorted catnip toys for playful cats", Price = 15, Availability = true }); 
        
        products.Add(new Product() { ProductId = 52, Name = "TechInnovate Laptop Stand", Seller = "Innovation Hub", Stars = 5, Review = "Elevate your laptop for ergonomic use", Description = "Adjustable laptop stand for better posture", Price = 25, Availability = true });

        products.Add(new Product() { ProductId = 53, Name = "HomeChef Culinary Torch", Seller = "Culinary Creations", Stars = 4, Review = "Create perfect caramelized toppings", Description = "Kitchen torch for culinary enthusiasts", Price = 30, Availability = true });
        
        products.Add(new Product() { ProductId = 54, Name = "ArtisticVision Sketchbook Set", Seller = "Creative Expressions", Stars = 5, Review = "Blank canvas for your artistic ideas", Description = "Sketchbook set with high-quality paper", Price = 20, Availability = true }); 
        
        products.Add(new Product() { ProductId = 55, Name = "AdventureSeeker Hiking Boots", Seller = "Outdoor Gear Co.", Stars = 4, Review = "Comfortable and durable for outdoor adventures", Description = "Hiking boots for trekking and hiking enthusiasts", Price = 80, Availability = true });

        products.Add(new Product() { ProductId = 56, Name = "HomeCrafter Sewing Machine", Seller = "Crafty Corner", Stars = 5, Review = "Unleash your creativity with sewing", Description = "Compact sewing machine for DIY projects", Price = 100, Availability = true }); 
        
        products.Add(new Product() { ProductId = 57, Name = "PetComfort Orthopedic Dog Bed", Seller = "Pet Paradise", Stars = 4, Review = "Supportive and comfortable for furry friends", Description = "Orthopedic dog bed for dogs of all sizes", Price = 45, Availability = true }); 
        
        products.Add(new Product() { ProductId = 58, Name = "TechSculpt Ergonomic Mouse", Seller = "Gadget Guru", Stars = 5, Review = "Reduce strain during long hours of work", Description = "Ergonomic mouse for comfortable computing", Price = 30, Availability = true });

        products.Add(new Product() { ProductId = 59, Name = "HomeHarmony Meditation Cushion", Seller = "Wellness Haven", Stars = 4, Review = "Create a tranquil meditation space", Description = "Meditation cushion for comfortable mindfulness", Price = 35, Availability = true });
        
        products.Add(new Product() { ProductId = 60, Name = "ArtisticCraft Calligraphy Set", Seller = "Creative Expressions", Stars = 5, Review = "Elevate your writing with calligraphy", Description = "Complete calligraphy set for artistic writing", Price = 25, Availability = true }); 
        
        products.Add(new Product() { ProductId = 61, Name = "AdventurePro Camping Hammock", Seller = "Outdoor Gear Co.", Stars = 4, Review = "Relax and unwind in nature", Description = "Portable camping hammock for outdoor enthusiasts", Price = 50, Availability = true });

        products.Add(new Product() { ProductId = 62, Name = "HomeScent Aromatherapy Diffuser", Seller = "Wellness Haven", Stars = 5, Review = "Create a soothing atmosphere with scents", Description = "Ultrasonic aromatherapy diffuser for essential oils", Price = 40, Availability = true }); 
        
        products.Add(new Product() { ProductId = 63, Name = "PetEase Interactive Dog Toy", Seller = "Pet Paradise", Stars = 4, Review = "Engage and entertain your furry friend", Description = "Interactive dog toy for mental stimulation", Price = 15, Availability = true });
        
        products.Add(new Product() { ProductId = 64, Name = "TechGlide Gaming Mouse Pad", Seller = "Gadget Guru", Stars = 5, Review = "Smooth surface for precision gaming", Description = "Large gaming mouse pad with enhanced glide", Price = 20, Availability = true });

        products.Add(new Product() { ProductId = 65, Name = "HomeBlend Smoothie Maker", Seller = "Kitchen Innovations", Stars = 4, Review = "Create healthy and delicious smoothies", Description = "Compact smoothie maker with multiple settings", Price = 50, Availability = true }); 
        
        products.Add(new Product() { ProductId = 66, Name = "ArtisticCraft Watercolor Paint Set", Seller = "Creative Expressions", Stars = 5, Review = "Vibrant colors for watercolor painting", Description = "High-quality watercolor paint set for artists", Price = 30, Availability = true });
        
        products.Add(new Product() { ProductId = 67, Name = "AdventurePro Travel Hammock", Seller = "Outdoor Gear Co.", Stars = 4, Review = "Compact hammock for on-the-go relaxation", Description = "Travel-friendly hammock for outdoor adventures", Price = 35, Availability = true });

        products.Add(new Product() { ProductId = 68, Name = "HomeChef Spice Rack Set", Seller = "Culinary Creations", Stars = 5, Review = "Organize and elevate your spice collection", Description = "Spice rack set with labeled jars for easy access", Price = 25, Availability = true }); 
        
        products.Add(new Product() { ProductId = 69, Name = "EcoStyle Bamboo Toothbrush Set", Seller = "Green Living Co.", Stars = 4, Review = "Sustainable oral care with bamboo toothbrushes", Description = "Set of eco-friendly bamboo toothbrushes", Price = 10, Availability = true }); 
        
        products.Add(new Product() { ProductId = 70, Name = "TechSync Wireless Earbuds", Seller = "Audio Harmony", Stars = 5, Review = "Immersive audio experience with wireless earbuds", Description = "Wireless earbuds with noise-canceling technology", Price = 80, Availability = true });

        products.Add(new Product() { ProductId = 71, Name = "HomeRefresh Air Purifier", Seller = "Wellness Haven", Stars = 4, Review = "Clean and fresh indoor air with an air purifier", Description = "HEPA air purifier for improved air quality", Price = 100, Availability = true }); 
        
        products.Add(new Product() { ProductId = 72, Name = "PetComfort Cat Bed", Seller = "Pet Paradise", Stars = 5, Review = "Cozy and comfortable bed for feline friends", Description = "Soft and plush cat bed for relaxation", Price = 30, Availability = true }); 
        
        products.Add(new Product() { ProductId = 73, Name = "TechSculpt Ergonomic Keyboard", Seller = "Gadget Guru", Stars = 4, Review = "Comfortable typing with an ergonomic keyboard", Description = "Wireless ergonomic keyboard with customizable keys", Price = 60, Availability = true });

        products.Add(new Product() { ProductId = 74, Name = "HomeRelax Massage Chair", Seller = "Wellness Haven", Stars = 5, Review = "Ultimate relaxation with a massage chair", Description = "Full-body massage chair with multiple settings", Price = 800, Availability = true }); 
        
        products.Add(new Product() { ProductId = 75, Name = "PetWonder Dog Leash and Collar Set", Seller = "Pet Paradise", Stars = 4, Review = "Stylish and durable accessories for dogs", Description = "Matching leash and collar set for dogs of all sizes", Price = 25, Availability = true }); 
        
        products.Add(new Product() { ProductId = 76, Name = "TechGlow LED Desk Lamp", Seller = "Gadget Guru", Stars = 5, Review = "Illuminate your workspace with LED lighting", Description = "Adjustable LED desk lamp for optimal lighting", Price = 40, Availability = true });

        products.Add(new Product() { ProductId = 77, Name = "HomeFit Elliptical Trainer", Seller = "FitZone", Stars = 4, Review = "Efficient full-body workouts at home", Description = "Elliptical trainer for cardiovascular exercise", Price = 600, Availability = true }); 
        
        products.Add(new Product() { ProductId = 78, Name = "PetComfort Luxury Cat Bed", Seller = "Pet Paradise", Stars = 5, Review = "Luxurious and cozy bed for pampered cats", Description = "Plush cat bed with elevated design", Price = 50, Availability = true }); 
        
        products.Add(new Product() { ProductId = 79, Name = "TechSonic Noise-Canceling Headphones", Seller = "Audio Harmony", Stars = 4, Review = "Immersive audio experience with noise-canceling", Description = "Over-ear headphones for clear and crisp sound", Price = 120, Availability = true });

        products.Add(new Product() { ProductId = 80, Name = "HomeGym Power Rack", Seller = "FitZone", Stars = 5, Review = "Versatile strength training at home", Description = "Power rack for weightlifting and bodyweight exercises", Price = 700, Availability = true }); 
        
        products.Add(new Product() { ProductId = 81, Name = "PetWonder Interactive Dog Puzzle Toy", Seller = "Pet Paradise", Stars = 4, Review = "Engage and entertain your canine companion", Description = "Interactive puzzle toy for dogs to stimulate their minds", Price = 20, Availability = true }); 
        
        products.Add(new Product() { ProductId = 82, Name = "TechInnovate Wireless Gaming Mouse", Seller = "Gadget Guru", Stars = 5, Review = "Precision gaming with wireless convenience", Description = "Wireless gaming mouse with customizable buttons", Price = 60, Availability = true });

        products.Add(new Product() { ProductId = 83, Name = "HomeBrew Coffee Maker", Seller = "Kitchen Innovations", Stars = 4, Review = "Brew your perfect cup of coffee at home", Description = "Automatic coffee maker with customizable settings", Price = 80, Availability = true }); 
        
        products.Add(new Product() { ProductId = 84, Name = "PetComfort Memory Foam Dog Bed", Seller = "Pet Paradise", Stars = 5, Review = "Supportive and comfortable bed for dogs", Description = "Memory foam dog bed for quality sleep", Price = 40, Availability = true }); 
        
        products.Add(new Product() { ProductId = 85, Name = "TechSculpt Mechanical Gaming Keyboard", Seller = "Gadget Guru", Stars = 4, Review = "Enhance your gaming experience with tactile feedback", Description = "Mechanical gaming keyboard with customizable RGB lighting", Price = 90, Availability = true });

        products.Add(new Product() { ProductId = 86, Name = "HomeChef Electric Food Processor", Seller = "Culinary Creations", Stars = 5, Review = "Efficient chopping and food preparation", Description = "Electric food processor for kitchen convenience", Price = 120, Availability = true }); 
        
        products.Add(new Product() { ProductId = 87, Name = "EcoLiving Bamboo Fiber Dinnerware Set", Seller = "Green Living Co.", Stars = 4, Review = "Sustainable and stylish dinnerware", Description = "Bamboo fiber dinnerware set for eco-friendly dining", Price = 50, Availability = true });
        
        products.Add(new Product() { ProductId = 88, Name = "TechSync Wireless Charging Stand", Seller = "Innovation Hub", Stars = 5, Review = "Wireless charging convenience for your devices", Description = "Charging stand compatible with various smartphones", Price = 35, Availability = true });

        products.Add(new Product() { ProductId = 89, Name = "HomeBaker Bread Machine", Seller = "Kitchen Innovations", Stars = 4, Review = "Automated bread baking at home", Description = "Bread machine for easy and delicious homemade bread", Price = 90, Availability = true }); 
        
        products.Add(new Product() { ProductId = 90, Name = "EcoChic Reusable Shopping Bags", Seller = "Green Living Co.", Stars = 5, Review = "Environmentally friendly shopping solution", Description = "Set of reusable shopping bags made from sustainable materials", Price = 15, Availability = true }); 
        
        products.Add(new Product() { ProductId = 91, Name = "TechStream Smart Wi-Fi Router", Seller = "Innovation Hub", Stars = 4, Review = "High-performance wireless connectivity", Description = "Smart Wi-Fi router with advanced features for seamless internet", Price = 80, Availability = true });

        products.Add(new Product() { ProductId = 92, Name = "HomeBlend Cold Press Juicer", Seller = "Kitchen Innovations", Stars = 5, Review = "Extract nutrient-rich juices with cold press technology", Description = "Juicer for making healthy and refreshing beverages", Price = 120, Availability = true }); 
        
        products.Add(new Product() { ProductId = 93, Name = "EcoSpark Bamboo Desk Organizer", Seller = "Green Living Co.", Stars = 4, Review = "Organize your workspace sustainably", Description = "Desk organizer made from eco-friendly bamboo", Price = 25, Availability = true });
        
        products.Add(new Product() { ProductId = 94, Name = "TechInnovate Smart Home Hub", Seller = "Innovation Hub", Stars = 5, Review = "Centralized control for your smart home devices", Description = "Smart home hub with compatibility for various devices", Price = 60, Availability = true });

        products.Add(new Product() { ProductId = 95, Name = "HomeGrind Coffee Grinder", Seller = "Kitchen Innovations", Stars = 4, Review = "Customize your coffee grind for the perfect brew", Description = "Electric coffee grinder for fresh and precise grinding", Price = 50, Availability = true }); 
        
        products.Add(new Product() { ProductId = 96, Name = "EcoHarmony Bamboo Bath Towel Set", Seller = "Green Living Co.", Stars = 5, Review = "Soft and sustainable bath towels for eco-conscious living", Description = "Set of bamboo bath towels for a luxurious bath experience", Price = 40, Availability = true }); 
        
        products.Add(new Product() { ProductId = 97, Name = "TechGlow Smart LED Strip Lights", Seller = "Innovation Hub", Stars = 4, Review = "Create vibrant lighting atmospheres with smart LED strips", Description = "Color-changing LED strip lights with smart controls", Price = 30, Availability = true });

        products.Add(new Product() { ProductId = 98, Name = "HomeBlend Espresso Machine", Seller = "Kitchen Innovations", Stars = 5, Review = "Brew authentic espresso at home", Description = "Espresso machine with built-in frother for creamy coffee", Price = 120, Availability = true }); 
        
        products.Add(new Product() { ProductId = 99, Name = "EcoChic Bamboo Plant Stand", Seller = "Green Living Co.", Stars = 4, Review = "Display your plants in a stylish and eco-friendly stand", Description = "Bamboo plant stand for indoor or outdoor use", Price = 25, Availability = true }); 
        
        products.Add(new Product() { ProductId = 100, Name = "TechInvent Virtual Reality Headset", Seller = "Innovation Hub", Stars = 5, Review = "Immersive virtual reality experiences at your fingertips", Description = "VR headset with motion tracking and HD display", Price = 150, Availability = true });


        foreach (Product product in await database.GetProductsAsync())
            await database.DeleteProductAsync(product);

        foreach (Product product in products)
            await database.SaveProductAsync(product);
    }

    public async void AddProduct(Product product)
    {
        products.Add(product);
        await database.SaveProductAsync(product);
    }

}
