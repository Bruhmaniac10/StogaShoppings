using SQLite;

namespace StogaShopping;

public class UserDatabase
{

    SQLiteAsyncConnection Database;


	async Task Init()
	{
		if (Database is not null)
			return;

		Database = new SQLite.SQLiteAsyncConnection(Constants.DatabasePath, Constants.Flags);

	}

	public async Task<List<User>> GetUsersAsync()
	{
		await Init();
		return await Database.Table<User>().ToListAsync();
	}

/*	public async Task<List<User>> GetUsersNotDoneAsync()
	{
		await Init();
		return await Database.Table<User>().Where(t => t.Done).ToListAsync();
	}*/

	public async Task<User> GetUserAsync(int id)
	{
		await Init();
		return await Database.Table<User>().Where(i=>i.UserId ==  id).FirstOrDefaultAsync();
	}

    public async Task<int> SaveUserAsync(User user)
    {
        await Init();
        if (user.Id != 0)
            return await Database.UpdateAsync(user);
        else  
            return await Database.InsertAsync(user);
    }

	public async Task<int> DeleteUserAsync(User user)
	{
		await Init();
		return await Database.DeleteAsync(user);
	}



}
