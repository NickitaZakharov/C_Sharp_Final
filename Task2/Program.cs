//Напишите программу вычисления функции Аккермана с помощью рекурсии. 
//Даны два неотрицательных числа m и n.

int Ackermann(int m, int n)
{
    if (m == 0)
    {
        return n + 1;
    }
    else if (m > 0 && n == 0)
    {
        return Ackermann(m - 1, 1);
    }
    else
    {
        return Ackermann(m - 1, Ackermann(m, n - 1));
    }
}
int m, n;
Console.Write("Введите число m: ");
m = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите число n: ");
n = Convert.ToInt32(Console.ReadLine());
int result = Ackermann(m, n);
Console.WriteLine($"Значение функции Аккермана для m = {m} и n = {n}: {result}");
Console.ReadKey();
