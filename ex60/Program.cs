// Задача 60. ...Сформируйте трёхмерный массив из неповторяющихся двузначных чисел. 
// Напишите программу, которая будет построчно выводить массив, добавляя индексы каждого элемента.
// Массив размером 2 x 2 x 2
// 66(0,0,0) 25(0,1,0)
// 34(1,0,0) 41(1,1,0)
// 27(0,0,1) 90(0,1,1)
// 26(1,0,1) 55(1,1,1)

using static System.Console;
Clear();
Write("введите размер трехмерного массива: ");
int size = Convert.ToInt32(ReadLine());
int[,,] cubMatrix = new int[size, size, size];
FillCubMatrix(cubMatrix);
PrintCubMatrix(cubMatrix);


void FillCubMatrix(int[,,] inCubMatrix)
{
    int[] array = new int[inCubMatrix.GetLength(0) * inCubMatrix.GetLength(0) * inCubMatrix.GetLength(0)];
    for (int i = 0; i < array.Length; i++)
    {
        array[i] = new Random().Next(10, 100);
    }
    WriteLine(String.Join(" ", array));

    for (int i = 0; i < array.Length; i++)
    {
        for (int j = 0; j < array.Length; j++)
        {
            if (i == j) continue;
            else
            if (array[i] == array[j])
            {
                array[j] = new Random().Next(10, 100);
                j--;
            }

        }
    }

    WriteLine(String.Join(" ", array));
    int count = 0;
    for (int i = 0; i < inCubMatrix.GetLength(0); i++)
    {
        for (int j = 0; j < inCubMatrix.GetLength(1); j++)
        {
            for (int z = 0; z < inCubMatrix.GetLength(2); z++)
            {
                inCubMatrix[i, j, z] = array[count];
                count++;
            }

        }
    }
}

void PrintCubMatrix(int[,,] inCubMatrix)
{
    for (int i = 0; i < inCubMatrix.GetLength(0); i++)
    {
        for (int j = 0; j < inCubMatrix.GetLength(1); j++)
        {
            for (int z = 0; z < inCubMatrix.GetLength(2); z++)
            {
                if (z < inCubMatrix.GetLength(2) - 1)
                    Write($"{inCubMatrix[i, j, z]}({i},{j},{z})  ");
                else
                    WriteLine($"{inCubMatrix[i, j, z]}({i},{j},{z})");
            }

        }
    }
}




