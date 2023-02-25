// Наишите программу замена элементов маасива : положительные элементы на соответствующие отрицательные и наоборот.
// [-4,-8,8,2]->[4,8,-8,-2]
int[]arry(int size){
    int[]arr = new int [size];
    for (int i = 0; i < size; i++)arr[i] = new Random().Next (-10,11);
    return arr;
}
void inv(int[] arry){
    for (int i = 0; i < arry.Length; i++)arry[i] = -1*arry[i];
}
Console. Clear();
Console.WriteLine("Введите разрядность массива");
int size = int.Parse(Console.ReadLine());
int[] mass = arry(size);
Console.WriteLine($"[{string.Join(" ",mass)} ]");
inv (mass);
Console.WriteLine($"[{string.Join(" ",mass)} ]");
