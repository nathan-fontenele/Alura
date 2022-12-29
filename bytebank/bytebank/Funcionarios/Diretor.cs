using bytebank.SistemaInterno;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace bytebank.Funcionarios
{
    public class Diretor : Autenticar
    {
        public override double GetBonificacao()
        {
            return Salario * 0.5;
        }
        public Diretor(string cpf) : base(cpf, 5000)
        {

        }
        public override double aumentarSalario()
        {
            return Salario *= 1.15;
        }

        public void ExibeInformacoe()
        {
            Console.WriteLine($"Nome: {Nome}");
            Console.WriteLine($"CPF: {Cpf}");
            Console.WriteLine($"Salário: R${Salario}");
        }

        public override bool Autenticacao(string login, string senha)
        {

            return (this.Senha == senha && this.Login == login);
        }
    }
}
