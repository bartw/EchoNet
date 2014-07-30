using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EchoNet.Api
{
    public class Genre : Base
    {
        public Genre(string baseUri, string key, string userAgent)
            : base(string.Format("{0}/genre", baseUri), key, userAgent)
        {
        }
    }
}
