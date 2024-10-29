using System.Text.Json.Serialization;

namespace Vaeret_i_Bergen.Models
{
	public class Weather
	{
		[JsonPropertyName("weather_code")]
		public int WeatherCode { get; set; }
		[JsonPropertyName("temperature_2m")]
		public decimal Temperature { get; set; }
		[JsonPropertyName("is_day")]
		public int IsDay { get; set; }
	}
}
