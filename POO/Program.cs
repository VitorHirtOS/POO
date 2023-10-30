using System;
using Acesso;

namespace Conceitos;

// Lembrando que toda a classe começa com letra maiúscula

class POO
{
    class Result : Salario // Herança/Poliformismo
    {
        // Atributo

        private int x = 0;
        private float y = 0f;
        private double z = 0;
        private string aac = "";
        private char c = 'a';
        protected float salario = 1.520f;


        public string RetornoHeranca(string nome, string idade)
        {
            this.nome = nome;
            this.idade = idade;
            Console.WriteLine(nome);
            Console.WriteLine(idade);
            return null;
        }

        public static void Main(string[] poo)
        {

            // Instanciar o meu objeto
            Pessoa obj = new Pessoa();
            obj.idade = 22;
            obj.nome = "Vitor Mateus Hirt";
            obj.Mensagem();

            var x = obj.Apresentar(10, 35);
            Console.WriteLine(x);

            string[] textArray = null;

            obj.Docs(ref textArray);

            Console.WriteLine(textArray[4]);

            var j = obj.Docsa();

           Console.WriteLine(j[0]);

            Result s = new Result();

            Console.WriteLine(s.salario + s.Salario2);

            Acesso.Acesso acesso = new Acesso.Acesso();

            acesso.Aluno();

            acesso.Nome("Vitor");

            float ab = acesso.Valor = 10.523f; // Set

            var i = acesso.Valor; // Get

            Console.WriteLine("\n" + i);

            Console.WriteLine(s.RetornoHeranca("Vitor", "22"));

            // Polimorfismo


            // Instanciar o estagiário
            Imposto objetE = new Estagiario();

            /*
             * O objeto estagiário ira sobreescrever o método do valiaAlimentacao() do método Imposto(),
             * Contudo, caso não exista um método valiaAlimentacao() no Estagiario, usará o método que estiver no Imposto()
             * e vise versa.
             */

            objetE.ValeAlimentacao(2000);
            objetE.ValeTransporte(2000); // Usando da classse Imposto, já que não tem criado no classe Estagiário 

            Imposto objetA = new Atendente();

            /*
             * O objeto estagiário ira sobreescrever o método do valiaAlimentacao() do método Imposto(),
             * Contudo, caso não exista um método valiaAlimentacao() no Atendente, usará o método que estiver no Imposto()
             * e vise versa.
             */

            objetA.ValeAlimentacao(2000);
            objetE.ValeTransporte(2000);  // Usando da classse Imposto, já que não tem criado no classe Atendente 

            Imposto objetG = new Gerente();

            /*
             * O objeto estagiário ira sobreescrever o método do valiaAlimentacao() do método Imposto(),
             * Contudo, caso não exista um método valiaAlimentacao() no Gerente, usará o método que estiver no Imposto()
             * e vise versa.
             */

            objetG.ValeAlimentacao(2000);
            objetE.ValeTransporte(2000);  // Usando da classse Imposto, já que não tem criado no classe Gerente 

        }
    }


    class Salario
    {
        protected float Salario2 = 10.500f;

        protected string nome, idade;

        public void Heranca()
        {
            Console.WriteLine("O meu nome é = " + nome);
            Console.WriteLine("A minha idade é = " + idade);
        }
    }
    
}