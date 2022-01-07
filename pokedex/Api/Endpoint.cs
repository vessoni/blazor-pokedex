namespace Pokedex.Api
{
    public static class Endpoint
    {
        public const string BaseUrl = "https://pokeapi.co/api/v2/pokemon/";

        public static class Pokemon
        {
          
            public static string Details(int id) => $"{id}";
            public static string Details(string name) => $"{name}";
        }

    }
}
