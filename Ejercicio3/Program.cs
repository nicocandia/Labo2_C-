using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio3
{
  class Program
  {
    static void Main(string[] args)
    {
      Console.WriteLine("ingrese numero");
      string numero;
      int i;
      int entero;
      numero = Console.ReadLine();
      entero = int.Parse(numero);
      bool correctamenteParseado = int.TryParse(numero, out entero);


      if (correctamenteParseado && entero >= 2)
      {
        for (i = 2; i <= entero; i++)
        {
          if (EsPrimo(i))
          {
            Console.WriteLine("{0}",i);
          }
        }
        
      }
      else
      {
        Console.WriteLine("ingrese numero mayor a dos");
       
      }
      Console.ReadKey();
    }
    private static bool EsPrimo(int numero)
    {
      bool retorno;
      int i;
      int contador = 0;

      for (i = 1; i <= numero; i++)
      {
        if ( numero%i == 0)
        {
          contador++;
        }
      }
      if (contador == 2)
      {
        retorno = true;
      }
      else { retorno = false;}

      return retorno;
    }

  }

  

}
