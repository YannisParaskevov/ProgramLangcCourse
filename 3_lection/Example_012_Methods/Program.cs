// Методы - Виды
Console.Clear();
void method1() // 1 группа методов. ничего не принимают и ничего не возвращают (например авторство в конце програмного кода)
{
Console.WriteLine("Автор ФИО");
}
//method1(); // так вызывают метод в программе, внимание со скобками

void method2(string msg) // 2 группа методов. что-то принимают и ничего не возвращают 
{
Console.WriteLine(msg);
}
//method2("Text"); 

void method21(string msg, int count) // 2 группа методов. пример 2 - именованные аргументы
{
    int i = 0;
    while(i < count)
    {
       Console.WriteLine(msg);
       i++;
    }
}
//method21("New Text", 3); // вызывая метод в таком виде, обязательно аргументы по порядку
//method21(count: 4, msg: "Можно не попорядку"); // если именовать аргументы, то можно в любом порядке

// int method3() // 3 группа методов. ничего не принимают и что-то возвращают
// {
//     return DateTime.Now.Year;
// }
// double year = method3();
// Console.WriteLine(year);

// string Metod4(int count, string text) // 4 группа методов. что-то принимают и что-то возвращают
// {
// int i = 0;
// string result = String.Empty;
// while (i<count)
// {
// result = result + text;
// i++;
// }
// return result;
// }
// string res = Metod4(10, "asdf+");
// Console.WriteLine(res);

// string Metod41(int count, string text) // 4 группа методов. что-то принимают и что-то возвращают
// {
// string result = String.Empty;
// for (int i=0; i < count; i++) // применили цикл for
//     {
//         result = result + text;
//     }
// return result;
// }
// string res = Metod41(5, "почему");
// Console.WriteLine(res);

// for (int i = 2; i <= 10; i++)
// {
// for (int j = 2; j <= 10; j++)
// {
// Console.WriteLine($"{i} * {j} = {i * j}");
// }
// Console.WriteLine();
// }


//=====Работа с текстом
// Дан текст. В тексте нужно все пробелы заменить чёрточками,
// маленькие буквы “к” заменить большими “К”,
// а большие “С” маленькими “с”.
// Ясна ли задача?

// string Replase(string text, char oldValue, char newValue) // Метод Replace проходит текст, находит нужный символ и заменяет на новый
// {
// string result = String.Empty;
// int length = text.Length;
// for (int i = 0; i < length; i++)
// {
// if(text[i] == oldValue) result = result + $"{newValue}";
// else result = result + $"{text[i]}";
// }
// return result;
// }
// string text = "— Я думаю, — сказал князь, улыбаясь, — что,"
// + "ежели бы вас послали вместо нашего милого Винценгероде,"
// + "вы бы взяли приступом согласие прусского короля."
// + "Вы так красноречивы. Вы дадите мне чаю?"; // текст соединяется + на новой строке
// string newText = Replase(text, ' ','[');
// Console.WriteLine(newText);
// Console.WriteLine();
// string newTextk = Replase(newText, 'к', 'К');
// Console.WriteLine(newTextk);
// Console.WriteLine();
// string newTextOk = Replase(newTextk, 'В', 'в');
// Console.WriteLine(newTextOk);
// Console.WriteLine();


void PrintArray(int[] array) // напечатать массив
{
for (int i = 0; i < array.Length; i++)
{
Console.Write($"{array[i]} ");
}
Console.WriteLine();
}
void selectionSort(int[] array) // отсортировать массив по возрастанию
{
for (int i = 0; i < array.Length - 1; i++)
{
    int minPosition = i;
        for (int j = i+1; j < array.Length; j++)
        {
            if(array[j] < array[minPosition]) minPosition = j;
        }
    int temp = array[i];
    array[i] = array[minPosition];
    array[minPosition] = temp;
}
}
int[] arr = {1, 5, 4, 3, 2, 6, 7, 1, 1, 2, 34, 15};
PrintArray(arr);
selectionSort(arr);
PrintArray(arr);
