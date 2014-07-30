using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EchoNet.Api
{
    public class Track : Base
    {
        public Track(string baseUri, string key, string userAgent)
            : base(string.Format("{0}/track", baseUri), key, userAgent)
        {
        }
    }
}
