/*
Задача 50. Напишите программу, которая
на вход принимает позиции 
элемента в двумерном массиве, 
и возвращает значение этого 
элемента или же указание, что такого элемента нет.

Например, задан массив:
1 4 7 2
5 9 2 3
8 4 2 4
17 -> такого числа в массиве нет
*/

int [,] CreateArray(int row, int col, int min , int max)
{
    Random rand = new Random();
    int [,] array = new int [row,col];
    for (int i = 0; i < row; i++)
    {
        for (int j = 0; j < col; j++)
        {
            array[i, j] = rand.Next(min, max+1);
        }
    }
    return array;
}

string FindNumberByIndex(int[,] array)
{
    Console.WriteLine("Введите номер строки:");
    int row = Convert.ToInt32(Console.ReadLine());
    Console.WriteLine("Введите номер столбца:");
    int col = Convert.ToInt32(Console.ReadLine());
    int numRows = array.GetLength(0);
    int numCols = array.GetLength(1);
    
    if (row >= 0 && row < numRows && col >= 0 && col < numCols)
    {
        int number = array[row, col];
        return ($"You find this index: [{row},{col}] and number in this position is: {number}");
    }
    else
    {
        return ($"You find this index: [{row},{col}]  and it doesn't exist in this matrix.");
    }
}

void PrintArray(int [,] array)
{
    int row = array.GetLength(0);
    int col = array.GetLength(1);
    for (int i = 0; i < row; i++)
    {
        for (int j = 0; j < col; j++)
        {
            Console.Write($"{array[i, j]}\t");
        }
        Console.WriteLine();
    }
}

int [,] array = CreateArray(5, 5, -10, 10);
string result = FindNumberByIndex(array);
Console.WriteLine(result);
Console.WriteLine();
PrintArray(array);


