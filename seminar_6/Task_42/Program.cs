// Задача 42: Напишите программу, которая будет преобразовывать десятичное число в двоичное.
// 45 -> 101101
// 3 -> 11
// 2 -> 10
string toBinary(int n)
{
    string aux = "";
    int ost = 0;
    while(n > 0)
        {
            ost = n%2;
            aux = aux + Convert.ToString(ost);
            n = n/2;
        }
    return aux;
}
string ReversArray2(string aux)
{

    string result = "";
    for (int i = 0; i < aux.Length; i++)
    {
        result += aux[aux.Length - 1 - i];

    }

    return result;
}

Console.Clear();
Console.Write("Введите число: ");
int num = int.Parse(Console.ReadLine());

Console.WriteLine();

 Console.WriteLine($"{num} -> {ReversArray2(toBinary(num))}");