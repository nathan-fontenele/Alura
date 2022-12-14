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
        public Diretor(string cpf):base(cpf)
        {

        }
        public override double GetBonificacao()
        {
            return this.Salario + base.GetBonificacao();
        }
        
        public void ExibeInformacoe()
        {
            Console.WriteLine($"Nome: {Nome}");
            Console.WriteLine($"CPF: {Cpf}");
            Console.WriteLine($"Salário: R${Salario}");
        }
    }
}
