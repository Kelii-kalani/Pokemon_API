using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using Pokemon.Models;

namespace Pokemon
{
    public static class Pokemon 
    {
        public static Root GetPokemon(string pokemonName)
        {
            var client = new HttpClient();
            var url = $"https://pokeapi.co/api/v2/pokemon/{pokemonName}";
            var response = client.GetStringAsync(url).Result;
            var resultsItem = JsonConvert.DeserializeObject<Root>(response);
            return resultsItem;
        }
    }
}