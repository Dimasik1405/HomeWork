int GetNaturalNumbers(int m, int n)
{
    if (m > n)
    {
        return n;
    }
    Console.WriteLine(m);
    return m + GetNaturalNumbers(m + 1, n);
}
GetNaturalNumbers(1, 5);