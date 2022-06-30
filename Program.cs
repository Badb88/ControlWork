using System;
 
string[] array =
{
    "hello",
    "2222",
    "world",
    "))):)",
    "DataScience",
    "St-Petersburg"
};
 
var result = new string[array.Length];
var realSize = 0;
foreach (var value in array)
{
    if (value.Length <= 3)
    {
        result[realSize] = value;
        realSize++;
    }
    else
    {
        Console.WriteLine("Ничоге не вывидина :(");
    }
}
 
Console.WriteLine(string.Join(Environment.NewLine, result, 0, realSize));