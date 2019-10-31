using EventsAndDelegatesMadeSimpleMosh.Encoding;
using System;
using System.Threading;

namespace EventsAndDelegatesMadeSimpleMosh.Services
{
    public class YouTubeService
    {
        public void OnVideoEncoded(object sender, VideoEventArgs e)
        {
            Console.WriteLine($"Uploading video to youtube {e.Title}..");

            Thread.Sleep(1000);

            Console.WriteLine($"Video {e.Title} is uploaded..");
        }
    }
}
