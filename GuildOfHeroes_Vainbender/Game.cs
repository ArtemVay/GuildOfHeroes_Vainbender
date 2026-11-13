public class Character {
    public string Name;
    public int Age;
    public string Race;
    public string Origin;
    public bool IsAlive;


    public Character(string name, int age, string origin, string race) {
        Name = name;
        Origin = origin;
        Age = age;
        Race = race;
        IsAlive = true;
    }
}