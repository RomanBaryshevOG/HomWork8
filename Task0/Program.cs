// Задача 54: Задайте двумерный массив. 
// Напишите программу, которая упорядочит по убыванию элементы каждой строки двумерного массива.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// В итоге получается вот такой массив:
// 7 4 2 1
// 9 5 3 2
// 8 4 4 2

int[,] CreateMatrixRndInt(int row, int col, int min, int max) // создаем метод для создания массива исходного
{
    int[,] matrix = new int[row, col];
    Random rnd = new Random();                                // заполняем массив случайными числами

    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            matrix[i, j] = rnd.Next(min, max + 1);
        }
    }
    return matrix;
}

void PrintMatrix(int[,] matrix)                                 // Содаем метод который печатает массив
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


int[,] SortingMatrix(int[,] matrix)                              // Создаем метод который сортирует массив
{

    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1) - 1; j++)
        {
            for (int k = 0; k < matrix.GetLength(1) - 1; k++)
            {
                if (matrix[i, k] < matrix[i, k + 1])      
                {
                    int temp = 0;
                    temp = matrix[i, k];
                    matrix[i, k] = matrix[i, k + 1];
                    matrix[i, k + 1] = temp;
                }
            } 
        }   
    }   return matrix;
}

int[,] mtrx = CreateMatrixRndInt(4, 4, 1, 9);
PrintMatrix(mtrx);

Console.WriteLine();

SortingMatrix(mtrx);
PrintMatrix(mtrx);