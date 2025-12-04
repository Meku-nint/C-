var p = new Pokemon("Pikachu");
p.GainExperience(3);
Console.WriteLine($"{p.Name} is now level {p.Level}");
var pikachu = new Pokemon("Pikachu");
var notifier = new NotificationService();
pikachu.LeveledUp += notifier.Announce;
pikachu.GainExperience(5);
var service = new PokemonService();
service.RegisterPokemon("Charmander");
service.RegisterPokemon("Squirtle");
service.Train("Charmander", 2);
service.Train("Squirtle", 3);
var pokemons= service.GetPokemons();
foreach (var poke in pokemons)
{
 Console.WriteLine($"{poke.Name} - Level {poke.Level}");
}
