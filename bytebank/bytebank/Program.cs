using bytebank;

ContaCorrente contaAndre = new ContaCorrente();

contaAndre.titular = "André silva";
contaAndre.numero_agencia = 15;
contaAndre.conta = "1010-x";
contaAndre.saldo = 100;

//informações básicas
Console.WriteLine($"Titular da conta: {contaAndre.titular}");
Console.WriteLine($"Número da agência: {contaAndre.numero_agencia}");
Console.WriteLine($"Número da conta {contaAndre.conta}");
Console.WriteLine($"Saldo da conta: {contaAndre.saldo}");


//verificação de saldo
/*
if(contaAndre.Sacar(100) == true)
{
    Console.WriteLine($"Saldo da conta do André: {contaAndre.saldo}\n");
}
else
{
    Console.WriteLine($"Não foi possível fazer o saque\n");
};
*/

ContaCorrente contaMaria = new ContaCorrente();
contaMaria.titular = "Maria Souza";
contaMaria.numero_agencia = 17;
contaMaria.conta = "1010-5";
contaMaria.saldo = 350;

Console.WriteLine($"Titular da conta: {contaMaria.titular}");
Console.WriteLine($"Número da agência: {contaMaria.numero_agencia}");
Console.WriteLine($"Número da conta {contaMaria.conta}");
Console.WriteLine($"Saldo da conta: {contaMaria.saldo}");

contaAndre.Transferir(50, contaMaria);

Console.WriteLine($"Saldo do André: {contaAndre.saldo}");
Console.WriteLine($"Saldo do Maria: {contaMaria.saldo}");