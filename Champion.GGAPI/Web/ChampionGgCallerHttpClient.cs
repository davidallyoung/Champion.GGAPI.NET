using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;
using Champion.GGAPI.Exception;
using Newtonsoft.Json;

namespace Champion.GGAPI.Web
{
    class ChampionGgCallerHttpClient
    {
        private const string ChampionGGBaseUrl = "http://api.champion.gg/";
        public static async Task<T> CallChampionGgApiAsync<T>(string apiCallPath)
        {
            using (var client = new HttpClient())
            {
                client.BaseAddress = new Uri(ChampionGGBaseUrl);
                client.DefaultRequestHeaders.Accept.Clear();
                client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));

                var completeUrl = $"{ChampionGGBaseUrl}{apiCallPath}";
                var response = await client.GetAsync(completeUrl);

                var json = await response.Content.ReadAsStringAsync();
                if (response.IsSuccessStatusCode)
                {
                    return JsonConvert.DeserializeObject<T>(json);
                }

                throw ChampionGgApiException.CreateForErrorCode((int)response.StatusCode);
            }
        }
    }
}
