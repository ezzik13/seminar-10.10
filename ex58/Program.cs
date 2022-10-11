// Задача 58: Задайте две матрицы. Напишите программу, которая будет находить произведение двух матриц.
// Например, даны 2 матрицы:
// 2 4 | 3 4
// 3 2 | 3 3
// Результирующая матрица будет:
// 18 20
// 15 18

using static System.Console;
Clear();
Write("введите количество строк первой матрицы: ");
int rows = Convert.ToInt32(ReadLine());
Write("введите количество столбцов первой матрицы: ");
int columns = Convert.ToInt32(ReadLine());
int[,] matrix1 = GetMatrixArray(rows, columns);
PrinttMatrix(matrix1);
WriteLine();
int[,] matrix2 = GetMatrixArray(columns, rows);
PrinttMatrix(matrix2);
WriteLine();
int[,] multiMatrix = MatrixMultiplication(matrix1, matrix2);
PrinttMatrix(multiMatrix);


int[,] GetMatrixArray(int size1, int size2)
{
    int[,] resultMatrix = new int[size1, size2];
    for (int i = 0; i < resultMatrix.GetLength(0); i++)
    {
        for (int j = 0; j < resultMatrix.GetLength(1); j++)
        {
            resultMatrix[i, j] = new Random().Next(1, 10);
        }
    }
    return resultMatrix;
}


void PrinttMatrix(int[,] inMatrix)
{
    for (int i = 0; i < inMatrix.GetLength(0); i++)
    {
        for (int j = 0; j < inMatrix.GetLength(1); j++)
        {
            Write($"{inMatrix[i, j]}\t");
        }
        WriteLine();
    }
}

int[,] MatrixMultiplication(int[,] inMatrixA, int[,] inMatrixB)
{
    int[,] finalMatrix = new int[inMatrixA.GetLength(0), inMatrixB.GetLength(1)];
    for (int i = 0; i < finalMatrix.GetLength(0); i++)
    {
        for (int j = 0; j < finalMatrix.GetLength(1); j++)
        {
            int sum = 0;
            for (int z = 0; z < inMatrixA.GetLength(1); z++)
            {
                sum = inMatrixA[i, z] * inMatrixB[z, j];
                finalMatrix[i, j] = finalMatrix[i, j] + sum;
            }

        }
    }
    return finalMatrix;
}