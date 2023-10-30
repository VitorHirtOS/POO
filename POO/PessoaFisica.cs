using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PessoaFisicas
{
    class PessoaFisica : Padraos.Padrao
    {

        // Método obrigatório

        public override void TaxaEmprestimo(double valor)
        {
            Console.WriteLine($"Taxa de empréstimo para pessoa física R$ {valor * 0.1}");
        }

    }
}
