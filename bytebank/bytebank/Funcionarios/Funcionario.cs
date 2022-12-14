using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Schema;

namespace bytebank.Funcionarios
{
    public class Funcionario
    {
        public string Nome { get; set; }
        public string Cpf { get; set; }
        public double Salario { get; set; }
        public static int TotalDeFuncionarios { get; private set; }
    
        public virtual double GetBonificacao()
        {
            return this.Salario * 0.1;
        }

        public Funcionario(string cpf)
        {
            this.Cpf = cpf;
            TotalDeFuncionarios++;
        }

        public void ExibeInformacoe()
        {
            Console.WriteLine($"Nome: {Nome}");
            Console.WriteLine($"CPF: {Cpf}");
            Console.WriteLine($"Salário: R${Salario}");
        }

    }
}
