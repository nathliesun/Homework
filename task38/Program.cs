double[] CreateArray(int size) // функция создает массив заданного размера
{
    double[] result = new double[size];
    Random r = new Random();
    for(int i = 0; i<size; i++)
    {
        result[i]=r.NextDouble(); //каждому элементу массива присваиваем случайное вещественное число
    }
    return result;
}

void PrintArray(double[] a) // вывод массива
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

double[] array = CreateArray(10);
double min, max;
min = array[0];
max = array[0];
for(int i=1;i<array.Length;i=i+2)
{
    if(array[i] < min)
        min = array[i];
    if(array[i] > max)
        max = array[i];
}

PrintArray(array);
Console.Write("max-min= ");
Console.WriteLine(max-min);