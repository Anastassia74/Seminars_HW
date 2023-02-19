// Задача 41: Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл пользователь.
// 0, 7, 8, -2, -2 -> 2      1, -7, 567, 89, 223-> 3

// Задача 43: Напишите программу, которая найдёт точку пересечения двух прямых, заданных уравнениями 
// y = k1 * x + b1, y = k2 * x + b2; значения b1, k1, b2 и k2 задаются пользователем.
// b1 = 2, k1 = 5, b2 = 4, k2 = 9 -> (-0,5; -0,5)

// Задача 44: С помощью рекурсии выведите первые N чисел Фибоначчи. Первые два числа Фибоначчи: 0 и 1.
// Если N = 5 --> 0 1 1 2 3     Если N = 3 --> 0 1 1   Если N = 7 --> 0 1 1 2 3 5 8

TaskChoose();

void TaskChoose()
{Console.Clear();
System.Console.WriteLine("Задача 41: Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл пользователь.");
System.Console.WriteLine("Задача 43: Напишите программу, которая найдёт точку пересечения двух прямых, заданных уравнениями ");
System.Console.WriteLine("y = k1 * x + b1, y = k2 * x + b2; значения b1, k1, b2 и k2 задаются пользователем.");
System.Console.WriteLine("Задача 44: С помощью рекурсии выведите первые N чисел Фибоначчи. Первые два числа Фибоначчи: 0 и 1.");
{while (true)
{System.Console.WriteLine();
System.Console.Write("Введите номер задачи (41/43/44), для выхода введите 0: ");
int task = int.Parse(Console.ReadLine());
System.Console.WriteLine();
switch (task)
{case 41:
Console.Clear();
System.Console.WriteLine("Ваш выбор:");
System.Console.WriteLine("Задача 41: Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл пользователь.");
System.Console.WriteLine("Введите целые числа через пробел:");
int[] array41 = Array.ConvertAll(Console.ReadLine().Split(), int.Parse);
int countMoreThenZero=0;
for (int i = 0; i < array41.Length; i++) countMoreThenZero += array41[i]>0?1:0; 
System.Console.WriteLine($"Вы ввели {countMoreThenZero} чисел, больше нуля.");
break;
case 43:
Console.Clear();
System.Console.WriteLine("Ваш выбор:");
System.Console.WriteLine("Задача 43: Напишите программу, которая найдёт точку пересечения двух прямых, заданных уравнениями ");
System.Console.WriteLine("y = k1 * x + b1, y = k2 * x + b2; значения b1, k1, b2 и k2 задаются пользователем.");
System.Console.WriteLine();
System.Console.Write("Введите целое число k1: ");
double numk1 = double.Parse(Console.ReadLine());
System.Console.Write("Введите целое число b1: ");
double numb1 = double.Parse(Console.ReadLine());
System.Console.Write("Введите целое число k2: ");
double numk2 = double.Parse(Console.ReadLine());
System.Console.Write("Введите целое число b2: ");
double numb2 = double.Parse(Console.ReadLine());
double resX = (numb2-numb1)/(numk1-numk2);
double resY = numk1*resX+numb1;
System.Console.WriteLine($"Точка пересечения двух прямых, заданных в/у уравнениями имеет координаты абсциссы (X)= {resX}, ординаты (Y)= {resY}.");
break;
case 44:
Console.Clear();
System.Console.WriteLine("Ваш выбор:");
System.Console.WriteLine("Задача 44: С помощью рекурсии выведите первые N чисел Фибоначчи. Первые два числа Фибоначчи: 0 и 1.");
System.Console.WriteLine();
System.Console.Write("Введите целое положительное число: ");
int nF = int.Parse(Console.ReadLine());
for (int i = 0; i <=nF; i++)
{
    Console.WriteLine($" f({i}) = {Fibonacci(i)}");
}
double Fibonacci (int n)
{
if (n==1||n==2) return 1;
else return (Fibonacci(n-1)+Fibonacci(n-2));
}
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
