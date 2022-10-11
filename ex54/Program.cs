// Задача 54: Задайте двумерный массив. Напишите программу, которая упорядочит по убыванию элементы каждой строки двумерного массива.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// В итоге получается вот такой массив:
// 7 4 2 1
// 9 5 3 2
// 8 4 4 2


using static System.Console;
Clear();
Write("введите размер матрицы и минимальный и максимальное значение через пробел: ");
int[] parametrs = GetArrayFromString(ReadLine());
int[,] matrix = GetMatrixArray(parametrs[0], parametrs[1], parametrs[2], parametrs[3]);
PrinttMatrix(matrix);
WriteLine();
int[,] sortMatrix=SortingMatrix(matrix);
PrinttMatrix(sortMatrix);













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
            Write($"{inMatrix[i, j]}\t ");
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

int[,] SortingMatrix(int[,] inMatrix)
{
    int[,] result=new int[inMatrix.GetLength(0),inMatrix.GetLength(1)];
    for (int i = 0; i < inMatrix.GetLength(0); i++)
    {
        int [] array=new int [inMatrix.GetLength(1)];
        for (int j = 0; j < array.Length; j++)
        {
            array[j]=inMatrix[i,j];
        }
        Array.Sort(array);
        for (int j = 0; j < array.Length; j++)
        {
            result[i,j]=array[j];
        }
    }

return result;
}