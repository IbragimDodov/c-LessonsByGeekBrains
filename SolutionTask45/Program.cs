//Метод возвращает массив заполненый случайными числами 
int[] FillingArray()
{
  int[] outArray = new int[10];
  int i = 0;
  System.Random numberSintezator = new System.Random();
  while (i < 10)
  {
    outArray[i] = numberSintezator.Next(0, 10);
    i++;
  }
  return outArray;
}

//Метод печатает массив
void PrintIntArray(int[] inputArray)
{
  //Буфферная переменная
  int i = 0;
  //Пробегаем все элементы массива
  while (i < inputArray.Length - 1)
  {
    //Выводим элемент массива
    Console.Write(inputArray[i] + ", ");
    //Увеличиваем инкремент
    i++;
  }
  //Выводим элемент массива
  Console.WriteLine(inputArray[i]);
}

int[] CopyArrayStandartTool(int[] inputArray)
{
  int[] buferArray = new int[inputArray.Length];
  inputArray.CopyTo(buferArray, 0); //поэлементно копирует массив
  return buferArray;
}

int[] testArray = FillingArray();
PrintIntArray(testArray);
Console.WriteLine();
int[] outArray = CopyArrayStandartTool(testArray);
PrintIntArray(outArray);