// // Строки 1-17 - считать массив через строку, разделитель слэш, массиы выведется на печать
// double[] PrintArrayFromString(string array)
// {
//     string[] elements = array.Split("/", StringSplitOptions.RemoveEmptyEntries);
//     double[] res = new double[elements.Length];

//     for (int i = 0; i < elements.Length; i++)
//     {
//         res[i] = double.Parse(elements[i]);
//     }
//     Console.Write($"В массиве [{string.Join("; ", res)}] ");
//     return res;
// }
// Console.Clear();
// Console.Write("Введите элементы массива через слэш(/) без пробелов: ");
// string numbers = Console.ReadLine();
// double[] array = PrintArrayFromString(numbers);

// ////////////////////////////

// // Двумерные массивы
// string[,] table = new string[2,3];
// Int[,] matrix = new int[2,5];
// for (int rows = 0; rows < 2; rows++)
// {
//  for (int columns = 0; columns < 5; columns++)
//  {
//  Console.WriteLine($"{table[rows, columns]}");
//  }
// }
// int[,] matrix = new int[3, 4];
// for (int i = 0; i < matrix.GetLength(0); i++)
// {
//  for (int j = 0; j < matrix.GetLength(1); j++)
//  {
//  Console.Write($"{matrix[i, j]} ");
//   }
//  }
// Console.WriteLine();


// static int[] PasTri(int n) {
//     int[] result = new int[n];
//     result [0] = 1;
//     for (int i = 1; i < n; i++) {
//         int left = 0;
//         for (int j = 0; j <= i; j++) {                  
//             int tmp = result [j];
//             result [j] += left;
//             left = tmp;
//         }
//     }
//     return result;
// }
// Console.Write($"В массиве [{string.Join("; ", PasTri(5))}] ");