/* **Задача 63:**Задайте значение N.Напишите программу,
 которая выведет все натуральные числа в промежутке от 1 до N.

N = 5-> "1, 2, 3, 4, 5"

N = 6-> "1, 2, 3, 4, 5, 6"
*/
/* **Задача 63:**Задайте значение N.Напишите программу,
 которая выведет все натуральные числа в промежутке от 1 до N.

N = 5-> "1, 2, 3, 4, 5"

N = 6-> "1, 2, 3, 4, 5, 6"
*/

Console.Clear();

Console.Write("Введите число: ");
int n = int.Parse(Console.ReadLine());
int i = 1;
Rekursia(n, i);

void Rekursia(int n, int i)
{
    Console.Write(i + ", ");
    if(i < n)
    {
        Rekursia(n, ++i);
    }

/*     if (i+1 == n)
    Console.Write(n); */
    Console.WriteLine();
}

/* WriteLine(PrintNumbers(n));

string PrintNumbers(int n)
{
    if (n == 1)
    {
        WriteLine(1);
        return "1";
    }
    string s = PrintNumbers(n - 1) + ", " + n.ToString();// $"{n}"
    WriteLine(s);
    return s;
} */