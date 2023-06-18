// **Задача 69:**Напишите программу,
//  которая на вход принимает два числа A и B,
//   и возводит число А в целую степень B с помощью рекурсии.

// A = 3; B = 5-> 243(3⁵)

// A = 2; B = 3-> 8

// **Задача 69:**Напишите программу,
//  которая на вход принимает два числа A и B,
//   и возводит число А в целую степень B с помощью рекурсии.

// A = 3; B = 5-> 243(3⁵)

// A = 2; B = 3-> 8

Console.Clear();
Console.Write("Введите число которое хотите возвести в степень ");
int a = int.Parse(Console.ReadLine()!);
Console.Write("Введите число степени ");
int b = int.Parse(Console.ReadLine()!);

Console.WriteLine(Rekursia(a, b));

int Rekursia(int a, int b)
{
    if(b == 1)
    {
        return a;
    }
        int result = Rekursia(a, b-1) * a;
    return result;
}