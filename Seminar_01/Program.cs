// Задача No5
Console.WriteLine("Напишите программу, которая на вход принимает одно число (N), а на выходе показывает все целые числа в промежутке от -N до N.");
// 4 -> "-4, -3, -2, -1, 0, 1, 2, 3, 4"
// 2 -> " -2, -1, 0, 1, 2"


Console.Write("Введите целое положительное число: ");
string strnumber=Console.ReadLine();
int number=Convert.ToInt32(strnumber);
if (number<0) {Console.WriteLine("Будьте внимательны - вы ввели неверное число. Оно должно быть положительное!");}
else
{
int count=-number;
while (count<number+1) 
{
    Console.Write(count);
    Console.Write("  ");
    count=count+1;
}
}
Console.WriteLine(" ");

// Задача No7. 
Console.WriteLine("Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает последнюю цифру этого числа.");
// 456 -> 6
// 782 -> 2
// 918 -> 8

Console.Write("Введите трёхзначное число: ");
int number7=Convert.ToInt32(Console.ReadLine());
if (number7<100||number7>999) 
{Console.WriteLine("Будьте внимательны - вы ввели неверное число. Оно должно быть трёхзначное положительное!");}
else
{
    System.Console.Write("Последняя цифра вашего числа --> ");
    System.Console.WriteLine(number7%10);
}

// Задача 2: 
Console.WriteLine("Напишите программу, которая на вход принимает два числа и выдает, какое число большее, а какое меньшее.");
// a = 5; b = 7 -> max = 7
// a = 2 b = 10 -> max = 10
// a = -9 b = -3 -> max = -3

Console.Write("Введите первое число: ");
int number2_1=Convert.ToInt32(Console.ReadLine());
Console.Write("Введите второе число: ");
int number2_2=Convert.ToInt32(Console.ReadLine());
if (number2_1<number2_2) 
{Console.Write("min = "); Console.WriteLine(number2_1);
Console.Write("max = ");Console.WriteLine(number2_2);}
if (number2_1>number2_2) 
{Console.Write("min = "); Console.WriteLine(number2_2);
Console.Write("max = ");Console.WriteLine(number2_1);}
if (number2_1==number2_2) 
{Console.Write("Введены одинаковые числа - числа равны!");}

// Задача 4: 
Console.WriteLine("Напишите программу, которая принимает на вход три числа и выдает максимальное из этих чисел.");
// 2, 3, 7 -> 7
// 44, 5, 78 -> 78
// 22, 3, 9 -> 22

Console.Write("Введите первое число: ");
int number4_1=Convert.ToInt32(Console.ReadLine());
Console.Write("Введите второе число: ");
int number4_2=Convert.ToInt32(Console.ReadLine());
Console.Write("Введите третье число: ");
int number4_3=Convert.ToInt32(Console.ReadLine());
int max4=number4_1;
if (number4_2>max4) {max4=number4_2;} 
if (number4_3>max4) {max4=number4_3;} 
Console.Write("max = ");Console.WriteLine(max4);

// Задача 6: 
Console.WriteLine("Напишите программу, которая на вход принимает число и выдает, является ли число четным (делится ли оно на два без остатка)");
// 4 -> да
// -3 -> нет
// 7 -> нет

Console.Write("Введите число: ");
int number6=Convert.ToInt32(Console.ReadLine());
int result6=number6 % 2;
if (result6 == 0) {System.Console.WriteLine("Число чётное");} 
else {System.Console.WriteLine("Число нечётное");} 

// Задача 8: 
Console.WriteLine("Напишите программу, которая на вход принимает число (N), а на выходе показывает все чётные числа от 1 до N.");
// 5 -> 2, 4
// 8 -> 2, 4, 6, 8

Console.Write("Введите целое положительное число больше 1: ");
int number8=Convert.ToInt32(Console.ReadLine());
if (number8<=1) {Console.WriteLine("Будьте внимательны - вы ввели неверное число. Число должно быть положительное, больше 1!");}
else
{
int count8=2;
while (count8<=number8) 
{
    Console.Write(count8);
    if ((count8+1)<number8) {Console.Write(",  ");}
    count8=count8+2;
}
}