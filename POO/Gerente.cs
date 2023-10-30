using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


class Gerente : Imposto
{
    // Override - sobeescrever um método que esta importanto do Imposto()
    public override void ValeAlimentacao(double salario)
    {
        Console.WriteLine($"Desconto Gerente do vale alimentação R$ {salario * 0.15}");
    }
}

