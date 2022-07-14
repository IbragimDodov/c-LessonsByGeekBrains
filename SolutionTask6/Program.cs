string? inputLineA = Console.ReadLine();
string? inputLineB = Console.ReadLine();
string? inputLineC = Console.ReadLine();

if (inputLineA != null && inputLineB != null && inputLineC != null)
{
  int inputNumberA = int.Parse(inputLineA);
  int inputNumberB = int.Parse(inputLineB);
  int inputNumberC = int.Parse(inputLineC);

  if (inputNumberA > inputNumberB)
  {
    if (inputNumberA > inputNumberC)
    {
      Console.WriteLine(inputNumberA);
    }
    else
    {
      Console.WriteLine(inputNumberC);
    }
  }
  else
  {
    if (inputNumberB > inputNumberC)
    {
      Console.WriteLine(inputNumberB);
    }
    else
    {
      Console.WriteLine(inputNumberC);
    }
  }
}
