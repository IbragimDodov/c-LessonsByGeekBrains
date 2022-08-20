System.Random numberSintezator = new Random();

void VariantNaiveHomeWork()
{
  int i = 0;
  Console.Write("[");
  while (i < 8)
  {
    Console.Write(numberSintezator.Next(0, 4) + ",");
    i++;
  }
  Console.Write("]");
}

VariantNaiveHomeWork();
