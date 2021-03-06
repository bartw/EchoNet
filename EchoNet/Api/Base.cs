﻿using EchoNet.Models;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Windows.Web.Http;

namespace EchoNet.Api
{
    public abstract class Base
    {
        private string _baseUri;
        private string _key;
        private string _userAgent;
        
        public Base(string baseUri, string key, string userAgent)
        {
            _baseUri = baseUri;
            _key = key;
            _userAgent = userAgent;
        }

        protected KeyValuePair<string, string> GetFormatParameter(Format format)
        {
            string formatString;

            switch (format)
            {
                case Format.Json:
                    formatString = "json";
                    break;
                case Format.Xml:
                    formatString = "xml";
                    break;
                default:
                    formatString = "json";
                    break;
            }

            return new KeyValuePair<string, string>("format", formatString);
        }

        protected async Task<EchoResponse<T>> Execute<T>(string endpoint, string dataIdentifier, Dictionary<string, string> parameters = null) where T : new()
        {
            var client = new HttpClient();
            var uri = new StringBuilder();
            bool firstParam = true;

            uri.AppendFormat("{0}{1}", _baseUri, endpoint);

            if (!string.IsNullOrWhiteSpace(_key))
            {
                uri.AppendFormat("{0}api_key={1}", firstParam ? "?" : "&", _key);
                firstParam = false;
            }

            if (parameters != null && parameters.Count > 0)
            {
                foreach (var parameter in parameters)
                {
                    uri.AppendFormat("{0}{1}={2}", firstParam ? "?" : "&", parameter.Key, parameter.Value);
                    firstParam = false;
                }
            }

            var request = new HttpRequestMessage(HttpMethod.Get, new Uri(uri.ToString()));

            if (!string.IsNullOrWhiteSpace(_userAgent))
            {
                request.Headers.Add("User-Agent", _userAgent);
            }

            var response = await client.SendRequestAsync(request);
            var content = await response.Content.ReadAsStringAsync();

            var echoResponse = new EchoResponse<T>();

            echoResponse.StatusCode = response.StatusCode;

            if (response.IsSuccessStatusCode)
            {
                var jsonResponse = JObject.Parse(content);
                var data = jsonResponse["response"][dataIdentifier];
                echoResponse.Data = data.ToObject<T>(); //JsonConvert.DeserializeObject<T>(data);
            }
            else
            {
                echoResponse.ErrorMessage = content;
            }

            return echoResponse;
        }
    }
}
