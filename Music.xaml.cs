using Plugin.Maui.Audio;
using SQLite;

namespace StogaShopping
{
    public partial class Music : ContentPage
    {
        [PrimaryKey, AutoIncrement]
        public int musicID { get; set; }

        public string musicval { get; set; }

        public Music()
        {
            InitializeComponent();
        }

        private readonly IAudioManager audioManager;

        public Music(IAudioManager audioManager)
        {
            this.audioManager = audioManager;
        }

        public async void play()
        {
            var player = audioManager.CreatePlayer(await FileSystem.OpenAppPackageFileAsync(musicval));
            player.Play();
        }
    }
}
