int Akkerman(int m, int n)
{
       if ((m>0) && (n==0))
    return Akkerman(m-1,1);
    if ((m>0) && (n>0))
    return Akkerman (m-1, Akkerman (m, n-1));
    return n+1;
}

Console.WriteLine("введите 2  неотрицательных числа");
int m = Convert.ToInt32(Console.ReadLine());
int n = Convert.ToInt32(Console.ReadLine());
if (m>=0 && n>=0)
{
Console.Write("значение функции Аккермана ");
Console.WriteLine(Akkerman(m, n));
}
else
{
 Console.WriteLine( "требуются неотрицательные числа");   
}