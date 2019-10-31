using System;

namespace EventsAndDelegatesMadeSimpleMosh.Encoding
{
    public class VideoEncoder
    {
        public event EventHandler<VideoEventArgs> VideoEncoded;
        public event EventHandler<AudioEventArgs> AudioEncoded;

        public void Encode()
        {
            Console.WriteLine("VideoEncoder: Encoding audio");
            OnAudioEncoded();
            Console.WriteLine("VideoEncoder: Encoding video");
            OnVideoEncoded();
        }

        protected virtual void OnVideoEncoded()
        {
            if (VideoEncoded != null)
            {
                VideoEncoded(this, new VideoEventArgs { Title = "Star Wars" });
            }
        }

        protected virtual void OnAudioEncoded()
        {
            if (AudioEncoded != null)
            {
                AudioEncoded(this, new AudioEventArgs { Title = "Star Wars", Encoding = "MP3" });
            }
        }
    }
}
