int[] CreateArray(int size) // функция создает массив заданного размера
{
    int[] result = new int[size];
    Random r = new Random();
    for(int i = 0; i<size; i++)
    {
        result[i]=r.Next(-100, 100); //каждому элементу массива присваиваем случайное число из диапазон
    }
    return result;
}

void PrintArray(int[] a) // вывод массива
{
    Console.Write("[");
    Console.Write(a[0]);
    for(int i=1;i<a.Length;i++)
    {
        Console.Write(", ");
        Console.Write(a[i]);
    }
    Console.WriteLine("]");
}

int[] array = CreateArray(10);
int sum=0; //сумма элементов
for(int i=1;i<array.Length;i=i+2)
{
    sum = sum+array[i];
}

PrintArray(array);
Console.Write("Сумма нечетных элементов: ");
Console.WriteLine(sum);