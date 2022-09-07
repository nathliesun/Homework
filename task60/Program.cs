int[,,] CreateMatrix(int rowCount, int columnCount, int deepCount, int min, int max)
{
    int[,,] array = new int[rowCount, columnCount, deepCount];
    for (int row = 0; row < rowCount; ++row)
    {
        for (int column = 0; column < columnCount; ++column)
        {
            for (int deep = 0; deep < deepCount; ++deep)
        {
            array[row, column, deep] = new Random().Next(min, max + 1);

        }
        }
    }
    return array;
}
void PrintMatrix(int[,,] arr)
{
    for (int deep = 0; deep < arr.GetLength(2); ++deep)
    {
    for (int row = 0; row < arr.GetLength(0); ++row)
    {
        for (int column = 0; column < arr.GetLength(1); ++column)
        {
            
        System.Console.Write($"{arr[row, column, deep]} ( {row} , {column} , {deep} )\t");
        }
        System.Console.WriteLine();
    }
    }


}


int[,,] matrix= CreateMatrix(3,3,3,0,99);
PrintMatrix (matrix);


