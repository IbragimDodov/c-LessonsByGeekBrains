Console.Write("Введите число ");
string? a = Console.ReadLine();
Console.Write("Введите число ");
string? b = Console.ReadLine();

void Read()
{
  if (a != null && b != null)
  {
    int parseA = int.Parse(a);
    int parseB = int.Parse(b);

    int c = (int)Math.Pow(parseA, parseB);

    Console.WriteLine(c);
  }

}

Read();