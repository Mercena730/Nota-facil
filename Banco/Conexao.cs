using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Banco
{
    public class Conexao
    {
        private static Conexao_dbDataContext context;
        Conexao_dbDataContext conexao
        {
            get
            {
                if(context == null)
                {
                    context = new Conexao_dbDataContext();
                }
                return context;
            }
        }
    }
}
