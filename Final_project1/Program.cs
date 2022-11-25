Console.Write("Enter size of your Array: ");
int size = int.Parse(Console.ReadLine() ?? "");

string[] inputArray = new string[size];
string[] newArray = new string[inputArray.Length];

FillArray(inputArray);
PrintArray(inputArray);
ChangeArray(inputArray, newArray);
PrintArray(newArray);

void FillArray(string[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write($"Enter element #{i + 1}: ");
        array[i] = Console.ReadLine() ?? "";
        Console.WriteLine();
    }
}

void ChangeArray(string[] firstArray, string[] secondArray)
{
    int count = 0;
    for (int i = 0; i < firstArray.Length; i++)
    {
        if (firstArray[i].Length <= 3)
        {
            secondArray[count] = firstArray[i];
            count++;
        }
    }
}

void PrintArray(string[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write($"{array[i]} ");
    }
    Console.WriteLine();
}