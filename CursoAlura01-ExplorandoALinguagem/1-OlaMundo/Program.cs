Console.WriteLine("Olá, mundo!");
Console.WriteLine("Escreva \"SAIR\" para finalizar");
var comando = Console.ReadLine();

while (!"SAIR".Equals(comando)) {
    Console.WriteLine("Comando enviado: " + comando + "\r\n");
    Console.WriteLine("Escreva \"SAIR\" para finalizar");
    comando = Console.ReadLine();
}