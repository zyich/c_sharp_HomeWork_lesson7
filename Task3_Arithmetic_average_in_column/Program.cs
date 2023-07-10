/* 
Задача 52. Задайте двумерный массив из 
целых чисел. Найдите среднее 
арифметическое элементов в каждом столбце.

Например, задан массив:
1 4 7 2
5 9 2 3
8 4 2 4
Среднее арифметическое каждого столбца: 4,6; 5,6; 3,6; 3.
*/

int[,] CreateArray(int row, int col, int min, int max)
{
    Random rand = new Random();
    int[,] array = new int[row, col];
    for (int i = 0; i < row; i++)
    {
        for (int j = 0; j < col; j++)
        {
            array[i, j] = rand.Next(min, max + 1);
        }
    }
    return array;
}

(double[] sum, double[] AVG) CountToCol(int[,] array)
{
    int numRows = array.GetLength(0);
    int numCols = array.GetLength(1);
    double[] columnSums = new double[numCols];
    double[] columnAverages = new double[numCols];

    for (int j = 0; j < numCols; j++)
    {
        double sum = 0;
        for (int i = 0; i < numRows; i++)
        {
            sum += array[i, j];
        }
        columnSums[j] = sum;
        columnAverages[j] = sum / numRows;
    }

    return (columnSums, columnAverages);
}

void PrintArray(int[,] array)
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

void PrintResult(double[] sum, double[] AVG)
{
    int col = sum.Length;
    for (int j = 0; j < col; j++)
    {
        Console.WriteLine($"Сolomn {j + 1}: sum = {sum[j]}, Average = {AVG[j]}");
    }
}

Console.Clear();
int[,] array = CreateArray(3, 4, 0, 10);
PrintArray(array);
var (sum, AVG) = CountToCol(array);
PrintResult(sum, AVG);