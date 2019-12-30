#define DEBUG_HTTP_HANDLER // Use this to print http requests and responses to console

using System;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Threading.Tasks;

namespace PubgNet.Http
{
    // Simple Http Handler for making requests to the PUBG api.
    //
    // The base url for PUBG at the moment is 'https://api.pubg.com/'.
    // Use this unless there are other versions available and you'd like 
    // to use that instead.
    //
    // Specify your authentication key and keep in mind the amount of requests
    // that are available to your key.
    //
    // The accepted content type can be specified to use 'application/json'
    // but it is recommended to use 'application/vnd.api+json'.
    //
    // TOOD: If requests are too large, consider controlling cache using HttpCacheControl
    public class HttpHandler
    {
        private readonly System.Net.Http.HttpClient _Client;
        private bool _HandleExceptions = true; // By default, automatically catch exceptions

        // Create a new http client with base url, authentication key, and content type.
        public HttpHandler(string base_url, string auth_key, string content_type)
        {
            // Create a new http client
            _Client = new System.Net.Http.HttpClient();

            // Set up http client
            _Client.BaseAddress = new Uri(base_url);
            _Client.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue("Bearer", auth_key);
            _Client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue(content_type));
#if DEBUG_HTTP_HANDLER
            //Console.WriteLine($"Http Client Created: {DateTime.Now.ToString("hh:mm:ss")}\nBase Url: {_Client.BaseAddress}\n{_Client.DefaultRequestHeaders}");
#endif
        }

        // Set whether to handle exceptions here or throw. By defalt this is true.
        public void SetHandleExceptions(bool val) { _HandleExceptions = val; }

        // Simple request using the base address and endpoint
        public async Task<string> RequestAsync(string endpoint)
        {
            try
            {
                HttpResponseMessage http_response = await _Client.GetAsync(_Client.BaseAddress + endpoint).ConfigureAwait(false);
                if (http_response.IsSuccessStatusCode)
                {
                    HttpContent http_content = http_response.Content;
                    string string_content = await http_content.ReadAsStringAsync().ConfigureAwait(false);
#if DEBUG_HTTP_HANDLER
                   // Console.WriteLine($"Http Request Success: {endpoint}\nContent: {string_content}");
#endif
                    return string_content;
                }
                else
                {
                    throw GetRequestException(http_response, endpoint);
                }
            }
            catch (Exception e)
            {
#if DEBUG_HTTP_HANDLER
                //Console.WriteLine(e);
#endif
                if (!_HandleExceptions) throw;
            }
            return ""; // Blank
        }

        // Check status code
        private Exception GetRequestException(HttpResponseMessage response, string endpoint)
        {
            switch (response.StatusCode)
            {
                case System.Net.HttpStatusCode.Unauthorized: return new Exception($"Http Error (401): {_Client.DefaultRequestHeaders.Authorization}");
                case System.Net.HttpStatusCode.NotFound: return new Exception($"Http Error (404): {endpoint}");
                case System.Net.HttpStatusCode.UnsupportedMediaType: return new Exception($"Http Error (415): {_Client.DefaultRequestHeaders.Accept}");
                case (System.Net.HttpStatusCode)429: return new Exception($"Http Error (429): Too many Requests");
                default: return new Exception($"Http Request Failed: {endpoint}");
            }
        }
    }
}
