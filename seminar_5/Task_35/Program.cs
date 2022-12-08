// // Задайте одномерный массив из 123 случайных чисел. Найдите количество элементов массива, значения которых лежат в отрезке [10,99]. 
// int[] FillPrintArray(int[] array, int min, int max) 
// {
//     for(int i =0; i < array.Length; i++)
//     {
//       array[i] = new Random().Next(min,max+1);
//     }
//     Console.Write($"[{string.Join(", ",array)}]");
//     return array;
// }
// int FindForDiapason (int[] arr, int min, int max)
// {
//     int sum = 0;
//     foreach (int i in arr)
//     {
//         if(i>min-1 && i< max+1)
//         sum++;
//     }
//     return sum;
// }
// Console.Clear();
// Console.Write("Введите желаемое количество элементов в массиве: ");
// int ind = int.Parse(Console.ReadLine());
// Console.WriteLine("Зададим диапазон для чисел в массиве");
// Console.Write("введите значение нижней границы (включительно): ");
// int min = int.Parse(Console.ReadLine());
// Console.Write("Введите значение верхней границы (включительно): ");
// int max = int.Parse(Console.ReadLine());
// Console.Write("Нижняя граница поиска (включительно): ");
// int min1 = int.Parse(Console.ReadLine());
// Console.Write("Верхняя граница поиска (включительно): ");
// int max1 = int.Parse(Console.ReadLine());

// int[] array = new int[ind]; 
// FillPrintArray(array, min, max);
// Console.WriteLine();

// Console.WriteLine($"В диапазаоне от {min1} до {max1} находится {FindForDiapason(array, min1, max1)} элементов");

double n = new Random().NextDouble() * 100 + 1;
Console.WriteLine(n);
