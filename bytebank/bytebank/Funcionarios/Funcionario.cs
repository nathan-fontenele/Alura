using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Schema;

namespace bytebank.Funcionarios
{
    public abstract class Funcionario
    {
        public string Nome { get; set; }
        public string Cpf { get; set; }
        public double Salario { get; protected set; }
        public static int TotalDeFuncionarios { get; private set; }

        public abstract double GetBonificacao();
        public abstract double aumentarSalario();
        
        public Funcionario(string cpf, int salario)
        {
            this.Salario = salario;
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
