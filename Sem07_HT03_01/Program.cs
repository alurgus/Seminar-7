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
void RowFromArray(int[] arr)
{
    if (0 == arr.Length)
        return;
    int k = arr[arr.Length - 1];
    Array.Resize(ref arr, arr.Length - 1);
    Console.Write($"{k} ");
    RowFromArray(arr);
}
RowFromArray(array);
