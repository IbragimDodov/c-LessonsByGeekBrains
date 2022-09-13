//Метод возвращает массив заполненый случайными числами 
float[] FillingArray()
{
  float[] outArray = new float[5];
  int i = 0;
  System.Random numberSintezator = new System.Random();
  while (i < 4)
  {
    outArray[i] = (float)numberSintezator.NextDouble() * 20; //вводим вещественные числа в рандомайзер
    i++;
  }
  return outArray;
}

//Метод печатает массив
void PrintIntArray(float[] inputArray)
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

//Метод решения задачи 38 
float ColculateTask(float[] inputArray)
{
  float result = 0;
  float max = 0;
  float min = int.MaxValue;  //Вводим переменную c максимальным значением
  int i = 0;
  while (i < 5)
  {
    if (inputArray[i] > max)
    {
      max = inputArray[i];
    }

    if (inputArray[i] < min)
    {
      min = inputArray[i];
    }

    i++; //Увеличиваем инкремент
  }
  result = max - min;
  return (result);
}


float[] buferArray = FillingArray();
PrintIntArray(buferArray);
float resultArray = ColculateTask(buferArray);
Console.WriteLine(resultArray);