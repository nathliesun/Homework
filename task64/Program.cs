void PrintNumbers(int max, int min)
{
    if (max == min - 1)
        return;
    Console.Write($"{max} ");
    PrintNumbers(max - 1, min);
}
Console.WriteLine("введите 2 числа");
int n = Convert.ToInt32(Console.ReadLine());
int m = Convert.ToInt32(Console.ReadLine());
int max;
int min;
if (n > m)
{
    max = n;
    min = m;
}
else
{
    max = m;
    min = n;
}
Console.WriteLine($"максимальное число {max} ");

PrintNumbers(max, min);
Console.WriteLine();
