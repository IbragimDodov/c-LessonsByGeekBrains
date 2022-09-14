int m;
int count = 0;

int ReadNumbers() //метод для считывания количества чисел
{
  Console.Write($"Укажи планируемое количество чисел: ");
  m = int.Parse(Console.ReadLine() ?? "");
  return m;
}

int[] InputNumbers(int m) //метод для считывания чисел поочереди
{
  int[] massiveNumbers = new int[m];
  for (int i = 0; i < m; i++)
  {
    Console.Write($"Введи {i + 1} число: ");
    massiveNumbers[i] = int.Parse(Console.ReadLine() ?? "");
  }
  return massiveNumbers;
}


int Comparison(int[] massiveNumbers) //метод определения чисел, которые больше нуля
{
  count = 0;
  for (int i = 0; i < massiveNumbers.Length; i++)
  {
    if (massiveNumbers[i] > 0) count += 1;
  }
  return count;
}


void PrintAnswer() //метод вывода ответа на задачу
{
  Console.WriteLine($"Введено чисел больше 0: {(count)} ");
}

ReadNumbers();
int[] testArray = InputNumbers(m);
Comparison(testArray);
PrintAnswer();