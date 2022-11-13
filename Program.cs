// Задача 66: Задайте значения M и N. Напишите программу, которая найдёт сумму
// натуральных элементов в промежутке от M до N.
// M = 1; N = 15 -> 120
// M = 4; N = 8. -> 30gi
int Counter(int a, int b)
{
    if (a == b)
    {
        return a;
    }
    if (a > b)
    {
        return b + Counter(a, b + 1);
    }
    return a + Counter(a + 1, b);
}
Console.Clear();
Console.Write("Введите первое число:");
int n = int.Parse(Console.ReadLine()!);
Console.Write("Введите второе число:");
int m = int.Parse(Console.ReadLine()!);
Console.WriteLine(Counter(n, m));