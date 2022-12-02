// если пришел Хантер то для особое приветствие
Console.Write("Введите Ваше имя: ");
string username = Console.ReadLine();
if(username.ToLower() == "хантер")
{
Console.WriteLine("О, да это же ХАНТЕР!");
}
else
{
Console.Write("Привет, ");
Console.WriteLine(username);
}