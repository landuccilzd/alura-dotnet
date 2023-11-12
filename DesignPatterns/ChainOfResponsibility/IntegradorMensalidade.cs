namespace Desafio {
    public class IntegradorMensalidade: AbstractIntegracaoNotaFiscal {
        public override bool VerificaNecessidadeIntegracao(NotaFiscal notaFiscal) {
            return (notaFiscal.ValorNota > 100 && notaFiscal.ValorNota < 1500);
        }
    }
}
