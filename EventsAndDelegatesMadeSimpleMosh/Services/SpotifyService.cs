using EventsAndDelegatesMadeSimpleMosh.Encoding;
using System;

namespace EventsAndDelegatesMadeSimpleMosh.Services
{
    public class SpotifyService
    {
        public void OnAudioEncoded(object sender, AudioEventArgs e)
        {
            Console.WriteLine($"Encoding {e.Encoding} was used to encode the audio of {e.Title}");
        }
    }
}
