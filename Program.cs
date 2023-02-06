using System;

namespace csphysics
{
  class Program
  {
    static void Main(string[] args)
    {
      Book book1 = new Book("Profesyonel Emirin Notlari", "Emir Topaloglu", 300, "Ga");

      book1.Print();
    }
  }
}
