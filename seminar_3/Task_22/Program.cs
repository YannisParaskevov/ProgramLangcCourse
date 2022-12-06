// принимает на вход число (N) и выдаёт таблицу квадратов чисел от 1 до N.
Console.Clear();
Console.Write("Введите натуральное число: ");
int num = int.Parse(Console.ReadLine());
if(num < 0)  Console.WriteLine("'Это не натуральное число");
if(num == 0)  
{
    Console.Write("0.");
    return;
}
int index = 1;
while(index < num)
{
    Console.Write($"{Math.Pow(index,2)}, ");
    index++;
}
Console.WriteLine($"{Math.Pow(index,2)}.");
