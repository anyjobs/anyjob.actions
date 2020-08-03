using System;
using System.Collections.Generic;
using System.Net;
using System.Net.Http;
using System.Text;
using System.Linq;

namespace AnyJob.Packages.Net
{
    public class HttpAction : IAction
    {
        public string Url { get; set; }

        public string Method { get; set; } = "GET";

        public int TimeOut { get; set; } = 30;
        public object Run(IActionContext context)
        {
            using (HttpClient client = new HttpClient())
            {
                client.Timeout = TimeSpan.FromSeconds(this.TimeOut);
                using (var request = new HttpRequestMessage(new HttpMethod(this.Method), this.Url))
                {
                    var response = client.SendAsync(request).Result;
                    return new HttpResponse
                    {
                        StatusCode = response.StatusCode,
                        ReasonPhrase = response.ReasonPhrase,
                        Version = response.Version.ToString(),
                        IsSuccess = response.IsSuccessStatusCode,
                        Headers = response.Headers.ToDictionary(p => p.Key, p => p.Value.Last()),
                        Content = response.Content.ReadAsStringAsync().Result,
                        ContentType = response.Content.Headers.ContentType.MediaType
                    };
                };
            }
        }
    }
    [Serializable]
    public class HttpResponse
    {
        public HttpStatusCode StatusCode { get; set; }
        public string ReasonPhrase { get; set; }
        public Dictionary<string, string> Headers { get; set; }
        public string ContentType { get; set; }
        public string Content { get; set; }
        public bool IsSuccess { get; set; }
        public string Version { get; set; }

    }
}


