var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
// Learn more about configuring OpenAPI at https://aka.ms/aspnet/openapi
builder.Services.AddOpenApi();

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.MapOpenApi();
}

app.UseHttpsRedirection();
var pokemons = new List<Pokemon>
{
    new("Pikachu", 5),
    new("Charmander", 3),
    new("Bulbasaur", 4)
};
app.MapGet("/",()=>"Welcome to the pokemon api session-2");
app.MapGet("/pokemon", () => Results.Ok(pokemons) );
app.MapGet("/pokemon/{name}", (string name) =>
{
    var pokemon = pokemons.FirstOrDefault(p =>
        string.Equals(p.Name, name, StringComparison.OrdinalIgnoreCase));

    if (pokemon is null)
    {
        return Results.Json(new
        {
            status = 404,
            message = "Pokemon not found"
        }, statusCode: 404);
    }

    return Results.Json(new
    {
        status = 200,
        message = "Pokemon found",
        data = pokemon
    }, statusCode: 200);
});

// Gain experience for a Pokémon by name
app.MapPost("/pokemon/{name}/experience/{amount:int}", (string name, int amount) =>
{
    if (amount <= 0)
    {
        return Results.Json(new
        {
            status = 400,
            message = "Amount must be positive"
        }, statusCode: 400);
    }

    var pokemon = pokemons.FirstOrDefault(p =>
        string.Equals(p.Name, name, StringComparison.OrdinalIgnoreCase));

    if (pokemon is null)
    {
        return Results.Json(new
        {
            status = 404,
            message = "Pokemon not found"
        }, statusCode: 404);
    }

    pokemon.GainExperience(amount);

    return Results.Json(new
    {
        status = 200,
        message = "Experience applied",
        data = pokemon
    }, statusCode: 200);
});


app.MapPost("/pokemon", (Pokemon pokemon) =>
{
    if (string.IsNullOrWhiteSpace(pokemon.Name))
    {
        return Results.BadRequest("Name is required.");
    }
    pokemons.Add(pokemon);
    var location = $"/pokemon/{pokemon.Name}";
    return Results.Created(location, pokemon);
});
app.MapDelete("/pokemon/{name}", (string name) =>
{
    var removed = pokemons.RemoveAll(p =>
        string.Equals(p.Name, name, StringComparison.OrdinalIgnoreCase));

    if (removed == 0)
    {        return Results.Json(new
        {
            status = 404,
            message = "Pokemon not found"
        }, statusCode: 404);
    }
    return Results.Json(new
    {
        status = 200,
        message = "Pokemon deleted successfully",
        data = pokemons
    }, statusCode: 200);
});

app.Run();