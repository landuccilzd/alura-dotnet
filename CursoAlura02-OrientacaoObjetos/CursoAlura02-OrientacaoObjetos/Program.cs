
using CursoAlura02_OrientacaoObjetos;

ContaCorrente conta = new(1, "1010-1", "Cris Louzada", 0);
Console.WriteLine($"Titular da conta: {conta.Titular}");
Console.WriteLine($"Número da conta: {conta.Numero}");
Console.WriteLine($"Agência: {conta.Agencia}");
Console.WriteLine($"Saldo R$ {String.Format("{0:0.00}", conta.Saldo)}");
Console.WriteLine();

ContaCorrente contaDestino = new(1, "1010-2", "Berlim", 0);
Console.WriteLine($"Titular da conta: {conta.Titular}");
Console.WriteLine($"Número da conta: {conta.Numero}");
Console.WriteLine($"Agência: {conta.Agencia}");
Console.WriteLine();

conta.Depositar(100);
Console.WriteLine($"Saldo na conta {conta.Titular} R$ {String.Format("{0:0.00}", conta.Saldo)}");

conta.Depositar(1000);
Console.WriteLine($"Saldo na conta {conta.Titular} R$ {String.Format("{0:0.00}", conta.Saldo)}");

conta.Depositar(10000);
Console.WriteLine($"Saldo na conta {conta.Titular} R$ {String.Format("{0:0.00}", conta.Saldo)}");

if (!conta.Sacar(10000)) {
    Console.WriteLine("Sem saldo para esse saque");
}
Console.WriteLine($"Saldo na conta {conta.Titular} R$ {String.Format("{0:0.00}", conta.Saldo)}");

if (!conta.Sacar(1000)) {
    Console.WriteLine("Sem saldo para esse saque");
}
Console.WriteLine($"Saldo na conta {conta.Titular} R$ {String.Format("{0:0.00}", conta.Saldo)}");

if (!conta.Sacar(200)) {
    Console.WriteLine("Sem saldo para esse saque");
}
Console.WriteLine($"Saldo na conta {conta.Titular} R$ {String.Format("{0:0.00}", conta.Saldo)}");

if (!conta.Transferir(50, contaDestino)) {
    Console.WriteLine("Sem saldo para esse saque");
}
Console.WriteLine($"Saldo na conta {conta.Titular} R$ {String.Format("{0:0.00}", conta.Saldo)}");
Console.WriteLine($"Saldo na conta {contaDestino.Titular} R$ {String.Format("{0:0.00}", contaDestino.Saldo)}");

Console.WriteLine($"Total de clietnes: {Titular.TOTAL_CLIENTES}");
