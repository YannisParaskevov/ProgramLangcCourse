// See https://aka.ms/new-console-template for more information
Console.Clear();
Console.Write("Введите элементы массива через запятая/пробел: ");
string elements = Console.ReadLine();
int[] Array = ArrayFromString(elements);
int[] ArrayFromString(string stringArray)
{
    string[] nums = stringArray.Split(", ", StringSplitOptions.RemoveEmptyEntries);
    int[] res = new int[nums.Length];

    for (int i = 0; i < nums.Length; i++)
    {
        res[i] = int.Parse(nums[i]);
    }
    return res;
}
Console.WriteLine($"[{string.Join(", ",Array)}]");

int[] result = new int[(Array.Length+1)/2];
int i =0;
while(i < Array.Length/2)
{
    result[i] = Array[i] * Array[Array.Length-1-i];
    i++;
}
if(Array.Length % 2 == 1) result[i] = Array[i];
Console.WriteLine($"[{string.Join(", ",result)}]");
