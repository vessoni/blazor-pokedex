using Newtonsoft.Json;
using System.Collections.Generic;


namespace Pokedex.Api.Responses
{
    public class Type
    {
        [JsonProperty("slot")]
        public int Slot { get; set; }
        [JsonProperty("type")]
        public PokemonType PokemonType { get; set; }
    }

    public class PokemonType
    {
        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("url")]
        public string Url { get; set; }
    }
    public class Pokemon
    {
        [JsonProperty("name")]
        public string Name { get; set; }
        [JsonProperty("weight")]
        public int Weight { get; set; }
        [JsonProperty("height")]
        public int Height { get; set; }
        [JsonProperty("base_experience")]
        public int Experience { get; set; }

        [JsonProperty("id")]
        public int Id { get; set; }

        [JsonProperty("types")]
        public List<Type> Types { get; set; }

    }

}