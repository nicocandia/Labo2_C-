using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio4
{
  class Program
  {
    static void Main(string[] args)
    {
      int contador = 0;
      int numero=1;
      do
      {
        if (esNumeroPerfecto(numero))
        {
          Console.WriteLine("{0}",numero);
          contador++;
        }
        else  { numero++; }
      } while (contador != 4);
      Console.ReadKey();
    }


    private static Boolean esNumeroPerfecto(int numero)
    {
      bool retorno = false;
      int i;
      int acumuladorDivisor = 0;
      for (i=1;i<numero;i++)
      {
        if (numero%i==0)
        {
          acumuladorDivisor = acumuladorDivisor + i;
        }
      }
      if (acumuladorDivisor == numero)
      {
        retorno = true;
      }
      return retorno;
    }
  }
}
