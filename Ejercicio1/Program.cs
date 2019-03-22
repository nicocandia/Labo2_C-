using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
  class Program
  {
    static void Main(string[] args)
    {

      Console.WriteLine("ingrese numero");
      string numero;
      int entero;
      numero = Console.ReadLine();
      entero = int.Parse(numero);
      bool correctamenteParseado = int.TryParse(numero, out entero);

      if (correctamenteParseado && entero > 0)
      {
        
      }
      else
      {
        
      }

    }
  }
}
