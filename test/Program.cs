void PrintArr(string[] arrayprint)
{
    int len = arrayprint.Length;
    for (int i = 0; i < len; i++) Console.Write($"{arrayprint[i]} ");
    Console.WriteLine();
}

int CountElements(string[] arraycount)
{
    int count = 0;
    foreach (string element in arraycount) if (element.Length <= 3) count++;
    return count;
}

string[] ModifyArray(string[] arraymodify)
{
    int len = CountElements(arraymodify);
    string[] newArray = new string[len];
    int index = 0;
    foreach (string element in arraymodify) if (element.Length <= 3)
    {
        newArray[index] = element;
        index++;
    }
    return newArray;
}

string[] a = new string[] { "hello", "2", "world", ":-)" };
string[] b = new string[] { "1234", "1567", "-2", "computer scince" };
string[] c = new string[] { "Russia", "Denmark", "Kazan" };

Console.Write("Заданный массив: ");
PrintArr(a);
Console.Write("Массив с элементами 3 и менее: ");
PrintArr(ModifyArray(a));
Console.WriteLine();
Console.Write("Заданный массив: ");
PrintArr(b);
Console.Write("Массив с элементами 3 и менее: ");
PrintArr(ModifyArray(b));
Console.WriteLine();
Console.Write("Заданный массив: ");
PrintArr(c);
Console.Write("Массив с элементами 3 и менее: ");
PrintArr(ModifyArray(c));