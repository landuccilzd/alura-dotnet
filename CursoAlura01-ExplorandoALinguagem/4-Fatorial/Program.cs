var numero = 10;
var resultado = numero;
var saida = $"{numero}";

for (var i = numero - 1; i > 0; i--) {
    saida += $" * {i}";
    resultado *= i;
}

Console.WriteLine($"{numero}! ({saida}) = {resultado}");
