using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;
using Vaeret_i_Bergen.Interfaces;
using Vaeret_i_Bergen.Models;

namespace Vaeret_i_Bergen.Controllers
{
	public class HomeController(IWeatherService weather, IImagesService images) : Controller
	{
		private readonly IWeatherService _weather = weather;
		private readonly IImagesService _images = images;

		public async Task<IActionResult> Index()
		{
			PageModel model = new()
			{
				Weather = await _weather.GetWeatherAsync()
			};
            Dictionary<string, WeatherImagesDict> imagesResponse = await _images.GetImagesAsync();
            bool areImagesFetched = imagesResponse.TryGetValue(model.Weather?.WeatherCode.ToString() ?? "", out WeatherImagesDict? imagesDict);
            if (areImagesFetched)
			{
                model.WeatherImage = model.Weather?.IsDay switch
				{
					0 => imagesDict?.Night,
					_ => imagesDict?.Day
				};
            }
			return View(model);
		}

		[ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
		public IActionResult Error()
		{
			return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
		}
	}
}
