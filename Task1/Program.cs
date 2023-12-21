//Задайте значения M и N. Напишите программу, которая выведет все 
//натуральные числа в промежутке от M до N. 
//Использовать рекурсию, не использовать циклы.

Console.WriteLine("Введите значение M:");
        int M = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("Введите значение N:");
        int N = Convert.ToInt32(Console.ReadLine());
        PrintNumbers(M, N);

void PrintNumbers(int current, int end)
    {
        if (current <= end)
        {
            Console.Write(current + ",");
            PrintNumbers(current + 1, end);
        }
    }
