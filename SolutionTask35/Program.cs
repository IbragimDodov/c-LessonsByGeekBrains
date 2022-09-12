//Метод возвращает массив заполненый случайными числами 
int[] FillingArray()
{
  int[] outArray = new int[123];
  int i = 0;
  System.Random numberSintezator = new System.Random();
  while (i < 123)
  {
    outArray[i] = numberSintezator.Next(-1000, 1000);
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

//Метод решения задачи 35 наивный
int ColculateTask(int[] inputArray, int downBorder, int upBorder)
{
  int resultCount = 0;
  int i = 0;
  while (i < inputArray.Length)
  {
    if (inputArray[i] >= downBorder && inputArray[i] <= upBorder)
    {
      Console.Write(inputArray[i] + " ");
      resultCount++;
    }
    i++;
  }
  return resultCount;
}


int[] buferArray = FillingArray();
PrintIntArray(buferArray);
Console.WriteLine(ColculateTask(buferArray, 10, 99));