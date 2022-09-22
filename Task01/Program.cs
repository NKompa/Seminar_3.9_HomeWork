// Задайте значения M и N. Напишите программу, которая выведет все натуральные числа в промежутке от M до N.

string NuturalNumbers (int start, int end)
{
    if (start<=end) return $"{start} " + NuturalNumbers(start+1,end);
    else return string.Empty;
}
Console.WriteLine(NuturalNumbers(1,8));