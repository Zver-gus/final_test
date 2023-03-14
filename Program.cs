string[] array0 = new string[5] {"123", "23", "hello", "world", "res"};
string[] array1 = new string[array0.Length];
void ElCountArray(string[] array0, string[] array1)
{
    int count = 0;
    for (int i = 0; i < array0.Length; i++)
    {
    if(array0[i].Length <= 3)
        {
        array1[count] = array0[i];
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
ElCountArray(array0, array1);
PrintArray(array1);