// Напишите программу, которая определяет, присутствует ли заданное число в массиве.
int[] FillPrintArray(int[] array, int min, int max) 
{
    for(int i =0; i < array.Length; i++)
    {
      array[i] = new Random().Next(min,max+1);
    }
    Console.Write($"[{string.Join(", ",array)}]");
    return array;
}
bool FindNumber (int[] arr, int number)
{
    foreach (int i in arr)
    {
        if(i == number)
        return true;
    }
    return false;
}
Console.Clear();
Console.Write("Введите желаемое количество элементов в массиве: ");
int ind = int.Parse(Console.ReadLine());
Console.WriteLine("Зададим диапазон для чисел в массиве");
Console.Write("введите значение нижней границы (включительно): ");
int min = int.Parse(Console.ReadLine());
Console.Write("Введите значение верхней границы (включительно): ");
int max = int.Parse(Console.ReadLine());
Console.Write("Введите число, которое хотим найти в массиве: ");
int num = int.Parse(Console.ReadLine());

int[] array = new int[ind]; 
FillPrintArray(array, min, max);
Console.WriteLine();
if(FindNumber(array, num)) Console.WriteLine($"Да, число {num} есть в массиве");
else Console.WriteLine($"Нет, числа {num} нет в массиве");



