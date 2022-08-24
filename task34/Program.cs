int[] CreateArray(int size) // функция создает массив заданного размера
{
    int[] result = new int[size];
    Random r = new Random();
    for(int i = 0; i<size; i++)
    {
        result[i]=r.Next(100, 999); //каждому элементу массива присваиваем случайное трехзн. положит число
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

int[] array = CreateArray(5);
int count=0; //счетчик четных чисел
for(int i=0;i<array.Length;i++)
{
    if(array[i]%2 == 0)
        count++;
}

PrintArray(array);
Console.Write("Четных чисел: ");
Console.WriteLine(count);