using System.Text.Json;
using Vaeret_i_Bergen.Interfaces;
using Vaeret_i_Bergen.Models;

namespace Vaeret_i_Bergen.Services
{
    public class WeatherImagesService : IImagesService
    {
        private readonly string path = "https://gist.github.com/stellasphere/9490c195ed2b53c707087c8c2db4ec0c/raw/76b0cb0ef0bfd8a2ec988aa54e30ecd1b483495d/descriptions.json";
        public async Task<Dictionary<string, WeatherImagesDict>> GetImagesAsync()
        {
            using HttpClient client = new();
            HttpResponseMessage response = await client.GetAsync(this.path);
            if (response.IsSuccessStatusCode)
            {
                string result = await response.Content.ReadAsStringAsync();
                Dictionary<string, WeatherImagesDict>? imagesResponse = JsonSerializer.Deserialize<Dictionary<string, WeatherImagesDict>>(result);
                return imagesResponse ?? [];
            }
            return [];
        }
    }
}
