void Method(int a, int b, int i)
{
    for (i = 0; i < 1; i++)
    {
    int c = Convert.ToInt32(Math.Pow(a, b));
    Console.WriteLine($"{a},{b} -> {c}");
    }
}
Method(23, 5, 0);