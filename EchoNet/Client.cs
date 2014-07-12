using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EchoNet
{
    public class Client
    {
        public Api.Artist Artist { get; set; }
        public Api.Genre Genre { get; set; }
        public Api.Song Song { get; set; }
        public Api.Track Track { get; set; }
    }
}
