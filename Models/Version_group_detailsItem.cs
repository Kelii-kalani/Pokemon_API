namespace Pokemon.Models
{
    public class Version_group_detailsItem
    {
        public int Level_learned_at { get; set; }
        public Version_group? Version_group { get; set; }
        public Move_learn_method? Move_learn_method { get; set; }
    }
}
