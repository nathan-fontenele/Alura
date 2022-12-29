using bytebank.Funcionarios;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using bytebank.Funcionarios;

namespace bytebank.SistemaInterno
{
    public abstract class Autenticar : Funcionario
    {
        public Autenticar(string cpf, int salario) : base(cpf, salario)
        {
        }

        public string Login { get; set; }
        public string Senha { get; set; }

        public abstract bool Autenticacao(string login, string senha);

        
    }
}
