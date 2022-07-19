Console.Clear();

string? inputLine = Console.ReadLine();

Char[] someArray = inputLine.ToCharArray();
if (someArray.Length >= 3)
{
  Console.WriteLine(someArray[2]);
}
else
{
  Console.WriteLine("please write your number correct, there must have 3 number");
}