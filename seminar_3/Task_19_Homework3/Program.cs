// принимает на вход пятизначное число и проверяет, является ли оно палиндромом.
Console.Clear();
Console.Write("Введите пятизначное число: ");
int num = int.Parse(Console.ReadLine());
if(num < 10000 || num > 99999 )
{
    Console.WriteLine("Это не пятизначное число");
    return;
}
int[] number = new int[5];
int temp = num;
for(int i=4; i >= 0; i--)
{
    number[i] = temp%10;
    temp = temp/10;
}
if((number[0] == number[4]) && (number[1] == number[3])) Console.WriteLine($"{num} -> да, это палиндром");
else Console.WriteLine($"{num} -> нет, это не палиндром");