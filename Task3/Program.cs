// Задача 60. ...Сформируйте трёхмерный массив из неповторяющихся двузначных чисел.
// Напишите программу, которая будет построчно выводить массив, добавляя индексы каждого элемента.
// Массив размером 2 x 2 x 2
// 66(0,0,0) 25(0,1,0)
// 34(1,0,0) 41(1,1,0)
// 27(0,0,1) 90(0,1,1)
// 26(1,0,1) 55(1,1,1)




int[,,] CreateMatrix3D(int row, int col, int zone)
{
    int count = 77;

    int[,,] matrix3D = new int[row, col, zone];
    int[] array = new int[count];

    int num = 10;
    for (int i = 0; i < array.Length; i++)
    {
        array[i] = num++;
    }
    for (int i = 0; i < array.Length; i++)
    {
        int randomInd = new Random().Next(0, array.Length);
        int temp = array[i];
        array[i] = array[randomInd];
        array[randomInd] = temp;
    }

    int value = 0;

    for (int i = 0; i < matrix3D.GetLength(0); i++)
    {
        for (int j = 0; j < matrix3D.GetLength(1); j++)
        {
            for (int k = 0; k < matrix3D.GetLength(2); k++)
            {
                matrix3D[i, j, k] = array[value++];
            }
        }
    }
    return matrix3D;
}

int[,,] mtrx3D = CreateMatrix3D(2, 2, 2);

for (int i = 0; i < mtrx3D.GetLength(0); i++)
{
    for (int j = 0; j < mtrx3D.GetLength(1); j++)
    {
        for (int k = 0; k < mtrx3D.GetLength(2); k++)
        {
            Console.Write($"{mtrx3D[i, j, k]}   |->   ({i},{j},{k}) ");

        }
        Console.WriteLine();
    }

}
