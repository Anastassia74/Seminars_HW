// Задача 54: Задайте двумерный массив. Напишите программу, которая упорядочит по убыванию элементы каждой строки двумерного массива.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// В итоге получается вот такой массив:
// 7 4 2 1
// 9 5 3 2
// 8 4 4 2

// Задача 56: Задайте прямоугольный двумерный массив. Напишите программу, которая будет находить строку с наименьшей суммой элементов.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// 5 2 6 7
// Программа считает сумму элементов в каждой строке и выдаёт номер строки с наименьшей суммой элементов: 1 строка

// Задача 58: Задайте две матрицы. Напишите программу, которая будет находить произведение двух матриц.
// Например, даны 2 матрицы:
// 2 4 | 3 4
// 3 2 | 3 3
// Результирующая матрица будет:
// 18 20
// 15 18

// Задача 60. Сформируйте трёхмерный массив из неповторяющихся двузначных чисел. Напишите программу, которая будет построчно выводить массив, добавляя индексы каждого элемента.
// Массив размером 2 x 2 x 2
// 66(0,0,0) 25(0,1,0)
// 34(1,0,0) 41(1,1,0)
// 27(0,0,1) 90(0,1,1)
// 26(1,0,1) 55(1,1,1)


TaskChoose();

void TaskChoose()
{
    Console.Clear();
    System.Console.WriteLine("Задача 54: Задайте двумерный массив. Напишите программу, которая упорядочит по убыванию элементы каждой строки двумерного массива.");
    System.Console.WriteLine("Задача 56: Задайте прямоугольный двумерный массив. Напишите программу, которая будет находить строку с наименьшей суммой элементов.");
    System.Console.WriteLine("Задача 58: Задайте две матрицы. Напишите программу, которая будет находить произведение двух матриц.");
    System.Console.WriteLine("Задача 60. Сформируйте трёхмерный массив из неповторяющихся двузначных чисел. Напишите программу, которая будет построчно выводить массив, добавляя индексы каждого элемента.");
    {
        while (true)
        {
            System.Console.WriteLine();
            System.Console.Write("Введите номер задачи (54/56/58/60), для выхода введите 0: ");
            int task = int.Parse(Console.ReadLine());
            System.Console.WriteLine();
            switch (task)
            {
                case 54:
                    Console.Clear();
                    System.Console.WriteLine("Ваш выбор:");
                    System.Console.WriteLine("Задача 54: Задайте двумерный массив. Напишите программу, которая упорядочит по убыванию элементы каждой строки двумерного массива.");
                    System.Console.WriteLine();
                    int rowMas4 = EnterIntDataMorethenzero("Введите количество строк массива: ");
                    int colMas4 = EnterIntDataMorethenzero("Введите количество столбцов массива: ");
                    int minElement4 = EnterIntData("Введите минимальное значение элемента массива: ");
                    int maxElement4 = EnterIntData("Введите максимальное значение элемента массива: ");
                    int[,] mass4 = FillArrayInt(rowMas4, colMas4, minElement4, maxElement4);
                    PrintArrayInt(mass4);
                    System.Console.WriteLine();
                    mass4 = SortArrayRowsFromMaxToMin(mass4);
                    PrintArrayInt(mass4);
                    Console.ReadLine();
                    break;
                case 56:
                    Console.Clear();
                    System.Console.WriteLine("Ваш выбор:");
                    System.Console.WriteLine("Задача 56: Задайте прямоугольный двумерный массив. Напишите программу, которая будет находить строку с наименьшей суммой элементов.");
                    System.Console.WriteLine();
                    int rowMas6 = EnterIntDataMorethenzero("Введите количество строк массива: ");
                    int colMas6 = EnterIntDataMorethenzeroDif("Введите количество столбцов массива, отличное от количества строк: ", rowMas6);
                    int minElement6 = EnterIntData("Введите минимальное значение элемента массива: ");
                    int maxElement6 = EnterIntData("Введите максимальное значение элемента массива: ");
                    int[,] mass6 = FillArrayInt(rowMas6, colMas6, minElement6, maxElement6);
                    PrintArrayInt(mass6);
                    System.Console.WriteLine();
                    int[] temp6 = ArrayRowWithSum(mass6);
                    GetMinSumRow(temp6);
                    Console.ReadLine();
                    break;
                case 58:
                    Console.Clear();
                    System.Console.WriteLine("Ваш выбор:");
                    System.Console.WriteLine("Задача 58: Задайте две матрицы. Напишите программу, которая будет находить произведение двух матриц.");
                    System.Console.WriteLine();
                    int rowMas81 = EnterIntDataMorethenzero("Введите количество строк первого массива: ");
                    int colMas81 = EnterIntDataMorethenzero("Введите количество столбцов первого массива: ");
                    int rowMas82 = EnterIntDataMorethenzero("Введите количество строк второго массива: ");
                    int colMas82 = EnterIntDataMorethenzero("Введите количество столбцов второго массива: ");
                    if (colMas81!=rowMas82)
                    {System.Console.WriteLine("Матрицы невозможно перемножить. Количество столбцов первой матрицы должно быть равно количеству строк второй.");
                    break;}
                    int[,] mass81 = FillArrayInt(rowMas81, colMas81, 1, 5);
                    System.Console.WriteLine("Первая матрица");
                    PrintArrayInt(mass81);
                    int[,] mass82 = FillArrayInt(rowMas82, colMas82, 1, 5);
                    System.Console.WriteLine("Вторая матрица");
                    PrintArrayInt(mass82);
                    int [,] multiMass = MultipArray (mass81,mass82);
                    System.Console.WriteLine("Произведение двух матриц");
                    PrintArrayInt(multiMass);
                    Console.ReadLine();
                    break;
                case 60:
                    Console.Clear();
                    System.Console.WriteLine("Ваш выбор:");
                    System.Console.WriteLine("Задача 60. Сформируйте трёхмерный массив из неповторяющихся двузначных чисел. Напишите программу, которая будет построчно выводить массив, добавляя индексы каждого элемента.");
                    System.Console.WriteLine();
                    int xyzMas86 = EnterIntDataMorethenzero("Введите размер трехмерного кубического массива (X,Y,Z) - не более 4: ");
                    if (xyzMas86>4)
                    {System.Console.WriteLine("Количество неповторяющихся двузначных чисел не обеспечит заполнение такого массива.");
                    break;}
                    int[,,] mass3D = FillArray3DInt(xyzMas86, 10, 100);
                    PrintArray3DInt(mass3D);
                    break;
                case 0:
                    return;
                    break;
                default:
                    System.Console.WriteLine("Номер задания введен неверно. Повторите ввод!");
                    break;
            }
        }
    }
}


//МЕТОДЫ

int[,] SortArrayRowsFromMaxToMin(int[,] matrix) //сортировка строк массива по убыванию
{
    for (int row = 0; row < matrix.GetLength(0); row++)
    {
        for (int i = 0; i < matrix.GetLength(1) - 1; i++)
        {
            int maxPosition = i;
            for (int j = i + 1; j < matrix.GetLength(1); j++)
            {
                if (matrix[row, j] > matrix[row, maxPosition])
                    maxPosition = j;
            }
            int temp = matrix[row, i];
            matrix[row, i] = matrix[row, maxPosition];
            matrix[row, maxPosition] = temp;
        }

    }
    return matrix;
}


int[] ArrayRowWithSum(int[,] matrix)  //вывод одномерного массива с суммой элементов строк двумерного массива
{
    int i = 0;
    int rowSumm;
    int j;
    int[] temp = new int[matrix.GetLength(0)];
    while (i < matrix.GetLength(0))
    {
        j = 0;
        rowSumm = 0;
        while (j < matrix.GetLength(1))
        {
            rowSumm = rowSumm + matrix[i, j];
            j++;
        }
        temp[i] = rowSumm;
        System.Console.WriteLine($"Сумма элементов в строке {i + 1} равна {rowSumm}");
        i++;
    }
    return temp;
}

int [,] MultipArray (int[,]matrix1, int[,]matrix2) //произведение двух матриц
{
    int[,]multArr=new int[matrix1.GetLength(0),matrix2.GetLength(1)];
    for (int i = 0; i < matrix1.GetLength(0); i++) 
        for (int j = 0; j < matrix2.GetLength(1); j++) 
            for (int k = 0; k< matrix2.GetLength(0); k++) 
            {
                multArr[i,j]+=matrix1[i,k]*matrix2[k,j];
            }
return multArr;
}


void GetMinSumRow(int [] temp) //найти позицию строки с минимальной суммой элементов двумерного массива
{   int minSumm = temp[0];
    int indexMinSum = 0;
    int t = 0;
    while (t < temp.Length)
    {
        if (temp[t] < minSumm)
        {
            minSumm = temp[t];
            indexMinSum = t;
        }
        t++;
    }
    System.Console.WriteLine();
    System.Console.WriteLine($"Строка {indexMinSum+1} имеет минимальную сумму элементов {minSumm}.");
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

int EnterIntDataMorethenzeroDif(string text, int row) //ввод пользователем требуемого в сопровождаемом тексте интового положительного значения, отличного, от указанного
{
    while (true)
    {
        System.Console.Write(text);
        int num = 0;
        string str = Console.ReadLine();
        if (int.TryParse(str, out num)) num = int.Parse(str);
        if (num > 0 && num != row) { return num; break; }
        else System.Console.WriteLine("Ошибка, повторите ввод");
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

void PrintArrayInt(int[,] mass) // печать двумерного массива инт
{
    for (int i = 0; i < mass.GetLongLength(0); i++)
    {
        for (int j = 0; j < mass.GetLongLength(1); j++)
            System.Console.Write($"{mass[i, j]} ");
        System.Console.WriteLine();
    }
}

int[,,] FillArray3DInt(int xyz, int minValue, int maxValue) //заполнение трёхмерного массива числами рандом инт (не повторяющимися)
{   int[,,] mass = new int[xyz,xyz,xyz];
    int element=0;
    bool repeat;
    for (int x = 0; x < mass.GetLength(0); x++)
        for (int y = 0; y < mass.GetLength(1); y++)
            for (int z = 0; z < mass.GetLength(2); z++)
            {   do
                {repeat=false;
                element=new Random().Next(minValue, maxValue);
                for (int k = 0; k < mass.GetLength(0); k++)
                for (int l = 0; l < mass.GetLength(1); l++)
                for (int m = 0; m < mass.GetLength(2); m++)
                    if (mass [k,l,m]==element) repeat=true;
                }
                while (repeat==true);
            mass[x,y,z] = element; 
            element=0;
            }
    return mass;
}

void PrintArray3DInt(int [,,] mass) //печать трёхмерного массива с позицией элементов
{   for (int x = 0; x < mass.GetLength(0); x++)
    {
        for (int y = 0; y < mass.GetLength(1); y++)
        {
            for (int z = 0; z < mass.GetLength(2); z++)
            System.Console.Write($" {mass[x,y,z]}  [{x},{y},{z}]  ");
        System.Console.WriteLine();
        }
    System.Console.WriteLine();
    }
}