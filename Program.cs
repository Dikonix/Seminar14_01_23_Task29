int[] GetArray(int size)
{
    int[] result = new int[size];
    for (int i = 0; i < size; i++)
    {
        result[i] = new Random().Next(-10, 100);
    }

    return result;
}

const int sizeArray = 8;
int[] array = GetArray(sizeArray);
Console.WriteLine($"[{String.Join(", ", array)}]");