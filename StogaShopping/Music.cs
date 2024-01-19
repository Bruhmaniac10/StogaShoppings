using Plugin.Maui.Audio;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StogaShopping
{
    public class Music
    {
        public string musicval {  get; set; }

        public int musicID { get; set; }

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
