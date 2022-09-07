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

int Findmin(int[,] arr)
{
    
    double B;
    double minB=0;
    int str=0;
        for (int column = 0; column < arr.GetLength(1); ++column)
        {
          minB= minB+arr[0,column]; 
        }

    for (int row = 1; row < arr.GetLength(0); ++row)
    
    {
        B=0;
        for (int column = 0; column < arr.GetLength(1); ++column)
        {
          B= B+arr[row,column]; 
        }
       
        if(B < minB) {minB = B; str= row;};
        
        
    }
    return str;

}

int[,] matrix= CreateMatrix(6,3,0,99);

PrintMatrix (matrix);
int str= Findmin (matrix);
Console.Write($"строка с наименьшей суммой элементов {str}");

