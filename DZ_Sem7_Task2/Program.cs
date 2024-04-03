// Напишите программу вычисления функции Аккермана с помощью рекурсии.
// Даны два неотрицательных числа m и n.

// int m = 11;
// int n = 3;

int m = 2;
int n = 3;

int Ack(int n, int m)
{
    if (n == 0) return m + 1;
    if (m == 0) return Ack(n - 1, 1);
    return Ack(n - 1, Ack(n, m - 1));
}

Console.WriteLine(Ack(n, m));