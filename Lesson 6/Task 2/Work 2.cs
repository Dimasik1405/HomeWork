int FindFunctionAkkerman(int m, int n)
{
    if (m == 0)
    {
        return n + 1;
    }
    else if (n == 0)
    {
        return FindFunctionAkkerman(m - 1, 1);
    }
    else
    {
        return FindFunctionAkkerman(m - 1, FindFunctionAkkerman(m, n - 1));
    }

}
int result = FindFunctionAkkerman(2, 3);
Console.WriteLine(result);