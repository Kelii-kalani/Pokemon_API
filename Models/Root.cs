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
        public string Next { get; set; }
        public string Previous { get; set; }
        public List<ResultsItem> Results { get; set; }

    }

    public class ResultsItem
    {
        public string Name { get; set; }
        public string Url { get; set; }
    }
}
