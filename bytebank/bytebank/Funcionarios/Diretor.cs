using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace bytebank.Funcionarios
{
    public class Diretor : Funcionario
    {
        public Diretor(string cpf) : base(cpf, 5000)
        {

        }
        public override double GetBonificacao()
        {
            return Salario + base.GetBonificacao();
        }
        public override double aumentarSalario()
        {
            return Salario *= 1.10;
        }

        public void ExibeInformacoe()
        {
            Console.WriteLine($"Nome: {Nome}");
            Console.WriteLine($"CPF: {Cpf}");
            Console.WriteLine($"Salário: R${Salario}");
        }
    }
}
