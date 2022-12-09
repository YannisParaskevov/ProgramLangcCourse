// Задайте массив вещественных чисел. 
// Найдите разницу между максимальным и минимальным элементов массива.
// [3 7 22 2 78] -> 76


double[] FillPrintArray(double[] array, int min, int max) 
{
    Console.WriteLine();
    Console.Write($"Получившийся массив из {array.Length} элементов: [  ");
    for(int i =0; i < array.Length; i++)
    {
      array[i] = new Random().NextDouble() * max + min;
      Console.Write($"{array[i]:f2}  ");
    }
    Console.Write("]");
    // Console.Write(array:f2);
    Console.WriteLine();
    return array;
}
double[] DifMinMax (double[] arr) 
{
    double dif = 0;
    double arrMin= arr[0];
    double arrMax= arr[0];
    double[] result = {arrMin, arrMax, dif};
    if(arr.Length == 1) return result;
    for(int i=1; i<arr.Length; i ++)
    {
        if(arr[i]>arrMax) arrMax = arr[i];
        if(arr[i]<arrMin) arrMin = arr[i];
    }
    dif = arrMax - arrMin;
    return result;
}
Console.Clear();
Console.Write("Введите количество элементов в массиве N = ");
int ind = int.Parse(Console.ReadLine());
if(ind < 1) 
{
    Console.WriteLine("Ошибка в условиях, N - натуральное число, попробуйте еще раз");
    return;
}
Console.WriteLine("Зададим диапазон для чисел в массиве");
Console.Write("введите значение нижней границы (включительно) min = ");
int min = int.Parse(Console.ReadLine());
Console.Write("Введите значение верхней границы (включительно) max = ");
int max = int.Parse(Console.ReadLine());
if(min > max) 
{
    Console.WriteLine("Ошибка в условиях, min < max, попробуйте еще раз");
    return;
}
double[] array = new double[ind]; 
double[] result = new double[3];
FillPrintArray(array, min, max);
double[] res = DifMinMax(array);
Console.WriteLine();
// Console.WriteLine($"В этом массиве мин. элемент = {res[0]:f2}, макс.элемент = {res[1]:f2}, разница между ними = {res[2]:f2}");
Console.WriteLine(result);