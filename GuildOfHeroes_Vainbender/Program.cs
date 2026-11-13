Hero yaroslav = new Hero("Ярослав", 100);
Hero anastasia = new Hero("Анастасия", 90);
Hero artem = new Hero("Артём", 120);

yaroslav.Health = 75;

Console.WriteLine(">>> Герой 1 <<<");
Console.WriteLine($"Имя: {yaroslav.Name}");
Console.WriteLine($"Здоровье: {yaroslav.Health}");
Console.WriteLine($"Уровень: {yaroslav.Level}");
Console.WriteLine($"Опыт: {yaroslav.Experience}");

Console.WriteLine();

Console.WriteLine(">>> Герой 2 <<<");
Console.WriteLine($"Имя: {anastasia.Name}");
Console.WriteLine($"Здоровье: {anastasia.Health}");
Console.WriteLine($"Уровень: {anastasia.Level}");
Console.WriteLine($"Опыт: {anastasia.Experience}");

Console.WriteLine();

Console.WriteLine(">>> Герой 3 <<<");
Console.WriteLine($"Имя: {artem.Name}");
Console.WriteLine($"Здоровье: {artem.Health}");
Console.WriteLine($"Уровень: {artem.Level}");
Console.WriteLine($"Опыт: {artem.Experience}");

Console.WriteLine();

Character Hawkeye = new Character("Соколиный глаз", 32, "Marvel", "Человек");
Character Klee = new Character("Кли", 12, "Genshin Impact", "Эльф");
Character Shane = new Character("Шейн", 20, "Stardew Valley", "Человек");

Console.WriteLine(">>> Персонаж 1 <<<");
Console.WriteLine($"Имя: {Hawkeye.Name}");
Console.WriteLine($"Возраст: {Hawkeye.Age}");
Console.WriteLine($"Раса: {Hawkeye.Race}");
Console.WriteLine($"Происхождение: {Hawkeye.Origin}");
Console.WriteLine($"Статус: {(Hawkeye.IsAlive ? "Жив" : "Мёртв")}");

Console.WriteLine();

Console.WriteLine(">>> Персонаж 2 <<<");
Console.WriteLine($"Имя: {Klee.Name}");
Console.WriteLine($"Возраст: {Klee.Age}");
Console.WriteLine($"Раса: {Klee.Race}");
Console.WriteLine($"Происхождение: {Klee.Origin}");
Console.WriteLine($"Статус: {(Klee.IsAlive ? "Жив" : "Мёртв")}");

Console.WriteLine();

Console.WriteLine(">>> Персонаж 3 <<<");
Console.WriteLine($"Имя: {Shane.Name}");
Console.WriteLine($"Возраст: {Shane.Age}");
Console.WriteLine($"Раса: {Shane.Race}");
Console.WriteLine($"Происхождение: {Shane.Origin}");
Console.WriteLine($"Статус: {(Shane.IsAlive ? "Жив" : "Мёртв")}");
