// Задайте произвольный массив. 
// Выведете его элементы, начиная с конца. 
// Использовать рекурсию, не использовать циклы.

Console.WriteLine("Введите количество чисел в массиве:");
int n = Convert.ToInt32(Console.ReadLine());
int[] array = new int[n];
Random rnd = new Random()!;

int min = 0;
int max = 100;

for (int i = 0; i < array.Length; i++)
{
    array[i] = rnd.Next(min, max);
}
Console.WriteLine(string.Join(" ", array));

int[] arr = array;
void RowFromArray(int[] arr, int m)
{
    if (m == arr.Length)
        return;
    m++;
    int k = arr[arr.Length - m];
    Console.Write($"{k} ");
    RowFromArray(arr, m);
}
RowFromArray(array, 0);

