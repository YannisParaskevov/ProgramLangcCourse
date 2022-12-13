// Составить частотный словарь элементов двумерного массива. 
// Частотный словарь содержит информацию о том, сколько раз встречается элемент входных данных.

using System;
using static System.Console;

Clear();
Write("Введите количество строк массива: ");
int rows=int.Parse(ReadLine());
Write("Введите количество столбцов массива: ");
int columns=int.Parse(ReadLine());

int[,] array = GetArray(rows, columns, 0, 9);
PrintArray(array);
WriteLine();
int[] ToOdnomer = OdnomArray(array);
Write($"[{string.Join(", ",ToOdnomer)}]");
WriteLine();
RangeArray(ToOdnomer);
WriteLine();
PrintData(ToOdnomer);

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
int[] OdnomArray(int [,] array)
{
    int []res = new int[array.GetLength(0) * array.GetLength(1)];
        for(int i = 0; i < array.GetLength(0); i++)
        {
            for(int j=0; j<array.GetLength(1); j++)
            {
                res[(i)*array.GetLength(1) + j] = array[i,j];
            }
        }
    return res;
}
void RangeArray(int[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        for (int j = i+1; j < array.Length; j++)
        {
            if(array[i]>array[j])
            {
                int k=array[i];
                array[i]=array[j];
                array[j]=k;
            }
        }
    }
Write($"[{string.Join(", ",array)}]");
}
void PrintData(int[] inArray)
{
    int el=inArray[0];
    int count = 1;
    for (int i = 1; i < inArray.Length; i++)
    {
        if(inArray[i]!=el)
        {
            WriteLine($"{el} встречается {count}");
            el=inArray[i];
            count=1;
        }
        else
        {
            count++;
        }
    }
    WriteLine($"{el} встречается {count}");
}








// void FrequencyDictionary(int[,] array, int minValue, int maxValue)
// {   
//     for(int k = minValue; k < maxValue+1; k++)
//     {
//     int count = 0;
//     for(int i=0; i < array.GetLength(0); i++)
//         {
//             for(int j=0; j<array.GetLength(1); j++)
//             {
//                 if(array[i,j] == k)
//                     {
//                         count++;
//                     }

//             }
            
//         }
//     }
// }