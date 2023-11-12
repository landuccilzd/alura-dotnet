namespace Desafio {
    public class IntegradorFinanciamento: AbstractIntegracaoNotaFiscal {
        public override bool VerificaNecessidadeIntegracao(NotaFiscal notaFiscal) {
            return (notaFiscal.ValorNota > 100);
        }
    }
}
