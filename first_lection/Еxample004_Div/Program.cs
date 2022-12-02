// Программа деления  двух чисел

double numberA = new Random().Next(1,100);
double numberB = new Random().Next(1,10);
double div = numberA / numberB;
Console.WriteLine(numberA);
Console.WriteLine(numberB);
Console.WriteLine(div);
double ostatok=numberA%10;
Console.WriteLine(ostatok);