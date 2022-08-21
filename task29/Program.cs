int [] getArrayFromConsole(int n)
{
    string str = Console.ReadLine();
    string[] s = str.Split(',');
    int[] result = new int [n];
    for(int i=0;i<s.Length;i++)
    {
        result[i] = Convert.ToInt32(s[i]);
    }
    return result;
}

void PrintArray(int[] a)
{
    Console.Write("[");
    Console.Write(a[0]);
    for(int i=1;i<a.Length;i++)
    {
        Console.Write(", ");
        Console.Write(a[i]);
    }
    Console.Write("]");
}

Console.WriteLine("Введите 8 чисел, разделенных запятыми");
int[] a = getArrayFromConsole(8);
PrintArray(a);

