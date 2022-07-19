
void middleDigitCutter2()
{
  int number = new Random().Next(100, 1000);
  Console.Write("The random number is: ");
  Console.WriteLine(number);

  int num1 = number / 100;
  int num2 = number % 10;

  Console.Write("The modified num is: ");
  Console.WriteLine(num1 * 10 + num2);
}

middleDigitCutter2();