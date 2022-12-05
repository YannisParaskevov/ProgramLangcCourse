// принимает на вход пятизначное число и проверяет, является ли оно палиндромом.
Console.Clear();
Console.Write("Введите пятизначное число: ");
int num = int.Parse(Console.ReadLine());
if(num < 0)  
{
    Console.WriteLine("Это не пятизначное число");
    return;
}
int[] number = new int[5];
Console.WriteLine($"{number[0]}, {number[1]}, {number[2]}, {number[3]}, {number[4]}");
int index = 0;
int aux = num;
number[index] = aux%10;
index = index+1;
aux = aux /10;
number[index] = aux%10;
index = index+1;
aux = aux /10;
number[index] = aux%10;
index = index+1;
aux = aux /10;
number[index] = aux%10;
index = index+1;
aux = aux /10;
number[index] = aux%10;
//while(index < 3)
  //  number[index] = aux%10;
    //aux = aux/10;
    // index++;
Console.WriteLine($"{number[0]}, {number[1]}, {number[2]}, {number[3]}, {number[4]}");
if((number[0] == number[4]) && (number[1] == number[3])) 
{
    Console.WriteLine("Это палиндром");
}
else
{
    Console.WriteLine("Это не палиндром");
}