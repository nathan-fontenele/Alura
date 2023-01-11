using bytebank.SistemaInterno;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace bytebank.Funcionarios
{
    public abstract class FuncionarioAutenticavel : Funcionario, IAutenticar
    {
        protected FuncionarioAutenticavel(string cpf, int salario) : base(cpf, salario)
        {
        }

        public string Senha { get; set; }
        public string Login { get; set; }
        public  bool Autenticacao(string login, string senha)
        {
            return (this.Senha == senha && this.Login == login); ;
        }
    }
}
