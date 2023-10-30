using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class Imposto
{
    // Métodos
    // Virtual - Diz que o método pode sofre alterações de outras classes
    public virtual void ValeAlimentacao(double salario)
    {
        Console.WriteLine($"Desconto padrão do vale alimentação R$ {salario * 0.1}");
    }

    public virtual void ValeTransporte(double salario)
    {
        Console.WriteLine($"Desconto padrão do vale transporte R$ {salario * 0.06}");
    }
}

