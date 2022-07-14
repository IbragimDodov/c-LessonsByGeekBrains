string? inputLine = Console.ReadLine();

if (inputLine != null)
{
  int inputNumber = int.Parse(inputLine);

  int outputNumber = inputNumber % 10;

  Console.WriteLine(outputNumber);
}