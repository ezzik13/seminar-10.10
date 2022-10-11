// Задача 56: Задайте прямоугольный двумерный массив. Напишите программу, которая будет находить строку с наименьшей суммой элементов.

// Например, задан массив:

// 1 4 7 2

// 5 9 2 3

// 8 4 2 4

// 5 2 6 7

// Программа считает сумму элементов в каждой строке и выдаёт номер строки с наименьшей суммой элементов: 1 строка



using static System.Console;
Clear();
Write("введите размер матрицы и минимальный и максимальное значение через пробел: ");
int[] parametrs = GetArrayFromString(ReadLine());
int[,] matrix = GetMatrixArray(parametrs[0], parametrs[1], parametrs[2], parametrs[3]);
PrinttMatrix(matrix);
WriteLine();
FindMinSumRow(matrix);














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


void FindMinSumRow(int[,] inMatrix)
{
    int[] array = new int[inMatrix.GetLength(0)];
    for (int i = 0; i < array.Length; i++)
    {
        int sum = 0;
        for (int j = 0; j < inMatrix.GetLength(1); j++)
        {
            sum=sum+inMatrix[i,j];
        }
        array[i]=sum;
    }
    WriteLine(String.Join(" ", array));
    int min=array[0];
    int str=0;
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i]<min)
        {
        min=array[i];
        str=i;
        }
    }
    WriteLine($"минимальная сумма элементов {min} в строке {str+1} ");
}