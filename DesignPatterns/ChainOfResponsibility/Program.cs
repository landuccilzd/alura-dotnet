/*
 * No Repasse temos um cenário de integração de notas fiscais e notas de débito com o ERP.
 * Abaixo existe um esqueleto dessa integração.
 * Implemente a classe Integrador para simularmos essa integração
 * 
 * Dicas:
 * 1. Não será necessário integrar ou comunicar com qualquer outro sistema, apensar escreva em tela:
 *    "Integrando nota: <NUMERO_NOME>/<SERIE_NOTA> - Valor: <VALOR_NOTA> - Tipo: <TIPO_NOTA>
 * 
 * 2. Sinta-se a vontade para criar mais classes no projeto para completar o desafio
 * 
 * 3. As regras que definem se as notas devem ser integradas ou não estão abaixo:
 * 
 * Notas de ANTENA só integram se tiverem valor acima de 1000
 * Notas de RECIBO só integram se tiverem valor acima de 2000
 * Notas de MENSALIDADE só integram se tiverem valor maior que 100 e menor que 1500
 * Notas de INSCRICAO só integram se tiverem valor entre 1000 e 7000
 * Notas de CHEQUE só integram se tiverem valor abaixo de 3000
 * Notas de NOTA_PROMISSORIA só integram se tiverem valor entre 3000 e 5000
 * Notas de FINANCIAMENTO só integram se tiverem valor acima de 100
 * Notas de JUDICIAL só integram se tiverem valor acima de 4000
 * Notas de ADIANTAMENTO só integram se tiverem valor acima de 5000
 * Notas de OUTROS só integram se tiverem valor acima de 10000 e forem serie A
 */
using Desafio;

Console.WriteLine("Chains of Responsibility - Integração de Notas\n");
Console.WriteLine("Integração das notas - Início");

var integrador = new Integrador();
integrador.Iniciar();

Console.WriteLine("Integração das notas - Fim");