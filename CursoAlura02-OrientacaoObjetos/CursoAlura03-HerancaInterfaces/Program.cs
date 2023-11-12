using CursoAlura03_HerancaInterfaces.Funcionarios;
using CursoAlura03_HerancaInterfaces.Util;

Funcionario cris = new Funcionario("Cris Louzada", "12345678910", 20000);
Diretor bruna = new Diretor("Bruna Sevilha", "98765432190", 30000);

var gb = new GerenciadorBonificacao();
gb.Registrar(cris);
gb.Registrar(bruna);
Console.WriteLine(gb.TotalBonificacao);

Console.WriteLine($"total de funcionarios {Funcionario.TOTAL_FUNCIONARIOS}");

cris.AumentarSalario();
bruna.AumentarSalario();

Console.WriteLine($"Novo salários de {cris.Nome}: {cris.Salario}");
Console.WriteLine($"Novo salários de {bruna.Nome}: {bruna.Salario}");
