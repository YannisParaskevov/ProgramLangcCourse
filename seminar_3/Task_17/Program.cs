// показывает номер четверти для точки X Y
Console.Clear();
Console.Write("Введите координату X: ");
int X = int.Parse(Console.ReadLine());
Console.Write("Введите координату Y: ");
int Y = int.Parse(Console.ReadLine());
int num = 1;
if(X>0)
{
    if(Y>0)
    {
        num = 1;
        Console.WriteLine($"{num}, первая четверть");
    }
    else
    {
        num = 4;
        Console.WriteLine($"{num}, четвертая четверть");
    }
}
else
{
       if(Y>0)
    {
        num = 2;
        Console.WriteLine($"{num}, вторая четверть");
    }
    else
    {
        num = 3;
        Console.WriteLine($"{num}, третья четверть");
    } 
}

if (X>0 && Y>0) Console.WriteLine("первая четверть");
if (X>0 && Y<0) Console.WriteLine("четвертая четверть");
if (X<0 && Y>0) Console.WriteLine("вторая четверть");
if (X>0 && Y<0) Console.WriteLine("третья четверть");
if (X == 0 && Y == 0) Console.WriteLine("точка лежит на оси");