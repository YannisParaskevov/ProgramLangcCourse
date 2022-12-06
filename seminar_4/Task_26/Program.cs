// Напишите программу, которая принимает на вход число и выдаёт количество цифр в числе.
Console.Clear();
Console.Write("Введите целое число: ");
int num = int.Parse(Console.ReadLine());
int temp = num;
if(num < 0) temp = Math.Abs(num);
if (num == 0) 
{
Console.WriteLine ($"Количество цифр в числе {num} равно 0");
return;
}
Console.WriteLine ($"Количество цифр в числе {num} равно {hmDigits (num)}");

int hmDigits (int number) 
{
    int qty = 0;
    while (temp > 0)
    {
        temp = temp/10;
        qty ++;
    }
    return qty;
    }