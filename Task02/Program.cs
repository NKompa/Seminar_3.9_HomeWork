// Задайте значения M и N. Напишите программу, которая найдёт сумму натуральных элементов в промежутке от M до N.

int GetSum (int start, int end)
{
    if (start > end) return 0;
    else return start + GetSum(start+1,end); 
}
Console.WriteLine(GetSum(2,8));