//МЕТОДЫ ПО ДЗ_5

int EnterDataForWork(string text, int min, int max)
{
    int number;
    while (true)
    {
        System.Console.Write($"{text}: ");
        number = int.Parse(Console.ReadLine());
        if (number >= min && number <= max) { break; }
    }
    return number;
}

int[] FillArray(int size, int minValue, int maxValue)
{
    int[] mass = new int[size];
    for (int i = 0; i < size; i++)
    { mass[i] = new Random().Next(minValue, maxValue + 1); }
    return mass;
}

int[] GetArray(int lengthFrom, int lengthTo, int elFrom, int elTo)
{
    int lengthMas = EnterDataForWork($"Enter length of massiv ({lengthFrom}-{lengthTo}) ", lengthFrom, lengthTo);
    int minElement = EnterDataForWork($"Enter min element of massive ({elFrom}-->{elTo}) ", elFrom, elTo);
    int maxElement = EnterDataForWork($"Enter max element of massive ({elFrom}-->{elTo}) ", elFrom, elTo);
    int[] mass = FillArray(lengthMas, minElement, maxElement);
    return mass;
}
double[] FillArrayDouble(int size, int minValue, int maxValue)
{
    double[] mass = new double[size];
    for (int i = 0; i < size; i++)
    {
        mass[i] = new Random().NextDouble() + new Random().Next(minValue + 1, maxValue - 1);
        mass[i] = Math.Round(mass[i], 2);
    }
    return mass;
}

double[] GetArrayDouble(int lengthFrom, int lengthTo, int elFrom, int elTo)
{
    int lengthMas = EnterDataForWork($"Enter length of massiv ({lengthFrom}-{lengthTo}) ", lengthFrom, lengthTo);
    int minElement = EnterDataForWork($"Enter min element of massive ({elFrom}-->{elTo}) ", elFrom, elTo);
    int maxElement = EnterDataForWork($"Enter max element of massive ({elFrom}-->{elTo}) ", elFrom, elTo);
    double[] mass = FillArrayDouble(lengthMas, minElement, maxElement);
    return mass;
}
void PrintMass(int[] mass)
{
    System.Console.Write("[ ");
    int length = mass.Length;
    for (int i = 0; i < length; i++)
    {
        System.Console.Write($" {mass[i]} ");
        if (i < length - 1) System.Console.Write(", ");
    }
    System.Console.WriteLine(" ]");
}
void PrintMassDouble(double[] mass)
{
    System.Console.Write("[ ");
    int length = mass.Length;
    for (int i = 0; i < length; i++)
    {
        System.Console.Write($" {mass[i]} ");
        if (i < length - 1) System.Console.Write(", ");
    }
    System.Console.WriteLine(" ]");
}
int FindEvenCount(int[] mass)
{
    int count = 0;
    for (int i = 0; i < mass.Length; i++)
    {
        if (mass[i] % 2 == 0) count++;
    }
    return count;
}

int SumForNotEvenPosition(int[] mass)
{
    int summ = 0;
    for (int i = 0; i < mass.Length; i += 2)
    {
        summ = summ + mass[i];
    }
    return summ;
}

double FindMinElement(double[] mass)
{
    double min = mass[0];
    for (int i = 1; i < mass.Length; i++)
    { if (mass[i] < min) min = mass[i]; }
    return min;
}

double FindMaxElement(double[] mass)
{
    double max = mass[0];
    for (int i = 1; i < mass.Length; i++)
    { if (mass[i] > max) max = mass[i]; }
    return max;
}

//Задача 34: Задайте массив заполненный случайными положительными трёхзначными числами. Напишите программу, 
//которая покажет количество чётных чисел в массиве.
//[345, 897, 568, 234] -> 2

System.Console.WriteLine();
System.Console.WriteLine("Задача 34: Задайте массив заполненный случайными положительными трёхзначными числами.");
System.Console.WriteLine("Напишите программу,которая покажет количество чётных чисел в массиве.");
System.Console.WriteLine();
int[] massivX = GetArray(1, 50, 100, 999);
PrintMass(massivX);
System.Console.WriteLine();
System.Console.WriteLine($"Количество чётных чисел в массиве = {FindEvenCount(massivX)}");


//Задача 36: Задайте одномерный массив, заполненный случайными числами. Найдите сумму элементов, стоящих 
//на нечётных позициях.
//[3, 7, 23, 12] -> 19     [-4, -6, 89, 6] -> 0

System.Console.WriteLine();
System.Console.WriteLine("Задача 36: Задайте одномерный массив, заполненный случайными числами. ");
System.Console.WriteLine("Найдите сумму элементов, стоящих на нечётных позициях.");
System.Console.WriteLine();
int[] massivXX = GetArray(1, 50, -999, 999);
PrintMass(massivXX);
System.Console.WriteLine();
System.Console.WriteLine($"Сумма элементов на нечётной позиции = {SumForNotEvenPosition(massivXX)}");

//Задача 38: Задайте массив вещественных чисел. Найдите разницу между максимальным и минимальным элементом массива.
//[3 7 22 2 78] -> 76

System.Console.WriteLine();
System.Console.WriteLine("Задача 38: Задайте массив вещественных чисел.");
System.Console.WriteLine("Найдите разницу между максимальным и минимальным элементом массива.");
System.Console.WriteLine();
double[] massivXXX = GetArrayDouble(1, 50, -50, 50);
PrintMassDouble(massivXXX);
System.Console.WriteLine();
Console.WriteLine($"Разница между минимальным элементом массива {FindMinElement(massivXXX)} и максимальным элементом массива {FindMaxElement(massivXXX)}");
Console.WriteLine($"составляет {Math.Round(FindMaxElement(massivXXX) - FindMinElement(massivXXX),2)}");
