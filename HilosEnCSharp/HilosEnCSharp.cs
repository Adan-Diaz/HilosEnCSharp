using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace HilosEnCSharp
{
    class HilosEnCSharp
    {
        public void sumarHilo(object parametros)
        {
            Thread current = Thread.CurrentThread;
            Int32[] numeros = (Int32[])parametros;
            Int32 resultado = numeros[0] + numeros[1];
            Console.WriteLine("El hilo " + current.Name + ", durmiendo por "
            + resultado + "segundos");
            Thread.Sleep(resultado * 1000);
            Console.WriteLine("El resultado de la suma de " + numeros[0] + " + " + numeros[1] + " es: "
                 + resultado);
            Console.WriteLine("hilo " + current.Name + " finalizo su trabajo");
           }
    }
}
