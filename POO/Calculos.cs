using Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculo
{
    class Calculos : IPadrao
    {
        public void Somar(int n1, int n2)
        {
            Console.WriteLine($"A soma é {n1 + n2}");
        }

        public void subtrair(int n1, int n2)
        {
            Console.WriteLine($"A subtração é {n1 - n2}");
        }
    }
}
