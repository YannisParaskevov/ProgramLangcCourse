// Напишите программу замена элементов массива: положительные элементы замените на соответствующие отрицательные, и наоборот.
int[] FillPrintArray(int[] array, int min, int max) 
{
    for(int i =0; i < array.Length; i++)
    {
      array[i] = new Random().Next(min,max+1);
    }
    Console.Write($"[{string.Join(", ",array)}]");
    return array;
}
Console.Clear();
Console.Write("Введите желаемое количество элементов в массиве: ");
int ind = int.Parse(Console.ReadLine());
Console.WriteLine("Зададим диапазон для чисел в массиве");
Console.Write("введите значение нижней границы (включительно): ");
int min = int.Parse(Console.ReadLine());
Console.Write("Введите значение верхней границы (включительно): ");
int max = int.Parse(Console.ReadLine());

int[] array = new int[ind]; 
FillPrintArray(array, min, max);
for (int i=0; i< array.Length; i++)
{
    array[i] *= -1;
}
Console.WriteLine();
Console.WriteLine($"[{string.Join(", ",array)}]");