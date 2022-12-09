// // задачи с 4ой лекции - двумерные массивы и начало рекурсии
// // Пример 1 - заполнение и вывод на печать двумерного массива
Console.Clear();
// // Console.Write("Введите количество строк в массиве: ");
// // int rows = int.Parse(Console.ReadLine());
// // Console.Write("Введите количество столбцов в массиве: ");
// // int columns = int.Parse(Console.ReadLine());
// // Console.WriteLine("Зададим диапазон для чисел в массиве");
// // Console.Write("введите значение нижней границы (включительно): ");
// // int min = int.Parse(Console.ReadLine());
// // Console.Write("введите значение верхней границы (включительно): ");
// // int max = int.Parse(Console.ReadLine());
// // int[,] matrix = new int[rows,columns];
// // PrintBinaryArray(matrix);
// // FillBinaryArray(matrix, min, max);
// // Console.WriteLine();
// // PrintBinaryArray(matrix);

// void PrintBinaryArray(int[,] binArray)
// {
//     for (int rows = 0; rows < binArray.GetLength(0); rows++)
//     {
//         for (int columns = 0; columns < binArray.GetLength(1) ; columns++)
//             {
//             Console.Write($"{binArray[rows, columns]} ");
//             }
//     Console.WriteLine();
//     }
// }

// int[,] FillBinaryArray(int[,] binArray, int min, int max) 
// {
//     for(int i = 0; i<binArray.GetLength(0); i++)
//     {
//         for(int j=0; j<binArray.GetLength(1); j++)
//         {
//             binArray[i,j]=new Random().Next(min,max+1);
//         }
//     }
//     return binArray;
// }

// // Закрашивание области
// int[,] picture = new int[,]
// {
// {0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0 },
// {0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 1, 1, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0 },
// {0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 1, 0, 0, 1, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0 },
// {0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 1, 0, 0, 1, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0 },
// {0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 1, 0, 0, 0, 1, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0 },
// {0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 1, 0, 0, 0, 1, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0 },
// {0, 0, 0, 0, 0, 0, 0, 0, 0, 1, 0, 0, 0, 1, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0 },
// {0, 0, 0, 0, 0, 0, 0, 1, 1, 0, 0, 0, 0, 1, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0 },
// {0, 0, 0, 0, 0, 1, 1, 0, 0, 0, 0, 0, 1, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0 },
// {0, 0, 1, 1, 1, 0, 0, 0, 0, 0, 0, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 0, 0, 0, 0 },
// {0, 0, 1, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 1, 0, 0, 0 },
// {0, 0, 1, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 1, 0, 0, 0 },
// {0, 0, 1, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 1, 1, 1, 1, 1, 0, 0, 0, 0 },
// {0, 0, 1, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 1, 0, 0, 0 },
// {0, 0, 1, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 1, 0, 0, 0 },
// {0, 0, 1, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 1, 1, 1, 1, 1, 0, 0, 0, 0 },
// {0, 0, 1, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 1, 0, 0, 0, 0 },
// {0, 0, 1, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 1, 0, 0, 0, 0 },
// {0, 0, 1, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 1, 1, 1, 1, 1, 0, 0, 0, 0, 0 },
// {0, 0, 1, 1, 1, 1, 1, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 1, 0, 0, 0, 0, 0 },
// {0, 0, 0, 0, 0, 0, 0, 1, 1, 1, 1, 0, 0, 0, 0, 0, 0, 0, 1, 0, 0, 0, 0, 0, 0 },
// {0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 1, 1, 1, 1, 1, 1, 1, 0, 0, 0, 0, 0, 0, 0 },
// {0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0 },
// };
// void PrintPicture(int[,] binArray) // рисование - если эл-т = 0, то пробел, а если =1, то $ 
// {
// Console.Clear();
//     for(int i = 0; i<binArray.GetLength(0); i++)
//         {
//             for(int j=0; j<binArray.GetLength(1); j++)
//             {
//                 if(binArray[i,j] == 0) Console.Write(" ");
//                 else Console.Write("$");
//             }
//         Console.WriteLine();
//         }
// }
// void FillImage(int row, int col) // рисование - закрашиваем область, на вход начальная точка в рисунке.
// {
//     if (picture[row, col] == 0) // значение в точке 0, то 
//         {
//             picture[row, col] = 1;  // меняем значение на 1 и дальше при печати выйдет символ - произойдет "окрашивание"
//             FillImage(row - 1, col); // уходим вверх
//             FillImage(row, col - 1); // уходим влево
//             FillImage(row + 1, col); // уходим вниз
//             FillImage(row, col + 1); // уходим вправо
//         }
// }
// // PrintPicture(picture); // начальная картинка - контур ладони

// FillImage(13, 13); // заполняем массив значениями 1 внутри ладони
// PrintPicture(picture); // печатаем новый массив с "закрашенной" ладонью

// Факториал с помощью рекурсии
// Console.Write("Введите натуральное число: ");
// int num = int.Parse(Console.ReadLine());
// double Factorial(int n)
// {
//  if(n == 1 || n == 0) return 1;
//  else return n * Factorial(n-1);
// }
// Console.WriteLine(Factorial(num));

// последовательнось фибоначии с помощью рекурсии
double Fibonacci(int n)
{
 if(n == 1 || n == 2) return 1;
 else return Fibonacci(n-1) + Fibonacci(n-2);
}
for (int i = 1; i < 10; i++)
{
 Console.WriteLine($"f({i}) = {Fibonacci(i)}");
}
