﻿// вывести числа от 1 до N
using System;
using static System.Console;

Clear();
Write("Введите N: ");
int n=int.Parse(ReadLine());

WriteLine(PrintNumbers(n));

string PrintNumbers(int end)
{
    if (end == 1) 
        return "1";
    return (PrintNumbers(end - 1) + ' ' + end.ToString());
}

