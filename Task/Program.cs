string[] array = new string[6] { "1208", "new", "15", "array", "string", "456" };
string[] array1 = new string[array.Length];
void FillInNewArray(string[] array, string[] array1)
{
    int count = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i].Length <= 3)
        {
            array1[count] = array[i];
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
FillInNewArray(array, array1);
PrintArray(array1);