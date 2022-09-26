using Microsoft.AspNetCore.Mvc;
using Postman.Models;
using System.Diagnostics;
using System.Net.Http.Json;

namespace Postman.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        public IActionResult Index()
        {
            HttpClient client = new HttpClient();
            string api = ("https://api.openweathermap.org/data/2.5/forecast?lat=55.676098&lon=12.568337&appid=36748394e6dde14a7ba9e505afe4df12");
            var result = client.GetFromJsonAsync<WeatherForecast.Root>(api);
            
            return View(result.Result);
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }

        //[HttpGet("{id}")]
        //public async Task<IActionResult> GetForecasts(int id)
        //{
            
        //}
       
    }
}