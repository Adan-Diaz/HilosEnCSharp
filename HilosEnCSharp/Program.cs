using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace HilosEnCSharp
{
    class Program
    {
        static void Main(string[] args)
        {

            HilosEnCSharp ejemplo = new HilosEnCSharp();
            Thread hilo1 = new Thread(new ParameterizedThreadStart(ejemplo.sumarHilo));
            Thread hilo2 = new Thread(new ParameterizedThreadStart(ejemplo.sumarHilo));
            Thread hilo3 = new Thread(new ParameterizedThreadStart(ejemplo.sumarHilo));

            hilo1.Name = "Hilo1";
            hilo2.Name = "Hilo2";
            hilo3.Name = "Hilo3";

            Int32[] parametros1 = { 1, 2 };
            Int32[] parametros2 = { 2, 3 };
            Int32[] parametros3 = { 3, 4 };

            Console.WriteLine("Preparando los hilos");

            hilo1.Start(parametros1);
            hilo2.Start(parametros2);
            hilo3.Start(parametros3);
            Console.WriteLine("Hilos Procesando.....");
            Console.ReadLine();

        }
    }
}
