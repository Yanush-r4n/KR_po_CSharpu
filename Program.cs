Console.Clear();

string[] ArrayOfWordsLessThen4Letters(string[] array)
{
    int count = 0;
    int result = 0;

    for (int i = 0; i < array.Length; i++)
    {
        for (int j = 0; j < array[i].Length; j++)
        {
            count = 1;
            if (j > 2) {count = 0; break;}
        }

        result += count;
    }

    string[] desiredArray = new string[result];

    int k = 0;

    for (int i = 0; i < array.Length; i++)
    {
        for (int j = 0; j < array[i].Length; j++)
        {
            count = 1;
            if (j > 2) {count = 0; break;}
        }

        if (count == 1) {desiredArray[k++] = array[i];}
    }

    return desiredArray;
}

string[] array = new string[] {"1447", "легенда", "кот", "7", "киш", "ахахахаха", "миш", "hero", "ice"};

Console.WriteLine($"[{String.Join(", ", array)}]");
Console.WriteLine($"[{String.Join(", ", ArrayOfWordsLessThen4Letters(array))}]");