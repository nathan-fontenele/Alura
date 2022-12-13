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
        public override double GetBonificacao()
        {
            return this.Salario + base.GetBonificacao();
        }
        
        public void ExibeInformacoe()
        {
            Console.WriteLine($"Nome: {Nome}");
            Console.WriteLine($"CPF: R${Cpf}");
            Console.WriteLine($"Salário: R${Salario}\n");
        }
    }
}
