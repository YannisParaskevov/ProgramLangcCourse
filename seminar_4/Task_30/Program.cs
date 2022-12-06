// выводит массив из 8 элементов, заполненный нулями и единицами в случайном порядке.
int[] FillArray(int[] array) // FillArray - функция заполни массив
{
    int index = 0;
    while(index<array.Length)
    {
      array[index] = new Random().Next(0,2);
      index++;
    }
    return array;
}
void PrintArray(int[] array) // PrintArray - функция напечатай массив
{
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write($"{array[i]} ");
        }
}
Console.Clear();
int[] array = new int[12]; 
PrintArray(FillArray(array));