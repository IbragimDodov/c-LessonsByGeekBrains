//Метод возвращает массив заполненый случайными числами 
int[] FillingArray()
{
  int[] outArray = new int[4];
  int i = 0;
  System.Random numberSintezator = new System.Random();
  while (i < 4)
  {
    outArray[i] = numberSintezator.Next(0, 100);
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

//Метод решения задачи 36 
int ColculateTask(int[] inputArray)
{
  int resultSearch = 0; //Вводим переменную
  int i = 1;
  while (i < 4)
  {
    resultSearch = resultSearch + inputArray[i];

    i += 2; //Увеличиваем инкремент
  }
  return resultSearch;
}


int[] buferArray = FillingArray();
PrintIntArray(buferArray);
ColculateTask(buferArray);

Console.WriteLine(ColculateTask(buferArray));