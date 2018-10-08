using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Exemplo_de_padrao_projeto.Command_exemplo;
namespace Exemplo_de_padrao_projeto
{
    class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("informe o produto que vai consumir ?");
            Pradrao_command();
            Console.ReadKey();
        }
        public static void Pradrao_command()
        {
            Apresentar_produto _Produto = new Apresentar_produto();
            Console.WriteLine(_Produto.mostra(Console.ReadLine()));
        } 
    }
}
