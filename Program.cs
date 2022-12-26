int FindSecondArrayLength(string[] array)
{
    int count = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i].Length <= 3)
            count++;
    }
    if (count == 0)
    {
        count = 1;
    }
    return count;
}

void PrintArray(string[] array)
{
    Console.Write("[");
    for (int i = 0; i < array.Length; i++)
    {
        if (i == array.Length - 1)
        {
            Console.Write($"{array[i]}");
        }
        else
        {
            Console.Write($"{array[i]},");
        }
    }
    Console.WriteLine("]");
}

string[] array = { "hello", "2", "world", ":-)" };
string[] arrayResult = new string[FindSecondArrayLength(array)];
int j = 0;

for (int i = 0; i < array.Length; i++)
{

    if (array[i].Length <= 3)
        arrayResult[j++] = array[i];

}

PrintArray(arrayResult);
