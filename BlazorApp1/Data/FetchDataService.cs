using Newtonsoft.Json;
using System.Net.Http.Json;
using System.Text.Json.Serialization;

namespace BlazorApp1.Data
{
    public class FetchDataService
    {
        

        public async static Task<List<JsonData>> FetchData()
        {
            HttpClient httpClient = new HttpClient();
            var result = await httpClient.GetFromJsonAsync<List<JsonData>>("https://jsonplaceholder.typicode.com/posts");

            return result;
        }
        
    }

    public class JsonData
    {
        public int Id { get; set; }
        public int UserId { get; set; }
        public string Title { get; set; }
        public string Body { get; set; }

    }
}
