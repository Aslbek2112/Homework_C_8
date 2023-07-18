/*Задача 56: Задайте прямоугольный двумерный массив. 
Напишите программу, которая будет находить строку с наименьшей суммой элементов.
*/

Console.Clear();

int rows = GetNumberFromUser("Введите число cрок массива: ", "Ошибка данных");
int columns = GetNumberFromUser("Введите число столбцов массива: ", "Ошибка данных");

int [,] array = GetArray(rows, columns, 0, 10);
PrintArray(array);
Console.WriteLine();
int minSum = GetMinSum(array);

Console.Write($"{minSum} строка с наименьшей суммой элементов.");

int GetNumberFromUser(string message, string errorMessage)
{
    while(true)
    {
        Console.Write(message);
        if (int.TryParse(Console.ReadLine(), out int number))
            return number;
        Console.WriteLine(errorMessage);
    }
}

int [,] GetArray(int m, int n, int minValue, int maxValue)
{
    int [,] result = new int[m,n];
    for(int i = 0; i < m; i ++)
    {
        for (int j = 0; j < n; j++)
        {
            result[i,j] = new Random().Next(minValue, maxValue + 1);
        }
    }
    return result;
}

void PrintArray(int [,] arr)
{
    for (int i = 0; i < arr.GetLength(0); i++)
    {
        for (int j = 0; j < arr.GetLength(1); j++)
        {
            Console.Write($"{arr[i,j]}\t");
        }
        Console.WriteLine();
    }
}

int GetMinSum(int [,] arr)
{
    int minRowIndex = 0;
    int minRowSum = int.MaxValue;
    for (int i = 0; i < arr.GetLength(0); i++)
    {
        int rowSum = 0;
        for (int j = 0; j < arr.GetLength(1); j++)
        {
            rowSum += array[i,j];
        }
        if (rowSum < minRowSum)
        {
            minRowSum = rowSum;
            minRowIndex = i+1;
        }
    }
    return minRowIndex;
}