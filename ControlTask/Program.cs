/*
**Задача**: Написать программу, которая из имеющегося массива строк формирует массив из строк,
длина которых меньше либо равна 3 символа. Первоначальный массив можно ввести с клавиатуры,
либо задать на старте выполнения алгоритма. При решении не рекомендуется пользоваться коллекциями,
лучше обойтись исключительно массивами.

**Примеры**:

["hello", "2", "world", ":-)"] -> ["2", ":-)"]

["1234", "1567", "-2", "computer science"] -> ["-2"]

["Russia", "Denmark", "Kazan"] -> []
*/

void FillArray(string[] collection)
{
    Console.WriteLine("Введите элементы массива: ");
    for (int i = 0; i < collection.Length; i++)
    {
        Console.Write($"[{i}] ");
        collection[i] = Console.ReadLine()!;
    }
}

void PrintArray(string[] col)
{
    Console.Write("[");
    for (int i = 0; i < col.Length; i++)
    {
        Console.Write(col[i]);
        if (i != col.Length - 1)
        {
            Console.Write(", ");
        }
    }
    Console.Write($"]");
}

string[] FindSymbol(string[] threeSymbol)
{
    int count = 0;
    string symbol = String.Empty;
    for (int i = 0; i < threeSymbol.Length; i++)
    {
        symbol = threeSymbol[i];
        if (symbol.Length <= 3)
        {
            count++;
        }
    }
    string[] array2 = new string[count];
    count = 0;
    for (int i = 0; i < threeSymbol.Length; i++)
    {
        symbol = threeSymbol[i];
        if (symbol.Length <= 3)
        {
            array2[count] = symbol;
            count++;
        }
    }
    return array2;
}

Console.WriteLine();
Console.Write("Задайте размер массива: ");

int sizeArray = Convert.ToInt32(Console.ReadLine());
string[] array = new string[sizeArray];
Console.WriteLine();
FillArray(array);
Console.WriteLine();
PrintArray(array);
Console.Write(" -> ");
string[] array2 = FindSymbol(array);
PrintArray(array2);
Console.WriteLine();