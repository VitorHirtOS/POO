using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class Atendente : Imposto
{
    public override void ValeAlimentacao(double salario)
    {
        Console.WriteLine($"Desconto Atendente do vale alimentação R$ {salario * 0.12}");
    }
}

