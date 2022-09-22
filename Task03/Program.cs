// Напишите программу вычисления функции Аккермана с помощью рекурсии. Даны два неотрицательных числа m и n.

int Ackermann (int m, int n)
{
    if (m==0) return n+1;
    if (n==0) return Ackermann(m-1,1);
    else return Ackermann(m-1, Ackermann(m,n-1));
}
Console.WriteLine(Ackermann(4,4));