using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EchoNet.Api
{
    public class Song : Base
    {
        public Song(string baseUri, string key, string userAgent)
            : base(string.Format("{0}/song", baseUri), key, userAgent)
        {
        }
    }
}
