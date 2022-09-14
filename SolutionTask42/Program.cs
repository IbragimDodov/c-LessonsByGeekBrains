Console.WriteLine(Convert.ToString(int.Parse(Console.ReadLine()), 2));

int number = int.Parse(Console.ReadLine());
string outLine = Convert.ToString(number, 2);
Console.WriteLine(outLine);

int ReadDecemalNumber()
{
  return int.Parse(Console.ReadLine() ?? "");
}

string BinaryConverter(int num)
{
  string bin = "";
  while (num > 0)
  {
    if (num % 2 == 1)
    {
      bin = "1" + bin;
    }
    else
    {
      bin = "0" + bin;
    }
    num /= 2;
  }
  return bin;
}

void PrintAnswer(string answer)
{
  Console.WriteLine("Введенное число в двоичном виде: " + answer);
}