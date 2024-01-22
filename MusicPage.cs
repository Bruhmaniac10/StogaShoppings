using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Runtime.CompilerServices;

namespace StogaShopping;

public partial class MusicPage : ContentPage, INotifyPropertyChanged
{
    MusicDatabase database;
    public ObservableCollection<Music> songs;

    public MusicPage()
    {
        database = new MusicDatabase();
        songs = new ObservableCollection<Music>();
        ((MusicPage)BindingContext).InitialSongList();
    }

    public ObservableCollection<Music> Songs
    {
        get => songs;
        set
        {
            if (songs != value)
            {
                songs = value;
                OnPropertyChanged(nameof(Music));
            }
        }
    }

    public event PropertyChangedEventHandler PropertyChanged;
    protected virtual void OnPropertyChanged(string propertyName)
    {
        PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
    }

   

    public async void InitialSongList()
    {
        songs.Clear();
        songs.Add(new Music()
        {
            musicval = "/Users/neeravraj/Projects/StogaShopping/StogaShopping/Resources/Raw/Billie Eilish What Was I Made For.mp3",
            musicID = 1,
        });

        songs.Add(new Music()
        {
            musicval = "/Users/neeravraj/Projects/StogaShopping/StogaShopping/Resources/Raw/David Kushner Daylight.mp3",
            musicID = 2,
        });

        songs.Add(new Music()
        {
            musicval = "/Users/neeravraj/Projects/StogaShopping/StogaShopping/Resources/Raw/Doja Cat Paint The Town Red",
            musicID = 3,
        });

        songs.Add(new Music()
        {
            musicval = "/Users/neeravraj/Projects/StogaShopping/StogaShopping/Resources/Raw/Dua Lipa Dance The Night",
            musicID = 4,
        });

        songs.Add(new Music()
        {
            musicval = "/Users/neeravraj/Projects/StogaShopping/StogaShopping/Resources/Raw/JVKE golden hour",
            musicID = 5,
        });

        songs.Add(new Music()
        {
            musicval = "/Users/neeravraj/Projects/StogaShopping/StogaShopping/Resources/Raw/Justin Bieber Peaches ft. Daniel Caesar Giveon",
            musicID = 6,
        });

        songs.Add(new Music()
        {
            musicval = "/Users/neeravraj/Projects/StogaShopping/StogaShopping/Resources/Raw/Olivia Rodrigo deja vu",
            musicID = 7,
        });

        songs.Add(new Music()
        {
            musicval = "/Users/neeravraj/Projects/StogaShopping/StogaShopping/Resources/Raw/Rema Selena Gomez Calm Down",
            musicID = 8,
        });

        songs.Add(new Music()
        {
            musicval = "/Users/neeravraj/Projects/StogaShopping/StogaShopping/Resources/Raw/Sabrina Carpenter Feather",
            musicID = 9,
        });

        songs.Add(new Music()
        {
            musicval = "/Users/neeravraj/Projects/StogaShopping/StogaShopping/Resources/Raw/Tate McRae greedy",
            musicID = 10,
        });

        songs.Add(new Music()
        {
            musicval = "/Users/neeravraj/Projects/StogaShopping/StogaShopping/Resources/Raw/The Kid LAROI Justin Bieber STAY",
            musicID = 11,
        });

        songs.Add(new Music()
        {
            musicval = "/Users/neeravraj/Projects/StogaShopping/StogaShopping/Resources/Raw/The Weeknd Save Your Tears",
            musicID = 12,
        });

        songs.Add(new Music()
        {
            musicval = "/Users/neeravraj/Projects/StogaShopping/StogaShopping/Resources/Raw/Tyla Water",
            musicID = 13,
        });

        songs.Add(new Music()
        {
            musicval = "/Users/neeravraj/Projects/StogaShopping/StogaShopping/Resources/Raw/harry_styles___as_it_was",
            musicID = 14,
        });

        songs.Add(new Music()
        {
            musicval = "/Users/neeravraj/Projects/StogaShopping/StogaShopping/Resources/Raw/justin_bieber___ghost",
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