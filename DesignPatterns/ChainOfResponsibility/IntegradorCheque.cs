namespace Desafio {
    internal class IntegradorCheque: AbstractIntegracaoNotaFiscal {

        public override bool VerificaNecessidadeIntegracao(NotaFiscal notaFiscal) {
            return (notaFiscal.ValorNota < 3000);
        }
    }
}
