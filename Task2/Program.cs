// Задача 58: Задайте две матрицы. 
// Напишите программу, которая будет находить произведение двух матриц.
// Например, даны 2 матрицы:
// 2 4 | 3 4
// 3 2 | 3 3
// Результирующая матрица будет:
// 18 20
// 15 18


int[,] CreateMatrixOneRndInt(int row, int col, int min, int max)
{
    int[,] matrixK = new int[row, col];
    Random rnd = new Random();

    for (int i = 0; i < matrixK.GetLength(0); i++)
    {
        for (int j = 0; j < matrixK.GetLength(1); j++)
        {
            matrixK[i, j] = rnd.Next(min, max + 1);
        }
    }
    return matrixK;
}

void PrintMatrixOne(int[,] matrixK)
{
    for (int i = 0; i < matrixK.GetLength(0); i++)
    {
        Console.Write("[");
        for (int j = 0; j < matrixK.GetLength(1); j++)
        {
            Console.Write(j < matrixK.GetLength(1) - 1 ?
            $"{matrixK[i, j],3}" : $"{matrixK[i, j],4}");
        }
        Console.WriteLine("  ]");
    }
}


int[,] CreateMatrixTwoRndInt(int row, int col, int min, int max)
{
    int[,] matrixL = new int[row, col];
    Random rnd = new Random();

    for (int i = 0; i < matrixL.GetLength(0); i++)
    {
        for (int j = 0; j < matrixL.GetLength(1); j++)
        {
            matrixL[i, j] = rnd.Next(min, max + 1);
        }
    }
    return matrixL;
}

void PrintMatrixTwo(int[,] matrixL)
{
    for (int i = 0; i < matrixL.GetLength(0); i++)
    {
        Console.Write("[");
        for (int j = 0; j < matrixL.GetLength(1); j++)
        {
            Console.Write(j < matrixL.GetLength(1) - 1 ?
            $"{matrixL[i, j],3}" : $"{matrixL[i, j],4}");
        }
        Console.WriteLine("  ]");
    }
}


int[,] WorkMatrix(int[,] matrixK, int[,] matrixL)
{
    int[,] matrixC = new int[matrixK.GetLength(0), matrixL.GetLength(1)];
    {
        for (int i = 0; i < matrixC.GetLength(0); i++)
        {
            for (int j = 0; j < matrixC.GetLength(1); j++)
            {
                for (int k = 0; k < matrixC.GetLength(1); k++)
                {
                    matrixC[i, j] = matrixC[i, j] + (matrixK[i, k] * matrixL[k, j]);

                }
            }
        }
    }
    return matrixC;
}

void PrintMatrixThree(int[,] matrixC)
{
    for (int i = 0; i < matrixC.GetLength(0); i++)
    {
        Console.Write("[");
        for (int j = 0; j < matrixC.GetLength(1); j++)
        {
            Console.Write(j < matrixC.GetLength(1) - 1 ?
            $"{matrixC[i, j],3}" : $"{matrixC[i, j],4}");
        }
        Console.WriteLine("  ]");
    }
}


int[,] mtrxK = CreateMatrixOneRndInt(2, 2, 1, 9);
PrintMatrixOne(mtrxK);

Console.WriteLine();

int[,] mtrxL = CreateMatrixTwoRndInt(2, 2, 1, 9);
PrintMatrixTwo(mtrxL);
Console.WriteLine();

int[,] mtrxC = WorkMatrix(mtrxK, mtrxL);
PrintMatrixThree(mtrxC);
