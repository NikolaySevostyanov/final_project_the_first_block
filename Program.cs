string[] Array = {"21re", "38a", "=)", "56"};
string[] resultArray = GetArrayOfShortElements(Array, 3);
PrintStringArray(resultArray);

string[] GetArrayOfShortElements(string[] arr, int maxLenght)
{
    int length = arr.Length;
    string[] tempResult = new string[length];
    string elem = string.Empty;
    int count = 0;
    for (int i = 0; i < length; i++)
    {
        elem = arr[i];
        if (elem.Length <= maxLenght)
        {
            tempResult[count] = elem;
            count++;
        }
    }
    string[] result = new string[count];
    for (int i = 0; i < count; i++)
    {
        result[i] = tempResult[i];
    }
    return result;
}

void PrintStringArray(string[] arr)
{
    int length = arr.Length;
    Console.Write("[");
    for (int i = 0; i < length; i++)
    {
        Console.Write(arr[i] + (i == length - 1 ? "" : ", "));
    }
    Console.WriteLine("]");
}
