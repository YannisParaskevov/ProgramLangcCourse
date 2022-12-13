// Напишите программу, которая на вход принимает позиции элемента в двумерном массиве, и возвращает значение этого элемента или же указание, что такого элемента нет.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// 17 -> такого числа в массиве нет

using System;
using static System.Console;
Clear();
Console.WriteLine("Вводим данные для создания массива");
Write("Введите количество строк: ");
int rows=int.Parse(ReadLine());
Write("Введите количество столбцов : ");
int columns=int.Parse(ReadLine());
double[,] array = GetArray(rows, columns, 0, 9);
PrintArray(array);
Console.WriteLine();
Console.Write("Введите позицию элемента массива в виде двузначного числа- десятки-строка, единицы-столбец = ");
int position = int.Parse(Console.ReadLine());
ShowPosition(array, position);

double[,] GetArray(int m, int n, int min, int max)
{
    double[,] result = new double[m, n];
    for (int i = 0; i < m; i++)
    {
        for (int j = 0; j < n; j++)
        {
            result[i, j] = new Random().NextDouble() * (max-min) + min; 
        }
    }
    return result;
}
void PrintArray(double[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            Write($" {array[i,j]:f3} |");
        }
        WriteLine();
    }
}
void ShowPosition(double[,] array, int pos)
{
    int row = pos/10;
    int column = pos%10;
    if(row <= array.GetLength(0) && column <= array.GetLength(1)) 
    {
        Write($"{pos} -> Значение на этой позиции без округления -> {array[row-1,column-1]}"); 
    }
    else Write($"{pos} -> такой позиции в массиве нет"); 
}