int SumNumbers(int min, int max)
{
    if (min == max)
        return min;
    return min + SumNumbers(min + 1, max);
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
Console.Write("сумма чисел равна ");
Console.WriteLine(SumNumbers(min, max));

