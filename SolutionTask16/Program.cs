Console.Clear();


Console.WriteLine("Add your first number: ");
string? inputFirst = Console.ReadLine();
Console.WriteLine("Add your second number: ");
string? inputSecond = Console.ReadLine();


if ((inputFirst != null) && (inputSecond != null))
{
  int inputNumberFirst = int.Parse(inputFirst);
  int inputNumberSecond = int.Parse(inputSecond);
  int a = inputNumberFirst * inputNumberFirst;
  int b = inputNumberSecond * inputNumberSecond;
  if ((a == inputNumberSecond) || (b == inputNumberFirst))
  {
    Console.WriteLine("yes");
  }
  else
  {
    Console.WriteLine("sorry, try again");
  }
}