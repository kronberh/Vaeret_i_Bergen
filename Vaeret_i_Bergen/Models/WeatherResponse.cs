using System.Text.Json.Serialization;

namespace Vaeret_i_Bergen.Models
{
    public class WeatherResponse
    {
        [JsonPropertyName("current")]
        public Weather? Current { get; set; }
    }
}
