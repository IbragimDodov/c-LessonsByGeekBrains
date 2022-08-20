Console.Clear();
Console.Write("Введите число ");

string inputLineNumber = Console.ReadLine() ?? "";
int inputNumber = int.Parse(inputLineNumber);

int VariantChar()
{
  // int numberLength = 0;
  // char[] array = inputLineNumber.ToCharArray();
  // numberLength = array.Length;

  return inputLineNumber.ToCharArray().Length;
}

int VariantSimple()
{
  int numberLength = 0;
  int digits = 1;
  while (digits < inputNumber)
  {
    digits = digits * 10;
    numberLength++;
  }

  return numberLength;
}

int VariantLog10()
{
  return (int)Math.Log10(inputNumber) + 1;
}

int result = 0;
result = VariantChar();
Console.WriteLine(result);

result = VariantSimple();
Console.WriteLine(result);

result = VariantLog10();
Console.WriteLine(result);