class PokemonService
{
   PokemonRepository  gain=new PokemonRepository();
    public void RegisterPokemon(string name)
    {
         var p=new Pokemon(name);
         gain.AddPokemon(p);
    }
     public void Train(string name,int amount)
    {
        var p=gain.GetPokemonByName(name);
        if(p!=null)
        {
            p.GainExperience(amount);
        }
    }
    public List<Pokemon>? GetPokemons()
    {
        return gain.GetAllPokemons();
    }
}