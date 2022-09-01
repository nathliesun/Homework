double[,] CreateMatrix(int rowCount, int columnCount)
{
    double[,] array = new double [rowCount, columnCount];
    for (int row = 0; row < rowCount; ++row)
    {
        for (int column = 0; column < columnCount; ++column)
        {
            array[row, column] = new Random().NextDouble();

        }
    }
    return array;
}
void PrintMatrix(double[,] arr)
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
double[,] matrix= CreateMatrix(3,4);
PrintMatrix (matrix);
