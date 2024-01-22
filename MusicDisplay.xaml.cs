using System.Collections.ObjectModel;
using Plugin.Maui.Audio;

namespace StogaShopping
{
    public partial class MusicDisplay : ContentPage
    {
        private IAudioManager audioManager;
        private MusicPageViewModel viewModel;
        private IAudioPlayer player;
        private int currentSongIndex = 0;

        public MusicDisplay()
        {
            InitializeComponent();
            viewModel = new MusicPageViewModel();
            BindingContext = viewModel;
            InitializePlayerAsync();
        }

        private async void ShoppingClicked(System.Object sender, EventArgs e)
        {
            await Navigation.PushAsync(new ShoppingPage());
        }

        private async void MusicClicked(System.Object sender, EventArgs e)
        {
            await Navigation.PushAsync(new MusicDisplay());
        }

        private async void DealsClicked(System.Object sender, EventArgs e)
        {
            await Navigation.PushAsync(new DealsPage());
        }

        private async void SellClicked(System.Object sender, EventArgs e)
        {
            await Navigation.PushAsync(new SellPage());
        }

        private async void CartClicked(System.Object sender, EventArgs e)
        {
            if (Application.Current.MainPage.Navigation.NavigationStack.FirstOrDefault(p => p is CartPage) == null)
            {
                await Navigation.PushAsync(new CartPage());
            }
        }

        private async void AccountClicked(System.Object sender, EventArgs e)
        {
            await Navigation.PushAsync(new AccountPage());
        }

        private async void HelpClicked(System.Object sender, EventArgs e)
        {
            await Navigation.PushAsync(new HelpPage());
        }

        private async Task InitializePlayerAsync()
        {
            await viewModel.LoadData();

            if (viewModel.Music.Any())
            {
                var currentSong = viewModel.Music[currentSongIndex];
                var audioFile = await FileSystem.OpenAppPackageFileAsync(currentSong.musicval);
                player = audioManager.CreatePlayer(audioFile);
            }
        }

        private void PlayButton_Clicked(object sender, EventArgs e)
        {
            if (player != null)
                player.Play();
        }

        private void PauseButton_Clicked(object sender, EventArgs e)
        {
            if (player != null)
                player.Pause();
        }

        private void LoopButton_Clicked(object sender, EventArgs e)
        {
            if (player != null)
                player.Loop = !player.Loop;
        }

        private void NextButton_Clicked(object sender, EventArgs e)
        {
            PlayNextSong();
        }

        private async void PlayNextSong()
        {
            if (viewModel.Music.Any())
            {
                currentSongIndex = (currentSongIndex + 1) % viewModel.Music.Count;
                var nextSong = viewModel.Music[currentSongIndex];
                var audioFile = await FileSystem.OpenAppPackageFileAsync(nextSong.musicval);

                player.Stop();
                player = audioManager.CreatePlayer(audioFile);
                player.Play();
            }
        }

        private void LikeButton_Clicked(object sender, EventArgs e)
        {

        }

        private void SongProgressSlider_ValueChanged(object sender, ValueChangedEventArgs e)
        {
            if (player != null)
            {
                var newPositionSeconds = e.NewValue;
                player.Seek(newPositionSeconds);
            }
        }
    }
}
