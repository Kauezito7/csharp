using Banco.Classes;

Console.Clear();
Console.WriteLine($"Bem vindo ao Bradescus");
Console.WriteLine();

ContaCorrente contaKaue = new ContaCorrente();
ContaCorrente contaAnna = new ContaCorrente();

contaKaue.Titular = "Kaue";
contaKaue.Depositar (98000f);

contaAnna.Titular = "Anna";
contaAnna.Depositar (98000f);

Console.WriteLine($"Conta da {contaKaue.Titular} tem R$ {contaKaue.Saldo}");
Console.WriteLine($"Conta da {contaAnna.Titular} tem R$ {contaAnna.Saldo}");

contaAnna.Sacar(250f);

Console.WriteLine($"Voce sacou e sua conta ficou com R${contaAnna.Saldo}");
Console.WriteLine();
Console.WriteLine();

Console.WriteLine($"Conta da {contaKaue.Titular} tem R${contaKaue.Saldo}");
Console.WriteLine($"Conta da {contaAnna.Titular} tem R${contaAnna.Saldo}");
Console.WriteLine();

