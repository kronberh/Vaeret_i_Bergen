using System.Text.Json.Serialization;

namespace Vaeret_i_Bergen.Models
{
    public class Image
    {
        [JsonPropertyName("description")]
        public string Description { get; set; } = null!;
        [JsonPropertyName("image")]
        public string ImageUrl { get; set; } = null!;
    }
}
