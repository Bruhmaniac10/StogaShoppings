using SQLite;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StogaShopping
{
    public class ProductDatabase
    {

        SQLiteAsyncConnection Database;

        public ProductDatabase()
        {
        }

        async Task Init()
        {
            if (Database is not null)
                return;

            Database = new SQLite.SQLiteAsyncConnection(Constants.DatabasePath, Constants.Flags);

        }

        public async Task<List<Product>> GetProductsAsync()
        {
            await Init();
            return await Database.Table<Product>().ToListAsync();
        }


        public async Task<Product> GetProductAsync(int id)
        {
            await Init();
            return await Database.Table<Product>().Where(i => i.ProductId == id).FirstOrDefaultAsync();
        }

        public async Task<int> SaveProductAsync(Product product)
        {
            await Init();
            if (product.ProductId != 0)
                return await Database.UpdateAsync(product);
            else
                return await Database.InsertAsync(product);
        }

        public async Task<int> DeleteProductAsync(Product product)
        {
            await Init();
            return await Database.DeleteAsync(product);
        }



    }
}