//Напишите программу, которая на вход принимает два числа A и B, и возводит число А в целую степень B с помощью рекурсии.
// A = 3; B = 5 -> 243 (3⁵)
// A = 2; B = 3 -> 8
using System;
using static System.Console;

Clear();
Write("Введите a: ");
int a =int.Parse(ReadLine());
Write("Введите b: ");
int b =int.Parse(ReadLine());

WriteLine(Stepen(a, b));

int Stepen(int osnov, int pokazatel)
{

    if (pokazatel == 0)
        return 1;
    return (osnov * Stepen(osnov, pokazatel-1));
}