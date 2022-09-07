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

int[,] proizv(int[,] array, int[,] array2 )
{
 int[,] result=new int [2,2];   
        
         result[0,0]= array[0,0]*array2[0,0] + array[0,1]* array2[1,0];
         result[1,0]= array[1,0]*array2[0,0] + array[1,1]* array2[1,0];
         result[0,1]= array[0,0]*array2[0,1] + array[0,1]* array2[1,1];
         result[1,1]= array[1,0]*array2[0,1] + array[1,1]* array2[1,1];
        
    
    return result;

}

int[,] matrix= CreateMatrix(2,2,0,99);
int[,] matrix2= CreateMatrix(2,2,0,99);
PrintMatrix (matrix);
PrintMatrix (matrix2);
Console.WriteLine($"произведение двух матриц равно");
int[,] matrix3 = proizv(matrix, matrix2);
PrintMatrix (matrix3);


