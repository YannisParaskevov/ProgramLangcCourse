// Не используя рекурсию, выведите первые N чисел Фибоначчи. Первые два числа Фибоначчи: 0 и 1.
// Если N = 5 -> 0 1 1 2 3

void fibonachi(int number)
{
    int f0 = 0;
    int f1 = 1;
    int temp = 0;
    Console.Write($"{number} -> {f0} ");
    for(int i = 1; i<number; i++)
        {
            Console.Write($"{f1} ");
            f1 = temp;
            f1 = f0 + f1;
            f0 = temp;
        }
}
Console.Clear();
Console.Write("Введите число: ");
int num = int.Parse(Console.ReadLine());
fibonachi(num);


// решение Кирилла
// Console.Clear();
// int number = int.Parse(Console.ReadLine());
// f(number);
// void f(int countTests)
// {
//     int fibonacci1 = 0;
//     int fibonacci2 = 1;
//     Console.Write($"f({0}) = {0}; ");
//     for (int i = 1; i < countTests; i++)
//     {
//         Console.Write($"f({i}) = {fibonacci2}; ");
//         int temporary = fibonacci2;
//         fibonacci2 += fibonacci1;
//         fibonacci1 = temporary;
//     }
// }