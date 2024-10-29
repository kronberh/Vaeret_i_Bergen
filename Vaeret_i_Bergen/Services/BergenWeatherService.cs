using System.Text.Json;
using Vaeret_i_Bergen.Interfaces;
using Vaeret_i_Bergen.Models;

namespace Vaeret_i_Bergen.Services
{
	public class BergenWeatherService : IWeatherService
	{
		private readonly string path = "https://api.open-meteo.com/v1/forecast?latitude=60.397076&longitude=5.324383&current=temperature_2m,is_day,weather_code&forecast_days=1";
		public async Task<Weather?> GetWeatherAsync()
		{
			using HttpClient client = new();
			HttpResponseMessage response = await client.GetAsync(this.path);
			if (response.IsSuccessStatusCode)
			{
				string result = await response.Content.ReadAsStringAsync();
				WeatherResponse? weatherResponse = JsonSerializer.Deserialize<WeatherResponse>(result);
				return weatherResponse?.Current;
			}
			return null;
		}
	}
}
