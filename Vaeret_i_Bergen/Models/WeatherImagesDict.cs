using System.Text.Json.Serialization;

namespace Vaeret_i_Bergen.Models
{
    public class WeatherImagesDict
    {
        [JsonPropertyName("day")]
        public Image? Day { get; set; }
        [JsonPropertyName("night")]
        public Image? Night { get; set; }
    }
}
