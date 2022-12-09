// Задача 56: Задайте прямоугольный двумерный массив. 
// Напишите программу, которая будет находить строку с наименьшей суммой элементов.

var matrix = FillMatrix(5,9);
PrintMatrix(matrix);
System.Console.WriteLine();

Console.WriteLine($"Строка с наименьшей суммой: " + FindMin(FindSumRow(matrix)));

int[] FindSumRow(int[,] matrix)
{
    int[] sumElements = new int[matrix.GetLength(0)];
    int sumRow = 0;
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            sumRow +=matrix[i,j];
            sumElements[i] = sumRow;
        }
        System.Console.Write($"Сумма строки {i + 1}: " + sumRow + " ");
        Console.WriteLine();
        sumRow = 0;
    }
    return sumElements;
}

int FindMin(int[] arr)
{
    int min = arr[0];
    int index = 0;
    for (int i = 0; i < arr.Length; i++)
    {
        if(arr[i] < min)
        {
            min = arr[i];
            index = i;
        }
    }
    return index +1;
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