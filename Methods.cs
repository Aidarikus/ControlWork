public static class Methods
{
  public static string InputString(string text)
  {
    Console.Write(text);
    string element = Console.ReadLine();
    return element;
  }  //Ввод элементов массива

  public static int InputNumber(string text)
  {
    int number;
    bool numberTrue;
    do
    {
      Console.Write(text);
      string numberString = Console.ReadLine();
      numberTrue = int.TryParse(numberString, out number);
      if (!numberTrue)
      {
        Console.WriteLine("Введено некорректное значение");
      }
    } while (!numberTrue);
    if (number < 0)
    {
      number = number * (-1);
      Console.WriteLine("Длина массива не может задаваться отрицательным числом. Числу присвоено положительное значение.");
    }
    return number;
  }  //Ввод длины массива

  public static string[] CreateStringArray()
  {
    int size = InputNumber("Задайте длину массива: ");
    string[] array = new string[size];
    for (int i = 0; i < size; i++)
    {
      array[i] = InputString($"Введите {i + 1} элемент массива: ");
    }
    Console.WriteLine();
    return array;
  }  //Создание и наполнение исходного массива

  public static void PrintArray(string[] array, string text)
  {
    Console.WriteLine(text);
    Console.Write("[");
    int i = 0;
    for (i = 0; i < array.Length - 1; i++)
    {
      Console.Write($"\"{array[i]}\", ");
    }
    Console.Write($"\"{array[i]}\"]");
    Console.WriteLine();
  }  //Печать массива

  public static string[] GenerateNewArray(string[] array)
  {
    int size = 0;
    for (int i = 0; i < array.Length; i++)
    {
      if (array[i].Length <= 3)
      {
        size++;
      }
    }
    string[] arrayShort = new string[size];
    int j = 0;
    for (int i = 0; i < array.Length; i++)
    {
      if (array[i].Length <= 3)
      {
        arrayShort[j] = array[i];
        j++;
      }
    }
    Console.WriteLine();
    return arrayShort;
  }  //Создание и наполнение результативного массива
}