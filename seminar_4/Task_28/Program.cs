// принимает на вход число N и выдаёт произведение чисел от 1 до N
Console.Clear();
Console.Write("Введите целое положительное число: ");
int num = int.Parse(Console.ReadLine());
if(num < 0) 
{
    Console.WriteLine ("Введено неправильное число"); 
    return;
}
if (num == 0) 
{
Console.WriteLine ($"{num}  -> 1");
return;
}
else
{
Console.WriteLine ($"{num} ->  {Factorial (num)}");
}
int Factorial (int number)
{
int Factor = 1;
    for (int i=1; i < num; i++){
        Factor = Factor * i;
    }
    return Factor;
}