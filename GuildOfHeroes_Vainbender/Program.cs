Probe.Run();

Hero yaroslav = new Hero("Ярослав", 100);
Hero anastasia = new Hero("Анастасия", 90);
Hero artem = new Hero("Артём", 120);
Hero alexander = new Hero("   Александр   ", 150);
Hero sergey = new Hero("Сергей", 110);


alexander.TakeDamage(10);
alexander.Heal(10);

Guild guild = new Guild("Гильдия героев");
guild.Heroes.Add(yaroslav);
guild.Heroes.Add(anastasia);
guild.Heroes.Add(artem);
guild.Heroes.Add(alexander);
guild.Heroes.Add(sergey);

Console.WriteLine($">>> {guild.Name}: перекличка <<<");
Console.WriteLine($"Участников: {guild.Heroes.Count}");
if (guild.Heroes.Count > 0) {
    Console.WriteLine($"Первый: {guild.Heroes[0].Name}");
    Console.WriteLine($"Последний: {guild.Heroes[guild.Heroes.Count - 1].Name}");
}
Console.WriteLine();
foreach (Hero hero in guild.Heroes) {
    Console.WriteLine(hero.GetInfo());
    Console.WriteLine();
}
Console.WriteLine($"Предел здоровья Александра: {alexander.MaxHealth}");

int strongCount = 0;
foreach (Hero hero in guild.Heroes) {
    if (hero.Health >= 120) {
        strongCount += 1;
    }
}
Console.WriteLine($"Могут нести тяжёлые ящики (здоровье от 120): {strongCount}");

if (guild.Heroes.Count > 0) {
    Hero strongest = guild.Heroes[0];
    foreach (Hero hero in guild.Heroes) {
        if (hero.Health > strongest.Health) {
            strongest = hero;
        }
    }
    Console.WriteLine($"Самый здоровый: {strongest.Name} ({strongest.Health})");
}




// лаба 1
// Character Hawkeye = new Character("Соколиный глаз", 32, "Marvel", "Человек");
// Character Klee = new Character("Кли", 12, "Genshin Impact", "Эльф");
// Character Shane = new Character("Шейн", 20, "Stardew Valley", "Человек");

// Console.WriteLine(">>> Персонаж 1 <<<");
// Console.WriteLine($"Имя: {Hawkeye.Name}");
// Console.WriteLine($"Возраст: {Hawkeye.Age}");
// Console.WriteLine($"Раса: {Hawkeye.Race}");
// Console.WriteLine($"Происхождение: {Hawkeye.Origin}");
// Console.WriteLine($"Статус: {(Hawkeye.IsAlive ? "Жив" : "Мёртв")}");

// Console.WriteLine();

// Console.WriteLine(">>> Персонаж 2 <<<");
// Console.WriteLine($"Имя: {Klee.Name}");
// Console.WriteLine($"Возраст: {Klee.Age}");
// Console.WriteLine($"Раса: {Klee.Race}");
// Console.WriteLine($"Происхождение: {Klee.Origin}");
// Console.WriteLine($"Статус: {(Klee.IsAlive ? "Жив" : "Мёртв")}");

// Console.WriteLine();

// Console.WriteLine(">>> Персонаж 3 <<<");
// Console.WriteLine($"Имя: {Shane.Name}");
// Console.WriteLine($"Возраст: {Shane.Age}");
// Console.WriteLine($"Раса: {Shane.Race}");
// Console.WriteLine($"Происхождение: {Shane.Origin}");
// Console.WriteLine($"Статус: {(Shane.IsAlive ? "Жив" : "Мёртв")}");

// лаб 2
// Character Hawkeye = new Character("Соколиный глаз", 32, "Marvel", "Человек");
// Console.WriteLine($"До: {Hawkeye.Age}");
// Hawkeye.Grow(3);
// Console.WriteLine($"После Grow(3): {Hawkeye.Age}");
// Hawkeye.Grow(-3);
// Console.WriteLine($"После Grow(-3): {Hawkeye.Age}");
// Character nn = new Character("неизвестный", 5000, "неизвестно", "Человек");
// Console.WriteLine($"Создан с age=5000: {nn.Age}");
//лаб 4
Character Hawkeye = new Character("Соколиный глаз", 32, "Marvel", "Человек");
Character Klee = new Character("Кли", 12, "Genshin Impact", "Эльф");
Character Shane = new Character("Шейн", 20, "Stardew Valley", "Человек");

List<Character> characters = new List<Character>();
characters.Add(Hawkeye);
characters.Add(Klee);
characters.Add(Shane);

Console.WriteLine($"Персонажей: {characters.Count}");
if (characters.Count > 0) {
    Console.WriteLine($"Первый: {characters[0].Name}");
    Console.WriteLine($"Последний: {characters[characters.Count - 1].Name}");
}
    foreach (Character character in characters) {
        Console.WriteLine(character.GetInfo());
        Console.WriteLine();
    }
Character newHero = new Character("Человек-паук", 16, "Marvel", "Человек");
characters.Add(newHero);
Console.WriteLine($"После добавления: {characters.Count}");
int adultCount = 0;
foreach (Character character in characters) {
    if (character.Age > 30) {
        adultCount += 1;
    }
}
Console.WriteLine($"Старше 30: {adultCount}");
Hawkeye.Grow(5);
Console.WriteLine($"Hawkeye после изменения: {characters[0].Age}");