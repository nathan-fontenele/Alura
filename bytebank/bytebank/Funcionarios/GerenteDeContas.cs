using bytebank.SistemaInterno;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace bytebank.Funcionarios
{
    public class GerenteDeContas : Autenticar
    {
        
        public override double GetBonificacao()
        {
            return Salario * 0.25;
        }
        public GerenteDeContas(string cpf) : base(cpf, 4000)
        {

        }

        public override double aumentarSalario()
        {
            return Salario *= 1.05;
        }
        public override bool Autenticacao(string login, string senha)
        {
            return (this.Senha == senha && this.Login == login); ;
        }
    }
}
