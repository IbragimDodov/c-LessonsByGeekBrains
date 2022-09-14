//Метод возвращает массив заполненый случайными числами 
int[] FillingArray(int arrayLength)
{
  int[] outArray = new int[arrayLength];
  int i = 0;
  System.Random numberSintezator = new System.Random();
  while (i < arrayLength)
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

int[] ReverseNewArray(int[] array)
{
  int length = array.Length;
  int[] newArray = new int[length];

  for (int i = 0; i < length; i++)
  {
    newArray[length - 1 - i] = array[i];
  }
  return newArray;
}

int[] ReverseSwapArray(int[] array)
{
  int length = array.Length;
  int buf;

  for (int i = 0; i < length / 2; i++)
  {
    buf = array[i];
    array[i] = array[length - 1 - i];
    array[length - 1 - i] = buf;
  }
  return array;
}

int[] testArray = FillingArray(17);
int[] reversedArray = ReverseNewArray(testArray);

PrintIntArray(testArray);
PrintIntArray(reversedArray);
PrintIntArray(ReverseSwapArray(testArray));
PrintIntArray(testArray);
