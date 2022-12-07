using bytebank.Contas;
using bytebank.Titular;

class Program
{
    public static void Main()
    {
        //instancia de objetos
        Cliente cliente = new Cliente();
        cliente.Nome = "André Silva";
        cliente.Cpf = "123.456.789-10";
        cliente.Profissao = "Analista";
        cliente.Renda = 1200;

        ContaCorrente conta = new ContaCorrente();
        conta.Titular = cliente;
        conta.Conta = "1010-X";
        conta.Numero_Agencia = 14;
        conta.Saldo = 200;

        Console.WriteLine($"Titular: {conta.Titular.Nome}");
        Console.WriteLine($"Conta: {conta.Conta}");
        Console.WriteLine($"Agência: {conta.Numero_Agencia}");
        Console.WriteLine($"Saldo: R${conta.Saldo}");
        Console.WriteLine($"Renda: R${conta.Titular.Renda}");

    }
}