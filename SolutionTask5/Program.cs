string? inputLineA = Console.ReadLine();
string? inputLineB = Console.ReadLine();

if (inputLineA != null && inputLineB != null)
{
  int inputNumberA = int.Parse(inputLineA);
  int inputNumberB = int.Parse(inputLineB);

  if (inputNumberA > inputNumberB)
  {
    Console.WriteLine(inputNumberA);
  }
  else
  {
    Console.WriteLine(inputNumberB);
  }
}
