Console.Write("Informe o seu ano de nascimento: ");
var leitura = Console.ReadLine();

while (leitura == null || "".Equals(leitura)) {
    Console.Write("Informe um valor válido para seu ano de nascimento: ");
    leitura = Console.ReadLine();

    try {
        var idade = DateTime.Now.Year - int.Parse(leitura);
        Console.WriteLine();
        Console.WriteLine($"Esse ano você completa {idade} anos\r\n");
    } catch (FormatException) {
        leitura = null;
    }
}

Console.Write("Tecle ENTER para finalizar");
Console.ReadLine();
