class PokemonLogEntry
{
    public string Name {get;}
    public int GainedLevels {get;}
    public DateTime TimeStamp {get;}
    public PokemonLogEntry(string name, int gainedLevels)
    {
        Name = name;
        GainedLevels = gainedLevels;
        TimeStamp = DateTime.Now;
    }

}