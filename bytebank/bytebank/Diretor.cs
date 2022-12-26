using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using bytebank.Funcionarios;

namespace bytebank
{
    public class Diretor:Funcionario
    {
        public Diretor(string cpf, int salario):base(cpf, salario)
        {

        }
        public override double GetBonificacao()
        {
            return this.Salario + base.GetBonificacao();
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
