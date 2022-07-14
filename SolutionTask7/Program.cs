string? inputLine = Console.ReadLine();

if (inputLine != null)
{
  int inputNumber = int.Parse(inputLine);

  int outNumber = inputNumber % 2;

  if (outNumber == 0)
  {
    Console.WriteLine("Четное");
  }
  else
  {
    Console.WriteLine("Нечетное");
  }
}