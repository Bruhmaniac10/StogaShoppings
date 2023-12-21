using StogaShopping;

public partial class Database : ContentPage
{
    private readonly DatabaseService databaseService;

    public Database()
    {

        string dbPath = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData), "products.db3");
        databaseService = new DatabaseService(dbPath);
    }

    protected override async void OnAppearing()
    {
        base.OnAppearing();
        var products = await databaseService.GetProductsAsync();
    }

    // Add methods to handle adding, updating, and deleting products using databaseService
}
