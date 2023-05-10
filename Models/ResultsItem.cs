using DocumentFormat.OpenXml.Drawing;
using Pokemon.Models;
using System.ComponentModel;

namespace Pokemon.Models
{
    public class Ability
    {
        public string name { get; set; }
        public string url { get; set; }
    }

    public class AbilitiesItem
    {
        public string is_hidden { get; set; }
        public int slot { get; set; }
        public Ability ability { get; set; }
    }

    public class FormsItem
    {
        public string name { get; set; }
        public string url { get; set; }
    }

    public class Version
    {
        public string name { get; set; }
        public string url { get; set; }
    }

    public class Game_indicesItem
    {
        public int game_index { get; set; }
        public Version version { get; set; }
    }

    public class Item
    {
        public string name { get; set; }
        public string url { get; set; }
    }

    public class Version_detailsItem
    {
        public int rarity { get; set; }
        public Version version { get; set; }
    }

    public class Held_itemsItem
    {
        public Item item { get; set; }
        public List<Version_detailsItem> version_details { get; set; }
    }

    public class Move
    {
        public string name { get; set; }
        public string url { get; set; }
    }

    public class Version_group
    {
        public string name { get; set; }
        public string url { get; set; }
    }

    public class Move_learn_method
    {
        public string name { get; set; }
        public string url { get; set; }
    }

    public class Version_group_detailsItem
    {
        public int level_learned_at { get; set; }
        public Version_group version_group { get; set; }
        public Move_learn_method move_learn_method { get; set; }
    }

    public class MovesItem
    {
        public Move move { get; set; }
        public List<Version_group_detailsItem> version_group_details { get; set; }
    }

    public class Species
    {
        public string name { get; set; }
        public string url { get; set; }
    }

    public class Dream_world
    {
        public string front_default { get; set; }
        public string front_female { get; set; }
    }

    public class Home
    {
        public string front_default { get; set; }
        public string front_female { get; set; }
        public string front_shiny { get; set; }
        public string front_shiny_female { get; set; }
    }

    public class Official-artwork
{
        public string front_default { get; set; }
}

public class Other
{
    public Dream_world dream_world { get; set; }
    public Home home { get; set; }
    public Official-artwork official-artwork { get; set; }
}

public class Red-Blue
{
        public string back_default { get; set; }
public string back_gray { get; set; }
public string front_default { get; set; }
public string front_gray { get; set; }
}

public class Yellow
{
    public string back_default { get; set; }
    public string back_gray { get; set; }
    public string front_default { get; set; }
    public string front_gray { get; set; }
}

public class Generation-i
{
        public Red -blue red - blue { get; set; }
public Yellow yellow { get; set; }
}

public class Crystal
{
    public string back_default { get; set; }
    public string back_shiny { get; set; }
    public string front_default { get; set; }
    public string front_shiny { get; set; }
}

public class Gold
{
    public string back_default { get; set; }
    public string back_shiny { get; set; }
    public string front_default { get; set; }
    public string front_shiny { get; set; }
}

public class Silver
{
    public string back_default { get; set; }
    public string back_shiny { get; set; }
    public string front_default { get; set; }
    public string front_shiny { get; set; }
}

public class Generation-ii
{
        public Crystal crystal { get; set; }
public Gold gold { get; set; }
public Silver silver { get; set; }
}

public class Emerald
{
    public string front_default { get; set; }
    public string front_shiny { get; set; }
}

public class Firered-leafgreen
{
        public string back_default { get; set; }
public string back_shiny { get; set; }
public string front_default { get; set; }
public string front_shiny { get; set; }
}

public class Ruby-sapphire
{
        public string back_default { get; set; }
public string back_shiny { get; set; }
public string front_default { get; set; }
public string front_shiny { get; set; }
}

public class Generation-iii
{
        public Emerald emerald { get; set; }
public Firered -leafgreen firered - leafgreen { get; set; }
public Ruby -sapphire ruby - sapphire { get; set; }
}

public class Diamond-pearl
{
        public string back_default { get; set; }
public string back_female { get; set; }
public string back_shiny { get; set; }
public string back_shiny_female { get; set; }
public string front_default { get; set; }
public string front_female { get; set; }
public string front_shiny { get; set; }
public string front_shiny_female { get; set; }
}

public class Heartgold-soulsilver
{
        public string back_default { get; set; }
public string back_female { get; set; }
public string back_shiny { get; set; }
public string back_shiny_female { get; set; }
public string front_default { get; set; }
public string front_female { get; set; }
public string front_shiny { get; set; }
public string front_shiny_female { get; set; }
}

public class Platinum
{
    public string back_default { get; set; }
    public string back_female { get; set; }
    public string back_shiny { get; set; }
    public string back_shiny_female { get; set; }
    public string front_default { get; set; }
    public string front_female { get; set; }
    public string front_shiny { get; set; }
    public string front_shiny_female { get; set; }
}

public class Generation-iv
{
        public Diamond -pearl diamond - pearl { get; set; }
public Heartgold -soulsilver heartgold - soulsilver { get; set; }
public Platinum platinum { get; set; }
}

public class Animated
{
    public string back_default { get; set; }
    public string back_female { get; set; }
    public string back_shiny { get; set; }
    public string back_shiny_female { get; set; }
    public string front_default { get; set; }
    public string front_female { get; set; }
    public string front_shiny { get; set; }
    public string front_shiny_female { get; set; }
}

public class Black-white
{
        public Animated animated { get; set; }
public string back_default { get; set; }
public string back_female { get; set; }
public string back_shiny { get; set; }
public string back_shiny_female { get; set; }
public string front_default { get; set; }
public string front_female { get; set; }
public string front_shiny { get; set; }
public string front_shiny_female { get; set; }
}

public class Generation-v
{
        public Black -white black - white { get; set; }
}

public class Omegaruby-alphasapphire
{
        public string front_default { get; set; }
public string front_female { get; set; }
public string front_shiny { get; set; }
public string front_shiny_female { get; set; }
}

public class X-y
{
        public string front_default { get; set; }
public string front_female { get; set; }
public string front_shiny { get; set; }
public string front_shiny_female { get; set; }
}

public class Generation-vi
{
        public Omegaruby -alphasapphire omegaruby - alphasapphire { get; set; }
public X -y x - y { get; set; }
}

public class Icons
{
    public string front_default { get; set; }
    public string front_female { get; set; }
}

public class Ultra-sun - ultra - moon
{
        public string front_default { get; set; }
public string front_female { get; set; }
public string front_shiny { get; set; }
public string front_shiny_female { get; set; }
}

public class Generation-vii
{
        public Icons icons { get; set; }
public Ultra -sun - ultra - moon ultra - sun - ultra - moon { get; set; }
}

public class Icons
{
    public string front_default { get; set; }
    public string front_female { get; set; }
}

public class Generation-viii
{
        public Icons icons { get; set; }
}

public class Versions
{
    public Generation-i generation-i { get; set; }
public Generation -ii generation - ii { get; set; }
public Generation -iii generation - iii { get; set; }
public Generation -iv generation - iv { get; set; }
public Generation -v generation - v { get; set; }
public Generation -vi generation - vi { get; set; }
public Generation -vii generation - vii { get; set; }
public Generation -viii generation - viii { get; set; }
}

public class Sprites
{
    public string back_default { get; set; }
    public string back_female { get; set; }
    public string back_shiny { get; set; }
    public string back_shiny_female { get; set; }
    public string front_default { get; set; }
    public string front_female { get; set; }
    public string front_shiny { get; set; }
    public string front_shiny_female { get; set; }
    public Other other { get; set; }
    public Versions versions { get; set; }
}

public class Stat
{
    public string name { get; set; }
    public string url { get; set; }
}

public class StatsItem
{
    public int base_stat { get; set; }
    public int effort { get; set; }
    public Stat stat { get; set; }
}

public class Type
{
    public string name { get; set; }
    public string url { get; set; }
}

public class TypesItem
{
    public int slot { get; set; }
    public Type type { get; set; }
}

public class Generation
{
    public string name { get; set; }
    public string url { get; set; }
}

public class Type
{
    public string name { get; set; }
    public string url { get; set; }
}

public class TypesItem
{
    public int slot { get; set; }
    public Type type { get; set; }
}

public class Past_typesItem
{
    public Generation generation { get; set; }
    public List<TypesItem> types { get; set; }
}

public class Root
{
    public int id { get; set; }
    public string name { get; set; }
    public int base_experience { get; set; }
    public int height { get; set; }
    public string is_default { get; set; }
    public int order { get; set; }
    public int weight { get; set; }
    public List<AbilitiesItem> abilities { get; set; }
    public List<FormsItem> forms { get; set; }
    public List<Game_indicesItem> game_indices { get; set; }
    public List<Held_itemsItem> held_items { get; set; }
    public string location_area_encounters { get; set; }
    public List<MovesItem> moves { get; set; }
    public Species species { get; set; }
    public Sprites sprites { get; set; }
    public List<StatsItem> stats { get; set; }
    public List<TypesItem> types { get; set; }
    public List<Past_typesItem> past_types { get; set; }
}


