var maiorLinha = 31;

for (var i = 1; i <= maiorLinha; i += 2) {
    for (var j = 0; j < (((maiorLinha - i) / 2)); j++) {
        Console.Write(' ');
    }

    for (var j = 0; j < i; j++) {
        Console.Write('*');
    }
    Console.WriteLine();
}

for (var i = maiorLinha - 2; i >= 1;  i -= 2) {
    for (var j = 0; j < (((maiorLinha - i) / 2)); j++) {
        Console.Write(' ');
    }

    for (var j = 0; j < i; j++) {
        Console.Write('*');
    }
    Console.WriteLine();
}

