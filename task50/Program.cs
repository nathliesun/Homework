int[,] CreateMatrix(int rowCount, int columnCount, int min, int max)
{
    int[,] array = new int[rowCount, columnCount];
    for (int row = 0; row < rowCount; ++row)
    {
        for (int column = 0; column < columnCount; ++column)
        {
            array[row, column] = new Random().Next(min, max + 1);

        }
    }
    return array;
}
void PrintMatrix(int[,] arr)
{
    for (int row = 0; row < arr.GetLength(0); ++row)
    {
        for (int column = 0; column < arr.GetLength(1); ++column)
        {
            System.Console.Write($"{arr[row, column]}\t");
        }
        System.Console.WriteLine();
    }

}

bool HasElement(int[,] array, int a, int b)
{
    if ((a > array.GetLength(0) -1) || (b > array.GetLength(1)-1))
        return false;
    else
    {
        return true;
    }
}

//-----------------------------------------------------

Console.WriteLine(" Введите номер строк матрицы, начинающейся с (0,0)");
int a = Convert.ToInt32(Console.ReadLine());
Console.WriteLine(" Введите номер столбца матрицы, начинающейся с (0,0)");
int b = Convert.ToInt32(Console.ReadLine());

int[,] matrix = CreateMatrix(5, 2, 0, 99);
PrintMatrix(matrix);
HasElement(matrix, a, b);
if (HasElement(matrix, a, b) == false)
Console.WriteLine(" Такого элемента нет");
else
Console.WriteLine($" Элемент на этой позиции  {matrix[a,b]}");