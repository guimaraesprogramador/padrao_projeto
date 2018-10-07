using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exemplo_de_padrao_projeto.Command_exemplo
{
   public class CreateCommand : Command
    {
        Apresentar_produto _Produto;
        Command pesquisa;
       public CreateCommand(Apresentar_produto apresentar)
        {
           this._Produto =  apresentar;
            
        }
        public string Executar(string valor)
        {
            
            for(int i = 0; i < _Produto.produtos.Length; i++)
            {
                if(valor == _Produto.produtos[i])
                {
                    return "existe esse produto ";
                }
            }
            return "nao existe esse produto";
        }
    }
}
