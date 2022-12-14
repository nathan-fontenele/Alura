using bytebank.Contas;
using bytebank.Titular;
using bytebank.Funcionarios;
using System;
using bytebank.Utilitario;
using System.Security.Cryptography.X509Certificates;
using bytebank.SistemaInterno;
using bytebank.Parceria;

class Program
{
    public static void Main()
    {
        #region
        //instancia de objeto
        ContaCorrente conta1 = new ContaCorrente(123, "345");
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

        ContaCorrente conta2 = new ContaCorrente(154, "564");
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


        ContaCorrente conta3 = new ContaCorrente(645, "4876");
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

        Console.WriteLine($"Total de contas criada:{ContaCorrente.TotalDeContasCriadas}");
        Console.WriteLine($"Taxa de Operação: {ContaCorrente.TaxaOperacao}\n");

        Console.WriteLine("-----Trasferência------");

        conta2.Transferir(50, conta3);
        conta2.ExibeInformacoe();
        conta3.ExibeInformacoe();

        Console.WriteLine("-----Funcionários------");
        Auxiliar pedro = new Auxiliar("12345");
        pedro.Nome = "Pedro Malazartes";
        pedro.ExibeInformacoe();
        Console.WriteLine($"Bonificação: {pedro.GetBonificacao()}");

        Console.WriteLine("-----Diretor------");
        Diretor roberta = new Diretor("543.653.346.43");
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
        #endregion

        #region
        //void CalcularBonificacao()
        //{
        //    GerenciadorDeBonificacao gerenciador = new GerenciadorDeBonificacao();
        //    Designer ulisses = new Designer("123456");
        //    Auxiliar igor = new Auxiliar("456345");
        //    Diretor paula = new Diretor("764376");
        //    GerenteDeContas camila = new GerenteDeContas("938475");

        //    ulisses.Nome = "Ulisses";
        //    igor.Nome = "igor";
        //    paula.Nome = "Paula";
        //    camila.Nome = "Camila";

        //    gerenciador.RegistrarBonificacao(ulisses);
        //    gerenciador.RegistrarBonificacao(igor);
        //    gerenciador.RegistrarBonificacao(paula);
        //    gerenciador.RegistrarBonificacao(camila);

        //    Console.WriteLine($"Total de bonificação: {gerenciador.TotalDeBonificacoes}");

        //}

        //void UsarSistema()
        //{
        //    SistemaInterno sistemaInterno = new SistemaInterno();

        //    Diretor roberta = new Diretor("123456");
        //    roberta.Nome = "Roberta";
        //    roberta.Login = "Roberta";
        //    roberta.Senha = "123";

        //    GerenteDeContas ursula = new GerenteDeContas("645634");
        //    ursula.Nome = "Ursula";
        //    ursula.Login = "Ursula";
        //    ursula.Senha = "123";

        //    ParceiroComercial carlos = new ParceiroComercial();
        //    carlos.Login = "Carlos";
        //    carlos.Senha = "999";

        //    Arquiteto marcio = new Arquiteto();
        //    marcio.Senha = "444";
        //    marcio.Login = "Marcio";
        //    marcio.CNPJ = "123";

        //    sistemaInterno.Login(roberta, "123", "Roberta");
        //    sistemaInterno.Login(ursula, "321", "Ursula");
        //    sistemaInterno.Login(carlos, "999", "Carlos");
        //    sistemaInterno.Login(marcio, "444", "Marcio");

        //}

        //UsarSistema();
        #endregion
    }
}