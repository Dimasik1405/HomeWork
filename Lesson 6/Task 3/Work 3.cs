void PrintArray(int[] array, int i)
{
    if(i < 0)
    {
        return;
    }
    if (i == array.Length)
    {
        return;
    }
    Console.Write(array[i]);
    PrintArray(array, i - 1);
}
int[] array = { 1, 4, 2, 7, 4 };
PrintArray(array, 4);
