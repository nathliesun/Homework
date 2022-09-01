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

void  FindSrarif(int[,] arr)
{
    
    double B;
    for (int column = 0; column < arr.GetLength(1); ++column)
    
    {
        B=0;
        for (int row = 0; row < arr.GetLength(0); ++row)
        {
          B= B+arr[row,column]; 
        }
         
        Console.Write($"{B/arr.GetLength(0)}\t");
        
    }

}

int[,] matrix= CreateMatrix(10,10,0,99);

PrintMatrix (matrix);
Console.Write("cреднее арифмитическое каждого столбца ");
FindSrarif (matrix);

