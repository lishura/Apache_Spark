string[] array = new string[6] { "sasha", "98", "hirrr", "1234", "a", "marusya" };
string[] secondarray = new string[array.Length];
void FillSecondArray(string[] array1, string[] array2)
{
    int count = 0;
    for (int i = 0; i < array1.Length; i++)
    {
        if (array1[i].Length <= 3)
        {
            array2[count] = array1[i];
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
FillSecondArray(array, secondarray);
PrintArray(secondarray);
