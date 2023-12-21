//Задайте произвольный массив. 
//Выведете его элементы, начиная с конца. 
//Использовать рекурсию, не использовать циклы.

int[] array = { 1, 2, 3, 4, 5 };
PrintArrayReversed(array, array.Length - 1);

void PrintArrayReversed(int[] array, int index)
{
    if (index < 0 || index >= array.Length)
    {
        return;
    }
    Console.WriteLine(array[index]);
    PrintArrayReversed(array, index - 1);
}