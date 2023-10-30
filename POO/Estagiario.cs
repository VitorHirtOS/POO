using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


class Estagiario : Imposto
{
    public override void ValeAlimentacao(double salario)
    {
        Console.WriteLine($"Desconto Estagiario do vale alimentação R$ {salario * 0.12}");
    }
}

