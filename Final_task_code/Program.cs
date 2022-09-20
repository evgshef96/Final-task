Console.Clear();

string[] GetArray(int size)
{
    string[] array = new string[size];
    for (int i = 0; i < size; i++)
    {
        array[i] = Console.ReadLine()!;
    }
    return array;
}

string[] NewArray(string[] array)
{
    string[] newArray = new string[array.Length];
    for (int i = 0; i < array.Length; i++)
    {
        if(array[i].Length <= 3)
        newArray[i] = array[i];
    }
    return newArray;
}
