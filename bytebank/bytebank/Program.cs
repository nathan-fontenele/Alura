using bytebank.Contas;
using bytebank.Titular;

//ContaCorrente contaAndre = new ContaCorrente();
//contaAndre.titular = "André silva";
//contaAndre.numero_agencia = 15;
//contaAndre.conta = "1010-x";
//contaAndre.saldo = 100;

//ContaCorrente contaAndre2 = new ContaCorrente(); //teste para passagens por valor e referência
//contaAndre2.titular = "André silva";
//contaAndre2.numero_agencia = 15;
//contaAndre2.conta = "1010-x";
//contaAndre2.saldo = 100;

//ContaCorrente contaMaria = new ContaCorrente();
//contaMaria.titular = "Maria Souza";
//contaMaria.numero_agencia = 17;
//contaMaria.conta = "1010-5";
//contaMaria.saldo = 350;

//ContaCorrente contaPedro = new ContaCorrente(); //teste para imprimir valores padrões

////passagem pro referência
//Console.WriteLine(contaAndre == contaAndre2); // false - os espaços de memórias são diferentes

////passagem por valor
//contaAndre = contaAndre2;
//Console.WriteLine(contaAndre == contaAndre2); //true - aponta para o mesmo objeto

//contaAndre.ExibeInformacoes();
//contaMaria.ExibeInformacoes();
//contaPedro.ExibeInformacoes();

//contaAndre.Transferir(50, contaMaria); //transfere da conta do andre para conta da maria

Cliente cliente = new Cliente();
cliente.nome = "André Souza";
cliente.CPF = "123456789";
cliente.profissao = "Analista";

ContaCorrente conta = new ContaCorrente();
conta.titular = cliente;
conta.conta = "1010-x";
conta.numero_agencia = 15;
conta.saldo = 100;

conta.ExibeInformacoes();

ContaCorrente conta2 = new ContaCorrente();
conta2.titular = new Cliente(); //referência ao objeto titular
conta2.titular.nome = "José Souza";
conta2.titular.profissao = "Tester";
conta2.titular.CPF = "234567891";
conta2.conta = "999-x";
conta2.numero_agencia = 18;
conta2.saldo = 500;

conta2.ExibeInformacoes();


