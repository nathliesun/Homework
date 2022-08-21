int number_sum(int a)
{
    int result = 0;
    int excess=0; // остаток
    int integer = a; // целая часть
    
    while(integer != 0)
    {
        excess = integer % 10;
        integer = integer / 10;
        result = result + excess;
    }
    return result;
}

Console.WriteLine(number_sum(9012));