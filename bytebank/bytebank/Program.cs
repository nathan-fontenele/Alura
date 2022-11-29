using bytebank;

ContaCorrente contaAndre = new ContaCorrente();
contaAndre.titular = "André silva";
contaAndre.numero_agencia = 15;
contaAndre.conta = "1010-x";
contaAndre.saldo = 100;

ContaCorrente contaAndre2 = new ContaCorrente();
contaAndre2.titular = "André silva";
contaAndre2.numero_agencia = 15;
contaAndre2.conta = "1010-x";
contaAndre2.saldo = 100;

ContaCorrente contaMaria = new ContaCorrente();
contaMaria.titular = "Maria Souza";
contaMaria.numero_agencia = 17;
contaMaria.conta = "1010-5";
contaMaria.saldo = 350;

ContaCorrente contaPedro = new ContaCorrente();

//passagem pro referência
Console.WriteLine(contaAndre == contaAndre2); // false - os espaços de memórias são diferentes

//passagem por valor
contaAndre = contaAndre2;
Console.WriteLine(contaAndre == contaAndre2); //true - aponta para o mesmo objeto

contaAndre.ExibeInformacoes();
contaMaria.ExibeInformacoes();
contaPedro.ExibeInformacoes();

contaAndre.Transferir(50, contaMaria); //transfere da conta do andre para conta da maria
Console.WriteLine("Saldo após a transferencia:");
Console.WriteLine($"Saldo do André: {contaAndre.saldo}");
Console.WriteLine($"Saldo do Maria: {contaMaria.saldo}");





