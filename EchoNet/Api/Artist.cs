using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EchoNet.Api
{
    public class Artist : Base
    {
        public Artist(string baseUri, string key, string userAgent)
            : base(string.Format("{0}/artist", baseUri), key, userAgent)
        {
        }

        public async Task<object> Biographies(string id, Format format = Format.Json, int results = 15, int start = 0)
        {
            if (string.IsNullOrEmpty(id))
            {
                throw new ArgumentException("Id can not be null or empty.");
            }

            if (results < 0 || results > 100)
            {
                results = 15;
            }

            var parameters = new Dictionary<string, string>();

            parameters.Add("id", id);
            parameters.Add("format", format == Format.Xml ? "xml" : "josn");
            parameters.Add("results", results.ToString());
            parameters.Add("start", start.ToString());

            return await Execute<object>("/biographies", parameters);
        }
    }
}
