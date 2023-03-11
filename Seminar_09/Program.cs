// Задача 64: Задайте значение N. Напишите программу, которая выведет все натуральные числа в промежутке от N до 1. Выполнить с помощью рекурсии.
// N = 5 -> "5, 4, 3, 2, 1"
// N = 8 -> "8, 7, 6, 5, 4, 3, 2, 1"
// Задача 66: Задайте значения M и N. Напишите программу, которая найдёт сумму натуральных элементов в промежутке от M до N.
// M = 1; N = 15 -> 120
// M = 4; N = 8. -> 30
// Задача 68: Напишите программу вычисления функции Аккермана с помощью рекурсии. Даны два неотрицательных числа m и n.
// m = 2, n = 3 -> A(m,n) = 9
// m = 3, n = 2 -> A(m,n) = 29


TaskChoose();

void TaskChoose()
{
    Console.Clear();
    System.Console.WriteLine("Задача 64: Задайте значение N. Напишите программу, которая выведет все натуральные числа в промежутке от N до 1. Выполнить с помощью рекурсии.");
    System.Console.WriteLine("Задача 66: Задайте значения M и N. Напишите программу, которая найдёт сумму натуральных элементов в промежутке от M до N.");
    System.Console.WriteLine("Задача 68: Напишите программу вычисления функции Аккермана с помощью рекурсии. Даны два неотрицательных числа m и n.");
    {
        while (true)
        {
            System.Console.WriteLine();
            System.Console.Write("Введите номер задачи (64/66/68), для выхода введите 0: ");
            int task = int.Parse(Console.ReadLine());
            System.Console.WriteLine();
            switch (task)
            {
                case 64:
                    Console.Clear();
                    System.Console.WriteLine("Ваш выбор:");
                    System.Console.WriteLine("Задача 64: Задайте значение N. Напишите программу, которая выведет все натуральные числа в промежутке от N до 1. Выполнить с помощью рекурсии.");
                    System.Console.WriteLine();
                    int n64 = EnterIntDataMorethenzero("Введите положительное число N>0: ");
                    System.Console.Write($"Натуральные числа в промежутке от {n64} до 1: ");
                    NaturNumber(n64);
                    Console.ReadLine();
                    break;
                case 66:
                    Console.Clear();
                    System.Console.WriteLine("Ваш выбор:");
                    System.Console.WriteLine("Задача 66: Задайте значения M и N. Напишите программу, которая найдёт сумму натуральных элементов в промежутке от M до N.");
                    System.Console.WriteLine();
                    int n66 = EnterIntDataMorethenzero("Введите положительное число (N) больше, чем 0: ");
                    int m66 = EnterIntDataMorethenzeroDif($"Введите положительное число (M) больше, чем {n66} : ", n66);
                    int sum = 0;
                    System.Console.WriteLine($"Сумма натуральных элементов в промежутке от {n66} до {m66}: {NaturNumberSum(n66, m66, sum)}");
                    Console.ReadLine();
                    break;
                case 68:
                    Console.Clear();
                    System.Console.WriteLine("Ваш выбор:");
                    System.Console.WriteLine("Задача 68: Напишите программу вычисления функции Аккермана с помощью рекурсии. Даны два неотрицательных числа m и n.");
                    System.Console.WriteLine();
                    int m68 = EnterIntDataMorethenzero68("Введите положительное число (M>=0): ");
                    int n68 = EnterIntDataMorethenzero68("Введите положительное число (N>=0): ");
                    int result68=Ackerman(m68,n68);
                    System.Console.WriteLine($"Функция Аккермана А ({m68},{n68}) = {result68}");
                    Console.ReadLine();
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

void NaturNumber(int n)
{
    System.Console.Write($"{n}  ");
    n--;
    if (n != 0) NaturNumber(n);
    else System.Console.WriteLine();
}

int EnterIntDataMorethenzeroDif(string text, int n) //ввод пользователем требуемого в сопровождаемом тексте интового положительного значения, ,больше указанного
{
    while (true)
    {
        System.Console.Write(text);
        int num = 0;
        string str = Console.ReadLine();
        if (int.TryParse(str, out num)) num = int.Parse(str);
        if (num > 0 && num > n) { return num; break; }
        else System.Console.WriteLine("Ошибка, повторите ввод");
    }
}

int NaturNumberSum(int n, int m, int sum)
{
    if (n == m) return sum = sum + n;
    else
    {
        sum = sum + m;
        return NaturNumberSum(n, m - 1, sum);
    }
}

int EnterIntDataMorethenzero68(string text) //ввод пользователем требуемого в сопровождаемом тексте интового положительного значения в том числе и 0
{
    while (true)
    {
        System.Console.Write(text);
        int num = 0;
        string str = Console.ReadLine();
        if (int.TryParse(str, out num)) num = int.Parse(str);
        if (num >= 0) { return num; break; }
        else System.Console.WriteLine("Ошибка, повторите ввод");
    }
}

 int Ackerman(int m,int n)
 {
    if (m==0)
    return n+1;
    else if (m!=0 && n==0)
    return Ackerman(m-1,1);
    else 
    return Ackerman (m-1, Ackerman (m,n-1));
 }