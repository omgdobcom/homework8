// Задача 58: Задайте две матрицы. Напишите программу,
//  которая будет находить произведение двух матриц.

// 2 4 | 3 4
// 3 2 | 3 3
// Результирующая матрица будет:
// 18 20
// 15 18

var matrix1 = FillMatrix(2,2);
var matrix2 = FillMatrix(2,2);

PrintMatrix(matrix1);
Console.WriteLine();
PrintMatrix(matrix2);
System.Console.WriteLine();

int[,] resultMatrix = new int[2,2];

MultiplyMatrix(matrix1, matrix2, resultMatrix);
Console.WriteLine($"Произведение матриц:");
PrintMatrix(resultMatrix);




void MultiplyMatrix(int[,] firstMartrix, int[,] secomdMartrix, int[,] resultMatrix)
{
    for (int i = 0; i < resultMatrix.GetLength(0); i++)
    {
        for (int j = 0; j < resultMatrix.GetLength(1); j++)
        {
            int sum = 0;
            for (int k = 0; k < firstMartrix.GetLength(1); k++)
            {
                sum += firstMartrix[i,k] * secomdMartrix[k,j];
            }
        resultMatrix[i,j] = sum;
        }
    }
}

int[,] FillMatrix(int rows, int colums)
{
    int[,] matrix = new int[rows, colums];
    Random rnd = new Random();
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            matrix[i, j] = rnd.Next(1, 10);
        }
    }
    return matrix;
}


void PrintMatrix(int[,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            Console.Write($"{matrix[i, j]}, ");
        }
        System.Console.WriteLine();
    }
}