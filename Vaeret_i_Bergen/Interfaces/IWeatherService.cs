using Vaeret_i_Bergen.Models;

namespace Vaeret_i_Bergen.Interfaces
{
	public interface IWeatherService
	{
		public Task<Weather?> GetWeatherAsync();
	}
}
