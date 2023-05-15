namespace Pokemon.Models
{
    public class StatsItem
    {
        public int base_stat { get; set; }
        public int effort { get; set; }
        public Stat? Stat { get; set; }
    }
}
