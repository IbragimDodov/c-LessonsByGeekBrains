Console.Write("Введите число ");
string? a = Console.ReadLine();
int b = 0;

void Calculate()
{
  int AtoNum = int.Parse(a);

  while (AtoNum > 0)
  {
    b = b + AtoNum % 10;
    AtoNum = AtoNum / 10;
  }

  Console.WriteLine(b);
}

Calculate();
