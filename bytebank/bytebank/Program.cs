using bytebank.Contas;
using bytebank.Titular;

class Program
{
    public static void Main()
    {
        //instancia de objetos
        ContaCorrente conta = new ContaCorrente();
        conta.Titular = new Cliente();
        conta.Titular.Nome = "André Silva";
        conta.Titular.Cpf = "123.456.789-10";
        conta.Titular.Profissao = "Analista";
        conta.Titular.Telefone = "(21) 912345678";
        conta.Titular.Renda = 1200;
        conta.Conta = "1010-X";
        conta.Numero_Agencia = 12;
        conta.Saldo = 200;

        conta.ExibeInformacoe();

    }
}