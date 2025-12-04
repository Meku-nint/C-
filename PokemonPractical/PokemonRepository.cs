/*Your Task
Create a new file named PokemonRepository.cs:
− Add a private list to store Pokemon objects
− Add methods to:
− Add a Pokemon
− Get a Pokemon by name
− GetAll Pokemon
Create a new file named PokemonService.cs:
− Add methods to:
− RegisterPokemon (creates a Pokemon and saves it to the repository)
*/

public class PokemonRepository
{
    private List <Pokemon> pokemons =new List <Pokemon> ();
    public void AddPokemon(Pokemon pokemon)
    {
        pokemons.Add(pokemon);
    }
    public Pokemon? GetPokemonByName(string name)
    {
        return pokemons.FirstOrDefault(p => p.Name == name);
    }
    public List<Pokemon> GetAllPokemons()
    {
        return pokemons;
    }
}