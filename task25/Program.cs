int power(int a, int b)
{
    int result;
    if(b==0)
    {
        result = 1;
    }
    else
    {
        result = a;
    }
    for(int i=1;i<b;i++)
    {
        result = result * a;
    }
    return result;
}

Console.WriteLine(power(3,5));
