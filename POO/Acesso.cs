using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Acesso
{
    class Acesso
    {
        /*
         * public => Atributos e Métodos visíveis em qualquer classe
         * private => Atributos e Métodos visíveis apenas na classe PAI
         * protected => Atributos e Métodos visíveis em classes onde são criados ou herdados
         */

        /*
         * O encapsulamento é restrigir o acesso as proriedades das classes, como determinados atributos e métodos ou seja o acesso só dentro da classe PAI
         */

        private string aluno = "";
        private int nota1, nota2;
        private string nome = "Vitor Hirt";

        public void Aluno()
        {
            Console.WriteLine("Nota 1, digite");
            this.nota1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Nota 2, digite");
            this.nota2 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("A média é = " + Media());
        }


        private double Media()
        {
            return (this.nota1 + this.nota2) / 3;
        }


        /* Construtor */

        public void Construtor()
        {
            
        }



        public void Nome(string nome) // Caso eu não passe o valor por tipo referência, o valor que eu passasse iria ser do atributo 
        {
            Console.Write($"Meu nome: {nome}\n"); // Tipo referência
            Console.Write($"Meu nome: {this.nome}"); // Referência de atributo 
        }

        /* Get; Set; */

        private float valor;

        public float Valor
        {
            /* Não é preciso usar os dois, caso eu queira retornar um dos valores eu acabo excluído um deles */
            get { return valor; }
            set { valor=value; }
        }

    }
}
