using System.Collections.ObjectModel;
using System.ComponentModel;

namespace StogaShopping
{
    public class MusicPageViewModel : INotifyPropertyChanged
    {
        public ObservableCollection<Music> music;

        public ObservableCollection<Music> Music
        {
            get => music;
            set
            {
                if (music != value)
                {
                    music = value;
                    OnPropertyChanged(nameof(Music));
                }
            }
        }

        public async Task LoadData()
        {
            var musicDatabase = new MusicDatabase();
            var songs = await musicDatabase.GetMusicAsync();
            Music = new ObservableCollection<Music>(songs);
        }

        public event PropertyChangedEventHandler PropertyChanged;

        protected virtual void OnPropertyChanged(string propertyName)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
    }
}
