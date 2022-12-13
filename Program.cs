/* Задача 54: Задайте двумерный массив. Напишите программу, которая упорядочит по убыванию элементы каждой строки двумерного массива.
Например, задан массив:
1 4 7 2
5 9 2 3
8 4 2 4
В итоге получается вот такой массив:
7 4 2 1
9 5 3 2
8 4 4 2*/

int rows = new Random().Next(0, 10);
int columns = new Random().Next(0, 10);
int[,] array = new int[rows, columns];
FillMatrixRandomNumbers(array);
WriteMatrix(array);
Console.WriteLine();

for (int i = 0; i < array.GetLength(0); i++)
{
    for (int l = 0; l < array.GetLength(1); l++)
    {
        for (int j = 0; j < array.GetLength(1) - 1; j++)
        {
            int temp = array[i, j];
            if (array[i, j + 1] > temp)
            {
                temp = array[i, j];
                array[i, j] = array[i, j + 1];
                array[i, j + 1] = temp;

            }
        }
    }
}
WriteMatrix(array);
void FillMatrixRandomNumbers(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            array[i, j] = new Random().Next(1, 10);
        }
    }
}

void WriteMatrix(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            Console.Write(array[i, j] + "  ");
        }
        Console.WriteLine();
    }
}

/* Задача 56: Задайте прямоугольный двумерный массив. Напишите программу, которая будет находить строку с наименьшей суммой элементов.
Например, задан массив:
1 4 7 2
5 9 2 3
8 4 2 4
5 2 6 7
Программа считает сумму элементов в каждой строке и выдаёт номер строки с наименьшей суммой элементов: 1 строка */

int rows = new Random().Next(1, 5);
int columns = new Random().Next(1, 5);
int[,] array = new int[rows, columns];
FillMatrixRandomNumbers(array);
WriteMatrix(array);
Console.WriteLine();
int rowSum = 0;
int minRowSum = 0;
for (int i = 0; i < array.GetLength(1); i++)
{
    minRowSum += array[0, i];
}

int indexMinSumRow = 0;
for (int i = 1; i < array.GetLength(0); i++)
{
    for (int j = 0; j < array.GetLength(1); j++)
    {
        rowSum += array[i, j];
    }
    if (rowSum < minRowSum)
    {
        minRowSum = rowSum;
        indexMinSumRow = i;
    }
    rowSum = 0;
}
Console.WriteLine(indexMinSumRow + 1 + " строка");

void FillMatrixRandomNumbers(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            array[i, j] = new Random().Next(1, 10);
        }
    }
}

void WriteMatrix(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            Console.Write(array[i, j] + "  ");
        }
        Console.WriteLine();
    }
}

/*Задача 58: Задайте две матрицы. Напишите программу, которая будет находить произведение двух матриц.
Например, даны 2 матрицы:
2 4 | 3 4
3 2 | 3 3
Результирующая матрица будет:
18 20
15 18*/

int rowsA = ReadInt("Введите количестов строк первой матрицы");
int columnsA = ReadInt("Введите количестов столбцов первой матрицы");
int rowsB = ReadInt("Введите количестов строк второй матрицы");
int columnsB = ReadInt("Введите количестов столбцов второй матрицы");
int[,] arrayA = new int[rowsA, columnsA];
int[,] arrayB = new int[rowsB, columnsB];
int[,] arrayC = new int[rowsA, columnsB];
FillMatrixRandomNumbers(arrayA);
WriteMatrix(arrayA);
Console.WriteLine();
FillMatrixRandomNumbers(arrayB);
WriteMatrix(arrayB);
Console.WriteLine();
if (rowsA == columnsB)
{
    for (int i = 0; i < arrayA.GetLength(0); i++)
    {
        for (int j = 0; j < arrayB.GetLength(1); j++)
        {
            for (int l = 0; l < arrayB.GetLength(0); l++)
            {
                arrayC[i, j] += arrayA[i, l] * arrayB[l, j];
            }
        }
    }
    WriteMatrix(arrayC);
    Console.WriteLine();
}
else Console.WriteLine("Найти произведение заданных матриц невозможно," +
" для умножения матриц необходимо, чтобы количество строк первой матрицы было равно количеству стоблцов второй матрицы");

int ReadInt(string message)
{
    Console.WriteLine(message);
    return Convert.ToInt32(Console.ReadLine());
}

void FillMatrixRandomNumbers(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            array[i, j] = new Random().Next(1, 5);
        }
    }
}

void WriteMatrix(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            Console.Write(array[i, j] + "  ");
        }
        Console.WriteLine();
    }
    Console.WriteLine();
}

/* Задача 60. ...Сформируйте трёхмерный массив из неповторяющихся двузначных чисел. Напишите программу, которая будет построчно выводить массив, добавляя индексы каждого элемента.
Массив размером 2 x 2 x 2
66(0,0,0) 25(0,1,0)
34(1,0,0) 41(1,1,0)
27(0,0,1) 90(0,1,1)
26(1,0,1) 55(1,1,1) */

int rows = new Random().Next(1, 5);
int columns = new Random().Next(1, 5);
int sheets = new Random().Next(1, 5);
int sizeSourceArray = 100;
int number = 1;
int index = 0;
int[,,] array = new int[rows, columns, sheets];
int[] sourceArrayNumbers = new int[sizeSourceArray];
for (int i = 0; i < sourceArrayNumbers.Length; i++)
{
    sourceArrayNumbers[i] = number;
    number++;
}
for (int i = 0; i < array.GetLength(0); i++)
{
    for (int j = 0; j < array.GetLength(1); j++)
    {
        for (int l = 0; l < array.GetLength(2); l++)
        {
            while (array[i, j, l] == 0)
            {
                index = new Random().Next(0, 100);
                if (sourceArrayNumbers[index] > 0)
                {
                    array[i, j, l] = sourceArrayNumbers[index];
                    sourceArrayNumbers[index] = 0;
                }
            }
        }
    }
}
WriteMatrix(array);

void WriteMatrix(int[,,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            for (int l = 0; l < array.GetLength(2); l++)
            {
                Console.Write(array[i, j, l] + "(" + i + "," + j + "," + l + ") ");
            }
            Console.WriteLine();
        }
    }
}

/* Задача 62. Напишите программу, которая заполнит спирально массив 4 на 4.
Например, на выходе получается вот такой массив:
01 02 03 04
12 13 14 05
11 16 15 06
10 09 08 07 */

int rows = new Random().Next(1, 5); //заполняется рандомный массив
int columns = new Random().Next(1, 5);
int[,] array = new int[rows, columns];
int row = 0;
int col = 0;
int dx = 1;
int dy = 0;
int direction = 0;
int gran = columns;
for (int i = 0; i < array.Length; i++)
{
    array[row, col] = i + 1;
    if (--gran == 0)
    {
        gran = columns * (direction % 2) + rows * ((direction + 1) % 2) - (direction / 2 - 1) - 2;
        int temp = dx;
        dx = -dy;
        dy = temp;
        direction++;
    }
    col += dx;
    row += dy;
}

for (int i = 0; i < rows; i++)
{
    for (int j = 0; j < columns; j++)
    {
        Console.Write(array[i, j] + "\t");
    }
    Console.WriteLine("");
}


/* Доп. адача 61*: Вывести первые N строк треугольника Паскаля. Сделать вывод в виде равнобедренного треугольника */

int n = new Random().Next(1, 10);
int[,] array = new int[n + 1, n * 2 + 1];
int index = n;
for (int i = 0; i < array.GetLength(1); i++)
{
    if (index >= 0)
    {
        array[index, i] = 1;
        array[index, array.GetLength(1) - i - 1] = 1;
        index--;
    }
}
for (int i = 2; i < array.GetLength(0); i++)
{
    for (int j = 1; j < array.GetLength(1) - 1; j++)
    {
        array[i, j] = array[i - 1, j - 1] + array[i - 1, j + 1];
    }
}
for (int i = 0; i < array.GetLength(0); i++)
{
    for (int j = 0; j < array.GetLength(1); j++)
    {
        if (array[i, j] > 0)
        {
            Console.Write("\t" + array[i, j]);

        }
        else
        {
            Console.Write("\t");

        }

    }
    Console.WriteLine();
}

