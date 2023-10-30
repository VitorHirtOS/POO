using System;
using Acesso;

namespace Conceitos;

// Lembrando que toda a classe começa com letra maiúscula

class POO
{
    class Result : Salario
    {
        // Atributo

        private int x = 0;
        private float y = 0f;
        private double z = 0;
        private string aac = "";
        private char c = 'a';
        protected float salario = 1.520f;

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
        }
    }


    class Salario
    {
        protected float Salario2 = 10.500f;
    }
    
}