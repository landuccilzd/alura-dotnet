using CursoAlura03_Desafios.Operacoes;

Operacoes op = new Soma();
Console.WriteLine(op.Calcular(10, 20));

op = new Subtracao();
Console.WriteLine(op.Calcular(10, 20));

op = new Multiplicacao();
Console.WriteLine(op.Calcular(10, 20));

op = new Divisao();
Console.WriteLine(op.Calcular(10, 20));
