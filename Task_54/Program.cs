/*Задача 54: Задайте двумерный массив. Напишите программу, 
которая упорядочит по убыванию элементы каждой строки двумерного массива.
*/
Console.Clear();

int rows = GetNumberFromUser("Введите число cрок массива: ", "Ошибка данных");
int columns = GetNumberFromUser("Введите число столбцов массива: ", "Ошибка данных");

int [,] array = GetArray(rows, columns, 0, 10);
PrintArray(array);
Console.WriteLine();
PrintArray(array);
SortRowsDescending(array);
Console.WriteLine();
PrintArray(array);

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


void SortRowsDescending(int[,] array)
{
    int rows = array.GetLength(0);
    int columns = array.GetLength(1);

    for (int i = 0; i < rows; i++)
    {
        for (int j = 0; j < columns - 1; j++)
        {
            for (int k = 0; k < columns - j - 1; k++)
            {
                if (array[i, k] < array[i, k + 1])
                {
                    int temp = array[i, k];
                    array[i, k] = array[i, k + 1];
                    array[i, k + 1] = temp;
                }
            }
        }
    }
}