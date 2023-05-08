using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using Pokemon.Models;

namespace Pokemon.Controllers
{
    public class PoemonController : Controller
    {
        public IActionResult Index([FromQuery(Name = "resource_url")] string resourceUrl = "https://pokeapi.co/api/v2/pokemon/")
        {
            if (resourceUrl.StartsWith("https://pokeapi.co"))
            {
                var client = new HttpClient();
                var url = resourceUrl;
                var response = client.GetStringAsync(url).Result;
                var resultsItem = JsonConvert.DeserializeObject<Root>(response);

                return View(resultsItem);
            }
            else
            {
                return View("Invalid Page");
            }
           
        }
        public IActionResult CallNameOfPokemon(string name)
        {
            string resourceUrl = $"https://pokeapi.co/api/v2/pokemon/{name}";

            if (resourceUrl.StartsWith("https://pokeapi.co"))
            {
                var client = new HttpClient();
                var url = resourceUrl;
                var response = client.GetStringAsync(url).Result;
                var resultsItem = JsonConvert.DeserializeObject<Root>(response);

                return View(resultsItem);
            }
            else
            {
                return View("Invalid Page");
            }
        }
    }
}
