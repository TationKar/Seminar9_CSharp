// **Задача 65:**Задайте значения M и N.
//  Напишите программу, которая выведет все
//   натуральные числа в промежутке от M до N.

// M = 1; N = 5. -> "1, 2, 3, 4, 5"
// M = 4; N = 8. -> "4, 5, 6, 7, 8"

Console.Clear();

Console.Write("Введите начальное значение: ");
int n = int.Parse(Console.ReadLine()!);
Console.Write("Введите конечное значение: ");
int i = int.Parse(Console.ReadLine()!);

Console.WriteLine(Rekursia(n, i));

string Rekursia(int n, int i)
{
    if(n == i)
    {
        Console.WriteLine(n);
        return n.ToString();
    }
        string s = Rekursia(n, i - 1) + ", " + i.ToString();

    return s;
    Console.WriteLine(s);
}