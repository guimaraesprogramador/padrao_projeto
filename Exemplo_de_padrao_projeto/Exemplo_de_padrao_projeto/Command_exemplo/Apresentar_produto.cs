using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exemplo_de_padrao_projeto.Command_exemplo
{
    public class Apresentar_produto
    {
        Command pergunta;
        Apresentar_produto Apresentar;
        public string mostra(string tipo)
        {
            Apresentar = new Apresentar_produto();
            this.pergunta = new CreateCommand(Apresentar);
            return pergunta.Executar(tipo);
        }
        public string[] produtos
        {
            get
            {
                string[] array_produtos = new string[4];
                array_produtos[0] = "sabonete";
                array_produtos[1] = "shampo";
                array_produtos[2] = "condicionador";
                array_produtos[3] = "pente";
                return array_produtos;
            }
        }
    }
}
