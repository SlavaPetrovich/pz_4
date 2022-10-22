Console.WriteLine("Введите массив чисел: ");
string a = Console.ReadLine();
string[] b = a.Split(",");
int i;
int c = new int[b.Length];

for (i = 0; i < b.Length; i++)
{
    c[i] = int.Parse(b[i]);
}

for (i = 0; i < c.Length; i++)
{
    Console.Write($"c{i}, ");
}