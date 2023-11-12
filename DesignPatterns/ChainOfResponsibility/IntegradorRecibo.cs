namespace Desafio {
    public class IntegradorRecibo: AbstractIntegracaoNotaFiscal {
        public override bool VerificaNecessidadeIntegracao(NotaFiscal notaFiscal) {
            return (notaFiscal.ValorNota > 2000);
        }
    }
}
