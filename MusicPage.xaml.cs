using System.Collections.ObjectModel;

namespace ShoppingDatabases;

public partial class MusicPage : ContentPage
{
	MusicDatabase database;
	ObservableCollection<Music> songs;
	public MusicPage()
	{
		InitializeComponent();
		database = new MusicDatabase();
		songs = new ObservableCollection<Music>();
	}

    public async void InitialSongList()
    {
        songs.Clear();
        songs.Add(new Music()
        {
            musicval = "supershy.mp3",
            musicID = 1,
        });

        foreach (Music music in await database.GetMusicAsync())
            await database.DeleteMusicAsync(music);

        foreach (Music music in songs)
            await database.SaveMusicAsync(music);
    }
}