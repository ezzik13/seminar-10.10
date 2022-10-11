// Задача 62. Напишите программу, которая заполнит спирально массив 4 на 4.
// Например, на выходе получается вот такой массив:
// 01 02 03 04
// 12 13 14 05
// 11 16 15 06
// 10 09 08 07

using static System.Console;
Clear();
Write("введите количество строк матрицы: ");
int rows = Convert.ToInt32(ReadLine());
Write("введите количество столбцов матрицы: ");
int columns = Convert.ToInt32(ReadLine());
int[,] matrix = new int[rows, columns];
FillMatrix(matrix);

PrinttMatrix(matrix);




void FillMatrix(int[,] inMatrix)
{
    int ring = 0;
    if (inMatrix.GetLength(0) > inMatrix.GetLength(1))
        ring = inMatrix.GetLength(1);
    else
        ring = inMatrix.GetLength(0);
    int count = 0;
    for (int i = 0; i < ring / 2; i++)
    {
        for (int columns = 0 + i; columns < inMatrix.GetLength(1) - i; columns++)
        {
            inMatrix[i, columns] = count;
            count++;
        }
        for (int rows = 1 + i; rows < inMatrix.GetLength(0) - i; rows++)
        {
            inMatrix[rows, inMatrix.GetLength(1) - i - 1] = count;
            count++;
        }
        for (int columns = inMatrix.GetLength(1) - i - 2; columns >= i; columns--)
        {
            inMatrix[inMatrix.GetLength(0) - 1 - i, columns] = count;
            count++;
        }
        for (int rows = inMatrix.GetLength(0) - i - 2; rows >= i + 1; rows--)
        {
            inMatrix[rows, i] = count;
            count++;
        }
    }
    if (ring % 2 != 0)
    {
        if (inMatrix.GetLength(0) > inMatrix.GetLength(1))
        {
            for (int i = (ring / 2); i < inMatrix.GetLength(0) - ring / 2; i++)
            {
                inMatrix[i, ring / 2] = count;
                count++;
            }
        }
        else
        {
            for (int i = (ring / 2); i < inMatrix.GetLength(1) - ring / 2; i++)
            {
                inMatrix[ring / 2, i] = count;
                count++;
            }
        }
    }
}








void PrinttMatrix(int[,] inMatrix)
{
    for (int i = 0; i < inMatrix.GetLength(0); i++)
    {
        for (int j = 0; j < inMatrix.GetLength(1); j++)
        {
            Write($"{inMatrix[i, j]}\t ");
        }
        WriteLine();
    }
}