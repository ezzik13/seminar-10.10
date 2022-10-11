// **Задача 55:** Задайте двумерный массив. Напишите программу, 
// которая заменяет строки на столбцы. В случае, если это невозможно, программа должна вывести сообщение для пользователя.
using static System.Console;
Clear();
Write("введите размер матрицы и минимальный и максимальное значение через пробел: ");
int[] parametrs = GetArrayFromString(ReadLine());
int[,] matrix = GetMatrixArray(parametrs[0], parametrs[1], parametrs[2], parametrs[3]);
PrinttMatrix(matrix);
WriteLine();

if (matrix.GetLength(0) != matrix.GetLength(1))
    WriteLine("Матрица не инвертируется");
else PrinttMatrix(InvertMatrix(matrix));









int[,] GetMatrixArray(int rows, int columns, int minValue, int maxValue)
{
    int[,] resultMatrix = new int[rows, columns];
    for (int i = 0; i < resultMatrix.GetLength(0); i++)
    {
        for (int j = 0; j < resultMatrix.GetLength(1); j++)
        {
            resultMatrix[i, j] = new Random().Next(minValue, maxValue);
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
            Write($"{inMatrix[i, j]} ");
        }
        WriteLine();
    }
}
int[] GetArrayFromString(string parameters)
{
    string[] parames = parameters.Split(" ", StringSplitOptions.RemoveEmptyEntries);
    int[] parameterNum = new int[parames.Length];
    for (int i = 0; i < parameterNum.Length; i++)
    {
        parameterNum[i] = int.Parse(parames[i]);
    }
    return parameterNum;
}

int[,] InvertMatrix(int[,] inMatrix)
{
    // int[,] finalMatrix = new int[inMatrix.GetLength(0), inMatrix.GetLength(1)];
    int temp = 0;

    for (int i = 0; i < inMatrix.GetLength(0); i++)
    {
        for (int j = i; j < inMatrix.GetLength(1); j++)
        {
            temp = inMatrix[i, j];
            inMatrix[i, j] = inMatrix[j, i];
            inMatrix[j, i] = temp;

        }
    }
    // return finalMatrix;
    return inMatrix;


}
