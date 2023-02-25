// Задача 47. Задайте двумерный массив размером m×n, заполненный случайными вещественными числами.
// m = 3, n = 4.
// 0,5 7 -2 -0,2
// 1 -3,3 8 -9,9
// 8 7,8 -7,1 9


Console.Clear();
System.Console.WriteLine("Задача 47. Задайте двумерный массив размером m*n, заполненный случайными вещественными числами.");
System.Console.WriteLine();
int rowMas1 = EnterIntDataMorethenzero ("Введите количество строк массива: ");
int colMas1 = EnterIntDataMorethenzero ("Введите количество столбцов массива: ");
int minElement1 = EnterIntData ("Введите минимальное значение элемента массива: ");
int maxElement1 = EnterIntData ($"Введите максимальное значение элемента массива (больше, чем {minElement1}): ");
double[,] mass1 = FillArrayDouble(rowMas1, colMas1, minElement1, maxElement1);
PrintMassDouble(mass1);
Console.ReadLine();

//Задача 50. Напишите программу, которая на вход принимает позиции элемента в двумерном массиве, и возвращает значение этого элемента или же указание, что такого элемента нет.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// 17 -> такого числа в массиве нет

Console.Clear();
System.Console.WriteLine("Задача 50. Напишите программу, которая на вход принимает позиции элемента в двумерном массиве, и возвращает значение этого элемента или же указание, что такого элемента нет.");
System.Console.WriteLine();
int rowMas2 = EnterIntDataMorethenzero ("Введите количество строк массива: ");
int colMas2 = EnterIntDataMorethenzero ("Введите количество столбцов массива: ");
int rowEl = EnterIntDataMorethenzero ($"Введите строку массива по искомому элементу (не более {rowMas2}): ");
int colEl = EnterIntDataMorethenzero ($"Введите столбец массива по искомому элементу (не более {colMas2}): ");
double[,] mass2 = FillArrayDouble(rowMas2, colMas2, 10, 99);
if (rowEl<=rowMas2 || colEl<=colMas2) 
    System.Console.WriteLine ($"Искомый элемент на позиции строка {rowEl}: столбец {colEl} = {mass2[rowEl-1,colEl-1]}");
    else System.Console.WriteLine($"Позиция элемента строка {rowEl} столбец {colEl} указана неверно.");
PrintMassDouble(mass2);
Console.ReadLine();


// Задача 52. Задайте двумерный массив из целых чисел. Найдите среднее арифметическое элементов в каждом столбце.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// Среднее арифметическое каждого столбца: 4,6; 5,6; 3,6; 3.

Console.Clear();
System.Console.WriteLine("Задача 52. Задайте двумерный массив из целых чисел. Найдите среднее арифметическое элементов в каждом столбце.");
System.Console.WriteLine();
int rowMas3 = EnterIntDataMorethenzero ("Введите количество строк массива: ");
int colMas3 = EnterIntDataMorethenzero ("Введите количество столбцов массива: ");
int minElement3 = EnterIntData ("Введите минимальное значение элемента массива: ");
int maxElement3 = EnterIntData ("Введите максимальное значение элемента массива: ");
int [,] mass3 = FillArrayInt (rowMas3, colMas3, minElement3, maxElement3);
PrintMassInt(mass3);
FindSrAr(mass3);
Console.ReadLine();

// Задача 62. Напишите программу, которая заполнит спирально массив 4 на 4. Например, на выходе получается вот такой массив:
// 01 02 03 04
// 12 13 14 05
// 11 16 15 06
// 10 09 08 07

Console.Clear();
System.Console.WriteLine("Задача 62. Напишите программу, которая заполнит спирально массив 4 на 4. Например, на выходе получается вот такой массив:");
System.Console.WriteLine();
int numRowCol = EnterIntDataMorethenzero("Введите количество строк/столбцов квадратной матрицы: ");
int [,] matrix =  new int[numRowCol, numRowCol];
FillSpiralMatrix(numRowCol, matrix);
Console.ReadLine();


//МЕТОДЫ

void FindSrAr(int[,] matrix)  //среднее арифметическое каждой сроки массива
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        double srAr = 0;
        for (int j = 0; j < matrix.GetLength(1); j++)
            srAr += matrix[i, j];
        double res = Convert.ToDouble(srAr / matrix.GetLength(1));
        System.Console.WriteLine($"Среднее арифметическое строки {i + 1} = {res:#.##}");
    }
}

int EnterIntDataMorethenzero(string text) //ввод пользователем требуемого в сопровождаемом тексте интового положительного значения
{
    while (true)
    {
        System.Console.Write(text);
        int num = 0;
        string str = Console.ReadLine();
        if (int.TryParse(str, out num)) num = int.Parse(str);
        if (num > 0) { return num; break; }
        else System.Console.WriteLine("Ошибка, повторите ввод");
    }
}

double[,] FillArrayDouble(int row, int col, int minValue, int maxValue) //заполнение двумерного массива числами рандом дабл 
{
    double[,] mass = new double[row, col];
    for (int i = 0; i < row; i++)
        for (int j = 0; j < col; j++)
        {
            mass[i, j] = new Random().NextDouble() + new Random().Next(minValue + 1, maxValue - 1);
            mass[i, j] = Math.Round(mass[i, j], 2);
        }
    return mass;
}


void PrintMassDouble(double[,] mass) // печать двумерного массива дабл
{
    for (int i = 0; i < mass.GetLongLength(0); i++)
    {
        for (int j = 0; j < mass.GetLongLength(1); j++)
            System.Console.Write($"{mass[i, j]} ");
        System.Console.WriteLine();
    }
}

void PrintMassInt(int[,] mass) // печать двумерного массива инт
{
    for (int i = 0; i < mass.GetLongLength(0); i++)
    {
        for (int j = 0; j < mass.GetLongLength(1); j++)
            System.Console.Write($"{mass[i, j]} ");
        System.Console.WriteLine();
    }
}
int[,] FillArrayInt(int row, int col, int minValue, int maxValue) //заполнение двумерного массива числами рандом инт
{
    int[,] mass = new int[row, col];
    for (int i = 0; i < row; i++)
        for (int j = 0; j < col; j++)
        { mass[i, j] = new Random().Next(minValue, maxValue + 1); }
    return mass;
}

int EnterIntData(string text) //ввод пользователем требуемого в сопровождаемом тексте интового значения
{
    while (true)
    {
        System.Console.Write(text);
        int num = 0;
        string str = Console.ReadLine();
        if (int.TryParse(str, out num)) { num = int.Parse(str); return num; break; }
        else System.Console.WriteLine("Ошибка, повторите ввод");
    }
}

void PrintInt(int[,] matrixInt)  //вывод интового двумерного массива
{
    for (int i = 0; i < matrixInt.GetLength(0); i++)
    {
        for (int j = 0; j < matrixInt.GetLength(1); j++)
            System.Console.Write(matrixInt[i, j] + " ");
        System.Console.WriteLine();
    }
}

int[,] GetIntMatrix(int rows, int colums, int min, int max) //ввод рандомного интового двумерного массива
{
    int[,] matrix = new int[rows, colums];
    for (int i = 0; i < rows; i++)
        for (int j = 0; j < colums; j++)
            matrix[i, j] = new Random().Next(min, max + 1);
    return matrix;
}

// void FillSpiralMatrix (int row, int col, int count) //заполнение спиральной квадратной матрицы с РЕКУРСИЕЙ НЕ ПОЛУЧИЛОСЬ!!!
                                                       //сначала по краям всё хорошо, а на внутренних кольцах массива
                                                       //ложится змейкой... ;( не могу исправить, разные варианты - результат один
                                                       //дня три билась... ;(

// {matrix[row, col] = count;
// count++;   
// PrintInt(matrix);
// while (col+1<matrix.GetLength(1) && matrix[row,col+1]==0)
//     FillSpiralMatrix(row, col+1,count);
// while (row+1<matrix.GetLength(0) && matrix[row+1,col]==0)
//     FillSpiralMatrix(row+1, col,count);
// while (col-1>=0 && matrix[row,col-1]==0)
//     FillSpiralMatrix(row, col-1,count);
// while (row-1>0 && matrix[row-1,col]==0)
//     FillSpiralMatrix(row-1, col,count);
// }

void FillSpiralMatrix (int numRowCol, int[,]matrix) //спиральная квадратная матрица 
{
int row = 0;
int col = -1;
int i = 1;
int dRow = 0;
int dCol = 1;
while (i <= numRowCol * numRowCol)
{
    if (row + dRow >= 0 && row + dRow < matrix.GetLength(0) && col + dCol >= 0 && col + dCol < matrix.GetLength(1) && matrix[row + dRow, col + dCol] == 0)
    {
        row = row + dRow;
        col = col + dCol;
        matrix[row, col] = i;
        i++;
    }
    else if (dCol == 1)
    {
        dCol = 0;
        dRow = 1;
    }
    else if (dRow == 1)
    {
        dRow = 0;
        dCol = -1;
    }
    else if (dCol == -1)
    {
        dCol = 0;
        dRow = -1;
    }
    else if (dRow == -1)
    {
        dRow = 0;
        dCol = 1;
    }
}
PrintInt(matrix);
}



