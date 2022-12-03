// убрать среднюю цифру из случайного трехзначного числа
Console.Clear();
int num = new Random().Next(100, 1000);
Console.WriteLine($"Число {num}");
int num1 = num / 100;
int num3 = num % 10;
Console.WriteLine($"Ответ: {num1}{num3}");

int result = (num / 100) * 10 + num % 10;
Console.WriteLine($"{num} -> {result}");

