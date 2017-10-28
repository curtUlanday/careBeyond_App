using System;
using System.Threading.Tasks;
using System.Net.Http;
using Newtonsoft.Json;
using System.Net.Http.Headers;
using System.Collections.Generic;

namespace careBeyond_App.Controller
{
    public static class APIService
    {
        public static async Task<string> getSerializeJSON(string url)
        {
            if (!string.IsNullOrEmpty(url))
            {
                using (var httpClient = new HttpClient())
                {
                    httpClient.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));
                    var jsonData = string.Empty;
                    try
                    {
                        jsonData = await httpClient.GetStringAsync(url);
                    }
                    catch (Exception)
                    {
                        return jsonData = string.Empty;
                    }
                    return !string.IsNullOrEmpty(jsonData) ? jsonData : jsonData = string.Empty;
                }
            }
            else
            {
                return "Invalid URL";
            }
        }

        public static async Task<T> postSerializeJSON<T>(string url, Dictionary<string, string> keyValueData)
        {
            using (var httpClient = new HttpClient())
            {
                httpClient.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));
                var jsonData = string.Empty;
                var content = new FormUrlEncodedContent(keyValueData);
                try
                {
                    var httpResponse = await httpClient.PostAsync(url,content);
                    httpResponse.EnsureSuccessStatusCode();
                    jsonData = await httpResponse.Content.ReadAsStringAsync();
                }
                catch (Exception)
                {
                    return default(T);
                }
                return !string.IsNullOrEmpty(jsonData) ? JsonConvert.DeserializeObject<T>(jsonData) : default(T);
            }
        }

        /**
        public static async Task<string> getSerializeJSON2(string url)
        {
            var request = new HttpRequestMessage();
            request.RequestUri = new Uri(url);
            request.Method = HttpMethod.Get;
            request.Headers.Add("Accept", "application/json");
            request.Headers.Add("Cache-Control", "no-cache");
            request.Headers.Add("Postman-Token", "1be474d8-3ba7-46ea-5748-a409f87312ce");
            var client = new HttpClient();
            var jsonData = string.Empty;

            HttpResponseMessage response = await client.SendAsync(request);
            if (response.StatusCode == System.Net.HttpStatusCode.OK)
            {
                HttpContent content = response.Content;
                jsonData = await content.ReadAsStringAsync();
            }
            return jsonData;
        }
        */


    }
}