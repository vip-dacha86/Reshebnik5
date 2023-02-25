// Задайте массив .Напишите программу которая определяет присутствует ли заданное число в массиве.
// 4->[6,7,19,345,3]->no
Console.Clear();
Console.Write("Введите элементы массива через пробел: ");
string elements = Console.ReadLine();
int[] baseArray = GetArrayFromString(elements);
Console.Write("Введите число: ");
int n = int.Parse(Console.ReadLine());
if (FindElement(baseArray, n))
{
   Console.WriteLine("да");
}
else
{
    Console.WriteLine("нет");
}
int[] GetArrayFromString (string stringArray)
{
    string[] nums =stringArray.Split(" ");
    int[] res = new int[nums.Length];
    for (int i =0; i < nums.Length; i++)
    {
        res[i] = int.Parse(nums [i]);
    } 
    return res;
}
bool FindElement(int[] array, int el)
{
    foreach ( var item in array)
    {
        if (el == item) return true;
    }
    return false;
}