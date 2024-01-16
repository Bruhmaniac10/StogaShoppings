using SQLite;

namespace StogaShopping
{
    public partial class Product
    {
        [PrimaryKey, AutoIncrement]
        public int Id { get; set; }
        public string Name { get; set; }
        public decimal Price { get; set; }
        // Add more properties as needed for product information
    }

    public class DatabaseService
    {
        readonly SQLiteAsyncConnection _database;

        public DatabaseService(string dbPath)
        {
            _database = new SQLiteAsyncConnection(dbPath);
            _database.CreateTableAsync<Product>().Wait();
        }

        public async Task<List<Product>> GetProductsAsync()
        {
            return await _database.Table<Product>().ToListAsync();
        }

        public async Task<int> SaveProductAsync(Product product)
        {
            if (product.Id != 0)
            {
                return await _database.UpdateAsync(product);
            }
            else
            {
                return await _database.InsertAsync(product);
            }
        }

        public async Task<int> DeleteProductAsync(Product product)
        {
            return await _database.DeleteAsync(product);
        }
        private void AddToCartButton_Clicked(object sender, EventArgs e)
{
    
    var selectedProduct = ((Button)sender).BindingContext as Product;
    
}
    }
}
