//Метод возвращает массив заполненый случайными числами от -9 до 9
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

//Метод инвертирует элементы массива простой
int[] ColculateTask(int[] inputArray)
{
  int[] outputArray = new int[12];
  int i = 0;
  while (i < 12)
  {
    outputArray[i] = inputArray[i] * (-1);
    i++;
  }
  return outputArray;
}

//Метод инвертирует элементы массива тильда
int[] InvertArrayTilda(int[] inputArray)
{
  //Буфферная переменная
  int i = 0;
  //Пробегаем все элементы массива
  while (i < inputArray.Length)
  {
    //Инвертируем элемент
    inputArray[i] = (~inputArray[i]) + 1;
    //Увеличиваем инкремент
    i++;
  }
  //Выводим массив
  return inputArray;
}


int[] bufferArray = FillingArray();
PrintIntArray(bufferArray);
int[] resultArray = ColculateTask(bufferArray);
PrintIntArray(resultArray);
resultArray = InvertArrayTilda(bufferArray);
PrintIntArray(resultArray);