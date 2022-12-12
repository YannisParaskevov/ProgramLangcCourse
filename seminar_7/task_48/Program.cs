// // Задайте двумерный массив размера m на n, каждый элемент в массиве находится по формуле: Aₘₙ = m+n. Выведите полученный массив на экран.
// m = 3, n = 4.
// 0 1 2 3
// 1 2 3 4
// 2 3 4 5

using System;
using static System.Console;
Clear();
Write("Введите количество строк массива: ");
int rows=int.Parse(ReadLine());

Write("Введите количество столбцов массива: ");
int columns=int.Parse(ReadLine());

FillPrintArray(rows, columns);

void FillPrintArray(int rows, int collumns)
{
int[,] result = new int[rows, collumns];
    for(int i=0; i< rows; i++)
    {
        for(int j=0; j<collumns; j++)
        {
            result[i, j] = i+j;
            Write($"{result[i, j]} ");
        }
    WriteLine();
    }
}
