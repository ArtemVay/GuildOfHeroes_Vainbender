// Hero yaroslav = new Hero("Ярослав", 100);
// Hero anastasia = new Hero("Анастасия", 90);
// Hero artem = new Hero("Артём", 120);

// Console.WriteLine($"До вызовов: {yaroslav.Health}, {anastasia.Health}, {artem.Health}");

// yaroslav.TakeDamage(25);
// anastasia.TakeDamage(30);

// Console.WriteLine($"После вызовов: {yaroslav.Health}, {anastasia.Health}, {artem.Health}");

// yaroslav.TakeDamage(-20);
// Console.WriteLine($"После неверного урона: {yaroslav.Health}");

// artem.TakeDamage(200);
// Console.WriteLine($"После сильного урона, Артём: {artem.Health}");
// yaroslav.Heal(10);
// yaroslav.GainExperience(40);
// yaroslav.GainExperience(25);

// Console.WriteLine($"После лечения, Ярослав: {yaroslav.Health}");
// Console.WriteLine($"Опыт Ярослава: {yaroslav.Experience}");
// bool yaroslavAlive = yaroslav.IsAlive();
// Console.WriteLine($"Ярослав жив: {yaroslavAlive}");
// Console.WriteLine($"Артём жив: {artem.IsAlive()}");

// if (yaroslavAlive) {
//     Console.WriteLine("Ярослав может продолжать приключение.");
// }
// else {
//     Console.WriteLine("Ярослав больше не может сражаться.");
// }
// string info = yaroslav.GetInfo();
// Console.WriteLine("Строка получена. Сейчас выведем её:");
// Console.WriteLine(info);

// Console.WriteLine();
// Console.WriteLine(anastasia.GetInfo());
// Console.WriteLine();
// Console.WriteLine(artem.GetInfo());

Hero margarita = new Hero("Маргарита", 80);
margarita.TakeDamage(30);
margarita.Heal(15);
margarita.GainExperience(50);
bool margoAlive = margarita.IsAlive();
Console.WriteLine($"Маргарита жива: {margoAlive}");
Console.WriteLine(margarita.GetInfo());

Hero yaroslav = new Hero("Ярослав", 100);
Hero anastasia = new Hero("Анастасия", 100);

yaroslav.TakeDamage(40);

Console.WriteLine($"Ярослав: {yaroslav.Health}");
Console.WriteLine($"Анастасия: {anastasia.Health}");

anastasia.TakeDamage(10);

Console.WriteLine($"Ярослав: {yaroslav.Health}");
Console.WriteLine($"Анастасия: {anastasia.Health}");
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

Character Hawkeye = new Character("Соколиный глаз", 32, "Marvel", "Человек");
Hawkeye.Grow(3);
Hawkeye.Grow(-3); // не сработает
Hawkeye.Rename("Глаз сокола");
Console.WriteLine(Hawkeye.GetInfo());