Console.WriteLine("введите 7 чисел");
int[] ReadArray(int size)
{
 int[] result = new int[size];
    
    for(int i = 0; i<size; i++)
    {
        result[i]=Convert.ToInt32(Console.ReadLine()); //каждому элементу массива присваиваем введенное по очереди число
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


int FindNumber(int[] array)
{
int number=0;
for(int i=0;i<array.Length;i++)
{
    if(array[i] > 0)
        number++;
} 
return number;  
}
int[] array = ReadArray(7);
PrintArray(array);
int number = FindNumber(array);
Console.Write("Чиcел больше нуля введено ");
Console.WriteLine(number);

