using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    class Pessoa
    {
        static void Main(string[] args)
        {
        public string nome;
        public int telefone;
        public int contato;
        public endereco endereco;


        public void mensagemPessoa()
            {
                Console.Write("Nome: " + nome);
                Console.Write("telefone: " + telefone);
                Console.Write("contato: " + contato);
                Console.Write("endereco: " + endereco);
           
        }
    }
}


