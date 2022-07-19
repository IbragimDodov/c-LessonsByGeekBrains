
string? inputOne = Console.ReadLine();
string? inputTwo = Console.ReadLine();

if (inputOne != null && inputTwo != null)
{
  int inputNumberOne = int.Parse(inputOne);
  int inputNumberTwo = int.Parse(inputTwo);

  int div = inputNumberTwo % inputNumberOne;

  if (div == 0)
  {
    Console.WriteLine("yes");
  }
  else
  {
    Console.WriteLine(div);
  }
}
