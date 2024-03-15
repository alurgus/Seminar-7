// Задайте значения M и N. Напишите программу, 
// которая выведет все натуральные числа в промежутке от M до N.
// Использовать рекурсию, не использовать циклы.


Console.WriteLine("Input first natural number");
int numM = Convert.ToInt32(Console.ReadLine());
if (numM < 1)
{
    Console.WriteLine("Неправильный ввод числа");
    return;
}

Console.WriteLine("Input second natural number");
int numN = Convert.ToInt32(Console.ReadLine());
if (numN < 1)
{
    Console.WriteLine("Неправильный ввод числа");
    return;
}

void RowOfNumbers(int m, int n)
{
    if (n > m)
    {
        RowOfNumbers(m, n - 1);
        Console.Write($"{n} ");
    }
    else
    {
        if (n < m)
            RowOfNumbers(m - 1, n);
        Console.Write($"{m} ");
    }
}

RowOfNumbers(numM, numN);

