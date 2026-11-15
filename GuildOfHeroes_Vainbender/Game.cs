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

    public void Grow(int n) {
        if (IsAlive && n > 0) {
            Age += n;
        }
        else {
            return;
        }
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