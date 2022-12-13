// Задайте двумерный массив. Напишите программу, которая поменяет местами первую и последнюю строку массива.
using System;
using static System.Console;
Clear();
Write("Введите количество строк массива: ");
int rows=int.Parse(ReadLine());
Write("Введите количество столбцов массива: ");
int columns=int.Parse(ReadLine());

int[,] array = GetArray(rows, columns, 0, 10);
PrintArray(array);
WriteLine();
int[,] result = ChangedArray(array);
PrintArray(result);



int[,] GetArray(int m, int n, int minValue, int maxValue)
{
    int[,] result = new int[m, n];
    for (int i = 0; i < m; i++)
    {
        for (int j = 0; j < n; j++)
        {
            result[i, j] = new Random().Next(minValue, maxValue + 1);
        }
    }
    return result;
}
void PrintArray(int[,] inArray)
{
    for (int i = 0; i < inArray.GetLength(0); i++)
    {
        for (int j = 0; j < inArray.GetLength(1); j++)
        {
            Write($"{inArray[i,j]} ");
        }
        WriteLine();
    }
}
int[,] ChangedArray(int[,] array)
{
    for(int j =0; j< array.GetLength(1); j++)
    {
        int temp = array[0, j];
        array[0,j] = array[array.GetLength(1)-1, j];
        array[array.GetLength(1)-1, j] = temp;
    }
return array;
}