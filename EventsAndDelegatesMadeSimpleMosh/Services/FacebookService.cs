using EventsAndDelegatesMadeSimpleMosh.Encoding;
using System;
using System.Threading;

namespace EventsAndDelegatesMadeSimpleMosh.Services
{
    public class FacebookService
    {
        public void OnVideoEncoded(object sender, VideoEventArgs e)
        {
            Console.WriteLine($"Posting {e.Title} to your facebook wall..");

            Thread.Sleep(3000);

            Console.WriteLine($"Video {e.Title} posted");
        }
    }
}
