// ищем индекс элемента равного запрошенному
int[] array = {1, 12, 32, 16, 43, 51, 16, 27, 80, 9};
int find = 16;
int index = 0;
while (index<array.Length)
{
    if(array[index] == find)
    {
        Console.WriteLine(index);
        break;
    }
    index++;
}