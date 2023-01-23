using System;

namespace myproject
{
  class Program
  {
    static void Main(string[] args)
    {
      Console.Write("Please enter threshold number: ");
      int maxNumber = int.Parse(Console.ReadLine());

      int Fonk1(int a, int b)
      {
        int toplam = a + b;

        if ((toplam) > maxNumber)
        {
          Console.WriteLine(toplam);
          return toplam;
        }
        else
        {
          Console.WriteLine(toplam);
          return (Fonk1(b, toplam));
        }
      }
      Fonk1(0, 1);
    }
  }
}

