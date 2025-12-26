public class Pokemon
{
    public Pokemon(string name, int level = 1)
    {
        Name = name;
        Level = level;
    }

    public string Name { get; set; }

    public int Level { get; set; }

    public event Action<int>? LeveledUp;

    public void GainExperience(int amount)
    {
        Level += amount;
        LeveledUp?.Invoke(amount);
    }
}
