Console.WriteLine("Enter size of your Array.");
int size = int.Parse(Console.ReadLine() ?? "");

string[] inputArray = new string[size];
FillArray(inputArray);
PrintArray(inputArray);

void FillArray(string[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write($"Enter element #{i + 1}: ");
        array[i] = Console.ReadLine();
        Console.WriteLine();
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