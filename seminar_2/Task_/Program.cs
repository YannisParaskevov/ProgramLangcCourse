// задача 12. кратно ли второе число первому и если нет, то какой остаток
Console.Clear();
Console.Write("Введите число 1: ");
int a = int.Parse(Console.ReadLine());
Console.Write("Введите число 2: ");
int b = int.Parse(Console.ReadLine());
int even = a % b;
if(even == 0)
{
Console.WriteLine("кратно");
}
else
{
Console.WriteLine($"не кратно, остаток {even}");
}