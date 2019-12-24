using System;

class Program
{
  static void Main()
  {
    try
    {
      int value = 1 / int.Parse("0");
    }
    catch (Exception ex)
    {
      Console.WriteLine("Message = {0}", ex.Message);
      Console.WriteLine("Source = {0}", ex.Source);
      Console.WriteLine("StackTrace= {0}", ex.StackTrace);
      Console.WriteLine("TargetSite = {0}", ex.TargetSite);
    }
  }
}
