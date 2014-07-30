using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EchoNet
{
    public class Client
    {
        private readonly string _baseUri = "http://developer.echonest.com/api/v4";
        public Api.Artist Artist { get; set; }
        public Api.Genre Genre { get; set; }
        public Api.Song Song { get; set; }
        public Api.Track Track { get; set; }

        public Client(string key, string userAgent)
        {
            Artist = new Api.Artist(_baseUri, key, userAgent);
            Genre = new Api.Genre(_baseUri, key, userAgent);
            Song = new Api.Song(_baseUri, key, userAgent);
            Track = new Api.Track(_baseUri, key, userAgent);
        }
    }
}
