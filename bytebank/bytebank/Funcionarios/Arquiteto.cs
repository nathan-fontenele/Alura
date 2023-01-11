using bytebank.Parceria;
using bytebank.SistemaInterno;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Transactions;

namespace bytebank.Funcionarios
{
    public class Arquiteto : PrestadorDeServico, IAutenticar
    {
        public string Login { get; set; }
        public string Senha { get; set; }
        public double GetBonificacao()
        {
            return 1000;
        }
        public bool Autenticacao(string login, string senha)
        {
            return (this.Senha == senha && this.Login == login); ;
        }
    }
}
