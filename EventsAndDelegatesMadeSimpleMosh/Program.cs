using EventsAndDelegatesMadeSimpleMosh.Encoding;
using EventsAndDelegatesMadeSimpleMosh.Services;
using System;
using System.Threading;

namespace EventsAndDelegatesMadeSimpleMosh
{
    class Program
    {
               
        static void Main(string[] args)
        {
            var encoder = new VideoEncoder();
            var facebookService = new FacebookService();
            var youtubeService = new YouTubeService();
            var spotifyService = new SpotifyService();

            // Subscribe
            encoder.VideoEncoded += facebookService.OnVideoEncoded;
            encoder.VideoEncoded += youtubeService.OnVideoEncoded;

            encoder.AudioEncoded += spotifyService.OnAudioEncoded;
            
            // Execute Encode
            encoder.Encode();
        }
    }
}
