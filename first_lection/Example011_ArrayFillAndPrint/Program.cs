// метод заполнения массива случ числами и вывод массива на консоль
void FillArray(int[] collection) // FillArray - функция заполни массив
{
    int index = 0;
    while(index<collection.Length)
    {
      collection[index] = new Random().Next(1,20);
      index++;
    }
}
void PrintArray(int[] coll) // PrintArray - функция напечатай массив
{
    int count = 0;
    while(count<coll.Length)
    {
        Console.Write(coll[count]);
        Console.Write("  ");
        count++;
    }
}
int IndexOf(int[] collection, int find) // метод нахождения элемента равного заданному
{
    int index = 0;
    int position = -1;
    while(index<collection.Length)
    {
        if(collection[index] == find) 
        {position = index;
        break;}
        index++;
    }
    return(position);
}

int[] array = new int[25]; //создай новый массив из 10 элементов
FillArray(array); // заполняем массив методом FillArray
PrintArray(array); // Выводим на экран функцией PrintArray
int pos = IndexOf(array, 15); // с помощью метода IndexOf находим индекс эл-та массива, который равен 15
Console.WriteLine();
Console.Write(pos);