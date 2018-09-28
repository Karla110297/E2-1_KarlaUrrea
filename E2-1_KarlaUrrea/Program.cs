using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace E2_1_KarlaUrrea
{
    class Program
    {
        static void Main(string[] args)
        {
            OperacionesFactoriales operacion = new OperacionesFactoriales();


            int[] n = new int[6];
            for (int i = 0; i < 6; i++)
            {
                Console.WriteLine("Numero n para sacar factorial");
                n[i] = Int32.Parse(Console.ReadLine());

            }


            TimeSpan stop;
            TimeSpan start = new TimeSpan(DateTime.Now.Ticks);


            for (int i = 0; i < 6; i++)
            {
                Console.WriteLine("{0}!= {1} ", n[i], operacion.FactorialRecursividad(n[i]));
            }

            stop = new TimeSpan(DateTime.Now.Ticks);
            Console.WriteLine("Tiempo: " + stop.Subtract(start).TotalMilliseconds);


            Console.WriteLine();


            TimeSpan parar;
            TimeSpan comenzar = new TimeSpan(DateTime.Now.Ticks);

            for (int i = 0; i < 6; i++)
            {
                Console.WriteLine("{0}!= {1} ", n[i], operacion.Factorial(n[i]));
            }

            parar = new TimeSpan(DateTime.Now.Ticks);
            Console.WriteLine("Tiempo: " + parar.Subtract(comenzar).TotalMilliseconds);

            Console.ReadKey();
        }


    }
}
