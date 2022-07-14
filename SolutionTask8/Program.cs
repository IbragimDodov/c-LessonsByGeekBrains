string? inputLine = Console.ReadLine();

if (inputLine != null)
{
  int inputNumber = int.Parse(inputLine);

  int outNumber = 2;

  string? inputLineB = "";

  while (outNumber < inputNumber)
  {
    inputLineB = inputLineB + outNumber + ", ";
    outNumber = outNumber + 2;
  }

  Console.WriteLine(inputLineB);
}
