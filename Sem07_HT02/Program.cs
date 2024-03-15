// функция ack(n, m)
//    если n = 0
//      вернуть m + 1
//    иначе, если m = 0
//      вернуть ack (n - 1, 1)
//    еще
//      вернуть ack(n - 1, ack (n, m - 1))

int ACK(int n, int m)
{
    if (n == 0)
        return (m + 1);

    if (m == 0)
        return ACK(n - 1, 1);

    else
        return ACK(n - 1, ACK(n, m - 1));

}

Console.WriteLine("Input 'N' natural number");
int numN = Convert.ToInt32(Console.ReadLine());

if (numN < 1)
{
    Console.WriteLine("Неправильный ввод числа");
    return;
}

Console.WriteLine("Input 'M' natural number");
int numM = Convert.ToInt32(Console.ReadLine());

if (numM < 1)
{
    Console.WriteLine("Неправильный ввод числа");
    return;
}

Console.WriteLine($"{ACK(numN, numM)}");