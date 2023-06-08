public static class Methods
{
    public static string InputString(string text)
  {
    Console.Write(text);
    string element = Console.ReadLine();
    return element;
  }

   public static int InputNumber(string text)
  {
    Console.Write(text);
    int number = Convert.ToInt32(Console.ReadLine());
    return number;
  }

  public static string[] CreateStringArray()
  {
    int size = InputNumber("Задайте длину массива: ");
    string[] array = new string[size];
    for (int i = 0; i < size; i++)
    {
      array[i] = InputString($"Введите {i + 1} элемент массива: ");
    }
    return array;
  }
}