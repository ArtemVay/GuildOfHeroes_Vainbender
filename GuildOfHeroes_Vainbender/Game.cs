public class Character {
    public string Name;
    public int Age { get; private set; }
    public string Race;
    public string Origin;
    public bool IsAlive;

    public int MaxHumanAge = 100;
    public int MaxElfAge = 800;

    public Character(string name, int age, string origin, string race) {
        Name = name;
        Origin = origin;
        Age = age;
        if (Age < 0) {
            Age = 0;
        }
        if (Age > MaxHumanAge && race == "Человек") {
            Age = MaxHumanAge;
        }
        else if (Age > MaxElfAge && race == "Эльф") {
            Age = MaxElfAge;
        }
        Race = race;
        IsAlive = true;
    }

    public void Grow(int n) {
        if (!IsAlive || n <= 0) {
            return;
        }

        if (n > MaxHumanAge - Age && Race == "Человек") {
            Age = MaxHumanAge;
            return;
        }
        else if (n > MaxElfAge - Age && Race == "Эльф") {
            Age = MaxElfAge;
            return;
        }

        Age += n;
    }

    public void Rename(string rn) {
        Name = rn;
    }

    public string GetInfo() {
        return $">>> {Name} <<<\n" +
               $"Возраст: {Age}\n" +
               $"Раса: {Race}\n" +
               $"Происхождение: {Origin}\n" +
               $"Статус: {(IsAlive ? "Жив" : "Мёртв")}";
    }
}