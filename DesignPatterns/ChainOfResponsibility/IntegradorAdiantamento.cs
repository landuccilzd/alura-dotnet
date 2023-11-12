namespace Desafio {
    internal class IntegradorAdiantamento: AbstractIntegracaoNotaFiscal {

        public override bool VerificaNecessidadeIntegracao(NotaFiscal notaFiscal) {
        return (notaFiscal.ValorNota > 5000);
        }
    }
}
