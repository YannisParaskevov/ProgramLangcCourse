// лиса алиса и кот базилио - разложить число > 7 без остатка монетами 3 и 5 с ним кол-вом монет
Console.Clear();
Console.Write("Введите число больше 7: ");
int N = int.Parse(Console.ReadLine());
int b = 0;
int a = 0;
if(N>7)
{
    if (N%5 == 0) a=N/5;
    if (N%5 == 1) {a=N/5-1; b = 2;}
    if (N%5 == 2) {a=N/5-2; b = 4;}
    if (N%5 == 3) {a=N/5; b = 1;}
    if (N%5 == 4) {a=N/5-1; b = 3;}
}
else {Console.WriteLine("Введенное число меньше 7");}
Console.WriteLine($"Число {N} = 5 * {a} ({5*a}) + 3 * {b} ({3*b})");
Console.WriteLine($"{a} {b}");