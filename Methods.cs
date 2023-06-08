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
}