// Задача 21. Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 3D пространстве.
// A (3,6,8); B (2,1,-7), -> 15.84
// A (7,-5, 0); B (1,-1,9) -> 11.53

System.Console.WriteLine("Задача 21. Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 3D пространстве.");
System.Console.WriteLine();
System.Console.Write("Введите координату точки А (Xa): ");
int numXa = int.Parse(Console.ReadLine());
System.Console.Write("Введите координату точки А (Ya): ");
int numYa = int.Parse(Console.ReadLine());
System.Console.Write("Введите координату точки A (Za): ");
int numZa = int.Parse(Console.ReadLine());
System.Console.Write("Введите координату точки B (Xb): ");
int numXb = int.Parse(Console.ReadLine());
System.Console.Write("Введите координату точки B (Yb): ");
int numYb = int.Parse(Console.ReadLine());
System.Console.Write("Введите координату точки B (Zb): ");
int numZb = int.Parse(Console.ReadLine());
double resultAB = Math.Sqrt(Math.Pow((numXa-numXb),2)+Math.Pow((numYa-numYb),2)+Math.Pow((numZa-numZb),2));
System.Console.WriteLine($"Расстояние между точками А и В составляет: {resultAB}");
System.Console.WriteLine($"Расстояние между точками А и В составляет (2 знака после запятой): {resultAB:#.##}");

// Задача 23. Напишите программу, которая принимает на вход число (N) и выдаёт таблицу кубов чисел от 1 до N.
// 3 -> 1, 8, 27               5 -> 1, 8, 27, 64, 125

System.Console.WriteLine();
System.Console.WriteLine("Задача 23. Напишите программу, которая принимает на вход число (N) и выдаёт таблицу кубов чисел от 1 до N.");
System.Console.WriteLine();
int numN;
while (true)
{   
    System.Console.Write("Введите число N (целое, больше нуля): ");
    numN = int.Parse(Console.ReadLine());
    if (numN>=1){break;}
}
for (int i=1; i<=numN; i++)
{ 
System.Console.Write($"{Math.Pow(i,3)}");
if (i<numN) {System.Console.Write(",  ");}
}
System.Console.WriteLine();

// Задача 19. Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.
// 14212 -> нет     12821 -> да    23432 -> да

System.Console.WriteLine();
System.Console.WriteLine("Задача 19. Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.");
System.Console.WriteLine();
int num19;
while (true)
{   
    System.Console.Write("Введите пятизначное целое положительное число: ");
    num19 = int.Parse(Console.ReadLine());
    if (num19>9999&&num19<100000){break;}
}
int num19_5=num19%10;
int num19_4=(num19%100-num19%10)/10;
int num19_3=(num19%1000-num19%100)/100;
int num19_2=(num19%10000-num19%1000)/1000;
int num19_1=(num19%100000-num19%10000)/10000;
int numRev=num19_5*10000+num19_4*1000+num19_3*100+num19_2*10+num19_1;
if (num19==numRev){System.Console.WriteLine($"Число {num19} палиндром!");}
else{System.Console.WriteLine($"Число {num19} НЕ палиндром!");}

// ВТОРОЙ ВАРИАНТ РЕШЕНИЯ

System.Console.WriteLine();
int num192;
while (true)
{   System.Console.Write("Введите пятизначное целое положительное число: ");
    num192 = Convert.ToInt32(Console.ReadLine());
    if (num192>9999&&num192<100000){break;}   }
int numRev2=0;
int numCut=num192;
for (int i=5; i>1; i--)
{numRev2=Convert.ToInt32(numRev2+(numCut%10)*Math.Pow(10,i-1));
numCut=numCut/10;}
numRev2=numRev2+numCut;
System.Console.WriteLine($"Перевёртыш  {numRev2}");
if (num192==numRev2){System.Console.WriteLine($"Число {num192} палиндром!");}
else{System.Console.WriteLine($"Число {num192} НЕ палиндром!");}


// ВАРИАНТ ТРИ - ЛЮБОЕ ЧИСЛО ДО 10 знаков

System.Console.WriteLine();
System.Console.WriteLine("Задача 19. Напишите программу, которая принимает на вход число не более десятизначного и проверяет, является ли оно палиндромом.");
System.Console.WriteLine();
int num193;
while (true)
{   
    System.Console.Write("Введите целое положительное число не более 10 знаков: ");
    num193 = Convert.ToInt32(Console.ReadLine());
    if (num193>0 && num193<10000000000){break;}
}
int numRev3=0;
int numCut3=num193;
int len;
for (len=1;numCut3>9;len++)
{numCut3=numCut3/10;}
numCut3=num193;
for (int i=len; i>1; i--)
{numRev3=Convert.ToInt32(numRev3+(numCut3%10)*Math.Pow(10,i-1));
numCut3=numCut3/10;}
numRev3=numRev3+numCut3;
System.Console.WriteLine($"Перевёртыш  {numRev3}");
if (num193==numRev3){System.Console.WriteLine($"Число {num193} палиндром!");}
else{System.Console.WriteLine($"Число {num193} НЕ палиндром!");}
