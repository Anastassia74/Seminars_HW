//Задача 25: Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B.
//3, 5 -> 243 (3⁵)     2, 4 -> 16

System.Console.WriteLine("Задача 25: Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B.");
System.Console.WriteLine();
System.Console.Write("Введите число А: ");
int numA = int.Parse(Console.ReadLine());
System.Console.Write("Введите число В: ");
int numB = int.Parse(Console.ReadLine());
if (numA<0 || numB<0) {System.Console.WriteLine("Неверный ввод, повторите, числа должны быть больше 0.");}
else { System.Console.WriteLine($"{numA} в степени {numB} = {(Exp (numA,numB))}");}

int Exp (int num1, int num2)
{int result=num1;
for (int i = 2; i <=num2; i++) result*=num1;
return result;}

//Задача 27: Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.
//452 -> 11    82 -> 10    9012 -> 12

System.Console.WriteLine();
System.Console.WriteLine("Задача 27: Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.");
System.Console.WriteLine();
System.Console.Write("Введите число целое положительное число: ");
int numC=int.Parse(Console.ReadLine());
if (numC<0)
System.Console.WriteLine("Неверно введено число, должно быть целое пложительное");
else {System.Console.WriteLine($"Сумма цифр числа {numC} равна {SumDigNum(numC)}");}

int SumDigNum (int number)
{int result=0;
    for (; number>0;)
{
 result=result+number%10; 
 number=number/10;   
}
return result;
}

//Задача 29: Напишите программу, которая задаёт массив из 8 элементов и выводит их на экран.
//1, 2, 5, 7, 19 -> [1, 2, 5, 7, 19]      6, 1, 33 -> [6, 1, 33]

System.Console.WriteLine();
System.Console.WriteLine("Задача 29: Напишите программу, которая задаёт массив из 8 элементов и выводит их на экран.");
System.Console.WriteLine();

int [] array = new int [8];
FillMass (array);
PrintMass (array);
System.Console.WriteLine();

void FillMass(int[]mas)
{
int length = mas.Length;
for (int i = 0; i < length; i++)
mas[i]=new Random().Next(1,100000);
}

void PrintMass (int[]mas)
{  System.Console.Write("[ ");
   int length = mas.Length;
   for (int i = 0; i < length; i++)
   {System.Console.Write($" {mas[i]} ");
    if (i<length-1) System.Console.Write(", ");
   }
   System.Console.WriteLine(" ]");
}




