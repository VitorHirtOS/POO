using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Padraos
{
    abstract class Padrao
    {

        // Obrigatório

        public abstract void TaxaEmprestimo(double valor);

        // Opcional

        public void CalcularPoupanca(double valor, double taxa)
        {
            Console.WriteLine($"Ganhos obtidos pela poupança R$ {valor * taxa}");
        }

    }
}
