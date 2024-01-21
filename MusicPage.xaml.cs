using System.Collections.ObjectModel;

namespace StogaShopping;

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
            musicval = "y2mate.is - Billie Eilish What Was I Made For Official Music Video -cW8VLC9nnTo-192k-1705854969.mp",
            musicID = 1,
        });

        songs.Add(new Music()
        {
            musicval = "y2mate.is - David Kushner Daylight Official Music Video -MoN9ql6Yymw-192k-1705854866.mp3",
            musicID = 2,
        });

        songs.Add(new Music()
        {
            musicval = "y2mate.is -Doja Cat Paint The Town Red Official Video - m4_9TFeMfJE - 192k - 1705855054.mp3",
            musicID = 3,
        });

        songs.Add(new Music()
        {
            musicval = "y2mate.is - Dua Lipa Dance The Night From Barbie The Album Official Music Video -OiC1rgCPmUQ-192k-1705854964.mp3",
            musicID = 4,
        });

        songs.Add(new Music()
        {
            musicval = "y2mate.is - JVKE golden hour official music video -PEM0Vs8jf1w-192k-1705854981.mp3",
            musicID = 5,
        });

        songs.Add(new Music()
        {
            musicval = "y2mate.is - Justin Bieber Peaches ft. Daniel Caesar Giveon-tQ0yjYUFKAE-192k-1705854985.mp3",
            musicID = 6,
        });

        songs.Add(new Music()
        {
            musicval = "y2mate.is - Olivia Rodrigo deja vu Official Video -cii6ruuycQA-192k-1705855034.mp3",
            musicID = 7,
        });

        songs.Add(new Music()
        {
            musicval = "y2mate.is -Rema Selena Gomez Calm Down Official Music Video - WcIcVapfqXw - 192k - 1705855044.mp3",
            musicID = 8,
        });

        songs.Add(new Music()
        {
            musicval = "y2mate.is - Sabrina Carpenter Feather Official Video -kLbn61Z4LDI-192k-1705854993.mp3",
            musicID = 9,
        });

        songs.Add(new Music()
        {
            musicval = "y2mate.is - Tate McRae greedy Official Video -To4SWGZkEPk-192k-1705854871.mp3",
            musicID = 10,
        });

        songs.Add(new Music()
        {
            musicval = "y2mate.is - The Kid LAROI Justin Bieber STAY Official Video -kTJczUoc26U-192k-1705854959.mp3",
            musicID = 11,
        });

        songs.Add(new Music()
        {
            musicval = "y2mate.is - The Weeknd Save Your Tears Official Music Video -XXYlFuWEuKI-192k-1705855040.mp3",
            musicID = 12,
        });

        songs.Add(new Music()
        {
            musicval = "y2mate.is - Tyla Water Official Music Video -XoiOOiuH8iI-192k-1705855050.mp3",
            musicID = 13,
        });

        songs.Add(new Music()
        {
            musicval = "y2mate.is - harry_styles___as_it_was__official_video_-H5v3kku4y6Q-192k-1705854858.mp3",
            musicID = 14,
        });

        songs.Add(new Music()
        {
            musicval = "y2mate.is - justin_bieber___ghost-Fp8msa5uYsc-192k-1705855015.mp3",
            musicID = 15,
        });


        foreach (Music music in await database.GetMusicAsync())
            await database.DeleteMusicAsync(music);

        foreach (Music music in songs)
            await database.SaveMusicAsync(music);
    }

    public async void AddSong(Music song)
    {
        songs.Add(song);
        await database.SaveMusicAsync(song);
    }
}
