using Plugin.Maui.Audio;
using SQLite;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StogaShopping
{
    public class MusicDatabase
    {

        SQLiteAsyncConnection Database;


        async Task Init()
        {
            if (Database is not null)
                return;

            Database = new SQLite.SQLiteAsyncConnection(Constants.DatabasePath, Constants.Flags);

        }

        public async Task<List<Music>> GetMusicAsync()
        {
            await Init();
            return await Database.Table<Music>().ToListAsync();
        }

        /*	public async Task<List<User>> GetUsersNotDoneAsync()
            {
                await Init();
                return await Database.Table<User>().Where(t => t.Done).ToListAsync();
            }*/

        public async Task<Music> GetMusicAsync(string val)
        {
            await Init();
            return await Database.Table<Music>().Where(i => i.musicval == val).FirstOrDefaultAsync();
        }

        public async Task<int> SaveMusicAsync(Music music)
        {
            await Init();
            if (music.musicID != 0)
                return await Database.UpdateAsync(music);
            else
                return await Database.InsertAsync(music);
        }

        public async Task<int> DeleteMusicAsync(Music music)
        {
            await Init();
            return await Database.DeleteAsync(music);
        }

    }
}
