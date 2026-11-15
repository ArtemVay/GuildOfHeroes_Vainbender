Hero yaroslav = new Hero("Ярослав", 100);
Hero anastasia = new Hero("Анастасия", 90);
Hero artem = new Hero("Артём", 120);
Hero alexander = new Hero("Александр", 150);

Console.WriteLine(yaroslav.GetInfo());
Console.WriteLine();
Console.WriteLine(anastasia.GetInfo());
Console.WriteLine();
Console.WriteLine(artem.GetInfo());
Console.WriteLine();
Console.WriteLine(alexander.GetInfo());





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
// Hawkeye.Grow(3);
// Hawkeye.Grow(-3); // не сработает
// Hawkeye.Rename("Глаз сокола");
// Console.WriteLine(Hawkeye.GetInfo());