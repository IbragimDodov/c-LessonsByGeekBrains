Console.Write("Введите число ");

int inputNumber = int.Parse(Console.ReadLine());

void VariantSimple()
{
  int sumOfNumbers = 0;
  for (int i = 1; i <= inputNumber; i++)
  {
    sumOfNumbers += i;
  }

  Console.WriteLine("Сумма чисел от 1 до " + inputNumber + " = " + sumOfNumbers);
}

void VariantGauss()
{
  int sumOfNumbers = 0;
  sumOfNumbers = ((1 + inputNumber) * inputNumber) / 2;

  Console.WriteLine("Сумма чисел от 1 до " + inputNumber + " = " + sumOfNumbers);
}

VariantSimple();
VariantGauss();