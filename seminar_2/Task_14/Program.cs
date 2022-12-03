// принимает на вход число и проверяет, кратно ли оно одновременно 7 и 23
// Console.Clear();
Console.Write("Введите число: ");
int num = int.Parse(Console.ReadLine());
int even7 = num % 7;
int even23 = num % 23;
Console.WriteLine($"{even7} {even23}");
if(even7 == 0 && even23 == 0) 
{
    Console.WriteLine("да, кратно");
}
else
{
Console.WriteLine("не кратно");
Console.WriteLine($"Остаток деления на 7 = {even7}");
Console.WriteLine($"Остаток деления на 23 = {even23}");
}
