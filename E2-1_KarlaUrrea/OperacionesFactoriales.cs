using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace E2_1_KarlaUrrea
{
    class OperacionesFactoriales
    {
        public OperacionesFactoriales() { }

      

        public int Factorial(int n)
        {
            int nFactorial = 1;

            if (n > -1 && n < 2)
            {
                nFactorial = 1;
            }
            else if (n < 0)
            {
                nFactorial= 0;
            }
            else
            {
                for (int i = 2; i <= n; i++)
                {
                    nFactorial *= i;
                }

            }

            return nFactorial;
        }

        public int FactorialRecursividad(int n)
        {
            if (n > -1 && n < 2)
            {
                return 1;
            }
            else if (n < 0)
            {
                return 0;
            }
            else
            {
                return n * FactorialRecursividad(n - 1);
            }
        }
    }
}
