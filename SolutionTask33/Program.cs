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

//Метод решения задачи 33 наивный
bool ColculateTask(int[] inputArray, int searchNumber)
{
  bool resultSearch = false;
  int i = 0;
  while (i < 12)
  {
    if (inputArray[i] == searchNumber)
    {
      resultSearch = true;
      break;
    }
    i++;
  }
  return resultSearch;
}



int[] buferArray = FillingArray();
PrintIntArray(buferArray);
Console.WriteLine("Введите число для поиска: ");
int searchNumber = int.Parse(Console.ReadLine());

Console.WriteLine(ColculateTask(buferArray, searchNumber));