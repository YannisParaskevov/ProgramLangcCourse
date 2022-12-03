// найти максимум из 9 чисел
int Max(int arg1, int arg2, int arg3)
{
    int result = arg1;
    if(arg2>result) result = arg2;
    if(arg3>result) result = arg3;
    return result;
    // метод нахождения максимума из 3 чисел
}
int a1 = 25;
int b1 = 5;
int c1 = 14;
int a2 = 1;
int b2 = 41;
int c2 = 11;
int a3 = 112;
int b3 = 41;
int c3 = 1121;

int max = Max(Max(a1, b1,c1), Max(a2, b2,c2), Max(a3, b3,c3));
Console.WriteLine(max);
