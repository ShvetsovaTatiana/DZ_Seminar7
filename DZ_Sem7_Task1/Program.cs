// Задайте значения M и N. Напишите программу, которая выведет все натуральные числа в промежутке от M до N.
// Использовать рекурсию, не использовать циклы.

void PrintNaturalNumbers1(int num, int num2)
{
    if (num <= 0 && num2 <= 0) return;
    if (num2 <= num - 1)
    {
        return;
    }
    PrintNaturalNumbers1(num, num2 - 1);
    Console.Write($"{num2} ");
}

void PrintNaturalNumbers2(int num, int num2)
{
    if (num <= 0 && num2 <= 0) return;
    if (num <= num2 - 1)
    {
        return;
    }
    Console.Write($"{num} ");
    PrintNaturalNumbers2(num - 1, num2);
}

Console.WriteLine("Введите натуральное число M ");
int M = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите натуральное число N ");
int N = Convert.ToInt32(Console.ReadLine());

if (M < N)
{
    PrintNaturalNumbers1(M, N);
}
if (M > N)
{
    PrintNaturalNumbers2(M, N);
}