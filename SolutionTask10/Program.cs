Console.Clear();

string? inputLine = Console.ReadLine();

if (inputLine != null)
{
  int inputNumber = int.Parse(inputLine);
  int resNum = (inputNumber % 100) / 10;
  Console.WriteLine(resNum);
}
