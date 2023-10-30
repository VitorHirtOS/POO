using System;


class Pessoa
{

    public string nome = "";
    public int idade = 0;
    private int nun;

    public void Mensagem()
    {
        Console.WriteLine($"O meu nome é {nome} e minha idade é {idade}");
        this.nun = 10;
        Console.WriteLine(nun);
    }

    public double Apresentar(double a, double b)
    {
        return (a * b) / 10;
    }

    public string[] Docs(ref string[] text)
    {
        text = new string[5] {"1","2","3","4","5"};
        return text;
    }

    public string[] Docsa()
    {
        string[] texto = new string[5] { "10", "0", "30", "50", "20" };
        return texto;
    }
}
