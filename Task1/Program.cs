// Задача 56: Задайте прямоугольный двумерный массив.
// Напишите программу, которая будет находить строку с наименьшей суммой элементов.
// Например, задан массив:
// 1 4 7 2

// 5 9 2 3

// 8 4 2 4

// 5 2 6 7

// Программа считает сумму элементов в каждой строке и выдаёт
//номер строки с наименьшей суммой элементов: 1 строка



int[,] CreateMatrixRndInt(int row, int col, int min, int max)
{
    int[,] matrix = new int[row, col];
    Random rnd = new Random();

    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            matrix[i, j] = rnd.Next(min, max + 1);
        }
    }
    return matrix;
}

void PrintMatrix(int[,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        Console.Write("[");
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            Console.Write(j < matrix.GetLength(1) - 1 ?
            $"{matrix[i, j],4}" : $"{matrix[i, j],4}");
        }
        Console.WriteLine("]");
    }
}

void SmallestSumOfElement(int[,] matrix)
{
    int minSum = Int32.MaxValue;
    int index = 0;

    for (int i = 0; i < matrix.GetLength(0); i++)
    {

        int sum = 0;
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            sum = sum + matrix[i, j];
        }
        if (sum < minSum)
        {
            minSum = sum;
        }
        index++;

    }
    Console.WriteLine($"строка с наименьшей суммой элементов : {index} = {minSum}");
}






int[,] mtrx = CreateMatrixRndInt(3, 3, 1, 9);
PrintMatrix(mtrx);

Console.WriteLine();

SmallestSumOfElement(mtrx);

