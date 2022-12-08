// задаёт массив из N элементов, диапазон для генератора и выводит массив на экран, и найсти сумму отриц и полож элементов
int[] FillPrintArray(int[] array) 
{
    for(int i =0; i < array.Length; i++)
    {
      array[i] = new Random().Next(-9,10);
    }
    Console.Write($"[{string.Join(", ",array)}]");
    return array;
}
Console.Clear();

int[] array = new int[12]; 
FillPrintArray(array);
int SumOtr = 0;
int SumPol = 0;
for(int i = 0; i < array.Length; i++)
{
    if(array[i] > 0)
        {
            SumPol = SumPol + array[i];
        }
    else SumOtr = SumOtr + array[i];
}
Console.WriteLine();
Console.WriteLine($"Сумма положительных элементов ->  {SumPol}");
Console.WriteLine($"Сумма отрицательных элементов -> {SumOtr}");