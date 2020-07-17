using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Text;

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
                return new HttpResponse
                {

                };
            }
        }
    }
    [Serializable]
    public class HttpResponse
    {
        public int StatusCode { get; set; }
        public string Content { get; set; }


    }
}
