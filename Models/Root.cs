using Newtonsoft.Json.Linq;
using static System.Net.Mime.MediaTypeNames;
using static System.Runtime.InteropServices.JavaScript.JSType;
using System.Drawing;
using System.Net.Sockets;
using System;

namespace Pokemon.Models
{
    public class Root
    {
        public int Count { get; set; }
        public string? Next { get; set; }
        public string? Previous { get; set; }
        public List<ResultsItem>? Results { get; set; }
        public int Id { get; set; }
        public string? Name { get; set; }
        public int Base_experience { get; set; }
        public int Height { get; set; }
        public string? Is_default { get; set; }
        public int Order { get; set; }
        public int Weight { get; set; }
        public List<AbilitiesItem>? Abilities { get; set; }
        public List<FormsItem>? Forms { get; set; }
        public List<Game_indicesItem>? Game_indices { get; set; }
        public List<Held_itemsItem>? Held_items { get; set; }
        public string? Location_area_encounters { get; set; }
        public List<MovesItem>? Moves { get; set; }
        public Species? Species { get; set; }
        public Sprites? Sprites { get; set; }
        public List<StatsItem>? Stats { get; set; }
        public List<TypesItem>? Types { get; set; }
        public List<Past_typesItem>? Past_types { get; set; }
    }
}
