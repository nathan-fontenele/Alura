using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using bytebank.Funcionarios;

namespace bytebank.Utilitario
{
    public class GerenciadorDeBonificacao
    {
        public double TotalDeBonificacoes { get; private set; }

        public void RegistrarBonificacao(Funcionario funcionarios)
        {
            this.TotalDeBonificacoes += funcionarios.GetBonificacao();
            
        }
    }
}
