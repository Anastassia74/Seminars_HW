// Задача 10: Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает вторую цифру этого числа.
// 456 -> 5       782 -> 8      918 -> 1

Console.Clear();
System.Console.WriteLine("Задача 10: Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает вторую цифру этого числа.");
System.Console.WriteLine();
Console.Write("Введите трёхзначное положительное число----> ");
int number10=Convert.ToInt32(Console.ReadLine());
if (number10<100 || number10>999) {System.Console.WriteLine("Число должно быть трёхзначное положительное, повторите ввод.");}
else {
int number10_second = number10/10%10;
Console.WriteLine($"Вторая цифра введённого числа ----> {number10_second}");
}
System.Console.WriteLine();

// Задача 13: Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет.
// 645 -> 5      78 -> третьей цифры нет     32679 -> 6

System.Console.WriteLine("Задача 13: Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет.");
System.Console.WriteLine();
Console.Write("Введите целое число ----> ");
int number13=Convert.ToInt32(Console.ReadLine());
if (number13<0) {number13=number13*(-1);}
if (number13<100) {System.Console.WriteLine("Третьей цифры в числе нет.");}
else
{
int number13_short=number13;
while (number13_short>999) {number13_short=number13_short/10;}
int number13_second = number13_short%10;
Console.WriteLine($"Третья цифра введённого числа ----> {number13_second}");
}
System.Console.WriteLine();

// Задача 15: Напишите программу, которая принимает на вход цифру, обозначающую день недели, и проверяет, является ли этот день выходным.
// 6 -> да    7 -> да    1 -> нет

System.Console.WriteLine("Задача 15: Напишите программу, которая принимает на вход цифру, обозначающую день недели, и проверяет, является ли этот день выходным.");
System.Console.WriteLine();
Console.Write("Введите номер дня недели (1-7): ");
int day=Convert.ToInt32(Console.ReadLine());
switch(day)
{
case 1 : 
case 2 : 
case 3 : 
case 4 : 
case 5 : 
System.Console.WriteLine("Увы - это не выходной.");break;
case 6 : 
case 7 : 
System.Console.WriteLine("Уррра, это выходной!");break;
default : System.Console.WriteLine("Будьте внимательны - вы ввели неверное число. Оно должно быть от 1 до 7!");break;
}

