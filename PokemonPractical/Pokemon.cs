public class Pokemon
{    public string Name { get; set; }
    public int Level { get; set; }
    public event Action <int> ?LeveledUp;
    public Pokemon(string name)
    {
        Name = name;
        Level = 1;  
    }
    public void GainExperience(int amount)
    {
        Level += amount;
        LeveledUp?.Invoke(amount);
    }
}
