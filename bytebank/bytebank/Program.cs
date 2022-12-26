using bytebank.Contas;
using bytebank.Titular;
using bytebank.Funcionarios;
using System;
using bytebank;
using bytebank.Utilitario;

class Program
{
    public static void Main()
    {
        //instancia de objeto
        ContaCorrente conta1 = new ContaCorrente();
        conta1.Titular = new Cliente();
        conta1.Titular.Nome = "André Silva";
        conta1.Titular.Cpf = "123.456.789-10";
        conta1.Titular.Profissao = "Analista";
        conta1.Titular.Telefone = "(21) 912345678";
        conta1.Titular.Renda = 1200;
        conta1.Conta = "1010-X";
        conta1.Numero_Agencia = 12;
        conta1.Saldo = 200;
        conta1.ExibeInformacoe();

        ContaCorrente conta2 = new ContaCorrente();
        conta2.Titular = new Cliente();
        conta2.Titular.Nome = "Maysa Silva";
        conta2.Titular.Cpf = "543.654.453-32";
        conta2.Titular.Profissao = "Desenvolvedor";
        conta2.Titular.Telefone = "(21) 912345678";
        conta2.Titular.Renda = 1500;
        conta2.Conta = "1010-X";
        conta2.Numero_Agencia = 12;
        conta2.Saldo = 300;
        conta2.ExibeInformacoe();


        ContaCorrente conta3 = new ContaCorrente();
        conta3.Titular = new Cliente();
        conta3.Titular.Nome = "Amanda Silva";
        conta3.Titular.Cpf = "234.645.567-45";
        conta3.Titular.Profissao = "Gerente";
        conta3.Titular.Telefone = "(21) 912345675";
        conta3.Titular.Renda = 1900;
        conta3.Conta = "1010-X";
        conta3.Numero_Agencia = 12;
        conta3.Saldo = 100;
        conta3.ExibeInformacoe();

        Console.WriteLine($"Total de contas criada:{ContaCorrente.TotalDeContasCriadas}\n");

        Console.WriteLine("-----Trasferência------");

        conta2.Transferir(50, conta3);
        conta2.ExibeInformacoe();
        conta3.ExibeInformacoe();

        Console.WriteLine("-----Funcionários------");
        Funcionario pedro = new Funcionario("125.654.234-65", 2000);
        pedro.Nome = "Pedro Malazartes";
        pedro.ExibeInformacoe();
        Console.WriteLine($"Bonificação: {pedro.GetBonificacao()}");
        
        Console.WriteLine("-----Diretor------");
        Diretor roberta = new Diretor("543.653.346.43", 5000);
        roberta.Nome = "Roberta Silva";
        roberta.ExibeInformacoe();
        Console.WriteLine($"Bonificação: {roberta.GetBonificacao()}");

        GerenciadorDeBonificacao gerenciador = new GerenciadorDeBonificacao();

        gerenciador.RegistrarBonificacao(pedro);
        gerenciador.RegistrarBonificacao(roberta);
        Console.WriteLine($"\nTotal de bonificaçõe; {gerenciador.TotalDeBonificacoes}");
        Console.WriteLine($"Total de duncionários: {Funcionario.TotalDeFuncionarios}");

        Console.WriteLine("\n-----Salário após aumento------");
        Console.WriteLine($"Roberta: {roberta.aumentarSalario()}");
        Console.WriteLine($"Pedro: {pedro.aumentarSalario()}");
    }
}