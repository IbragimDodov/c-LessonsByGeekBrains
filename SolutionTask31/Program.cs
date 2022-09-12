// Переменные для накопления результата

int posetivSum = 0;
int negativSum = 0;


// Метод возвращает массив заполненный случайными числами от -9 до 9
int[] FillingArray()
{
  int[] outArray = new int[12];
  int i = 0;
  System.Random numberSintezator = new System.Random();
  while (i < 12)
  {
    outArray[i] = numberSintezator.Next(-9, 10);
    i++;
  }

  return outArray;
}

void CalculateTask(int[] outArray)
{
  int i = 0;
  while (i < 12)
  {
    if (outArray[i] > 0)
    {
      posetivSum += outArray[i];
    }
    else
    {
      negativSum += outArray[i];
    }
    i++;
  }
}

void PrintResult()
{
  Console.WriteLine(posetivSum);
  Console.WriteLine(negativSum);
}

void VariantNaive()
{
  int[] bufferArray = FillingArray();
  CalculateTask(bufferArray);
  PrintResult();
}

VariantNaive();