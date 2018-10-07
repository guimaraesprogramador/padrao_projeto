using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exemplo_de_padrao_projeto.Command_exemplo
{
    interface Command
    {
        string Executar(string valor);
        
    }
}
