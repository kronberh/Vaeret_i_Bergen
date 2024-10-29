using Vaeret_i_Bergen.Models;

namespace Vaeret_i_Bergen.Interfaces
{
    public interface IImagesService
    {
        public Task<Dictionary<string, WeatherImagesDict>> GetImagesAsync();
    }
}
