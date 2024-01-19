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
        products.Add(new Product()
        {
            ProductId = 1,
            Name = "AmongUsMan",
            Seller = "Joe Zou",
            Stars = 5,
            Review = "Amazing",
            Description = "suspicious",
            Price = 500,
            Availability = true
        });

        foreach (Product product in await database.GetProductsAsync())
            await database.DeleteProductAsync(product);

        foreach (Product product in products)
            await database.SaveProductAsync(product);
    }

}