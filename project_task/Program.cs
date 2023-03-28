string[] InputArray(string text)
{
    System.Console.Write(text);
    string[] array = Array.ConvertAll(Console.ReadLine().Split(","), Convert.ToString);
    return array;
}

void PrintArray(string[] array)
{
    System.Console.WriteLine("[" + string.Join(",", array) + "]");
}

int CountElements(string[] array)
{
    int result = 0;
    for (int i = 0; i < array.Length; i++)
        if (array[i].Length <= 3)
            result++;
    return result;
}

string[] ArrayMaxThree(string[] array, int size)
{
    string[] newArray = new string[size];
    int j = 0;
    for (int i = 0; i < array.Length; i++)
        if (array[i].Length <= 3)
        {
            newArray[j] = array[i];
            j++;
        }
    return newArray;
}

string[] myArray = InputArray("Enter array elements using ',' after each element: ");
int sizeNewArray = CountElements(myArray);
string[] newArray = ArrayMaxThree(myArray, sizeNewArray);
System.Console.Write("Array of strings from original array whose length is less than or equal to three characters: ");
PrintArray(newArray);