using System;
using System.Net.Http;

namespace SAL
{
    public class SALService
    {
        public HttpClient Cliente { get; set; }

        public SALService(String url)
        {
            Cliente = new HttpClient();
            //Cliente.BaseAddress = new Uri("http://localhost:52514/api/");
            Cliente.BaseAddress = new Uri(url);
            Cliente.DefaultRequestHeaders.Clear();
            Cliente.DefaultRequestHeaders.Accept.Add(new System.Net.Http.Headers.MediaTypeWithQualityHeaderValue("application/json"));
        }

        ~SALService()
        {
            Cliente.Dispose();
        }

    }
}