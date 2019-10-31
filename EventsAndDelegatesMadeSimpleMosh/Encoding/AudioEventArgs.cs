using System;

namespace EventsAndDelegatesMadeSimpleMosh.Encoding
{
    public class AudioEventArgs : EventArgs
    {
        public string Encoding { get; set; }
        public string Title { get; set; }
    }
}
