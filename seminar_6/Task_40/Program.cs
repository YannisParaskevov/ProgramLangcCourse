// Напишите программу, которая принимает на вход три числа и проверяет, может ли существовать треугольник с сторонами такой длины.
Console.Clear();

bool Chek(int a, int b, int c) 
{
    if(a+b>c && a+c>b & b+c>a) return true;
    else return false;
}
Console.Write("Введите первую сторону: ");
int a = int.Parse(Console.ReadLine());
Console.Write("Введите вторую сторону: ");
int b = int.Parse(Console.ReadLine());
Console.Write("Введите третью сторону: ");
int c = int.Parse(Console.ReadLine());

if(Chek(a,b,c)) Console.WriteLine("треугольник существует");
else Console.WriteLine("треугольник не существует");